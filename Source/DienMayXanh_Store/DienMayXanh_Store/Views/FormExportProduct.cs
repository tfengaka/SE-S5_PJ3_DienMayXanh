using DienMayXanh_Store.Models;
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
    public partial class FormExportProduct : Form
    {
        private ContextDB context = Program.context;
        private string currKey = "", warehouseID;
        private Guna2Panel pnlProduct, currPnl;
        private Guna2PictureBox ptbProduct;
        private Guna2HtmlLabel lblInfo;
        private Guna2CircleButton btnDelete, currBtn;
        private int currIndex = 0, currQuantity = 0;
        private int containerX = 15, containerY = 60;
        private List<ImportSlip> listProduct = new List<ImportSlip>();

        private Bitmap deleleIcon = global::DienMayXanh_Store.Properties.Resources.delete;
        private Bitmap minusIcon = global::DienMayXanh_Store.Properties.Resources.minus;

        public FormExportProduct()
        {
            InitializeComponent();
        }

        private void FormExportProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.AutoGenerateColumns = false;
            loadCmbFilter();
        }

        private void loadData(string cateID = "0")
        {
            var data = cateID != "0" ?
                context.PRODUCTAVAILABLES
                .Where(x => x.PRODUCT.CategoryID.Equals(cateID)
                && x.WarehouseID.Equals(warehouseID))
                : context.PRODUCTAVAILABLES
                .Where(x => x.WarehouseID.Equals(warehouseID));


            dgvProduct.DataSource = data.Select(x => new
            {
                x.ProductID,
                x.PRODUCT.Name,
                x.PRODUCT.Price,
                x.Quantity,
                BrandName = x.PRODUCT.BRAND.Name,
                CateName = x.PRODUCT.CATEGORY.Name,
                x.PRODUCT.BrandID,
                x.PRODUCT.CategoryID,
            }).ToList();

        }

        private void loadDataByName()
        {
            dgvProduct.DataSource = context.PRODUCTAVAILABLES
                .Where(x => x.PRODUCT.Name.Contains(currKey) 
                && x.WarehouseID.Equals(warehouseID))
                .Select(x => new
                {
                    x.ProductID,
                    x.PRODUCT.Name,
                    x.PRODUCT.Price,
                    x.Quantity,
                    BrandName = x.PRODUCT.BRAND.Name,
                    CateName = x.PRODUCT.CATEGORY.Name,
                    x.PRODUCT.BrandID,
                    x.PRODUCT.CategoryID,
                }).ToList();
        }

        private void loadCmbFilter()
        {
            string cateID = "CategoryID", name = "Name";
            cmbFilterCategory.ValueMember = cateID;
            cmbFilterCategory.DisplayMember = name;
            cmbFilterCategory.DataSource = setTable(cateID, name,
                "Tất cả danh mục", context.CATEGORIES.ToList());

            cmbWarehouse.ValueMember = "WarehouseID";
            cmbWarehouse.DisplayMember = name;
            cmbWarehouse.DataSource = context.WAREHOUSES.ToList();
        }

        private DataTable setTable(string id, string name, string label,
            List<CATEGORY> category)
        {
            DataTable table = new DataTable();
            table.Columns.Add(id, typeof(string));
            table.Columns.Add(name, typeof(string));

                category.ForEach(x =>
                {
                    var rowDT = table.NewRow();
                    rowDT[id] = x.CategoryID;
                    rowDT[name] = x.Name;
                    table.Rows.Add(rowDT);
                });
     

            DataRow row = table.NewRow();
            row[id] = "0";
            row[name] = label;

            table.Rows.InsertAt(row, 0);

            return table;
        }

        private void cmbFilterCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadData(cmbFilterCategory.SelectedValue.ToString());
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            cmbFilterCategory.SelectedIndex = 0;
            currKey = txtSearch.Text;
            loadDataByName();
            currKey = "";
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            warehouseID = cmbWarehouse.SelectedValue.ToString();
            cmbFilterCategory.SelectedIndex = 0;
            txtSearch.Text = "";
            loadData();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                ImportSlip productOrder = new ImportSlip();
                string id = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                if(context.PRODUCTAVAILABLES.FirstOrDefault(x => x.ProductID.Equals(id)).Quantity == 0)
                {
                    MessageBox.Show("Hàng trong kho không đủ");
                    return;
                }    
                if(checkExistProduct(id))
                {
                    this.pnlListOrder.Controls[id].Controls["productQuantity" + id].Text 
                        = currQuantity.ToString();
                    this.pnlListOrder.Controls[id].Controls["totalPrice" + id].Text
                        = (currQuantity *
                        Convert.ToDecimal(senderGrid.Rows[e.RowIndex].Cells[2].Value)).ToString() + "VNĐ";
                    currQuantity = 0;
                    reloadData(id, 1, true);
                    return; 
                }
                productOrder.ProductID = id;
                productOrder.Name = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                productOrder.Price = Convert.ToDecimal(senderGrid.Rows[e.RowIndex].Cells[2].Value);
                productOrder.Quantity = 1;
                productOrder.BrandID = senderGrid.Rows[e.RowIndex].Cells["BrandID"].Value.ToString();
                productOrder.CategoryID = senderGrid.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
                listProduct.Add(productOrder);
                setLayout();
                reloadData(id, 1, true);
            }
        }

        private void reloadData(string id, int quantity, bool type)
        {
            if(type)
                context.PRODUCTAVAILABLES.FirstOrDefault(x => x.ProductID.Equals(id)).Quantity -= quantity;
            else context.PRODUCTAVAILABLES.FirstOrDefault(x => x.ProductID.Equals(id)).Quantity += quantity;
            context.SaveChanges();
            currKey = txtSearch.Text;
            if (currKey.Equals(""))
                loadData(cmbFilterCategory.SelectedValue.ToString());
            else
                loadDataByName();
            currKey = "";
            lblTotalPice.Text = "Thành tiền: " + calculTotalPrice() + " VNĐ";
        }

        private decimal calculTotalPrice()
        {
            decimal total = 0;
            listProduct.ForEach(x => total += (x.Quantity * x.Price));
            return total;
        }

        private bool checkExistProduct(string id)
        {
            ImportSlip result = listProduct.Find(x => x.ProductID.Equals(id));
            if (result == null)
                return false;
            result.Quantity += 1;
            currQuantity = result.Quantity;
            return true;
        }

        private int alignmentHeight(Control control)
        {
            return this.pnlProduct.Height / 2 - control.Height / 2;
        }

        private void setLayout()
        {
            int labelX = 0;
            ImportSlip item = listProduct[currIndex++];
            string id = item.ProductID;
            string producer = context.BRANDS.Find(item.BrandID).Name;
            string category = context.CATEGORIES.Find(item.CategoryID).Name;

            setPanelProduct(id, containerX, containerY);
            setPictureProduct(id);

            setLabelProduct("productName" + id, item.Name, labelX += 90, 325);
            setLabelProduct("productPrice" + id, item.Price + " VNĐ", labelX += 325, 130);
            setLabelProduct("productQuantity" + id, item.Quantity.ToString(), labelX += 130, 80);

            setLabelProduct("category" + id, category, labelX += 80, 115);
            setLabelProduct("producer" + id, producer, labelX += 115, 140);
            setLabelProduct("totalPrice" + id, Math.Round(item.Price * item.Quantity) + " VNĐ"
                , labelX += 140, 200);

            containerY += 135;
        }

        private void setPanelProduct(string id, int x, int y)
        {
            this.pnlProduct = new Guna2Panel();
            this.pnlProduct.Dock = DockStyle.Top;
            this.pnlProduct.BackColor = System.Drawing.Color.Transparent;
            this.pnlProduct.FillColor = System.Drawing.Color.White;
            this.pnlProduct.Location = new System.Drawing.Point(x, y);
            this.pnlProduct.Name = id;
            this.pnlProduct.Size = new System.Drawing.Size(652, 100);
            this.pnlProduct.Cursor = Cursors.Hand;
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlListOrder.Controls.Add(this.pnlProduct);
            setBtnDelete("btnMinus." + id, 10, minusIcon);
            setBtnDelete("btnDelete." + id, 50, deleleIcon);
        }

        private void setLabelProduct(string id, string label, int x, int maximumWidth)
        {
            this.lblInfo = new Guna2HtmlLabel();
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.AutoSize = false;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblInfo.Name = id;
            this.lblInfo.TextAlignment = ContentAlignment.MiddleCenter;
            this.lblInfo.Size = new System.Drawing.Size(maximumWidth, 30);
            this.lblInfo.MaximumSize = new Size(maximumWidth, 60);
            this.lblInfo.Text = label;
            this.lblInfo.Location = new System.Drawing.Point(x, alignmentHeight(this.lblInfo));
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
            this.ptbProduct.Size = new System.Drawing.Size(50, 50);
            this.ptbProduct.Location = new System.Drawing.Point(20, alignmentHeight(this.ptbProduct));
            this.ptbProduct.Name = "ptb" + id;
            this.ptbProduct.ShadowDecoration.Parent = this.ptbProduct;
            this.ptbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlProduct.Controls.Add(this.ptbProduct);
        }

        private void setBtnDelete(string id, int y, Bitmap icon)
        {
            string btnType = id.Split('.')[0];
            this.btnDelete = new Guna2CircleButton();
            this.btnDelete.Animated = true;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = icon;
            this.btnDelete.Name = id;
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.Location = new System.Drawing.Point(1060, y);
            if(btnType.Equals("btnMinus"))
            {
                this.btnDelete.Click += btnMinus_Click;
                toolTip.SetToolTip(btnDelete, "Giảm số lượng");
            }
            else
            {
                this.btnDelete.Click += btnDelete_Click;
                toolTip.SetToolTip(btnDelete, "Xóa sản phẩm");
            }
            this.pnlProduct.Controls.Add(this.btnDelete);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            currBtn = (Guna2CircleButton)sender;
            string id = currBtn.Name.Split('.')[1];
            ImportSlip item = listProduct.Find(x => x.ProductID.Equals(id));
            listProduct.Remove(item);
            currIndex = 0;
            this.pnlListOrder.Controls.Clear();
            listProduct.ForEach(x => setLayout());
            reloadData(id, item.Quantity, false);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            currBtn = (Guna2CircleButton)sender;
            string id = currBtn.Name.Split('.')[1];
            int quantity = Convert.ToInt32(this.pnlListOrder.Controls[id].Controls["productQuantity" + id].Text);
            if (quantity == 1)
            {
                btnDelete_Click(sender, e);
                return;
            }
            quantity--;
            decimal price = 
                Convert.ToDecimal(this.pnlListOrder.Controls[id].Controls["productPrice" + id].Text.Split(' ')[0]);
            this.pnlListOrder.Controls[id].Controls["productQuantity" + id].Text = quantity.ToString();
            this.pnlListOrder.Controls[id].Controls["totalPrice" + id].Text
                = (quantity * price).ToString() + "VNĐ";
            listProduct.Find(x => x.ProductID.Equals(id)).Quantity -= 1;
            reloadData(id, 1, false);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listProduct.Count == 0)
                MessageBox.Show("Vui lòng thêm sản phẩm vào đơn hàng");
            else saveData();
        }

        private void saveData()
        {

        }
    }
}
