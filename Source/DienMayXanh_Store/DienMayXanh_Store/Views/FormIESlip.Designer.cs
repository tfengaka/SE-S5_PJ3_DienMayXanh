
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
            Guna.UI2.WinForms.Guna2TabControl tabControl;
            this.pageOrder = new System.Windows.Forms.TabPage();
            this.pageImport = new System.Windows.Forms.TabPage();
            tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(this.pageOrder);
            tabControl.Controls.Add(this.pageImport);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.ItemSize = new System.Drawing.Size(180, 40);
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Margin = new System.Windows.Forms.Padding(0);
            tabControl.Name = "tabControl";
            tabControl.Padding = new System.Drawing.Point(0, 0);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1167, 585);
            tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.Gainsboro;
            tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.Gainsboro;
            tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            tabControl.TabIndex = 0;
            tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // pageOrder
            // 
            this.pageOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.pageOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pageOrder.ForeColor = System.Drawing.Color.Black;
            this.pageOrder.Location = new System.Drawing.Point(4, 44);
            this.pageOrder.Margin = new System.Windows.Forms.Padding(0);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrder.Size = new System.Drawing.Size(1159, 537);
            this.pageOrder.TabIndex = 0;
            this.pageOrder.Text = "Tạo Đơn Hàng";
            // 
            // pageImport
            // 
            this.pageImport.Cursor = System.Windows.Forms.Cursors.Default;
            this.pageImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pageImport.ForeColor = System.Drawing.Color.Coral;
            this.pageImport.Location = new System.Drawing.Point(4, 44);
            this.pageImport.Margin = new System.Windows.Forms.Padding(0);
            this.pageImport.Name = "pageImport";
            this.pageImport.Padding = new System.Windows.Forms.Padding(3);
            this.pageImport.Size = new System.Drawing.Size(1127, 624);
            this.pageImport.TabIndex = 1;
            this.pageImport.Text = "Nhập Hàng";
            this.pageImport.UseVisualStyleBackColor = true;
            // 
            // FormIESlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1167, 585);
            this.Controls.Add(tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIESlip";
            this.Text = "FormIESlip";
            this.Load += new System.EventHandler(this.FormIESlip_Load);
            tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageImport;
        private System.Windows.Forms.TabPage pageOrder;
    }
}