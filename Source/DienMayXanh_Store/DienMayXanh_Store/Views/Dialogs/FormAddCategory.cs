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
        }

        private void btnAddCatergory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập danh mục");
            else
                saveCategory();
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
            loadData();
        }
    }
}
