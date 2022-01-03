namespace DienMayXanh_Store.Views.Dialogs
{
    partial class EditPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tb_currPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_newPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tb_StaffID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tb_repressPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_confirm = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 4;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.btn_exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(3)))), ((int)(((byte)(54)))));
            this.btn_exit.HoverState.IconColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.IconColor = System.Drawing.Color.DarkGray;
            this.btn_exit.Location = new System.Drawing.Point(517, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(57, 38);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Empty;
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(574, 38);
            this.guna2Shapes1.TabIndex = 4;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SVN-Neutraface 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(218, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(117, 25);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Đổi Mật Khẩu";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(120, 131);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(127, 23);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Mật khẩu hiện tại";
            // 
            // tb_currPassword
            // 
            this.tb_currPassword.BorderRadius = 4;
            this.tb_currPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_currPassword.DefaultText = "";
            this.tb_currPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_currPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_currPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_currPassword.DisabledState.Parent = this.tb_currPassword;
            this.tb_currPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_currPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_currPassword.FocusedState.Parent = this.tb_currPassword;
            this.tb_currPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_currPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_currPassword.HoverState.Parent = this.tb_currPassword;
            this.tb_currPassword.Location = new System.Drawing.Point(120, 160);
            this.tb_currPassword.Name = "tb_currPassword";
            this.tb_currPassword.PasswordChar = '●';
            this.tb_currPassword.PlaceholderText = "";
            this.tb_currPassword.SelectedText = "";
            this.tb_currPassword.ShadowDecoration.Parent = this.tb_currPassword;
            this.tb_currPassword.Size = new System.Drawing.Size(340, 41);
            this.tb_currPassword.TabIndex = 7;
            this.tb_currPassword.UseSystemPasswordChar = true;
            // 
            // tb_newPassword
            // 
            this.tb_newPassword.BorderRadius = 4;
            this.tb_newPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_newPassword.DefaultText = "";
            this.tb_newPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_newPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_newPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_newPassword.DisabledState.Parent = this.tb_newPassword;
            this.tb_newPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_newPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_newPassword.FocusedState.Parent = this.tb_newPassword;
            this.tb_newPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_newPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_newPassword.HoverState.Parent = this.tb_newPassword;
            this.tb_newPassword.Location = new System.Drawing.Point(120, 236);
            this.tb_newPassword.Name = "tb_newPassword";
            this.tb_newPassword.PasswordChar = '●';
            this.tb_newPassword.PlaceholderText = "";
            this.tb_newPassword.SelectedText = "";
            this.tb_newPassword.ShadowDecoration.Parent = this.tb_newPassword;
            this.tb_newPassword.Size = new System.Drawing.Size(340, 41);
            this.tb_newPassword.TabIndex = 9;
            this.tb_newPassword.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(120, 207);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(102, 23);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Mật khẩu mới";
            // 
            // tb_StaffID
            // 
            this.tb_StaffID.BorderRadius = 4;
            this.tb_StaffID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_StaffID.DefaultText = "";
            this.tb_StaffID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_StaffID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_StaffID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_StaffID.DisabledState.Parent = this.tb_StaffID;
            this.tb_StaffID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_StaffID.Enabled = false;
            this.tb_StaffID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_StaffID.FocusedState.Parent = this.tb_StaffID;
            this.tb_StaffID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_StaffID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_StaffID.HoverState.Parent = this.tb_StaffID;
            this.tb_StaffID.Location = new System.Drawing.Point(120, 84);
            this.tb_StaffID.Name = "tb_StaffID";
            this.tb_StaffID.PasswordChar = '\0';
            this.tb_StaffID.PlaceholderText = "";
            this.tb_StaffID.SelectedText = "";
            this.tb_StaffID.ShadowDecoration.Parent = this.tb_StaffID;
            this.tb_StaffID.Size = new System.Drawing.Size(340, 41);
            this.tb_StaffID.TabIndex = 11;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(120, 55);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(127, 23);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "Mã Số Nhân Viên";
            // 
            // tb_repressPassword
            // 
            this.tb_repressPassword.BorderRadius = 4;
            this.tb_repressPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_repressPassword.DefaultText = "";
            this.tb_repressPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_repressPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_repressPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_repressPassword.DisabledState.Parent = this.tb_repressPassword;
            this.tb_repressPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_repressPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_repressPassword.FocusedState.Parent = this.tb_repressPassword;
            this.tb_repressPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_repressPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_repressPassword.HoverState.Parent = this.tb_repressPassword;
            this.tb_repressPassword.Location = new System.Drawing.Point(120, 312);
            this.tb_repressPassword.Name = "tb_repressPassword";
            this.tb_repressPassword.PasswordChar = '●';
            this.tb_repressPassword.PlaceholderText = "";
            this.tb_repressPassword.SelectedText = "";
            this.tb_repressPassword.ShadowDecoration.Parent = this.tb_repressPassword;
            this.tb_repressPassword.Size = new System.Drawing.Size(340, 41);
            this.tb_repressPassword.TabIndex = 13;
            this.tb_repressPassword.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(120, 283);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(132, 23);
            this.guna2HtmlLabel5.TabIndex = 12;
            this.guna2HtmlLabel5.Text = "Nhập lại mật khẩu ";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BorderRadius = 5;
            this.btn_confirm.CheckedState.Parent = this.btn_confirm;
            this.btn_confirm.CustomImages.Parent = this.btn_confirm;
            this.btn_confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirm.DisabledState.Parent = this.btn_confirm;
            this.btn_confirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(91)))), ((int)(((byte)(208)))));
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.HoverState.Parent = this.btn_confirm;
            this.btn_confirm.Location = new System.Drawing.Point(120, 368);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.ShadowDecoration.Parent = this.btn_confirm;
            this.btn_confirm.Size = new System.Drawing.Size(340, 60);
            this.btn_confirm.TabIndex = 14;
            this.btn_confirm.Text = "Đổi Mật Khẩu";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 470);
            this.ControlBox = false;
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_repressPassword);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.tb_StaffID);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.tb_newPassword);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.tb_currPassword);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.guna2Shapes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox btn_exit;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_confirm;
        private Guna.UI2.WinForms.Guna2TextBox tb_repressPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox tb_StaffID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox tb_newPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox tb_currPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}