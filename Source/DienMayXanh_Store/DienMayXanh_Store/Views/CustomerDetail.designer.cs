namespace DienMayXanh_Store.Views
{
    partial class CustomerDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lb_CustomerID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_CustomerPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_CusotmerAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_CustomerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_ListInvoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvc_Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_filter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lb_totalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_totalQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_EditInfo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListInvoice)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(3)))), ((int)(((byte)(54)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 163);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(140, 36);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Quay lại";
            this.guna2Button1.Click += new System.EventHandler(this.closePanel);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.lb_CustomerID);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox1.Controls.Add(this.lb_CustomerPhone);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.lb_CusotmerAddress);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.lb_CustomerName);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(740, 145);
            this.guna2GroupBox1.TabIndex = 6;
            this.guna2GroupBox1.Text = "Thông tin khách hàng";
            this.guna2GroupBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // lb_CustomerID
            // 
            this.lb_CustomerID.AutoSize = false;
            this.lb_CustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lb_CustomerID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_CustomerID.Location = new System.Drawing.Point(146, 51);
            this.lb_CustomerID.Name = "lb_CustomerID";
            this.lb_CustomerID.Size = new System.Drawing.Size(185, 23);
            this.lb_CustomerID.TabIndex = 7;
            this.lb_CustomerID.Text = "KH0000001";
            this.lb_CustomerID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(3, 51);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(137, 23);
            this.guna2HtmlLabel5.TabIndex = 6;
            this.guna2HtmlLabel5.Text = "Mã số khách hàng:";
            // 
            // lb_CustomerPhone
            // 
            this.lb_CustomerPhone.AutoSize = false;
            this.lb_CustomerPhone.BackColor = System.Drawing.Color.Transparent;
            this.lb_CustomerPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_CustomerPhone.Location = new System.Drawing.Point(446, 51);
            this.lb_CustomerPhone.Name = "lb_CustomerPhone";
            this.lb_CustomerPhone.Size = new System.Drawing.Size(214, 23);
            this.lb_CustomerPhone.TabIndex = 5;
            this.lb_CustomerPhone.Text = "0868104306";
            this.lb_CustomerPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(337, 51);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(103, 23);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Số điện thoại:";
            // 
            // lb_CusotmerAddress
            // 
            this.lb_CusotmerAddress.AutoSize = false;
            this.lb_CusotmerAddress.BackColor = System.Drawing.Color.Transparent;
            this.lb_CusotmerAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CusotmerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_CusotmerAddress.Location = new System.Drawing.Point(65, 109);
            this.lb_CusotmerAddress.Name = "lb_CusotmerAddress";
            this.lb_CusotmerAddress.Size = new System.Drawing.Size(595, 23);
            this.lb_CusotmerAddress.TabIndex = 3;
            this.lb_CusotmerAddress.Text = "Số 40 Lê Văn Việt, P. Tăng Nhơn Phú A, TP.Thủ Đức, TP.HCM";
            this.lb_CusotmerAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(3, 109);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 23);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Địa chỉ:";
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = false;
            this.lb_CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lb_CustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_CustomerName.Location = new System.Drawing.Point(172, 80);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(488, 23);
            this.lb_CustomerName.TabIndex = 1;
            this.lb_CustomerName.Text = "Võ Đoàn Hoàng Long";
            this.lb_CustomerName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 80);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(163, 23);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Họ và tên khách hàng:";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 5;
            this.guna2GroupBox3.Controls.Add(this.dgv_ListInvoice);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(12, 205);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.BorderRadius = 5;
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(1143, 368);
            this.guna2GroupBox3.TabIndex = 8;
            this.guna2GroupBox3.Text = "Lịch sử mua hàng";
            this.guna2GroupBox3.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // dgv_ListInvoice
            // 
            this.dgv_ListInvoice.AllowUserToAddRows = false;
            this.dgv_ListInvoice.AllowUserToDeleteRows = false;
            this.dgv_ListInvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(209)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_ListInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ListInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ListInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ListInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ListInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ListInvoice.ColumnHeadersHeight = 32;
            this.dgv_ListInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InvoiceID,
            this.dgvc_Staff,
            this.CreateAt,
            this.MethodPay,
            this.TotalPrice,
            this.dgv_Button});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(209)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListInvoice.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_ListInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ListInvoice.EnableHeadersVisualStyles = false;
            this.dgv_ListInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ListInvoice.Location = new System.Drawing.Point(0, 38);
            this.dgv_ListInvoice.Name = "dgv_ListInvoice";
            this.dgv_ListInvoice.ReadOnly = true;
            this.dgv_ListInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_ListInvoice.RowHeadersVisible = false;
            this.dgv_ListInvoice.RowTemplate.Height = 30;
            this.dgv_ListInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListInvoice.Size = new System.Drawing.Size(1143, 330);
            this.dgv_ListInvoice.TabIndex = 0;
            this.dgv_ListInvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ListInvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ListInvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ListInvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ListInvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ListInvoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ListInvoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ListInvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(215)))), ((int)(((byte)(249)))));
            this.dgv_ListInvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ListInvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ListInvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_ListInvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ListInvoice.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_ListInvoice.ThemeStyle.ReadOnly = true;
            this.dgv_ListInvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ListInvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_ListInvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ListInvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgv_ListInvoice.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_ListInvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ListInvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_ListInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btn_invoiceDetail_Click);
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle13;
            this.No.FillWeight = 28.4264F;
            this.No.HeaderText = "STT";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // InvoiceID
            // 
            this.InvoiceID.DataPropertyName = "RecieptID";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InvoiceID.DefaultCellStyle = dataGridViewCellStyle14;
            this.InvoiceID.FillWeight = 122.2264F;
            this.InvoiceID.HeaderText = "Mã Hóa Đơn";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            // 
            // dgvc_Staff
            // 
            this.dgvc_Staff.DataPropertyName = "Name";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvc_Staff.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvc_Staff.FillWeight = 122.2264F;
            this.dgvc_Staff.HeaderText = "Tên Nhân Viên";
            this.dgvc_Staff.Name = "dgvc_Staff";
            this.dgvc_Staff.ReadOnly = true;
            // 
            // CreateAt
            // 
            this.CreateAt.DataPropertyName = "CreateAt";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "g";
            dataGridViewCellStyle16.NullValue = null;
            this.CreateAt.DefaultCellStyle = dataGridViewCellStyle16;
            this.CreateAt.FillWeight = 122.2264F;
            this.CreateAt.HeaderText = "Ngày Lập Hóa Đơn";
            this.CreateAt.Name = "CreateAt";
            this.CreateAt.ReadOnly = true;
            // 
            // MethodPay
            // 
            this.MethodPay.DataPropertyName = "PaymentMethod";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MethodPay.DefaultCellStyle = dataGridViewCellStyle17;
            this.MethodPay.FillWeight = 122.2264F;
            this.MethodPay.HeaderText = "Phương Thức Thanh Toán";
            this.MethodPay.Name = "MethodPay";
            this.MethodPay.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "Total";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = null;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle18;
            this.TotalPrice.FillWeight = 122.2264F;
            this.TotalPrice.HeaderText = "Tổng Thanh Toán";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // dgv_Button
            // 
            this.dgv_Button.FillWeight = 60.44162F;
            this.dgv_Button.HeaderText = "";
            this.dgv_Button.Name = "dgv_Button";
            this.dgv_Button.ReadOnly = true;
            this.dgv_Button.Text = "Chi tiết";
            this.dgv_Button.UseColumnTextForButtonValue = true;
            // 
            // FromDate
            // 
            this.FromDate.Animated = true;
            this.FromDate.BorderRadius = 4;
            this.FromDate.Checked = true;
            this.FromDate.CheckedState.Parent = this.FromDate;
            this.FromDate.FillColor = System.Drawing.Color.White;
            this.FromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.HoverState.Parent = this.FromDate;
            this.FromDate.Location = new System.Drawing.Point(649, 163);
            this.FromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.ShadowDecoration.Parent = this.FromDate;
            this.FromDate.Size = new System.Drawing.Size(180, 36);
            this.FromDate.TabIndex = 11;
            this.FromDate.Value = new System.DateTime(2021, 12, 30, 19, 19, 20, 107);
            // 
            // ToDate
            // 
            this.ToDate.Animated = true;
            this.ToDate.BackColor = System.Drawing.Color.Transparent;
            this.ToDate.Checked = true;
            this.ToDate.CheckedState.Parent = this.ToDate;
            this.ToDate.FillColor = System.Drawing.Color.White;
            this.ToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.HoverState.Parent = this.ToDate;
            this.ToDate.Location = new System.Drawing.Point(835, 163);
            this.ToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.ShadowDecoration.Parent = this.ToDate;
            this.ToDate.Size = new System.Drawing.Size(180, 36);
            this.ToDate.TabIndex = 12;
            this.ToDate.Value = new System.DateTime(2021, 12, 30, 17, 36, 2, 196);
            // 
            // btn_filter
            // 
            this.btn_filter.Animated = true;
            this.btn_filter.BorderRadius = 4;
            this.btn_filter.CheckedState.Parent = this.btn_filter;
            this.btn_filter.CustomImages.Parent = this.btn_filter;
            this.btn_filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_filter.DisabledState.Parent = this.btn_filter;
            this.btn_filter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btn_filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_filter.ForeColor = System.Drawing.Color.White;
            this.btn_filter.HoverState.Parent = this.btn_filter;
            this.btn_filter.Location = new System.Drawing.Point(1021, 163);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.ShadowDecoration.Parent = this.btn_filter;
            this.btn_filter.Size = new System.Drawing.Size(140, 36);
            this.btn_filter.TabIndex = 13;
            this.btn_filter.Text = "Lọc";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 5;
            this.guna2GroupBox2.Controls.Add(this.lb_totalQuantity);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(758, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(200, 145);
            this.guna2GroupBox2.TabIndex = 14;
            this.guna2GroupBox2.Text = "Số Sản Phẩm Đã Mua";
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(20, 0);
            this.guna2GroupBox2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = false;
            this.lb_totalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_totalPrice.Location = new System.Drawing.Point(0, 38);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(200, 104);
            this.lb_totalPrice.TabIndex = 10;
            this.lb_totalPrice.Text = "2.200.000.000";
            this.lb_totalPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_totalQuantity
            // 
            this.lb_totalQuantity.AutoSize = false;
            this.lb_totalQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalQuantity.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_totalQuantity.Location = new System.Drawing.Point(3, 38);
            this.lb_totalQuantity.Name = "lb_totalQuantity";
            this.lb_totalQuantity.Size = new System.Drawing.Size(194, 104);
            this.lb_totalQuantity.TabIndex = 9;
            this.lb_totalQuantity.Text = "30";
            this.lb_totalQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_EditInfo
            // 
            this.btn_EditInfo.Animated = true;
            this.btn_EditInfo.BorderRadius = 4;
            this.btn_EditInfo.CheckedState.Parent = this.btn_EditInfo;
            this.btn_EditInfo.CustomImages.Parent = this.btn_EditInfo;
            this.btn_EditInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_EditInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_EditInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_EditInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_EditInfo.DisabledState.Parent = this.btn_EditInfo;
            this.btn_EditInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(91)))), ((int)(((byte)(208)))));
            this.btn_EditInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_EditInfo.ForeColor = System.Drawing.Color.White;
            this.btn_EditInfo.HoverState.Parent = this.btn_EditInfo;
            this.btn_EditInfo.Location = new System.Drawing.Point(184, 163);
            this.btn_EditInfo.Name = "btn_EditInfo";
            this.btn_EditInfo.ShadowDecoration.Parent = this.btn_EditInfo;
            this.btn_EditInfo.Size = new System.Drawing.Size(159, 36);
            this.btn_EditInfo.TabIndex = 15;
            this.btn_EditInfo.Text = "Cập nhật thông tin";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 5;
            this.guna2GroupBox4.Controls.Add(this.lb_totalPrice);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox4.Location = new System.Drawing.Point(964, 12);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(200, 145);
            this.guna2GroupBox4.TabIndex = 16;
            this.guna2GroupBox4.Text = "Tổng Thanh Toán (VNĐ)";
            this.guna2GroupBox4.TextOffset = new System.Drawing.Point(12, 0);
            this.guna2GroupBox4.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1167, 585);
            this.ControlBox = false;
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.btn_EditInfo);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết";
            this.Load += new System.EventHandler(this.CustomerDetail_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListInvoice)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_ListInvoice;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_CustomerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_CusotmerAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_CustomerID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_CustomerPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private Guna.UI2.WinForms.Guna2Button btn_filter;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_totalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_totalQuantity;
        private Guna.UI2.WinForms.Guna2Button btn_EditInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvc_Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_Button;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
    }
}