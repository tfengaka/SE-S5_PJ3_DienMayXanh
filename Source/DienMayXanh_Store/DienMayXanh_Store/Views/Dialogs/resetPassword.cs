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

namespace DienMayXanh_Store.Views.Dialogs
{
    public partial class resetPassword : Form
    {
        private ContextDB context = Program.context;
        public resetPassword()
        {
            InitializeComponent();
        }

        private void resetPassword_Load(object sender, EventArgs e)
        {
            var list = context.STAFFS.AsEnumerable().Select(staff => new
            {
                StaffID = staff.StaffID,
                StaffName = staff.Name,
                StaffPosition = staff.Position,
                StaffPhone = staff.Phone,
            }).ToList();
            dgv_Staff.DataSource = list;
        }

        private void btn_resetPassword_Click(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string staffId = dgv_Staff.Rows[e.RowIndex].Cells["StaffID"].Value.ToString();
                string passReset = FormLogin.MD5Hash(FormLogin.Base64Encode("staff"));
                var account = context.ACCOUNTS.Find(staffId);
                account.Password = passReset;
                context.SaveChanges();
                MessageBox.Show("Cấp Lại Mật Khẩu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
