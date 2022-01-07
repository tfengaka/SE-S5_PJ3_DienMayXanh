
namespace DienMayXanh_Store.Views
{
    partial class FormImportProduct
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
            this.lblPosition = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFilterCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblProducer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFilterProducer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbListProduct = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnChangeImg = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.lblWarehouse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFilterWarehouse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEditProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddImg = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ptbAddImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddProducer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ptbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.toogleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPosition.Location = new System.Drawing.Point(7, 16);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(93, 27);
            this.lblPosition.TabIndex = 3;
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
            this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbFilterCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilterCategory.HoverState.Parent = this.cmbFilterCategory;
            this.cmbFilterCategory.ItemHeight = 30;
            this.cmbFilterCategory.ItemsAppearance.Parent = this.cmbFilterCategory;
            this.cmbFilterCategory.Location = new System.Drawing.Point(147, 12);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.ShadowDecoration.BorderRadius = 10;
            this.cmbFilterCategory.ShadowDecoration.Depth = 10;
            this.cmbFilterCategory.ShadowDecoration.Enabled = true;
            this.cmbFilterCategory.ShadowDecoration.Parent = this.cmbFilterCategory;
            this.cmbFilterCategory.Size = new System.Drawing.Size(224, 36);
            this.cmbFilterCategory.TabIndex = 2;
            this.cmbFilterCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbFilterCategory_SelectionChangeCommitted);
            // 
            // lblProducer
            // 
            this.lblProducer.BackColor = System.Drawing.Color.Transparent;
            this.lblProducer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblProducer.Location = new System.Drawing.Point(7, 67);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(125, 27);
            this.lblProducer.TabIndex = 7;
            this.lblProducer.Text = "Nhà cung cấp";
            // 
            // cmbFilterProducer
            // 
            this.cmbFilterProducer.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterProducer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.cmbFilterProducer.BorderRadius = 5;
            this.cmbFilterProducer.BorderThickness = 0;
            this.cmbFilterProducer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterProducer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterProducer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterProducer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterProducer.FocusedState.Parent = this.cmbFilterProducer;
            this.cmbFilterProducer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbFilterProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilterProducer.HoverState.Parent = this.cmbFilterProducer;
            this.cmbFilterProducer.ItemHeight = 30;
            this.cmbFilterProducer.ItemsAppearance.Parent = this.cmbFilterProducer;
            this.cmbFilterProducer.Location = new System.Drawing.Point(147, 61);
            this.cmbFilterProducer.Name = "cmbFilterProducer";
            this.cmbFilterProducer.ShadowDecoration.BorderRadius = 10;
            this.cmbFilterProducer.ShadowDecoration.Depth = 10;
            this.cmbFilterProducer.ShadowDecoration.Enabled = true;
            this.cmbFilterProducer.ShadowDecoration.Parent = this.cmbFilterProducer;
            this.cmbFilterProducer.Size = new System.Drawing.Size(224, 36);
            this.cmbFilterProducer.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Animated = true;
            this.txtProductName.BackColor = System.Drawing.Color.Transparent;
            this.txtProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtProductName.BorderRadius = 5;
            this.txtProductName.BorderThickness = 0;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.Parent = this.txtProductName;
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtProductName.FocusedState.Parent = this.txtProductName;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtProductName.HoverState.Parent = this.txtProductName;
            this.txtProductName.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtProductName.Location = new System.Drawing.Point(7, 153);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.MaxLength = 30;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "Tên sản phẩm";
            this.txtProductName.SelectedText = "";
            this.txtProductName.ShadowDecoration.BorderRadius = 10;
            this.txtProductName.ShadowDecoration.Depth = 10;
            this.txtProductName.ShadowDecoration.Enabled = true;
            this.txtProductName.ShadowDecoration.Parent = this.txtProductName;
            this.txtProductName.Size = new System.Drawing.Size(364, 37);
            this.txtProductName.TabIndex = 13;
            this.txtProductName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // gbListProduct
            // 
            this.gbListProduct.AutoScroll = true;
            this.gbListProduct.BackColor = System.Drawing.Color.Transparent;
            this.gbListProduct.BorderRadius = 5;
            this.gbListProduct.BorderThickness = 0;
            this.gbListProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gbListProduct.ForeColor = System.Drawing.Color.Black;
            this.gbListProduct.Location = new System.Drawing.Point(448, 2);
            this.gbListProduct.Name = "gbListProduct";
            this.gbListProduct.ShadowDecoration.BorderRadius = 10;
            this.gbListProduct.ShadowDecoration.Depth = 10;
            this.gbListProduct.ShadowDecoration.Enabled = true;
            this.gbListProduct.ShadowDecoration.Parent = this.gbListProduct;
            this.gbListProduct.Size = new System.Drawing.Size(678, 523);
            this.gbListProduct.TabIndex = 14;
            this.gbListProduct.Text = "DANH SÁCH SẢN PHẨM";
            this.gbListProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.Transparent;
            this.cmbProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.cmbProduct.BorderRadius = 5;
            this.cmbProduct.BorderThickness = 0;
            this.cmbProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProduct.FocusedState.Parent = this.cmbProduct;
            this.cmbProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProduct.HoverState.Parent = this.cmbProduct;
            this.cmbProduct.ItemHeight = 30;
            this.cmbProduct.ItemsAppearance.Parent = this.cmbProduct;
            this.cmbProduct.Location = new System.Drawing.Point(7, 153);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.ShadowDecoration.BorderRadius = 10;
            this.cmbProduct.ShadowDecoration.Depth = 10;
            this.cmbProduct.ShadowDecoration.Enabled = true;
            this.cmbProduct.ShadowDecoration.Parent = this.cmbProduct;
            this.cmbProduct.Size = new System.Drawing.Size(364, 36);
            this.cmbProduct.TabIndex = 29;
            this.cmbProduct.Visible = false;
            this.cmbProduct.SelectionChangeCommitted += new System.EventHandler(this.cmbProduct_SelectionChangeCommitted);
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtPrice.BorderRadius = 5;
            this.txtPrice.BorderThickness = 0;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPrice.Location = new System.Drawing.Point(217, 199);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.MaxLength = 30;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Đơn giá";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.BorderRadius = 10;
            this.txtPrice.ShadowDecoration.Depth = 10;
            this.txtPrice.ShadowDecoration.Enabled = true;
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(154, 37);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblQuantity.Location = new System.Drawing.Point(12, 204);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 27);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nudQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.nudQuantity.BorderRadius = 5;
            this.nudQuantity.BorderThickness = 0;
            this.nudQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuantity.DisabledState.Parent = this.nudQuantity;
            this.nudQuantity.FocusedState.Parent = this.nudQuantity;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.nudQuantity.ForeColor = System.Drawing.Color.Black;
            this.nudQuantity.Location = new System.Drawing.Point(104, 200);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ShadowDecoration.BorderRadius = 10;
            this.nudQuantity.ShadowDecoration.Depth = 10;
            this.nudQuantity.ShadowDecoration.Enabled = true;
            this.nudQuantity.ShadowDecoration.Parent = this.nudQuantity;
            this.nudQuantity.Size = new System.Drawing.Size(87, 36);
            this.nudQuantity.TabIndex = 17;
            this.nudQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.nudQuantity.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // btnChangeImg
            // 
            this.btnChangeImg.Animated = true;
            this.btnChangeImg.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnChangeImg.BorderRadius = 5;
            this.btnChangeImg.CheckedState.Parent = this.btnChangeImg;
            this.btnChangeImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeImg.CustomImages.Parent = this.btnChangeImg;
            this.btnChangeImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeImg.DisabledState.Parent = this.btnChangeImg;
            this.btnChangeImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnChangeImg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnChangeImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnChangeImg.HoverState.Parent = this.btnChangeImg;
            this.btnChangeImg.Location = new System.Drawing.Point(260, 425);
            this.btnChangeImg.Name = "btnChangeImg";
            this.btnChangeImg.ShadowDecoration.BorderRadius = 10;
            this.btnChangeImg.ShadowDecoration.Depth = 10;
            this.btnChangeImg.ShadowDecoration.Enabled = true;
            this.btnChangeImg.ShadowDecoration.Parent = this.btnChangeImg;
            this.btnChangeImg.Size = new System.Drawing.Size(168, 50);
            this.btnChangeImg.TabIndex = 20;
            this.btnChangeImg.Text = "Xóa ảnh";
            this.btnChangeImg.Visible = false;
            this.btnChangeImg.Click += new System.EventHandler(this.btnChangeImg_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Animated = true;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnAddProduct.BorderRadius = 5;
            this.btnAddProduct.CheckedState.Parent = this.btnAddProduct;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.CustomImages.Parent = this.btnAddProduct;
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.DisabledState.Parent = this.btnAddProduct;
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAddProduct.HoverState.Parent = this.btnAddProduct;
            this.btnAddProduct.Location = new System.Drawing.Point(260, 369);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.ShadowDecoration.BorderRadius = 10;
            this.btnAddProduct.ShadowDecoration.Depth = 10;
            this.btnAddProduct.ShadowDecoration.Enabled = true;
            this.btnAddProduct.ShadowDecoration.Parent = this.btnAddProduct;
            this.btnAddProduct.Size = new System.Drawing.Size(168, 50);
            this.btnAddProduct.TabIndex = 21;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(7, 498);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(102, 23);
            this.lblTotalPrice.TabIndex = 22;
            this.lblTotalPrice.Text = "Thành tiền: 0";
            // 
            // btnImport
            // 
            this.btnImport.Animated = true;
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnImport.BorderRadius = 5;
            this.btnImport.CheckedState.Parent = this.btnImport;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.CustomImages.Parent = this.btnImport;
            this.btnImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImport.DisabledState.Parent = this.btnImport;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnImport.HoverState.Parent = this.btnImport;
            this.btnImport.Location = new System.Drawing.Point(260, 481);
            this.btnImport.Name = "btnImport";
            this.btnImport.ShadowDecoration.BorderRadius = 10;
            this.btnImport.ShadowDecoration.Depth = 10;
            this.btnImport.ShadowDecoration.Enabled = true;
            this.btnImport.ShadowDecoration.Parent = this.btnImport;
            this.btnImport.Size = new System.Drawing.Size(168, 50);
            this.btnImport.TabIndex = 23;
            this.btnImport.Text = "Nhập hàng";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.lblWarehouse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblWarehouse.Location = new System.Drawing.Point(12, 110);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(38, 27);
            this.lblWarehouse.TabIndex = 24;
            this.lblWarehouse.Text = "Kho";
            // 
            // cmbFilterWarehouse
            // 
            this.cmbFilterWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterWarehouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.cmbFilterWarehouse.BorderRadius = 5;
            this.cmbFilterWarehouse.BorderThickness = 0;
            this.cmbFilterWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterWarehouse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterWarehouse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilterWarehouse.FocusedState.Parent = this.cmbFilterWarehouse;
            this.cmbFilterWarehouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbFilterWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilterWarehouse.HoverState.Parent = this.cmbFilterWarehouse;
            this.cmbFilterWarehouse.ItemHeight = 30;
            this.cmbFilterWarehouse.ItemsAppearance.Parent = this.cmbFilterWarehouse;
            this.cmbFilterWarehouse.Location = new System.Drawing.Point(147, 110);
            this.cmbFilterWarehouse.Name = "cmbFilterWarehouse";
            this.cmbFilterWarehouse.ShadowDecoration.BorderRadius = 10;
            this.cmbFilterWarehouse.ShadowDecoration.Depth = 10;
            this.cmbFilterWarehouse.ShadowDecoration.Enabled = true;
            this.cmbFilterWarehouse.ShadowDecoration.Parent = this.cmbFilterWarehouse;
            this.cmbFilterWarehouse.Size = new System.Drawing.Size(224, 36);
            this.cmbFilterWarehouse.TabIndex = 25;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Animated = true;
            this.btnEditProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnEditProduct.BorderRadius = 5;
            this.btnEditProduct.CheckedState.Parent = this.btnEditProduct;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.CustomImages.Parent = this.btnEditProduct;
            this.btnEditProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditProduct.DisabledState.Parent = this.btnEditProduct;
            this.btnEditProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditProduct.HoverState.Parent = this.btnEditProduct;
            this.btnEditProduct.Location = new System.Drawing.Point(260, 253);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.ShadowDecoration.BorderRadius = 10;
            this.btnEditProduct.ShadowDecoration.Depth = 10;
            this.btnEditProduct.ShadowDecoration.Enabled = true;
            this.btnEditProduct.ShadowDecoration.Parent = this.btnEditProduct;
            this.btnEditProduct.Size = new System.Drawing.Size(168, 50);
            this.btnEditProduct.TabIndex = 26;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.Visible = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnCancel.BorderRadius = 5;
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
            this.btnCancel.Location = new System.Drawing.Point(260, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.BorderRadius = 10;
            this.btnCancel.ShadowDecoration.Depth = 10;
            this.btnCancel.ShadowDecoration.Enabled = true;
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(168, 50);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.btnAddImg.CheckedState.Parent = this.btnAddImg;
            this.btnAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImg.CustomImages.Parent = this.btnAddImg;
            this.btnAddImg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddImg.DisabledState.Parent = this.btnAddImg;
            this.btnAddImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnAddImg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddImg.ForeColor = System.Drawing.Color.White;
            this.btnAddImg.HoverState.Parent = this.btnAddImg;
            this.btnAddImg.Image = global::DienMayXanh_Store.Properties.Resources.add_img;
            this.btnAddImg.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddImg.Location = new System.Drawing.Point(94, 334);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddImg.ShadowDecoration.Parent = this.btnAddImg;
            this.btnAddImg.Size = new System.Drawing.Size(50, 50);
            this.btnAddImg.TabIndex = 19;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // ptbAddImg
            // 
            this.ptbAddImg.BackColor = System.Drawing.Color.Transparent;
            this.ptbAddImg.BorderRadius = 5;
            this.ptbAddImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ptbAddImg.ImageRotate = 0F;
            this.ptbAddImg.Location = new System.Drawing.Point(7, 257);
            this.ptbAddImg.Name = "ptbAddImg";
            this.ptbAddImg.ShadowDecoration.BorderRadius = 10;
            this.ptbAddImg.ShadowDecoration.Depth = 10;
            this.ptbAddImg.ShadowDecoration.Enabled = true;
            this.ptbAddImg.ShadowDecoration.Parent = this.ptbAddImg;
            this.ptbAddImg.Size = new System.Drawing.Size(230, 218);
            this.ptbAddImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddImg.TabIndex = 18;
            this.ptbAddImg.TabStop = false;
            this.ptbAddImg.DragDrop += new System.Windows.Forms.DragEventHandler(this.ptbAddImg_DragDrop);
            this.ptbAddImg.DragEnter += new System.Windows.Forms.DragEventHandler(this.ptbAddImg_DragEnter);
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Animated = true;
            this.btnAddProducer.CheckedState.Parent = this.btnAddProducer;
            this.btnAddProducer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProducer.CustomImages.Parent = this.btnAddProducer;
            this.btnAddProducer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProducer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProducer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProducer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProducer.DisabledState.Parent = this.btnAddProducer;
            this.btnAddProducer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnAddProducer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProducer.ForeColor = System.Drawing.Color.White;
            this.btnAddProducer.HoverState.Parent = this.btnAddProducer;
            this.btnAddProducer.Image = global::DienMayXanh_Store.Properties.Resources.add_producer;
            this.btnAddProducer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddProducer.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnAddProducer.Location = new System.Drawing.Point(393, 61);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.ShadowDecoration.BorderRadius = 100;
            this.btnAddProducer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddProducer.ShadowDecoration.Parent = this.btnAddProducer;
            this.btnAddProducer.Size = new System.Drawing.Size(35, 36);
            this.btnAddProducer.TabIndex = 8;
            this.btnAddProducer.Tag = "";
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Animated = true;
            this.btnAddCategory.CheckedState.Parent = this.btnAddCategory;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.CustomImages.Parent = this.btnAddCategory;
            this.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCategory.DisabledState.Parent = this.btnAddCategory;
            this.btnAddCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.HoverState.Parent = this.btnAddCategory;
            this.btnAddCategory.Image = global::DienMayXanh_Store.Properties.Resources.add_product;
            this.btnAddCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddCategory.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnAddCategory.Location = new System.Drawing.Point(393, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.ShadowDecoration.BorderRadius = 100;
            this.btnAddCategory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddCategory.ShadowDecoration.Parent = this.btnAddCategory;
            this.btnAddCategory.Size = new System.Drawing.Size(35, 36);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Tag = "";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // ptbProduct
            // 
            this.ptbProduct.ImageRotate = 0F;
            this.ptbProduct.Location = new System.Drawing.Point(0, 0);
            this.ptbProduct.Name = "ptbProduct";
            this.ptbProduct.ShadowDecoration.Parent = this.ptbProduct;
            this.ptbProduct.Size = new System.Drawing.Size(300, 200);
            this.ptbProduct.TabIndex = 0;
            this.ptbProduct.TabStop = false;
            // 
            // toogleSwitch
            // 
            this.toogleSwitch.Animated = true;
            this.toogleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.toogleSwitch.CheckedState.BorderColor = System.Drawing.Color.White;
            this.toogleSwitch.CheckedState.BorderRadius = 5;
            this.toogleSwitch.CheckedState.FillColor = System.Drawing.Color.White;
            this.toogleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.toogleSwitch.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.toogleSwitch.CheckedState.Parent = this.toogleSwitch;
            this.toogleSwitch.Location = new System.Drawing.Point(393, 162);
            this.toogleSwitch.Name = "toogleSwitch";
            this.toogleSwitch.ShadowDecoration.BorderRadius = 10;
            this.toogleSwitch.ShadowDecoration.Depth = 10;
            this.toogleSwitch.ShadowDecoration.Enabled = true;
            this.toogleSwitch.ShadowDecoration.Parent = this.toogleSwitch;
            this.toogleSwitch.Size = new System.Drawing.Size(35, 20);
            this.toogleSwitch.TabIndex = 28;
            this.toogleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.toogleSwitch.UncheckedState.BorderRadius = 5;
            this.toogleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.toogleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toogleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toogleSwitch.UncheckedState.Parent = this.toogleSwitch;
            this.toogleSwitch.CheckedChanged += new System.EventHandler(this.toogleSwitch_CheckedChanged);
            // 
            // FormImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 537);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.toogleSwitch);
            this.Controls.Add(this.cmbFilterWarehouse);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnChangeImg);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.ptbAddImg);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.gbListProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnAddProducer);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.cmbFilterProducer);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cmbFilterCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImportProduct";
            this.Text = "FormImportProduct";
            this.Load += new System.EventHandler(this.FormImportProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblPosition;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterCategory;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddCategory;
        private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddProducer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProducer;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterProducer;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private Guna.UI2.WinForms.Guna2GroupBox gbListProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantity;
        private Guna.UI2.WinForms.Guna2PictureBox ptbAddImg;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddImg;
        private Guna.UI2.WinForms.Guna2Button btnChangeImg;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWarehouse;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterWarehouse;
        private Guna.UI2.WinForms.Guna2Button btnEditProduct;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toogleSwitch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProduct;
    }
}