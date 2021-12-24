
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
            this.cbmFilterCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2CircleButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddProducer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblProducer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFilterProducer = new Guna.UI2.WinForms.Guna2ComboBox();
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
            // cbmFilterCategory
            // 
            this.cbmFilterCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbmFilterCategory.BorderColor = System.Drawing.Color.Black;
            this.cbmFilterCategory.BorderRadius = 5;
            this.cbmFilterCategory.BorderThickness = 2;
            this.cbmFilterCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFilterCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmFilterCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmFilterCategory.FocusedState.Parent = this.cbmFilterCategory;
            this.cbmFilterCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbmFilterCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmFilterCategory.HoverState.Parent = this.cbmFilterCategory;
            this.cbmFilterCategory.ItemHeight = 30;
            this.cbmFilterCategory.ItemsAppearance.Parent = this.cbmFilterCategory;
            this.cbmFilterCategory.Location = new System.Drawing.Point(114, 12);
            this.cbmFilterCategory.Name = "cbmFilterCategory";
            this.cbmFilterCategory.ShadowDecoration.Parent = this.cbmFilterCategory;
            this.cbmFilterCategory.Size = new System.Drawing.Size(224, 36);
            this.cbmFilterCategory.TabIndex = 2;
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
            this.btnAddProducer.Location = new System.Drawing.Point(898, 12);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddProducer.ShadowDecoration.Parent = this.btnAddProducer;
            this.btnAddProducer.Size = new System.Drawing.Size(35, 36);
            this.btnAddProducer.TabIndex = 8;
            this.btnAddProducer.Tag = "";
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // lblProducer
            // 
            this.lblProducer.BackColor = System.Drawing.Color.Transparent;
            this.lblProducer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblProducer.Location = new System.Drawing.Point(474, 16);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(125, 27);
            this.lblProducer.TabIndex = 7;
            this.lblProducer.Text = "Nhà cung cấp";
            // 
            // cmbFilterProducer
            // 
            this.cmbFilterProducer.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterProducer.BorderColor = System.Drawing.Color.Black;
            this.cmbFilterProducer.BorderRadius = 5;
            this.cmbFilterProducer.BorderThickness = 2;
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
            this.cmbFilterProducer.Location = new System.Drawing.Point(631, 12);
            this.cmbFilterProducer.Name = "cmbFilterProducer";
            this.cmbFilterProducer.ShadowDecoration.Parent = this.cmbFilterProducer;
            this.cmbFilterProducer.Size = new System.Drawing.Size(224, 36);
            this.cmbFilterProducer.TabIndex = 6;
            // 
            // FormImportProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 624);
            this.Controls.Add(this.btnAddProducer);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.cmbFilterProducer);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cbmFilterCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImportProduct";
            this.Text = "FormImportProduct";
            this.Load += new System.EventHandler(this.FormImportProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblPosition;
        private Guna.UI2.WinForms.Guna2ComboBox cbmFilterCategory;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddCategory;
        private System.Windows.Forms.ToolTip toolTip;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddProducer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProducer;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilterProducer;
    }
}