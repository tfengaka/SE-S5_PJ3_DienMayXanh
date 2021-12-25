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

namespace DienMayXanh_Store.Views
{
    public partial class FormExportProduct : Form
    {
        private ContextDB context = Program.context;
        private string currKey = "", warehouseID;
        public FormExportProduct()
        {
            InitializeComponent();
        }

        private void FormExportProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.AutoGenerateColumns = false;
            loadCmbFilter();
        }

        private void loadData(string cateID = "0")
        {
            MessageBox.Show(warehouseID);
            var data = cateID != "0" ?
                context.PRODUCTAVAILABLES
                .Where(x => x.PRODUCT.CategoryID.Equals(cateID)
                && x.WarehouseID.Equals(warehouseID))
                : context.PRODUCTAVAILABLES
                .Where(x => x.WarehouseID.Equals(warehouseID));


            dgvProduct.DataSource = data.Select(x => new
            {
                x.ProductID,
                x.PRODUCT.Name,
                x.PRODUCT.Price,
                x.Quantity,
                BrandName = x.PRODUCT.BRAND.Name,
                CateName = x.PRODUCT.CATEGORY.Name
            }).ToList();
        }

        private void loadDataByName()
        {
            dgvProduct.DataSource = context.PRODUCTAVAILABLES
                .Where(x => x.PRODUCT.Name.Contains(currKey) 
                && x.WarehouseID.Equals(warehouseID))
                .Select(x => new
                {
                    x.ProductID,
                    x.PRODUCT.Name,
                    x.PRODUCT.Price,
                    x.Quantity,
                    BrandName = x.PRODUCT.BRAND.Name,
                    CateName = x.PRODUCT.CATEGORY.Name
                }).ToList();
        }

        private void loadCmbFilter()
        {
            string cateID = "CategoryID", name = "Name";
            cmbFilterCategory.ValueMember = cateID;
            cmbFilterCategory.DisplayMember = name;
            cmbFilterCategory.DataSource = setTable(cateID, name,
                "Tất cả danh mục", context.CATEGORIES.ToList());

            cmbWarehouse.ValueMember = "WarehouseID";
            cmbWarehouse.DisplayMember = name;
            cmbWarehouse.DataSource = context.WAREHOUSES.ToList();
        }

        private DataTable setTable(string id, string name, string label,
            List<CATEGORY> category)
        {
            DataTable table = new DataTable();
            table.Columns.Add(id, typeof(string));
            table.Columns.Add(name, typeof(string));

                category.ForEach(x =>
                {
                    var rowDT = table.NewRow();
                    rowDT[id] = x.CategoryID;
                    rowDT[name] = x.Name;
                    table.Rows.Add(rowDT);
                });
     

            DataRow row = table.NewRow();
            row[id] = "0";
            row[name] = label;

            table.Rows.InsertAt(row, 0);

            return table;
        }

        private void cmbFilterCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadData(cmbFilterCategory.SelectedValue.ToString());
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            cmbFilterCategory.SelectedIndex = 0;
            currKey = txtSearch.Text;
            loadDataByName();
            currKey = "";
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            warehouseID = cmbWarehouse.SelectedValue.ToString();
            cmbFilterCategory.SelectedIndex = 0;
            txtSearch.Text = "";
            loadData();
        }

        private void cmbWarehouse_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
/*                int examID = Convert.ToInt32(dgvListContests.Rows[e.RowIndex].Cells["ExamID"].Value);
                int subjectID = Convert.ToInt32(dgvListContests.Rows[e.RowIndex].Cells["SubjectID"].Value);
                FormEditContest dialog = new FormEditContest(examID, subjectID, subject);
                dialog.ShowDialog();*/
            }
        }
    }
}
