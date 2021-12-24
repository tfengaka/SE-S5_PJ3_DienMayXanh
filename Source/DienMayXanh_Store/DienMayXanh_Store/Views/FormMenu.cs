using DienMayXanh_Store.Models;
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
    public partial class FormMenu : Form
    {
        private ContextDB context = Program.context;
        private STAFF info = FormLogin.instance.info;

        private Guna2Button currBtn;
        private Panel leftBorderBtn;
        private Form currChildForm;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            leftBorderBtn = new Panel();
            panelMenu.Controls.Add(leftBorderBtn);
            activateButton(btnHome);

            ptbAvatar.ImageLocation = string.Format(@"..\..\Images\" + info.StaffID + ".jpg");
            lblFullName.Text = info.Name;
            lblPosition.Text = info.Position;
        }

        public void openChildForm(Form childForm)
        {
            if (currChildForm != null)
                currChildForm.Dispose();
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void activateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableButton();
                currBtn = (Guna2Button)senderBtn;
                currBtn.Checked = true;

                leftBorderBtn.BackColor = Color.FromArgb(0, 158, 225);
                leftBorderBtn.Location = new Point(currBtn.Size.Width - 5, currBtn.Location.Y);
                leftBorderBtn.Size = new Size(5, 45);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void disableButton()
        {
            if (currBtn != null)
                currBtn.Checked = false;
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(new FormProduct());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openChildForm(new FormIESlip());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin.instance.Visible = true;
            this.Dispose();
        }

        private void close_Click(object sender, EventArgs e)
        {
            FormLogin.instance.Dispose();   
        }
    }
}
