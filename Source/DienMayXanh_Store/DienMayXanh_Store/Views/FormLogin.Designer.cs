namespace DienMayXanh_Store
{
    partial class FormLogin
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
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogin = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbLoginName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 10;
            this.Elipse.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.HoverState.Image = global::DienMayXanh_Store.Properties.Resources.ExitLogin_hover;
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(150, 50);
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = global::DienMayXanh_Store.Properties.Resources.ExitLogin;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(150, 50);
            this.btnExit.Location = new System.Drawing.Point(197, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(150, 50);
            this.btnExit.PressedState.Parent = this.btnExit;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.HoverState.Image = global::DienMayXanh_Store.Properties.Resources.ButtonLogin_hover;
            this.btnLogin.HoverState.ImageSize = new System.Drawing.Size(150, 50);
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Image = global::DienMayXanh_Store.Properties.Resources.ButtonLogin;
            this.btnLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageRotate = 0F;
            this.btnLogin.ImageSize = new System.Drawing.Size(150, 50);
            this.btnLogin.Location = new System.Drawing.Point(32, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedState.ImageSize = new System.Drawing.Size(150, 50);
            this.btnLogin.PressedState.Parent = this.btnLogin;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txbPassword.BorderRadius = 8;
            this.txbPassword.BorderThickness = 2;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.DefaultText = "";
            this.txbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.DisabledState.Parent = this.txbPassword;
            this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txbPassword.FocusedState.Parent = this.txbPassword;
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txbPassword.ForeColor = System.Drawing.Color.Black;
            this.txbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txbPassword.HoverState.Parent = this.txbPassword;
            this.txbPassword.IconLeft = global::DienMayXanh_Store.Properties.Resources.key;
            this.txbPassword.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txbPassword.IconRight = global::DienMayXanh_Store.Properties.Resources.hide;
            this.txbPassword.Location = new System.Drawing.Point(32, 137);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '\0';
            this.txbPassword.PlaceholderText = "Mật Khẩu";
            this.txbPassword.SelectedText = "";
            this.txbPassword.ShadowDecoration.Parent = this.txbPassword;
            this.txbPassword.Size = new System.Drawing.Size(315, 45);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txbPassword.IconRightClick += new System.EventHandler(this.showPassword);
            // 
            // txbLoginName
            // 
            this.txbLoginName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.txbLoginName.BorderRadius = 8;
            this.txbLoginName.BorderThickness = 2;
            this.txbLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLoginName.DefaultText = "";
            this.txbLoginName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbLoginName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbLoginName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLoginName.DisabledState.Parent = this.txbLoginName;
            this.txbLoginName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLoginName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txbLoginName.FocusedState.Parent = this.txbLoginName;
            this.txbLoginName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txbLoginName.ForeColor = System.Drawing.Color.Black;
            this.txbLoginName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(225)))));
            this.txbLoginName.HoverState.Parent = this.txbLoginName;
            this.txbLoginName.IconLeft = global::DienMayXanh_Store.Properties.Resources.username;
            this.txbLoginName.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txbLoginName.Location = new System.Drawing.Point(32, 64);
            this.txbLoginName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbLoginName.Name = "txbLoginName";
            this.txbLoginName.PasswordChar = '\0';
            this.txbLoginName.PlaceholderText = "Tên đăng nhập";
            this.txbLoginName.SelectedText = "";
            this.txbLoginName.ShadowDecoration.Parent = this.txbLoginName;
            this.txbLoginName.Size = new System.Drawing.Size(315, 45);
            this.txbLoginName.TabIndex = 0;
            this.txbLoginName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(380, 315);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbLoginName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2TextBox txbLoginName;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogin;
    }
}

