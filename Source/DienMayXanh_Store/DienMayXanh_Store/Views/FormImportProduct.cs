using DienMayXanh_Store.Views.Dialogs;
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
    public partial class FormImportProduct : Form
    {
        public FormImportProduct()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new FormAddCategory().ShowDialog();
        }
    }
}
