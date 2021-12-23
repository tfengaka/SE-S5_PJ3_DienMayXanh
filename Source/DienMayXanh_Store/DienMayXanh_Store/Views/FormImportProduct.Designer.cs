
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
            this.lblPosition = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2CircleButton();
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
            this.cbmFilter.Location = new System.Drawing.Point(114, 12);
            this.cbmFilter.Name = "cbmFilter";
            this.cbmFilter.ShadowDecoration.Parent = this.cbmFilter;
            this.cbmFilter.Size = new System.Drawing.Size(224, 36);
            this.cbmFilter.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Animated = true;
            this.btnAddCategory.BorderThickness = 2;
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
            this.btnAddCategory.Location = new System.Drawing.Point(381, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddCategory.ShadowDecoration.Parent = this.btnAddCategory;
            this.btnAddCategory.Size = new System.Drawing.Size(35, 36);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Tag = "";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // FormImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1119, 553);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cbmFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImportProduct";
            this.Text = "FormImportProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblPosition;
        private Guna.UI2.WinForms.Guna2ComboBox cbmFilter;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddCategory;
    }
}