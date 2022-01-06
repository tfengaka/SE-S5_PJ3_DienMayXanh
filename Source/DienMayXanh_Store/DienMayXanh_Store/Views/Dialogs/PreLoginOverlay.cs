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
    public partial class PreLoginOverlay : Form
    {
        private ContextDB context = Program.context;
        private string userName, Password;
        public PreLoginOverlay()
        {
            InitializeComponent();
        }

        public PreLoginOverlay(string loginName, string password)
        {
            InitializeComponent();
            this.userName = loginName;
            this.Password = password;
        }
        private void PreLoginOverlay_Load(object sender, EventArgs e)
        {
            progressIndicator.Location =
               new Point(this.ClientSize.Width / 2 - this.progressIndicator.Size.Width / 2,
               this.ClientSize.Height / 2 - this.progressIndicator.Size.Height / 2);
        }


        private bool checkLogin(string loginName, string Password)
        {
            string encodePassword = FormLogin.MD5Hash(FormLogin.Base64Encode(Password));
            ACCOUNT getAccount = context.ACCOUNTS
                .FirstOrDefault(x => x.LoginName.Equals(loginName)
                && x.Password.Equals(encodePassword));
            if (getAccount != null)
            {
                FormLogin.instance.info = getAccount.STAFF;
                return true;
            }
            return false;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkLogin(userName, Password))
            {
                timer1.Enabled = false;
                new FormMenu().Show();
                this.Dispose();
                FormLogin.instance.Hide();
                return;
            }
            timer1.Enabled = false;
            MessageBox.Show("Thông Tin Đăng Nhập Không Chính Xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }
    }
}
