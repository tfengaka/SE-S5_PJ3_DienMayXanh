
namespace DienMayXanh_Store.Views.Dialogs
{
    partial class FormAddProducer
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
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblProducer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtProducerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProducerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvProducer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProducer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditProducer = new Guna.UI2.WinForms.Guna2Button();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProducer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 15;
            this.Elipse.TargetControl = this;
            // 
            // ShadowForm
            // 
            this.ShadowForm.ShadowColor = System.Drawing.Color.Gray;
            this.ShadowForm.TargetForm = this;
            // 
            // lblProducer
            // 
            this.lblProducer.BackColor = System.Drawing.Color.Transparent;
            this.lblProducer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblProducer.Location = new System.Drawing.Point(286, 12);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(209, 27);
            this.lblProducer.TabIndex = 5;
            this.lblProducer.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BorderColor = System.Drawing.Color.Transparent;
            this.close.FillColor = System.Drawing.Color.Transparent;
            this.close.HoverState.FillColor = System.Drawing.Color.Red;
            this.close.HoverState.Parent = this.close;
            this.close.IconColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(769, -1);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(32, 25);
            this.close.TabIndex = 11;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtProducerName
            // 
            this.txtProducerName.Animated = true;
            this.txtProducerName.BackColor = System.Drawing.Color.Transparent;
            this.txtProducerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtProducerName.BorderRadius = 8;
            this.txtProducerName.BorderThickness = 2;
            this.txtProducerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducerName.DefaultText = "";
            this.txtProducerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducerName.DisabledState.Parent = this.txtProducerName;
            this.txtProducerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtProducerName.FocusedState.Parent = this.txtProducerName;
            this.txtProducerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtProducerName.ForeColor = System.Drawing.Color.Black;
            this.txtProducerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtProducerName.HoverState.Parent = this.txtProducerName;
            this.txtProducerName.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtProducerName.Location = new System.Drawing.Point(12, 46);
            this.txtProducerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducerName.MaxLength = 30;
            this.txtProducerName.Name = "txtProducerName";
            this.txtProducerName.PasswordChar = '\0';
            this.txtProducerName.PlaceholderText = "Tên nhà cung cấp";
            this.txtProducerName.SelectedText = "";
            this.txtProducerName.ShadowDecoration.BorderRadius = 15;
            this.txtProducerName.ShadowDecoration.Depth = 10;
            this.txtProducerName.ShadowDecoration.Enabled = true;
            this.txtProducerName.ShadowDecoration.Parent = this.txtProducerName;
            this.txtProducerName.Size = new System.Drawing.Size(315, 45);
            this.txtProducerName.TabIndex = 12;
            this.txtProducerName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtProducerAddress
            // 
            this.txtProducerAddress.Animated = true;
            this.txtProducerAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtProducerAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtProducerAddress.BorderRadius = 8;
            this.txtProducerAddress.BorderThickness = 2;
            this.txtProducerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducerAddress.DefaultText = "";
            this.txtProducerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProducerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProducerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducerAddress.DisabledState.Parent = this.txtProducerAddress;
            this.txtProducerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProducerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtProducerAddress.FocusedState.Parent = this.txtProducerAddress;
            this.txtProducerAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtProducerAddress.ForeColor = System.Drawing.Color.Black;
            this.txtProducerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtProducerAddress.HoverState.Parent = this.txtProducerAddress;
            this.txtProducerAddress.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtProducerAddress.Location = new System.Drawing.Point(380, 46);
            this.txtProducerAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducerAddress.MaxLength = 30;
            this.txtProducerAddress.Name = "txtProducerAddress";
            this.txtProducerAddress.PasswordChar = '\0';
            this.txtProducerAddress.PlaceholderText = "Địa chỉ nhà cung cấp";
            this.txtProducerAddress.SelectedText = "";
            this.txtProducerAddress.ShadowDecoration.BorderRadius = 15;
            this.txtProducerAddress.ShadowDecoration.Depth = 10;
            this.txtProducerAddress.ShadowDecoration.Enabled = true;
            this.txtProducerAddress.ShadowDecoration.Parent = this.txtProducerAddress;
            this.txtProducerAddress.Size = new System.Drawing.Size(408, 45);
            this.txtProducerAddress.TabIndex = 13;
            this.txtProducerAddress.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // dgvProducer
            // 
            this.dgvProducer.AllowUserToAddRows = false;
            this.dgvProducer.AllowUserToDeleteRows = false;
            this.dgvProducer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducer.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducer.ColumnHeadersHeight = 36;
            this.dgvProducer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrandID,
            this.nameProducer,
            this.createAt,
            this.address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducer.EnableHeadersVisualStyles = false;
            this.dgvProducer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducer.Location = new System.Drawing.Point(12, 140);
            this.dgvProducer.Name = "dgvProducer";
            this.dgvProducer.ReadOnly = true;
            this.dgvProducer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducer.RowHeadersVisible = false;
            this.dgvProducer.RowTemplate.Height = 30;
            this.dgvProducer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducer.Size = new System.Drawing.Size(776, 298);
            this.dgvProducer.TabIndex = 14;
            this.dgvProducer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProducer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProducer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProducer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProducer.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvProducer.ThemeStyle.ReadOnly = true;
            this.dgvProducer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvProducer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProducer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducer.ThemeStyle.RowsStyle.Height = 30;
            this.dgvProducer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducer_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.DisabledState.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(542, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.BorderRadius = 15;
            this.btnCancel.ShadowDecoration.Depth = 10;
            this.btnCancel.ShadowDecoration.Enabled = true;
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Animated = true;
            this.btnAddProducer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProducer.BorderRadius = 10;
            this.btnAddProducer.BorderThickness = 1;
            this.btnAddProducer.CheckedState.Parent = this.btnAddProducer;
            this.btnAddProducer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProducer.CustomImages.Parent = this.btnAddProducer;
            this.btnAddProducer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProducer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProducer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProducer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProducer.DisabledState.Parent = this.btnAddProducer;
            this.btnAddProducer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnAddProducer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAddProducer.HoverState.Parent = this.btnAddProducer;
            this.btnAddProducer.Location = new System.Drawing.Point(675, 98);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.ShadowDecoration.BorderRadius = 15;
            this.btnAddProducer.ShadowDecoration.Depth = 10;
            this.btnAddProducer.ShadowDecoration.Enabled = true;
            this.btnAddProducer.ShadowDecoration.Parent = this.btnAddProducer;
            this.btnAddProducer.Size = new System.Drawing.Size(100, 36);
            this.btnAddProducer.TabIndex = 17;
            this.btnAddProducer.Text = "Thêm";
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // btnEditProducer
            // 
            this.btnEditProducer.Animated = true;
            this.btnEditProducer.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProducer.BorderRadius = 10;
            this.btnEditProducer.BorderThickness = 1;
            this.btnEditProducer.CheckedState.Parent = this.btnEditProducer;
            this.btnEditProducer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProducer.CustomImages.Parent = this.btnEditProducer;
            this.btnEditProducer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProducer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProducer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditProducer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditProducer.DisabledState.Parent = this.btnEditProducer;
            this.btnEditProducer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnEditProducer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditProducer.HoverState.Parent = this.btnEditProducer;
            this.btnEditProducer.Location = new System.Drawing.Point(675, 98);
            this.btnEditProducer.Name = "btnEditProducer";
            this.btnEditProducer.ShadowDecoration.BorderRadius = 15;
            this.btnEditProducer.ShadowDecoration.Depth = 10;
            this.btnEditProducer.ShadowDecoration.Enabled = true;
            this.btnEditProducer.ShadowDecoration.Parent = this.btnEditProducer;
            this.btnEditProducer.Size = new System.Drawing.Size(100, 36);
            this.btnEditProducer.TabIndex = 18;
            this.btnEditProducer.Text = "Sửa";
            this.btnEditProducer.Visible = false;
            this.btnEditProducer.Click += new System.EventHandler(this.btnEditProducer_Click);
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "BrandID";
            this.BrandID.FillWeight = 71.82564F;
            this.BrandID.HeaderText = "Mã số thuế";
            this.BrandID.Name = "BrandID";
            this.BrandID.ReadOnly = true;
            // 
            // nameProducer
            // 
            this.nameProducer.DataPropertyName = "Name";
            this.nameProducer.FillWeight = 91.37056F;
            this.nameProducer.HeaderText = "Tên doanh nghiệp";
            this.nameProducer.Name = "nameProducer";
            this.nameProducer.ReadOnly = true;
            // 
            // createAt
            // 
            this.createAt.DataPropertyName = "CreateAt";
            this.createAt.FillWeight = 72.08369F;
            this.createAt.HeaderText = "Ngày ký kết";
            this.createAt.Name = "createAt";
            this.createAt.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "Address";
            this.address.FillWeight = 164.7201F;
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // FormAddProducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditProducer);
            this.Controls.Add(this.btnAddProducer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvProducer);
            this.Controls.Add(this.txtProducerAddress);
            this.Controls.Add(this.txtProducerName);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lblProducer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddProducer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddProducer";
            this.Load += new System.EventHandler(this.FormAddProducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProducer;
        private Guna.UI2.WinForms.Guna2ControlBox close;
        private Guna.UI2.WinForms.Guna2TextBox txtProducerName;
        private Guna.UI2.WinForms.Guna2TextBox txtProducerAddress;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducer;
        private Guna.UI2.WinForms.Guna2Button btnAddProducer;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnEditProducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProducer;
        private System.Windows.Forms.DataGridViewTextBoxColumn createAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}