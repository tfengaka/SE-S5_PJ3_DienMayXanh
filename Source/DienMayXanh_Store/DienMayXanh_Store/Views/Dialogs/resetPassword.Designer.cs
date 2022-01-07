namespace DienMayXanh_Store.Views.Dialogs
{
    partial class resetPassword
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.dgv_Staff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_resetPassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_searchStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SVN-Neutraface 2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(342, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(149, 25);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Cấp lại mật khẩu";
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
            this.btn_exit.Location = new System.Drawing.Point(780, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(57, 38);
            this.btn_exit.TabIndex = 6;
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
            this.guna2Shapes1.Size = new System.Drawing.Size(837, 38);
            this.guna2Shapes1.TabIndex = 7;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // dgv_Staff
            // 
            this.dgv_Staff.AllowUserToAddRows = false;
            this.dgv_Staff.AllowUserToDeleteRows = false;
            this.dgv_Staff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Staff.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Staff.ColumnHeadersHeight = 36;
            this.dgv_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.StaffPosition,
            this.StaffPhone,
            this.btn_resetPassword});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Staff.EnableHeadersVisualStyles = false;
            this.dgv_Staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Staff.Location = new System.Drawing.Point(12, 85);
            this.dgv_Staff.Name = "dgv_Staff";
            this.dgv_Staff.ReadOnly = true;
            this.dgv_Staff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Staff.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Staff.RowHeadersVisible = false;
            this.dgv_Staff.RowTemplate.Height = 30;
            this.dgv_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Staff.Size = new System.Drawing.Size(813, 353);
            this.dgv_Staff.TabIndex = 9;
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgv_Staff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Staff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Staff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Staff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Staff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Staff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Staff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Staff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Staff.ThemeStyle.HeaderStyle.Height = 36;
            this.dgv_Staff.ThemeStyle.ReadOnly = true;
            this.dgv_Staff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Staff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_Staff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Staff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Staff.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_Staff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgv_Staff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btn_resetPassword_Click);
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.FillWeight = 88.11921F;
            this.StaffID.HeaderText = "Mã Nhân Viên";
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.FillWeight = 142.1012F;
            this.StaffName.HeaderText = "Tên Nhân Viên";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // StaffPosition
            // 
            this.StaffPosition.DataPropertyName = "StaffPosition";
            this.StaffPosition.FillWeight = 63.45177F;
            this.StaffPosition.HeaderText = "Chức Vụ";
            this.StaffPosition.Name = "StaffPosition";
            this.StaffPosition.ReadOnly = true;
            // 
            // StaffPhone
            // 
            this.StaffPhone.DataPropertyName = "StaffPhone";
            this.StaffPhone.FillWeight = 142.1012F;
            this.StaffPhone.HeaderText = "Số Điện Thoại";
            this.StaffPhone.Name = "StaffPhone";
            this.StaffPhone.ReadOnly = true;
            // 
            // btn_resetPassword
            // 
            this.btn_resetPassword.FillWeight = 64.22654F;
            this.btn_resetPassword.HeaderText = "Tùy Chọn";
            this.btn_resetPassword.Name = "btn_resetPassword";
            this.btn_resetPassword.ReadOnly = true;
            this.btn_resetPassword.Text = "Cấp";
            this.btn_resetPassword.UseColumnTextForButtonValue = true;
            // 
            // tb_searchStaff
            // 
            this.tb_searchStaff.Animated = true;
            this.tb_searchStaff.BackColor = System.Drawing.Color.Transparent;
            this.tb_searchStaff.BorderRadius = 5;
            this.tb_searchStaff.BorderThickness = 0;
            this.tb_searchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchStaff.DefaultText = "";
            this.tb_searchStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchStaff.DisabledState.Parent = this.tb_searchStaff;
            this.tb_searchStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.tb_searchStaff.FocusedState.Parent = this.tb_searchStaff;
            this.tb_searchStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_searchStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchStaff.HoverState.Parent = this.tb_searchStaff;
            this.tb_searchStaff.IconRight = global::DienMayXanh_Store.Properties.Resources.search;
            this.tb_searchStaff.IconRightOffset = new System.Drawing.Point(5, 0);
            this.tb_searchStaff.Location = new System.Drawing.Point(12, 44);
            this.tb_searchStaff.Name = "tb_searchStaff";
            this.tb_searchStaff.PasswordChar = '\0';
            this.tb_searchStaff.PlaceholderText = "Tìm kiếm nhân viên";
            this.tb_searchStaff.SelectedText = "";
            this.tb_searchStaff.ShadowDecoration.BorderRadius = 10;
            this.tb_searchStaff.ShadowDecoration.Depth = 10;
            this.tb_searchStaff.ShadowDecoration.Enabled = true;
            this.tb_searchStaff.ShadowDecoration.Parent = this.tb_searchStaff;
            this.tb_searchStaff.Size = new System.Drawing.Size(353, 36);
            this.tb_searchStaff.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.Animated = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderRadius = 5;
            this.btn_search.CheckedState.Parent = this.btn_search;
            this.btn_search.CustomImages.Parent = this.btn_search;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.DisabledState.Parent = this.btn_search;
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(91)))), ((int)(((byte)(208)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.Parent = this.btn_search;
            this.btn_search.Location = new System.Drawing.Point(371, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.ShadowDecoration.BorderRadius = 10;
            this.btn_search.ShadowDecoration.Depth = 10;
            this.btn_search.ShadowDecoration.Enabled = true;
            this.btn_search.ShadowDecoration.Parent = this.btn_search;
            this.btn_search.Size = new System.Drawing.Size(164, 36);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Tìm kiếm";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // resetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_searchStaff);
            this.Controls.Add(this.dgv_Staff);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.guna2Shapes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.resetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Staff;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox btn_exit;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffPhone;
        private System.Windows.Forms.DataGridViewButtonColumn btn_resetPassword;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}