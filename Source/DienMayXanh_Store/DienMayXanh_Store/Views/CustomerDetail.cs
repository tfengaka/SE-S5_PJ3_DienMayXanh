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
        public CustomerDetail()
        {
            InitializeComponent();
        }

        private void closePanel(object sender, EventArgs e)
        {
            FormMenu.instance.openChildForm(new FormCustomer());
            this.Dispose();
        }

        public void addTestData(DataGridView dgv)
        {
            
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell _cell;
                _cell = new DataGridViewTextBoxCell();
                _cell.Value = 1;
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "HD00000001";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "Võ Đoàn hoang long";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "20/11/2021";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "Tiền mặt";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "5000000";
                row.Cells.Add(_cell);

            dgv.Rows.Add(row);
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            addTestData(dgv_ListInvoice);
        }

        private void btn_invoiceDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               Dialogs.InvoiceDetail invoiceDetail = new Dialogs.InvoiceDetail();
                invoiceDetail.ShowDialog();
            }
        }
    }
}
