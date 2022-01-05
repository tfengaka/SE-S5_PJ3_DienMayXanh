using DienMayXanh_Store.Models;
using DienMayXanh_Store.Views.Dialogs;
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
    public partial class CustomerDetail : Form
    {
        private ContextDB context = Program.context;
        private object _customer;
        public CustomerDetail()
        {
            InitializeComponent();
        }
        public CustomerDetail(object customer)
        {
            InitializeComponent();
            _customer = customer;
        }
        private void closePanel(object sender, EventArgs e)
        {
            FormMenu.instance.openChildForm(new FormCustomer());
            this.Dispose();
        }


        private void reloadFullList()
        {
            System.Reflection.PropertyInfo _ID = _customer.GetType().GetProperty("_ID");
            string _customerID = (String)_ID.GetValue(_customer, null);
            tb_CustomerID.Text = _customerID;
            System.Reflection.PropertyInfo _Name = _customer.GetType().GetProperty("_Name");
            tb_CustomerName.Text = (String)_Name.GetValue(_customer, null);
            System.Reflection.PropertyInfo _Phone = _customer.GetType().GetProperty("_Phone");
            tb_CustomerPhone.Text = (String)_Phone.GetValue(_customer, null);
            System.Reflection.PropertyInfo _Address = _customer.GetType().GetProperty("_Address");
            tb_CustomerAddress.Text = (String)_Address.GetValue(_customer, null);
            System.Reflection.PropertyInfo _Gender = _customer.GetType().GetProperty("_Gender");
            string strGender = (String)_Address.GetValue(_customer, null);
            cb_Gender.SelectedIndex = strGender.Equals("Nam") ? 1 : 0;
            var Orders = context.RECIEPTS
               .Where(item => item.CustomerID == _customerID)
               .AsEnumerable()
               .Select((item, index) => new
               {
                   No = ++index,
                   item.RecieptID,
                   item.STAFF.Name,
                   item.CreateAt,
                   item.PaymentMethod,
                   item.Total
               }).ToList();
            dgv_ListInvoice.DataSource = Orders;

            int totalQuantity = context.RECIEPTS
                .Where(item => item.CustomerID.Equals(_customerID))
                .Count();
            decimal totalPayment = context.RECIEPTS
                .Where(item => item.CustomerID.Equals(_customerID))
                .Sum(item => item.Total);

            lb_totalPrice.Text = String.Format("{0:n0}", totalPayment);
            lb_totalQuantity.Text = totalQuantity.ToString();
        }
        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            dgv_ListInvoice.Columns["CreateAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            FromDate.CustomFormat = "dd/MM/yyyy";
            ToDate.CustomFormat = "dd/MM/yyyy";
            reloadFullList();
            if (!FormLogin.instance.info.Position.Equals("Quản Lý"))
            {
                btn_EditInfo.Visible = false;
            }
        }

        private List<object> convertCartToListObj(List<CARTITEM> cart)
        {
            List<object> result = new List<object>();
            int index = 0;
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
                result.Add(cartitem);
            }
            return result;
        }

        private void btn_invoiceDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string recieptID = dataGridView.Rows[e.RowIndex].Cells["InvoiceID"].Value.ToString();
                RECIEPT reciept = context.RECIEPTS.Find(recieptID);
                List<CARTITEM> Cart = context.CARTITEMS.Where(item => item.RecieptID == recieptID).ToList();
                List<object> list = convertCartToListObj(Cart);
                InvoiceDetail invoiceDetail = new InvoiceDetail(reciept, list, recieptID);
                invoiceDetail.ShowDialog();
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            if (btn_filter.Text == "Lọc")
            {

                DateTime from = FromDate.Value;
                DateTime to = ToDate.Value;

                var Orders = context.RECIEPTS
              .Where(item => item.CustomerID == tb_CustomerID.Text)
              .AsEnumerable().Where(order => (order.CreateAt.CompareTo(from) > 0 && order.CreateAt.CompareTo(to) < 0))
              .Select((item, index) => new
              {
                  No = ++index,
                  item.RecieptID,
                  item.STAFF.Name,
                  item.CreateAt,
                  item.PaymentMethod,
                  item.Total
              }).ToList();
                dgv_ListInvoice.DataSource = Orders;
                FromDate.Enabled = false;
                ToDate.Enabled = false;
                btn_filter.Text = "Bỏ Lọc";
                btn_filter.FillColor = Color.FromArgb(222, 56, 96);

            }
            else
            {
                reloadFullList();
                FromDate.Enabled = true;
                ToDate.Enabled = true;
                btn_filter.Text = "Lọc";
                btn_filter.FillColor = Color.FromArgb(0, 158, 225);
            }
        }
        private void switchTextBoxStatus()
        {
            tb_CustomerName.Enabled = !tb_CustomerName.Enabled;
            tb_CustomerPhone.Enabled = !tb_CustomerPhone.Enabled;
            tb_CustomerAddress.Enabled = !tb_CustomerAddress.Enabled;
            cb_Gender.Enabled = !cb_Gender.Enabled;
        }

        private void btn_EditInfo_Click(object sender, EventArgs e)
        {
            if (btn_EditInfo.Text.Equals("Cập nhật thông tin"))
            {
                btn_EditInfo.Text = "Xác Nhận";
                switchTextBoxStatus();
            }
            else
            {
                try
                {
                    CUSTOMER customer = context.CUSTOMERS.Find(tb_CustomerID.Text);
                    customer.Name = tb_CustomerName.Text;
                    customer.Phone = tb_CustomerPhone.Text;
                    customer.Address = tb_CustomerAddress.Text;
                    customer.Gender = cb_Gender.Text.Equals("Nam") ? true : false;
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_EditInfo.Text = "Cập nhật thông tin";
                    switchTextBoxStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
