
namespace DienMayXanh_Store.Views
{
    partial class FormIESlip
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
            this.pnlOrderHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlOrderContent = new Guna.UI2.WinForms.Guna2Panel();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.pnlOrderHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderHeader
            // 
            this.pnlOrderHeader.Controls.Add(this.btnExport);
            this.pnlOrderHeader.Controls.Add(this.btnImport);
            this.pnlOrderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderHeader.Name = "pnlOrderHeader";
            this.pnlOrderHeader.ShadowDecoration.Parent = this.pnlOrderHeader;
            this.pnlOrderHeader.Size = new System.Drawing.Size(1135, 63);
            this.pnlOrderHeader.TabIndex = 2;
            // 
            // pnlOrderContent
            // 
            this.pnlOrderContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderContent.Location = new System.Drawing.Point(0, 63);
            this.pnlOrderContent.Name = "pnlOrderContent";
            this.pnlOrderContent.ShadowDecoration.Parent = this.pnlOrderContent;
            this.pnlOrderContent.Size = new System.Drawing.Size(1135, 609);
            this.pnlOrderContent.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.Animated = true;
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BorderRadius = 10;
            this.btnImport.BorderThickness = 1;
            this.btnImport.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btnImport.CheckedState.ForeColor = System.Drawing.Color.White;
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
            this.btnImport.Location = new System.Drawing.Point(348, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.ShadowDecoration.BorderRadius = 10;
            this.btnImport.ShadowDecoration.Depth = 10;
            this.btnImport.ShadowDecoration.Enabled = true;
            this.btnImport.ShadowDecoration.Parent = this.btnImport;
            this.btnImport.Size = new System.Drawing.Size(143, 45);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Nhập hàng";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Animated = true;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BorderRadius = 10;
            this.btnExport.BorderThickness = 1;
            this.btnExport.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btnExport.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnExport.CheckedState.Parent = this.btnExport;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.CustomImages.Parent = this.btnExport;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.DisabledState.Parent = this.btnExport;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExport.HoverState.Parent = this.btnExport;
            this.btnExport.Location = new System.Drawing.Point(617, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.ShadowDecoration.BorderRadius = 10;
            this.btnExport.ShadowDecoration.Depth = 10;
            this.btnExport.ShadowDecoration.Enabled = true;
            this.btnExport.ShadowDecoration.Parent = this.btnExport;
            this.btnExport.Size = new System.Drawing.Size(143, 45);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Xuất hàng";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormIESlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1135, 672);
            this.Controls.Add(this.pnlOrderContent);
            this.Controls.Add(this.pnlOrderHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIESlip";
            this.Text = "FormIESlip";
            this.Load += new System.EventHandler(this.FormIESlip_Load);
            this.pnlOrderHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlOrderHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlOrderContent;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnImport;
    }
}