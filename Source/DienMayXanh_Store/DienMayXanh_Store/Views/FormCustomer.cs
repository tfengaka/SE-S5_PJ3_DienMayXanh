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
    public partial class FormCustomer : Form
    {
        private ContextDB context = Program.context;
        public FormCustomer()
        {
            InitializeComponent();
            dgv_listCustomer.AutoGenerateColumns = false;
        }

        private void initialData(object sender, EventArgs e)
        {
            var customers = context.CUSTOMERS
                 .AsEnumerable()
                 .Select((customer, index) => new
                 {
                     No = ++index,
                     customer.CustomerID,
                     customer.Name,
                     customer.Address,
                     Gender = customer.Gender ? "Nam" : "Nữ",
                     customer.Phone,
                 }).ToList();
            dgv_listCustomer.DataSource = customers;
        }

        private void btn_ViewDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string _ID = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string _Name = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string _Phone = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string _Address = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                string _Gender = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                object _customer = new { _ID, _Name, _Gender, _Phone, _Address };
                FormMenu.instance.openChildForm(new CustomerDetail(_customer));
                this.Hide();
            }
        }
    }
}
