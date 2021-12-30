
namespace DienMayXanh_Store.Views.Dialogs
{
    partial class FormAddCategory
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
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddCatergory = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCategory = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblCategory.Location = new System.Drawing.Point(299, 12);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(172, 27);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Quản Lý Danh Mục";
            // 
            // txtCategory
            // 
            this.txtCategory.Animated = true;
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txtCategory.BorderRadius = 8;
            this.txtCategory.BorderThickness = 2;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.DefaultText = "";
            this.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.DisabledState.Parent = this.txtCategory;
            this.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtCategory.FocusedState.Parent = this.txtCategory;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtCategory.ForeColor = System.Drawing.Color.Black;
            this.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txtCategory.HoverState.Parent = this.txtCategory;
            this.txtCategory.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtCategory.Location = new System.Drawing.Point(12, 79);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategory.MaxLength = 30;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.PlaceholderText = "Tên danh mục";
            this.txtCategory.SelectedText = "";
            this.txtCategory.ShadowDecoration.BorderRadius = 15;
            this.txtCategory.ShadowDecoration.Depth = 10;
            this.txtCategory.ShadowDecoration.Enabled = true;
            this.txtCategory.ShadowDecoration.Parent = this.txtCategory;
            this.txtCategory.Size = new System.Drawing.Size(315, 45);
            this.txtCategory.TabIndex = 6;
            this.txtCategory.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnAddCatergory
            // 
            this.btnAddCatergory.Animated = true;
            this.btnAddCatergory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCatergory.BorderRadius = 10;
            this.btnAddCatergory.BorderThickness = 1;
            this.btnAddCatergory.CheckedState.Parent = this.btnAddCatergory;
            this.btnAddCatergory.CustomImages.Parent = this.btnAddCatergory;
            this.btnAddCatergory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCatergory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCatergory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCatergory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCatergory.DisabledState.Parent = this.btnAddCatergory;
            this.btnAddCatergory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnAddCatergory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCatergory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAddCatergory.HoverState.Parent = this.btnAddCatergory;
            this.btnAddCatergory.Location = new System.Drawing.Point(371, 75);
            this.btnAddCatergory.Name = "btnAddCatergory";
            this.btnAddCatergory.ShadowDecoration.BorderRadius = 15;
            this.btnAddCatergory.ShadowDecoration.Depth = 10;
            this.btnAddCatergory.ShadowDecoration.Enabled = true;
            this.btnAddCatergory.ShadowDecoration.Parent = this.btnAddCatergory;
            this.btnAddCatergory.Size = new System.Drawing.Size(100, 50);
            this.btnAddCatergory.TabIndex = 7;
            this.btnAddCatergory.Text = "Thêm";
            this.btnAddCatergory.Click += new System.EventHandler(this.btnAddCatergory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Animated = true;
            this.btnEditCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnEditCategory.BorderRadius = 10;
            this.btnEditCategory.BorderThickness = 1;
            this.btnEditCategory.CheckedState.Parent = this.btnEditCategory;
            this.btnEditCategory.CustomImages.Parent = this.btnEditCategory;
            this.btnEditCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCategory.DisabledState.Parent = this.btnEditCategory;
            this.btnEditCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnEditCategory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEditCategory.HoverState.Parent = this.btnEditCategory;
            this.btnEditCategory.Location = new System.Drawing.Point(371, 75);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.ShadowDecoration.BorderRadius = 15;
            this.btnEditCategory.ShadowDecoration.Depth = 10;
            this.btnEditCategory.ShadowDecoration.Enabled = true;
            this.btnEditCategory.ShadowDecoration.Parent = this.btnEditCategory;
            this.btnEditCategory.Size = new System.Drawing.Size(100, 50);
            this.btnEditCategory.TabIndex = 8;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.Visible = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // dgvCategory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.ColumnHeadersHeight = 21;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryID,
            this.categoryName,
            this.createAt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategory.Location = new System.Drawing.Point(12, 173);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(776, 265);
            this.dgvCategory.TabIndex = 9;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategory.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCategory.ThemeStyle.ReadOnly = false;
            this.dgvCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategory.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // categoryID
            // 
            this.categoryID.DataPropertyName = "CategoryID";
            this.categoryID.HeaderText = "Mã danh mục";
            this.categoryID.Name = "categoryID";
            this.categoryID.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "Name";
            this.categoryName.HeaderText = "Tên danh mục";
            this.categoryName.Name = "categoryName";
            // 
            // createAt
            // 
            this.createAt.DataPropertyName = "CreateAt";
            this.createAt.HeaderText = "Ngày tạo";
            this.createAt.Name = "createAt";
            this.createAt.ReadOnly = true;
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
            this.close.Location = new System.Drawing.Point(770, 0);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(32, 25);
            this.close.TabIndex = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 15;
            this.Elipse.TargetControl = this;
            // 
            // ShadowForm
            // 
            this.ShadowForm.BorderRadius = 15;
            this.ShadowForm.ShadowColor = System.Drawing.Color.Gray;
            this.ShadowForm.TargetForm = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
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
            this.btnCancel.Location = new System.Drawing.Point(499, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.BorderRadius = 15;
            this.btnCancel.ShadowDecoration.Depth = 10;
            this.btnCancel.ShadowDecoration.Enabled = true;
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCatergory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddCategory";
            this.Load += new System.EventHandler(this.FormAddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtCategory;
        private Guna.UI2.WinForms.Guna2Button btnAddCatergory;
        private Guna.UI2.WinForms.Guna2Button btnEditCategory;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCategory;
        private Guna.UI2.WinForms.Guna2ControlBox close;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createAt;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}