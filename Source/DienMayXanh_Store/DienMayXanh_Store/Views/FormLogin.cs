using DienMayXanh_Store.Models;
using DienMayXanh_Store.Views;
using DienMayXanh_Store.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store
{
    public partial class FormLogin : Form
    {
        public static FormLogin instance;
        public STAFF info = null;

        private bool isShowPassword = false;
        private Bitmap hide = global::DienMayXanh_Store.Properties.Resources.hide;
        private Bitmap show = global::DienMayXanh_Store.Properties.Resources.show;
        public FormLogin()
        {
            InitializeComponent();
            instance = this;
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
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txbLoginName.Text.Equals("") && !txbPassword.Text.Equals(""))
            { 
                new PreLoginOverlay(txbLoginName.Text, txbPassword.Text).ShowDialog();
                return;
            }
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

      
    }
}
