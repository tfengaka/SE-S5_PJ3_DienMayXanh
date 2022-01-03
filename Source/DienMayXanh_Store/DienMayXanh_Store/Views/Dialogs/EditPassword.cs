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
    public partial class EditPassword : Form
    {
        private ContextDB context = Program.context;
        public EditPassword()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditPassword_Load(object sender, EventArgs e)
        {
            tb_StaffID.Text = FormLogin.instance.info.StaffID;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            var account = context.ACCOUNTS.Find(FormLogin.instance.info.StaffID);
            string OldPass = FormLogin.MD5Hash(FormLogin.Base64Encode(tb_currPassword.Text));
            if (account.Password.Equals(OldPass))
            {
                if (tb_newPassword.Text.Equals(tb_repressPassword.Text))
                {
                    string newPass = FormLogin.MD5Hash(FormLogin.Base64Encode(tb_newPassword.Text));
                    account.Password = newPass;
                    context.SaveChanges();
                    MessageBox.Show("Đổi Mật Khẩu Thành Công!\nVui Lòng Đăng Nhập Lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin newLogin = new FormLogin();
                    FormMenu.instance.Dispose();
                    newLogin.Show();
                    return;
                }
            }
            MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
