using Guna.UI2.WinForms;
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
    public partial class FormIESlip : Form
    {
        public FormIESlip()
        {
            InitializeComponent();
        }

        private void FormIESlip_Load(object sender, EventArgs e)
        {
            openChildForm(new FormImportProduct(), pageImport);
        }

        private void openChildForm(Form childForm, TabPage page)
        {
            childForm.TopLevel = false;
            page.Controls.Add(childForm);
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

    }
}
