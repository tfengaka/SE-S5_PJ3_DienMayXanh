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
        public FormCustomer()
        {
            InitializeComponent();
        }

        public void addTestData(DataGridView dgv)
        {
            for (int i = 0;i < 10; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell _cell;
                _cell = new DataGridViewTextBoxCell();
                _cell.Value = i + 1;
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "KH00000001";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "Võ Doãn Hoàng Lông";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "Nam";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "0987654321";
                row.Cells.Add(_cell);

                _cell = new DataGridViewTextBoxCell();
                _cell.Value = "Số 450 Lê Văn Việt, P. Tăng Nhơn Phú A, TP. Thủ Đức, TP.HCM";
                row.Cells.Add(_cell);

                dgv.Rows.Add(row);
            }
            


        }

        private void initialData(object sender, EventArgs e)
        {
            addTestData(dgv_listCustomer);
        }

        private void btn_ViewDetail_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                FormMenu.instance.openChildForm(new CustomerDetail());
                this.Hide();
            }
        }
    }
}
