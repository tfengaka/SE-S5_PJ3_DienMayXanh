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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAddProduct, "Thêm sản phẩm");
            toolTip.SetToolTip(btnAddProduct, "Thêm nhà cung cấp");
            toolTip.SetToolTip(btnReload, "Đặt lại");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new FormAddProduct().ShowDialog();
        }
    }
}
