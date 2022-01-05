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
    public partial class FormAddProducer : Form
    {
        private ContextDB context = Program.context;
        private string currID;
        public FormAddProducer()
        {
            InitializeComponent();
        }

        private void FormAddProducer_Load(object sender, EventArgs e)
        {
            dgvProducer.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            loadData();
        }

        private void loadData()
        {
            dgvProducer.DataSource = context.BRANDS
                .Select(x => new
                {
                    x.BrandID,
                    x.Name,
                    x.CreateAt,
                    x.Address
                })
                .OrderByDescending(x => x.BrandID)
                .ToList();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if(FormImportProduct.instance != null)
            {
                FormImportProduct.instance.loadCbmFilter();
            }
           
        }

        private bool checkNull()
        {
            return txtProducerName.Text.Equals("")
                || txtProducerAddress.Text.Equals("")
                ? false : true;
        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            if (!checkNull())
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else saveData();
        }

        private void reload()
        {
            txtProducerName.Text = "";
            txtProducerAddress.Text = "";
            btnEditProducer.Visible = false;
            btnCancel.Visible = false;
            loadData();
        }

        private void saveData()
        {
            DateTime date = DateTime.Now;
            BRAND newBrand = new BRAND();
            newBrand.BrandID = date.ToString("yyyyMMddHHmmss");
            newBrand.Name = txtProducerName.Text;
            newBrand.CreateAt = date;
            newBrand.Address = txtProducerAddress.Text;
            context.BRANDS.Add(newBrand);
            context.SaveChanges();
            MessageBox.Show("Thêm thành công");
            reload();
        }

        private void updateData()
        {
            BRAND updateBrand = context.BRANDS.Find(currID);
            updateBrand.Name = txtProducerName.Text;
            updateBrand.Address = txtProducerAddress.Text;
            context.SaveChanges();
            MessageBox.Show("Cập nhật thành công");
            reload();
        }

        private void btnEditProducer_Click(object sender, EventArgs e)
        {
            if (!checkNull())
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else updateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtProducerName.Text = "";
            txtProducerAddress.Text = "";
            btnEditProducer.Visible = false;
            btnCancel.Visible = false;
        }

        private void dgvProducer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                currID = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProducerName.Text = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProducerAddress.Text = senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnEditProducer.Visible = true;
                btnCancel.Visible = true;
            }
        }
    }
}
