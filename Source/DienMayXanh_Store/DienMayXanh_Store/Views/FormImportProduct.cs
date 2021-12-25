using DienMayXanh_Store.Models;
using DienMayXanh_Store.Views.Dialogs;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store.Views
{
    public partial class FormImportProduct : Form
    {
        private ContextDB context = Program.context;
        private decimal total;
        private int currIndex = 0;
        private int containerX = 15, containerY = 60;
        private Image img;
        private ImportSlip currItem;
        private Guna2ShadowPanel pnlProduct, currPnl;
        private Guna2PictureBox ptbProduct;
        private Guna2HtmlLabel lblInfo;
        private List<ImportSlip> listProduct = new List<ImportSlip>();
        private string filterImg = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
        private string newImg = @"..\..\Images\Products\";
        private string selectedFile;
        public static FormImportProduct instance;
        public FormImportProduct()
        {
            InitializeComponent();
            instance = this;
        }



        private void FormImportProduct_Load(object sender, EventArgs e)
        {
            ptbAddImg.AllowDrop = true;
            btnChangeImg.Visible = false;

            toolTip.SetToolTip(btnAddCategory, "Quản lý danh mục");
            toolTip.SetToolTip(btnAddProducer, "Quản lý nhà cung cấp");
            loadCbmFilter();
        }

        public void loadCbmFilter()
        {
            cbmFilterCategory.ValueMember = "CategoryID";
            cbmFilterCategory.DisplayMember = "Name";
            cbmFilterCategory.DataSource = context.CATEGORIES.ToList();

            cmbFilterProducer.ValueMember = "BrandID";
            cmbFilterProducer.DisplayMember = "Name";
            cmbFilterProducer.DataSource = context.BRANDS.ToList();

            cmbFilterWarehouse.ValueMember = "WarehouseID";
            cmbFilterWarehouse.DisplayMember = "Name";
            cmbFilterWarehouse.DataSource = context.WAREHOUSES.ToList();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new FormAddCategory().ShowDialog();
        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            new FormAddProducer().ShowDialog();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = filterImg;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ptbAddImg.Image = new Bitmap(dlg.FileName);
                    selectedFile = dlg.FileName;
                    btnAddImg.Visible = false;
                    btnChangeImg.Visible = true;
                }
            }
        }

        private void ptbAddImg_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                selectedFile = pic;
                img = Image.FromFile(pic);
                ptbAddImg.Image = img;
            }
            btnAddImg.Visible = false;
            btnChangeImg.Visible = true;
        }

        private void ptbAddImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            ptbAddImg.Image = null;
            btnAddImg.Visible = true;
            btnChangeImg.Visible = false;
        }

        private void resetInput()
        {
            nudQuantity.Value = 0;
            txtProductName.Text = "";
            txtPrice.Text = "";
            btnAddImg.Visible = true;
            btnChangeImg.Visible = false;
            ptbAddImg.Image = null;
        }

        private void addProdut()
        {
            ImportSlip checkName = listProduct.FirstOrDefault(x => x.Name.Equals(txtProductName.Text));
            if (checkName != null)
            {
                MessageBox.Show("Tên sản phẩm đã có trong danh sách");
                return;
            }
            DateTime date = DateTime.Now;
            ImportSlip newProduct = new ImportSlip();
            newProduct.ProductID = "SP" + date.ToString("yyyyMMddHHmmss");
            newProduct.Name = txtProductName.Text;
            newProduct.Price = Convert.ToDecimal(txtPrice.Text);
            newProduct.Quantity = (int)nudQuantity.Value;
            newProduct.CategoryID = cbmFilterCategory.SelectedValue.ToString();
            newProduct.BrandID = cmbFilterProducer.SelectedValue.ToString();
            listProduct.Add(newProduct);
            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string resultFileCopy = newImg + newProduct.ProductID + fileExt;
            System.IO.File.Copy(selectedFile, resultFileCopy);
            resetInput();
            setLayout();
            lblTotalPrice.Text = "Thành tiền: " + calculTotalPrice() + " VNĐ";
            MessageBox.Show("Thêm sản phẩm thành công");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtPrice.Text == ""
                || nudQuantity.Value == 0)
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            else if (ptbAddImg.Image == null)
                MessageBox.Show("Vui lòng chọn ảnh cho sản phẩm");
            else
                addProdut();
        }

        private decimal calculTotalPrice()
        {
            total = 0;
            listProduct.ForEach(x => total += (x.Quantity * x.Price));
            return total;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (listProduct.Count == 0)
                MessageBox.Show("Vui lòng thêm sản phẩm");
            else importProduct();
        }

        private void importProduct()
        {
            DateTime date = DateTime.Now;
            IESLIP newIE = new IESLIP();
            string warehouseID = cmbFilterWarehouse.SelectedValue.ToString();

            newIE.IESlipID = "I" + date.ToString("yyyyMMddHHmmss");
            newIE.TotalPrice = total;
            newIE.StaffID = FormLogin.instance.info.StaffID;
            newIE.WarehouseID = warehouseID;
            newIE.CreateAt = date;
            context.IESLIPS.Add(newIE);

            listProduct.ForEach(x =>
            {
                PRODUCT newP = new PRODUCT();
                PRODUCTAVAILABLE newPA = new PRODUCTAVAILABLE();
                IESLIPDETAIL newIED = newIED = new IESLIPDETAIL();;

                PRODUCTAVAILABLE checkProduct = context.PRODUCTAVAILABLES
                                .FirstOrDefault(item => item.WarehouseID.Equals(warehouseID)
                                && item.PRODUCT.Name.Equals(x.Name));
                
                if (checkProduct != null)
                {
                    string id = checkProduct.ProductID;
                    checkProduct
                    .Quantity += x.Quantity;
                    checkProduct.PRODUCT.Price = x.Price;
                    string fileExt = System.IO.Path.GetExtension(selectedFile);
                    string oldFile = newImg + x.ProductID + fileExt;
                    string resultFileCopy = newImg + id + fileExt;
                    System.IO.File.Copy(oldFile, resultFileCopy, true);
                    System.IO.File.Delete(oldFile);

                    newIED.ProductID = id;
                    newIED.IESlipID = newIE.IESlipID;
                    newIED.Quantity = x.Quantity;
                }
                else
                {
                    newP.ProductID = x.ProductID;
                    newP.Name = x.Name;
                    newP.Price = x.Price;
                    newP.CategoryID = x.CategoryID;
                    newP.BrandID = x.BrandID;

                    newPA.ProductID = x.ProductID;
                    newPA.WarehouseID = newIE.WarehouseID;
                    newPA.Quantity = x.Quantity;

                    newIED.ProductID = x.ProductID;
                    newIED.IESlipID = newIE.IESlipID;
                    newIED.Quantity = x.Quantity;

                    context.PRODUCTS.Add(newP);
                    context.PRODUCTAVAILABLES.Add(newPA);
                }
                context.IESLIPDETAILS.Add(newIED);
                context.SaveChanges();
            });

            context.SaveChanges();
            MessageBox.Show("Hàng đã được nhập");
            resetInput();
            lblTotalPrice.Text = "Thành tiền: 0";
            containerY = 60;
            currIndex = 0;
            this.listProduct.Clear();
            this.gbListProduct.Controls.Clear();
        }

        private void setLayout()
        {
            int labelX = 125, labelY = 15;
            ImportSlip item = listProduct[currIndex++];
            string id = item.ProductID;
            string producer = context.BRANDS.Find(item.BrandID).Name;
            string category = context.CATEGORIES.Find(item.CategoryID).Name;

            setPanelProduct(id, containerX, containerY);
            setPictureProduct(id);

            setLabelProduct("productName" + id, "Tên sản phẩm: " + item.Name, labelX, labelY);
            setLabelProduct("productPrice" + id, "Đơn giá: " + item.Price + " VNĐ", labelX, labelY += 30);
            setLabelProduct("productQuantity" + id, "Số lượng: " + item.Quantity, labelX, labelY += 30);

            setLabelProduct("category" + id, "Danh mục: " + category, labelX += 250, labelY = 15);
            setLabelProduct("producer" + id, "Nhà cung cấp: " + producer, labelX, labelY += 30);
            setLabelProduct("totalPrice" + id, "Tổng tiền: " + Math.Round(item.Price * item.Quantity) + " VNĐ"
                , labelX, labelY += 30);

            containerY += 135;
        }

        private void setPanelProduct(string id, int x, int y)
        {
            this.pnlProduct = new Guna2ShadowPanel();
            this.pnlProduct.BackColor = System.Drawing.Color.Transparent;
            this.pnlProduct.FillColor = System.Drawing.Color.White;
            this.pnlProduct.Location = new System.Drawing.Point(x, y);
            this.pnlProduct.Name = id;
            this.pnlProduct.Radius = 5;
            this.pnlProduct.ShadowColor = System.Drawing.Color.Black;
            this.pnlProduct.Size = new System.Drawing.Size(652, 118);
            this.pnlProduct.Cursor = Cursors.Hand;
            this.pnlProduct.Click += this.pnlProduct_Click;
            this.pnlProduct.DoubleClick += this.pnlProduct_DoubleClick;
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.gbListProduct.Controls.Add(this.pnlProduct);
        }


        private void setLabelProduct(string id, string label, int x, int y)
        {
            this.lblInfo = new Guna2HtmlLabel();
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblInfo.Location = new System.Drawing.Point(x, y);
            this.lblInfo.Name = id;
            this.lblInfo.Size = new System.Drawing.Size(93, 27);
            this.lblInfo.Text = label;
            this.pnlProduct.Controls.Add(this.lblInfo);
        }

        private void setPictureProduct(string id)
        {
            this.ptbProduct = new Guna2PictureBox();
            this.ptbProduct.ImageLocation = string.Format(@"..\..\Images\Products\" + id + ".jpg");
            this.ptbProduct.BackColor = System.Drawing.Color.Transparent;
            this.ptbProduct.BorderRadius = 5;
            this.ptbProduct.FillColor = System.Drawing.Color.Black;
            this.ptbProduct.ImageRotate = 0F;
            this.ptbProduct.Location = new System.Drawing.Point(20, 15);
            this.ptbProduct.Name = "ptb" + id;
            this.ptbProduct.ShadowDecoration.Parent = this.ptbProduct;
            this.ptbProduct.Size = new System.Drawing.Size(92, 88);
            this.ptbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlProduct.Controls.Add(this.ptbProduct);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            currItem.Name = txtProductName.Text;
            currItem.Price = Convert.ToDecimal(txtPrice.Text);
            currItem.Quantity = (int)nudQuantity.Value;
            currItem.CategoryID = cbmFilterCategory.SelectedValue.ToString();
            currItem.BrandID = cmbFilterProducer.SelectedValue.ToString();
            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string resultFileCopy = newImg + currItem.ProductID + fileExt;
            if (!resultFileCopy.Equals(selectedFile))
                System.IO.File.Copy(selectedFile, resultFileCopy, true);
            currIndex = 0;
            containerY = 60;
            int index = this.listProduct.IndexOf(currItem);
            this.listProduct[index] = currItem;
            this.gbListProduct.Controls.Clear();
            lblTotalPrice.Text = "Thành tiền: " + calculTotalPrice() + " VNĐ";
            listProduct.ForEach(x => setLayout());
            btnChangeImg.Visible = false;
            btnEditProduct.Visible = false;
            btnCancel.Visible = false;
            resetInput();
            MessageBox.Show("Sửa thành công");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetInput();
            btnEditProduct.Visible = false;
            btnCancel.Visible = false;
        }

        // show product need to update
        private void pnlProduct_Click(object sender, EventArgs e)
        {
            currPnl = (Guna2ShadowPanel)sender;
            btnEditProduct.Visible = true;
            btnCancel.Visible = true;
            btnAddImg.Visible = false;
            btnChangeImg.Visible = true;
            currItem = listProduct.FirstOrDefault(x => x.ProductID.Equals(currPnl.Name));
            cbmFilterCategory.SelectedValue = currItem.CategoryID;
            cmbFilterProducer.SelectedValue = currItem.BrandID;
            txtProductName.Text = currItem.Name;
            nudQuantity.Value = currItem.Quantity;
            txtPrice.Text = currItem.Price.ToString();
            ptbAddImg.ImageLocation = string.Format(@"..\..\Images\Products\" + currItem.ProductID + ".jpg");
            selectedFile = ptbAddImg.ImageLocation;
        }

        // delete product list
        private void pnlProduct_DoubleClick(object sender, EventArgs e)
        {
            currPnl = (Guna2ShadowPanel)sender;
            string fileExt = System.IO.Path.GetExtension(selectedFile);
            string oldFile = newImg + currPnl.Name + fileExt;
            System.IO.File.Delete(oldFile);
            ImportSlip item = listProduct.FirstOrDefault(x => x.ProductID.Equals(currPnl.Name));
            listProduct.Remove(item);
            currIndex = 0;
            containerY = 60;
            this.gbListProduct.Controls.Clear();
            lblTotalPrice.Text = "Thành tiền: " + calculTotalPrice() + " VNĐ";
            listProduct.ForEach(x => setLayout());
            MessageBox.Show("Đã xóa sản phẩm ra khỏi danh sách");
        }
    }

    class ImportSlip
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryID { get; set; }
        public string BrandID { get; set; }
        public ImportSlip()
        { }
        public ImportSlip(string ProductID, string Name, decimal Price, int Quantity,
            string CategoryID, string BrandID)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.CategoryID = CategoryID;
            this.BrandID = BrandID;
        }
    }
}
