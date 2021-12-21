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
        private Bitmap hide = global::DienMayXanh_Store.Properties.Resources.hide;
        private Bitmap show = global::DienMayXanh_Store.Properties.Resources.show;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtPassword.IconRight.Equals(show))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.IconRight = hide;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.IconRight = show;
            }
        }
    }
}
