using DienMayXanh_Store.Models;
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
    public partial class formPayment : Form
    {
        private ContextDB context = Program.context;
        private RECIEPT reciept = new RECIEPT();
        private List<CARTITEM> Cart;
        private string wareHouseID = string.Empty;
        public formPayment()
        {
            InitializeComponent();
        }
        public formPayment(string recieptID, List<CARTITEM> cart, string warehouseid)
        {
            InitializeComponent();
            dgv_savedCustomer.AutoGenerateColumns = false;
            dgv_CartItem.AutoGenerateColumns = false;
            this.reciept.StaffID = FormLogin.instance.info.StaffID;
            this.reciept.RecieptID = recieptID;
            this.Cart = cart;
            this.wareHouseID = warehouseid;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormExportProduct.instance.Show();
        }
        public List<object> accessListCartItem(List<CARTITEM> cart)
        {
            List<object> result = new List<object>();
            int index = 0;
            decimal Total = 0;
            foreach (CARTITEM item in cart)
            {
                PRODUCT product = context.PRODUCTS.Find(item.ProductID);
                object cartitem = new
                {
                    No = ++index,
                    ProductID = item.ProductID,
                    ProductName = product.Name,
                    Quantity = item.Quantity,
                    UnitPrice = product.Price,
                    Subtotal = item.SubTotal
                };
                Total += item.SubTotal;
                result.Add(cartitem);
            }
            this.reciept.Total = Total;
            return result;
        }
        private void loadCartItem(List<CARTITEM> cart)
        {
            dgv_CartItem.DataSource = accessListCartItem(cart);
            tb_Total.Text = String.Format("{0:n0}", this.reciept.Total) + " VNĐ";
        }
        private void loadCustomerInfo(string customerID)
        {
            CUSTOMER customer = context.CUSTOMERS.Find(customerID);
            tb_Name.Text = customer.Name;
            tb_address.Text = customer.Address;
            cb_gender.SelectedIndex = customer.Gender ? 1 : 0;
            tb_Phone.Text = customer.Phone;
        }
        private void formPayment_Load(object sender, EventArgs e)
        {
            var savedCustomers = context.CUSTOMERS.AsEnumerable().Select(customer => new
            {
                customer.CustomerID,
                customer.Name,
                customer.Phone,
            });
            dgv_savedCustomer.DataSource = savedCustomers.ToList();
            cb_gender.SelectedIndex = 1;
            cb_payMethod.SelectedIndex = 0;
            loadCartItem(this.Cart);
        }

        private void dgv_savedCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                reciept.CustomerID = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                reciept.PaymentMethod = cb_payMethod.Text;
            }
            loadCustomerInfo(reciept.CustomerID);
            btn_ConfirmInfo.Enabled = false;
            btn_refresh.Enabled = true;
        }

        private void btn_ConfirmInfo_Click(object sender, EventArgs e)
        {
            if (tb_address.Text.Equals("") || tb_Name.Text.Equals("") || tb_Phone.Text.Equals(""))
            {
                MessageBox.Show("Vui Lòng điền đẩy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                reciept.PaymentMethod = cb_payMethod.Text;
                reciept.CustomerID = "KH" + tb_Phone.Text;
                btn_refresh.Enabled = true;
                btn_ConfirmInfo.Enabled = false;
                tb_address.Enabled = false;
                tb_Name.Enabled = false;
                tb_Phone.Enabled = false;
                cb_gender.Enabled = false;
                dgv_savedCustomer.Columns["btn_Add"].Visible = false;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Text = String.Empty;
            tb_address.Text = String.Empty;
            tb_Phone.Text = String.Empty;
            cb_gender.SelectedIndex = 1;
            cb_payMethod.SelectedIndex = 0;
            btn_ConfirmInfo.Enabled = true;
            btn_refresh.Enabled = false;

            tb_address.Enabled = true;
            tb_Name.Enabled = true;
            tb_Phone.Enabled = true;
            cb_gender.Enabled = true;
            dgv_savedCustomer.Columns["btn_Add"].Visible = true;

        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            IESLIP exportBill = new IESLIP();
            exportBill.WarehouseID = this.wareHouseID;
            exportBill.IESlipID = reciept.RecieptID;
            exportBill.TotalPrice = reciept.Total;
            exportBill.CreateAt = date;
            exportBill.StaffID = FormLogin.instance.info.StaffID;
            this.reciept.CreateAt = date;
            context.IESLIPS.Add(exportBill);
            if (context.CUSTOMERS.Any(customer => customer.CustomerID == reciept.CustomerID))
            {
                try
                {
                    context.RECIEPTS.Add(reciept);
                    Cart.ForEach(item =>
                    {
                        context.CARTITEMS.Add(item);
                        IESLIPDETAIL exportDetail = new IESLIPDETAIL();
                        exportDetail.ProductID = item.ProductID;
                        exportDetail.IESlipID = exportBill.IESlipID;
                        exportDetail.Quantity = item.Quantity;
                        context.IESLIPDETAILS.Add(exportDetail);
                        context.SaveChanges();
                    });
                    context.SaveChanges();
                    MessageBox.Show("Thanh Toán Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

                try
                {
                    CUSTOMER customer = new CUSTOMER();
                    customer.CustomerID = reciept.CustomerID;
                    customer.Name = tb_Name.Text;
                    customer.Phone = tb_Phone.Text;
                    customer.Gender = cb_gender.SelectedIndex == 1 ? true : false;
                    customer.Address = tb_address.Text;
                    context.CUSTOMERS.Add(customer);
                    context.RECIEPTS.Add(reciept);
                    Cart.ForEach(item =>
                    {
                        context.CARTITEMS.Add(item);
                        IESLIPDETAIL exportDetail = new IESLIPDETAIL();
                        exportDetail.ProductID = item.ProductID;
                        exportDetail.IESlipID = exportBill.IESlipID;
                        exportDetail.Quantity = item.Quantity;
                        context.IESLIPDETAILS.Add(exportDetail);
                        context.SaveChanges();
                    });
                    context.SaveChanges();
                    MessageBox.Show("Thanh Toán Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            Dialogs.InvoiceDetail invoiceDetail = new Dialogs.InvoiceDetail(reciept, accessListCartItem(Cart), exportBill.IESlipID);
            invoiceDetail.ShowDialog();
            Dispose();
            FormMenu.instance.openChildForm(new FormExportProduct());
        }
    }
}
