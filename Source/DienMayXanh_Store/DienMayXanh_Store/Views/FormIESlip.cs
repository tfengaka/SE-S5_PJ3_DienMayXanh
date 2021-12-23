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
        private Form currChildForm;
        private Guna2Button currBtn;
        public FormIESlip()
        {
            InitializeComponent();
        }

        private void FormIESlip_Load(object sender, EventArgs e)
        {
            btnImport_Click(btnImport, e);
            activateButton(btnImport);
        }

        private void activateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableButton();
                currBtn = (Guna2Button)senderBtn;
                currBtn.Checked = true;
            }
        }

        private void disableButton()
        {
            if (currBtn != null)
                currBtn.Checked = false;
        }


        private void openChildForm(Form childForm)
        {
            if (currChildForm != null)
                currChildForm.Dispose();
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlOrderContent.Controls.Add(childForm);
            pnlOrderContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(new FormImportProduct());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }
    }
}
