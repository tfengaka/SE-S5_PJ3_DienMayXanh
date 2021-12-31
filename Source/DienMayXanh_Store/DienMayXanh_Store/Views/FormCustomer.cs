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
        }

        private void initialData(object sender, EventArgs e)
        {
            var customers = context.CUSTOMERS.Select(customer => new
            {
                customer.CustomerID,
                customer.Name,
                customer.Address,
                customer.Gender,
                customer.Phone,
            }).ToList();
            int i = 0;
            foreach (var customer in customers)
            {
                DataGridViewRow _row = new DataGridViewRow();
                DataGridViewCell _cell;

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = i + 1;
                _row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = customer.CustomerID;
                _row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = customer.Name;
                _row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                if(customer.Gender)
                {
                    _cell.Value = "Nam";
                }
                else
                {
                    _cell.Value = "Nữ";
                }
                _row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = customer.Phone;
                _row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = customer.Address;
                _row.Cells.Add(_cell);

                dgv_listCustomer.Rows.Add(_row);
                i++;
            }
        }

        private void btn_ViewDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string _ID = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string _Name = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string _Phone = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string _Address = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                object _customer = new { _ID, _Name,_Phone,_Address};
                FormMenu.instance.openChildForm(new CustomerDetail(_customer));
                this.Hide();
            }
        }
    }
}
