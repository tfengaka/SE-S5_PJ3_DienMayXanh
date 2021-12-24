using DienMayXanh_Store.Models;
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
        private ContextDB context = Program.context;
        public static FormImportProduct instance;
        public FormImportProduct()
        {
            InitializeComponent();
            instance = this;
        }

        private void FormImportProduct_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAddCategory, "Quản lý danh mục");
            toolTip.SetToolTip(btnAddProducer, "Quản lý nhà cung cấp");
            loadCbmFilter();
        }

        public void loadCbmFilter()
        {
            cbmFilterCategory.ValueMember = "CategoryID";
            cbmFilterCategory.DisplayMember = "Name";
            cbmFilterCategory.DataSource = context.CATEGORIES.ToList();

            cmbFilterProducer.ValueMember = "BrandID";
            cmbFilterProducer.DisplayMember = "Name";
            cmbFilterProducer.DataSource = context.BRANDS.ToList();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new FormAddCategory().ShowDialog();
        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            new FormAddProducer().ShowDialog();
        }
    }
}
