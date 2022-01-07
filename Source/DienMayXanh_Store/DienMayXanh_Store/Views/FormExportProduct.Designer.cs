
namespace DienMayXanh_Store.Views
{
    partial class FormExportProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPosition = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFilterCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWarehouse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbWarehouse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblImg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblTotalPice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.containerListOrder = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.containerListOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPosition.Location = new System.Drawing.Point(12, 84);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(93, 27);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Danh mục";
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.cmbFilterCategory.BorderRadius = 5;
            this.cmbFilterCategory.BorderThickness = 0;
            this.cmbFilterCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterCategory.FocusedState.Parent = this.cmbFilterCategory;
            this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilterCategory.HoverState.Parent = this.cmbFilterCategory;
            this.cmbFilterCategory.ItemHeight = 30;
            this.cmbFilterCategory.ItemsAppearance.Parent = this.cmbFilterCategory;
            this.cmbFilterCategory.Location = new System.Drawing.Point(12, 116);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.ShadowDecoration.BorderRadius = 10;
            this.cmbFilterCategory.ShadowDecoration.Depth = 10;
            this.cmbFilterCategory.ShadowDecoration.Enabled = true;
            this.cmbFilterCategory.ShadowDecoration.Parent = this.cmbFilterCategory;
            this.cmbFilterCategory.Size = new System.Drawing.Size(271, 36);
            this.cmbFilterCategory.TabIndex = 8;
            this.cmbFilterCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbFilterCategory_SelectionChangeCommitted);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProduct.ColumnHeadersHeight = 30;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductPrice,
            this.Category,
            this.Brand,
            this.Quantity,
            this.btnAddProduct,
            this.BrandID,
            this.CategoryID});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.Location = new System.Drawing.Point(289, 12);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvProduct.RowHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvProduct.RowTemplate.Height = 30;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(864, 205);
            this.dgvProduct.TabIndex = 15;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvProduct.ThemeStyle.ReadOnly = true;
            this.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.ThemeStyle.RowsStyle.Height = 30;
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductID.DefaultCellStyle = dataGridViewCellStyle20;
            this.ProductID.FillWeight = 93.56895F;
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "Name";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle21;
            this.ProductName.FillWeight = 217.838F;
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.DataPropertyName = "Price";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            this.ProductPrice.DefaultCellStyle = dataGridViewCellStyle22;
            this.ProductPrice.FillWeight = 88.20953F;
            this.ProductPrice.HeaderText = "Đơn giá";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "CateName";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Category.DefaultCellStyle = dataGridViewCellStyle23;
            this.Category.FillWeight = 78.78949F;
            this.Category.HeaderText = "Danh mục";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "BrandName";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Brand.DefaultCellStyle = dataGridViewCellStyle24;
            this.Brand.FillWeight = 89.40144F;
            this.Brand.HeaderText = "Thương hiệu";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle25;
            this.Quantity.FillWeight = 75.3397F;
            this.Quantity.HeaderText = "Tồn kho";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FillWeight = 56.85278F;
            this.btnAddProduct.HeaderText = ".....";
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.ReadOnly = true;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseColumnTextForButtonValue = true;
            // 
            // BrandID
            // 
            this.BrandID.DataPropertyName = "BrandID";
            this.BrandID.HeaderText = "BrandID";
            this.BrandID.Name = "BrandID";
            this.BrandID.ReadOnly = true;
            this.BrandID.Visible = false;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CateID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblWarehouse.Location = new System.Drawing.Point(12, 12);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(38, 27);
            this.lblWarehouse.TabIndex = 18;
            this.lblWarehouse.Text = "Kho";
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.cmbWarehouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.cmbWarehouse.BorderRadius = 5;
            this.cmbWarehouse.BorderThickness = 0;
            this.cmbWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbWarehouse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbWarehouse.FocusedState.Parent = this.cmbWarehouse;
            this.cmbWarehouse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbWarehouse.HoverState.Parent = this.cmbWarehouse;
            this.cmbWarehouse.ItemHeight = 30;
            this.cmbWarehouse.ItemsAppearance.Parent = this.cmbWarehouse;
            this.cmbWarehouse.Location = new System.Drawing.Point(12, 42);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.ShadowDecoration.BorderRadius = 10;
            this.cmbWarehouse.ShadowDecoration.Depth = 10;
            this.cmbWarehouse.ShadowDecoration.Enabled = true;
            this.cmbWarehouse.ShadowDecoration.Parent = this.cmbWarehouse;
            this.cmbWarehouse.Size = new System.Drawing.Size(271, 36);
            this.cmbWarehouse.TabIndex = 17;
            this.cmbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cmbWarehouse_SelectedIndexChanged);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = false;
            this.lblImg.BackColor = System.Drawing.Color.Transparent;
            this.lblImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblImg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblImg.Location = new System.Drawing.Point(0, 0);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(93, 56);
            this.lblImg.TabIndex = 19;
            this.lblImg.Text = "Ảnh";
            this.lblImg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblName.Location = new System.Drawing.Point(93, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(367, 56);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Tên sản phẩm";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = false;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPrice.Location = new System.Drawing.Point(460, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(116, 56);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Đơn giá";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = false;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblQuantity.Location = new System.Drawing.Point(576, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(123, 56);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Số lượng";
            this.lblQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPice
            // 
            this.lblTotalPice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblTotalPice.Location = new System.Drawing.Point(12, 498);
            this.lblTotalPice.Name = "lblTotalPice";
            this.lblTotalPice.Size = new System.Drawing.Size(165, 27);
            this.lblTotalPice.TabIndex = 19;
            this.lblTotalPice.Text = "Thành tiền: 0 VNĐ";
            // 
            // btnPayment
            // 
            this.btnPayment.Animated = true;
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnPayment.BorderRadius = 5;
            this.btnPayment.CheckedState.Parent = this.btnPayment;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.CustomImages.Parent = this.btnPayment;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.DisabledState.Parent = this.btnPayment;
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnPayment.HoverState.Parent = this.btnPayment;
            this.btnPayment.Location = new System.Drawing.Point(1015, 490);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.ShadowDecoration.BorderRadius = 10;
            this.btnPayment.ShadowDecoration.Depth = 10;
            this.btnPayment.ShadowDecoration.Enabled = true;
            this.btnPayment.ShadowDecoration.Parent = this.btnPayment;
            this.btnPayment.Size = new System.Drawing.Size(138, 39);
            this.btnPayment.TabIndex = 27;
            this.btnPayment.Text = "Tạo đơn hàng";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconRight = global::DienMayXanh_Store.Properties.Resources.search;
            this.txtSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.Location = new System.Drawing.Point(12, 172);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.MaxLength = 30;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm tên sản phẩm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSearch.ShadowDecoration.Depth = 10;
            this.txtSearch.ShadowDecoration.Enabled = true;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(271, 45);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // containerListOrder
            // 
            this.containerListOrder.BackColor = System.Drawing.Color.Transparent;
            this.containerListOrder.BorderRadius = 5;
            this.containerListOrder.BorderThickness = 0;
            this.containerListOrder.Controls.Add(this.dgvListOrder);
            this.containerListOrder.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.containerListOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerListOrder.ForeColor = System.Drawing.Color.Black;
            this.containerListOrder.Location = new System.Drawing.Point(11, 234);
            this.containerListOrder.Name = "containerListOrder";
            this.containerListOrder.ShadowDecoration.BorderRadius = 10;
            this.containerListOrder.ShadowDecoration.Depth = 10;
            this.containerListOrder.ShadowDecoration.Enabled = true;
            this.containerListOrder.ShadowDecoration.Parent = this.containerListOrder;
            this.containerListOrder.Size = new System.Drawing.Size(1142, 246);
            this.containerListOrder.TabIndex = 28;
            this.containerListOrder.Text = "Giỏ hàng";
            this.containerListOrder.TextOffset = new System.Drawing.Point(0, -5);
            this.containerListOrder.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // dgvListOrder
            // 
            this.dgvListOrder.AllowUserToAddRows = false;
            this.dgvListOrder.AllowUserToDeleteRows = false;
            this.dgvListOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvListOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvListOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvListOrder.ColumnHeadersHeight = 36;
            this.dgvListOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Img,
            this.id,
            this.prdName,
            this.Price,
            this.number,
            this.totalPrice,
            this.btnMinus,
            this.btnDel});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListOrder.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvListOrder.EnableHeadersVisualStyles = false;
            this.dgvListOrder.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvListOrder.Location = new System.Drawing.Point(0, 30);
            this.dgvListOrder.Name = "dgvListOrder";
            this.dgvListOrder.ReadOnly = true;
            this.dgvListOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvListOrder.RowHeadersVisible = false;
            this.dgvListOrder.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListOrder.RowTemplate.Height = 35;
            this.dgvListOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOrder.Size = new System.Drawing.Size(1142, 216);
            this.dgvListOrder.TabIndex = 0;
            this.dgvListOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListOrder.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvListOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.dgvListOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dgvListOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListOrder.ThemeStyle.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvListOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.dgvListOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dgvListOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListOrder.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvListOrder.ThemeStyle.ReadOnly = true;
            this.dgvListOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvListOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dgvListOrder.ThemeStyle.RowsStyle.Height = 35;
            this.dgvListOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.dgvListOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dgvListOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListOrder_CellContentClick);
            // 
            // Img
            // 
            this.Img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Img.DataPropertyName = "Img";
            this.Img.FillWeight = 108.4844F;
            this.Img.HeaderText = "Ảnh";
            this.Img.Image = ((System.Drawing.Image)(resources.GetObject("Img.Image")));
            this.Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            this.Img.Width = 60;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // prdName
            // 
            this.prdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prdName.DataPropertyName = "Name";
            this.prdName.FillWeight = 164.2176F;
            this.prdName.HeaderText = "Tên sản phẩm";
            this.prdName.Name = "prdName";
            this.prdName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            dataGridViewCellStyle31.Format = "N0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle31;
            this.Price.FillWeight = 125.4609F;
            this.Price.HeaderText = "Đơn giá ";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.FillWeight = 66.96804F;
            this.number.HeaderText = "Số lượng";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "totalPrice";
            dataGridViewCellStyle32.Format = "N0";
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle32;
            this.totalPrice.FillWeight = 72.49739F;
            this.totalPrice.HeaderText = "Thành tiền";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // btnMinus
            // 
            this.btnMinus.FillWeight = 59.12497F;
            this.btnMinus.HeaderText = "Giảm";
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ReadOnly = true;
            this.btnMinus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnMinus.Text = "Giảm";
            this.btnMinus.UseColumnTextForButtonValue = true;
            // 
            // btnDel
            // 
            this.btnDel.FillWeight = 51.73922F;
            this.btnDel.HeaderText = "Xóa";
            this.btnDel.Name = "btnDel";
            this.btnDel.ReadOnly = true;
            this.btnDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseColumnTextForButtonValue = true;
            // 
            // FormExportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1159, 537);
            this.Controls.Add(this.containerListOrder);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblTotalPice);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.cmbWarehouse);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cmbFilterCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExportProduct";
            this.Text = "FormExportProduct";
            this.Load += new System.EventHandler(this.FormExportProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.containerListOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPosition;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWarehouse;
        private Guna.UI2.WinForms.Guna2ComboBox cmbWarehouse;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblImg;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalPice;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2GroupBox containerListOrder;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListOrder;
        private System.Windows.Forms.DataGridViewImageColumn Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn btnMinus;
        private System.Windows.Forms.DataGridViewButtonColumn btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn btnAddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
    }
}