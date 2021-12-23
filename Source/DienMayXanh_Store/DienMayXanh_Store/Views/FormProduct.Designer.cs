
namespace DienMayXanh_Store.Views
{
    partial class FormProduct
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
            this.cbmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPosition = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddProducer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // cbmFilter
            // 
            this.cbmFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbmFilter.BorderColor = System.Drawing.Color.Black;
            this.cbmFilter.BorderRadius = 5;
            this.cbmFilter.BorderThickness = 2;
            this.cbmFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmFilter.FocusedState.Parent = this.cbmFilter;
            this.cbmFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmFilter.HoverState.Parent = this.cbmFilter;
            this.cbmFilter.ItemHeight = 30;
            this.cbmFilter.ItemsAppearance.Parent = this.cbmFilter;
            this.cbmFilter.Location = new System.Drawing.Point(119, 32);
            this.cbmFilter.Name = "cbmFilter";
            this.cbmFilter.ShadowDecoration.Parent = this.cbmFilter;
            this.cbmFilter.Size = new System.Drawing.Size(224, 36);
            this.cbmFilter.TabIndex = 0;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblPosition.Location = new System.Drawing.Point(12, 36);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(93, 27);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Danh mục";
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.Animated = true;
            this.btnAddProducer.BorderThickness = 2;
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
            this.btnAddProducer.Location = new System.Drawing.Point(772, 32);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddProducer.ShadowDecoration.Parent = this.btnAddProducer;
            this.btnAddProducer.Size = new System.Drawing.Size(35, 36);
            this.btnAddProducer.TabIndex = 5;
            this.btnAddProducer.Tag = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Animated = true;
            this.btnAddProduct.BorderThickness = 2;
            this.btnAddProduct.CheckedState.Parent = this.btnAddProduct;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.CustomImages.Parent = this.btnAddProduct;
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.DisabledState.Parent = this.btnAddProduct;
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.HoverState.Parent = this.btnAddProduct;
            this.btnAddProduct.Image = global::DienMayXanh_Store.Properties.Resources.add_product;
            this.btnAddProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddProduct.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnAddProduct.Location = new System.Drawing.Point(842, 32);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddProduct.ShadowDecoration.Parent = this.btnAddProduct;
            this.btnAddProduct.Size = new System.Drawing.Size(35, 36);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Tag = "";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnReload
            // 
            this.btnReload.Animated = true;
            this.btnReload.BorderThickness = 2;
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.DisabledState.Parent = this.btnReload;
            this.btnReload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Image = global::DienMayXanh_Store.Properties.Resources.reload;
            this.btnReload.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnReload.Location = new System.Drawing.Point(702, 32);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(35, 36);
            this.btnReload.TabIndex = 3;
            this.btnReload.Tag = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "Tìm kiếm";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeftSize = new System.Drawing.Size(18, 18);
            this.txtSearch.IconRight = global::DienMayXanh_Store.Properties.Resources.search;
            this.txtSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.Location = new System.Drawing.Point(387, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(273, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1151, 711);
            this.Controls.Add(this.btnAddProducer);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cbmFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbmFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPosition;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
        private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddProduct;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddProducer;
    }
}