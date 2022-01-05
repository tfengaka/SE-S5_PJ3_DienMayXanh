using DienMayXanh_Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DienMayXanh_Store.Views
{
    public partial class FormProduct : Form
    {
        private ContextDB context = Program.context;
        private string currKey = "";
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAddCategory, "Thêm sản phẩm");
            toolTip.SetToolTip(btnAddCategory, "Thêm nhà cung cấp");

            loadCmbFilter();

            loadData();
        }

        private void loadCmbFilter()
        {
            List<CATEGORY> cate = context.CATEGORIES.ToList();

            DataTable table = new DataTable();
            table.Columns.Add("CategoryID", typeof(string));
            table.Columns.Add("Name", typeof(string));

            cate.ForEach(x =>
            {
                var rowDT = table.NewRow();
                rowDT["CategoryID"] = x.CategoryID;
                rowDT["Name"] = x.Name;
                table.Rows.Add(rowDT);
            });

            DataRow row = table.NewRow();
            row["CategoryID"] = "0";
            row["Name"] = "Tất cả";
            table.Rows.InsertAt(row, 0);

            cbmFilter.ValueMember = "CategoryID";
            cbmFilter.DisplayMember = "Name";
            cbmFilter.DataSource = table;
        }

        private void loadData(string cate = "0")
        {
            var data = !currKey.Equals("") ?
                context.PRODUCTS.Where(x => x.Name.Contains(currKey))
                : cate.Equals("0") ?
                context.PRODUCTS :
                context.PRODUCTS.Where(x => x.CategoryID.Equals(cate));
                
            
            dgvProduct.DataSource = data
                .AsEnumerable()
                .Select(item => new
                {
                    item.Img,
                    item.ProductID,
                    item.Name,
                    item.Price,
                    CategoryName = item.CATEGORY.Name,
                    BrandName = item.BRAND.Name
                }).ToList();
        }

        private void cbmFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadData(cbmFilter.SelectedValue.ToString());
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            currKey = txtSearch.Text;
            cbmFilter.SelectedIndex = 0;
            loadData();
            currKey = "";
        }

        private void btnAddCatagory_Click(object sender, EventArgs e)
        {
            new Dialogs.FormAddCategory().ShowDialog();
        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            new Dialogs.FormAddProducer().ShowDialog();
        }
    }
}
