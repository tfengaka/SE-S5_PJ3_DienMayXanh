using DienMayXanh_Store.Models;
using DienMayXanh_Store.Report;
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
        public static FormExportProduct instance;

        private ContextDB context = Program.context;
        private string currKey = "", warehouseID;
        private List<ImportSlip> listProduct = new List<ImportSlip>();

        public FormExportProduct()
        {
            InitializeComponent();
            instance = this;
        }

        private void FormExportProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.AutoGenerateColumns = false;
            loadCmbFilter();
        }

        public void loadData(string cateID = "0")
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

        public DataTable setTable(string id, string name, string label,
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
                    loadDgvData();
                    return; 
                }
                productOrder.ProductID = id;
                productOrder.Name = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                productOrder.Price = Convert.ToDecimal(senderGrid.Rows[e.RowIndex].Cells[2].Value);
                productOrder.Quantity = 1;
                productOrder.BrandID = senderGrid.Rows[e.RowIndex].Cells["BrandID"].Value.ToString();
                productOrder.CategoryID = senderGrid.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
                listProduct.Add(productOrder);
                loadDgvData();
                reloadDgvProduct(id, true, 1);
            }
        }

        private void loadDgvData()
        {
            dgvListOrder.DataSource = listProduct.Select(x => new
            {
                x.Img,
                id = x.ProductID,
                x.Name,
                price = x.Price,
                number = x.Quantity,
                totalPrice = x.Price * x.Quantity
            }).ToList();
            lblTotalPice.Text = "Thành tiền: " + String.Format("{0:n0}", calculTotalPrice()) + " VNĐ";
        }

  
        private decimal calculTotalPrice()
        {
            decimal total = 0;
            listProduct.ForEach(x => total += (x.Quantity * x.Price));
            return total;
        }

        private bool checkExistProduct(string id, int type = 0)
        {
            ImportSlip result = listProduct.Find(x => x.ProductID.Equals(id));
            if (result == null)
                return false;
            if (type == 0)
            {
                result.Quantity += 1;
                reloadDgvProduct(id, true, 1);
            }
            else if (type == 1)
            {
                if (result.Quantity == 1)
                {
                    reloadDgvProduct(id, false, result.Quantity);
                    listProduct.Remove(result);
                }
                else
                {
                    result.Quantity -= 1;
                    reloadDgvProduct(id, false, 1);
                }
            }
            else 
            {
                reloadDgvProduct(id, false, result.Quantity);
                listProduct.Remove(result);
            }

            return true;
        }

        private void reloadDgvProduct(string id, bool type, int quantity)
        {
            if (type)
                context.PRODUCTAVAILABLES.FirstOrDefault(x => x.ProductID.Equals(id)).Quantity -= quantity;
            else context.PRODUCTAVAILABLES.FirstOrDefault(x => x.ProductID.Equals(id)).Quantity += quantity;
            context.SaveChanges();

            currKey = txtSearch.Text;
            if (currKey.Equals(""))
                loadData(cmbFilterCategory.SelectedValue.ToString());
            else
                loadDataByName();
            currKey = "";
        }
    

        private void dgvListOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            string id = senderGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                senderGrid.Columns[e.ColumnIndex].Name.Equals("btnMinus") &&
                e.RowIndex >= 0 && checkExistProduct(id, 1))
                loadDgvData();
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                senderGrid.Columns[e.ColumnIndex].Name.Equals("btnDel") &&
                e.RowIndex >= 0 && checkExistProduct(id, 2))
                loadDgvData();
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listProduct.Count == 0)
                MessageBox.Show("Vui lòng thêm sản phẩm vào đơn hàng");
            else
            {
                createCartProduct();
            }                
        }
        private void createCartProduct()
        {
            List<CARTITEM> cart = new List<CARTITEM>();
            DateTime date = DateTime.Now;
            string recieptID = "HD" + date.ToString("yyyyMMddHHmm");
            listProduct.ForEach(product =>
            {
                CARTITEM cartItem = new CARTITEM();
                cartItem.RecieptID = recieptID;
                cartItem.ProductID = product.ProductID;
                cartItem.Quantity = product.Quantity;
                cartItem.SubTotal = product.Price * product.Quantity;
                cart.Add(cartItem);
            });
            formPayment frmpayment = new formPayment(recieptID, cart, cmbWarehouse.SelectedValue.ToString());
            GotoNextStep(frmpayment);
        }

        public void GotoNextStep(Form childForm)
        {
            this.Hide();
            FormMenu.instance.currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FormMenu.instance.panelContent.Controls.Add(childForm);
            FormMenu.instance.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } 
    }
}
