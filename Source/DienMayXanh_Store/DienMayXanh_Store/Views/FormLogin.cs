using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store
{
    public partial class FormLogin : Form
    {
        private bool isShowPassword = false;
        private Bitmap hide = global::DienMayXanh_Store.Properties.Resources.hide;
        private Bitmap show = global::DienMayXanh_Store.Properties.Resources.show;
        public FormLogin()
        {
            InitializeComponent();
            txbPassword.UseSystemPasswordChar = true;
        }

        private void showPassword(object sender, EventArgs e)
        {
            if (isShowPassword)
            {
                txbPassword.UseSystemPasswordChar = true;
                isShowPassword = false;
                txbPassword.IconRight = hide;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = false;
                isShowPassword = true;
                txbPassword.IconRight = show;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang Đăng Nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
