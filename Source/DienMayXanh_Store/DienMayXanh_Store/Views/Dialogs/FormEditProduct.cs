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
    public partial class FormEditProduct : Form
    {
        private ContextDB context = Program.context;
        private PRODUCT product;
        public FormEditProduct(PRODUCT product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void FormEditProduct_Load(object sender, EventArgs e)
        {
            loadCbmFilter();

            ptbAddImg.Image = product.Img;
            txtPrice.Text =  product.Price.ToString();
            txtProductName.Text = product.Name;
            cmbFilterCategory.SelectedValue = product.CategoryID;
            cmbFilterProducer.SelectedValue = product.BrandID;
        }

        public void loadCbmFilter()
        {
            cmbFilterCategory.ValueMember = "CategoryID";
            cmbFilterCategory.DisplayMember = "Name";
            cmbFilterCategory.DataSource = context.CATEGORIES.ToList();

            cmbFilterProducer.ValueMember = "BrandID";
            cmbFilterProducer.DisplayMember = "Name";
            cmbFilterProducer.DataSource = context.BRANDS.ToList();
        }

        private void setDataProducer()
        {
            string cate = cmbFilterCategory.SelectedValue.ToString();
            cmbFilterProducer.DataSource = context.PRODUCTS
            .Where(x => x.CategoryID.Equals(cate))
            .ToLookup(x => x.BrandID, x => x.BRAND.Name)
            .Select(x => new
            {
                BrandID = x.Key,
                Name = x.ToList()[0],
            })
            .ToList();
        }

        private void updateData()
        {
            if (txtPrice.Text.Equals("") || txtProductName.Text.Equals("") || ptbAddImg.Image == null)
                MessageBox.Show("Vui lòng nhập đủ thông tin kèm ảnh");
            else
            {
                PRODUCT updateProduct = product;
                updateProduct.Name = txtProductName.Text;
                updateProduct.Price = Convert.ToDecimal(txtPrice.Text);
                updateProduct.CategoryID = cmbFilterCategory.SelectedValue.ToString();
                updateProduct.BrandID = cmbFilterProducer.SelectedValue.ToString();
                context.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                FormMenu.instance.openChildForm(new FormProduct());
                this.Dispose();
            }    
        }


        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDataProducer();
        }
    }
}
