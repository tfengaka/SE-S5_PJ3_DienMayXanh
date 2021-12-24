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
    public partial class FormAddCategory : Form
    {
        private ContextDB context = Program.context;
        private string currID;
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {
            dgvCategory.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            loadData();
        }

        private void loadData()
        {
            dgvCategory.DataSource = context.CATEGORIES
                .Select(x => new
                {
                    x.CategoryID,
                    x.Name,
                    x.CreateAt
                })
                .OrderByDescending(x => x.CategoryID)
                .ToList();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormImportProduct.instance.loadCbmFilter();
        }

        private void btnAddCatergory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập danh mục");
            else
                saveCategory();
        }

        private void reload()
        {
            loadData();
            txtCategory.Text = "";
            btnEditCategory.Visible = false;
            btnCancel.Visible = false;
        }

        private void saveCategory()
        {
            DateTime date = DateTime.Now;
            CATEGORY newCate = new CATEGORY();
            newCate.CategoryID = date.ToString("yyyyMMddHHmmss");
            newCate.Name = txtCategory.Text;
            newCate.CreateAt = date;
            context.CATEGORIES.Add(newCate);
            context.SaveChanges();
            MessageBox.Show("Thêm thành công");
            reload();
        }

        private void updateCategory()
        {
            context.CATEGORIES.Find(currID).Name = txtCategory.Text;
            context.SaveChanges();
            MessageBox.Show("Cập nhật thành công");
            reload();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập danh mục");
            else
                updateCategory();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCategory.Text = "";
            btnEditCategory.Visible = false;
            btnCancel.Visible = false;
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                currID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCategory.Text = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();          
                btnEditCategory.Visible = true;
                btnCancel.Visible = true;
            }
        }
    }
}
