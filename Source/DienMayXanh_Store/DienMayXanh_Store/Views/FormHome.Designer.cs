
namespace DienMayXanh_Store.Views
{
    partial class FormHome
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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new Guna.Charts.WinForms.GunaChart();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_totalSales = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_totalProfit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_totalCost = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.oDataInstantFeedbackSource1 = new DevExpress.Data.ODataLinq.ODataInstantFeedbackSource();
            this.dgv_fullOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fullOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.White;
            chartFont1.FontName = "Arial";
            this.chart.Legend.LabelFont = chartFont1;
            this.chart.Location = new System.Drawing.Point(9, 82);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1146, 206);
            this.chart.TabIndex = 0;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chart.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.chart.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.chart.Tooltips.TitleFont = chartFont4;
            this.chart.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.chart.XAxes.Ticks = tick1;
            this.chart.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.chart.YAxes.Ticks = tick2;
            this.chart.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.chart.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.chart.ZAxes.Ticks = tick3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 4;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 73);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lb_totalSales);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(375, 67);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(92, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(213, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Doanh số bán hàng";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_totalSales
            // 
            this.lb_totalSales.AutoSize = false;
            this.lb_totalSales.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalSales.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalSales.Location = new System.Drawing.Point(92, 28);
            this.lb_totalSales.Name = "lb_totalSales";
            this.lb_totalSales.Size = new System.Drawing.Size(213, 31);
            this.lb_totalSales.TabIndex = 2;
            this.lb_totalSales.Text = "guna2HtmlLabel2";
            this.lb_totalSales.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.guna2Panel2.BorderRadius = 6;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lb_totalProfit);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(384, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(375, 67);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lb_totalProfit
            // 
            this.lb_totalProfit.AutoSize = false;
            this.lb_totalProfit.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalProfit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalProfit.Location = new System.Drawing.Point(92, 28);
            this.lb_totalProfit.Name = "lb_totalProfit";
            this.lb_totalProfit.Size = new System.Drawing.Size(213, 31);
            this.lb_totalProfit.TabIndex = 2;
            this.lb_totalProfit.Text = "guna2HtmlLabel3";
            this.lb_totalProfit.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(92, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(213, 27);
            this.guna2HtmlLabel4.TabIndex = 1;
            this.guna2HtmlLabel4.Text = "Tổng Doanh Thu";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.guna2Panel3.BorderRadius = 6;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.lb_totalCost);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(765, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(375, 67);
            this.guna2Panel3.TabIndex = 2;
            // 
            // lb_totalCost
            // 
            this.lb_totalCost.AutoSize = false;
            this.lb_totalCost.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalCost.Location = new System.Drawing.Point(92, 28);
            this.lb_totalCost.Name = "lb_totalCost";
            this.lb_totalCost.Size = new System.Drawing.Size(213, 31);
            this.lb_totalCost.TabIndex = 2;
            this.lb_totalCost.Text = "guna2HtmlLabel5";
            this.lb_totalCost.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(92, 4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(213, 27);
            this.guna2HtmlLabel6.TabIndex = 1;
            this.guna2HtmlLabel6.Text = "Tổng Chi Phí";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 6;
            this.guna2GroupBox1.Controls.Add(this.dgv_fullOrder);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(9, 294);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1146, 279);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Tất cả đơn hàng";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -9);
            this.guna2GroupBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // dgv_fullOrder
            // 
            this.dgv_fullOrder.AllowUserToAddRows = false;
            this.dgv_fullOrder.AllowUserToDeleteRows = false;
            this.dgv_fullOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_fullOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fullOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fullOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fullOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_fullOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_fullOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fullOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_fullOrder.ColumnHeadersHeight = 30;
            this.dgv_fullOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.RecieptID,
            this.CustomerName,
            this.StaffName,
            this.CreateAt,
            this.TotalPrice,
            this.btn_detail});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fullOrder.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_fullOrder.EnableHeadersVisualStyles = false;
            this.dgv_fullOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_fullOrder.Location = new System.Drawing.Point(-3, 24);
            this.dgv_fullOrder.Name = "dgv_fullOrder";
            this.dgv_fullOrder.ReadOnly = true;
            this.dgv_fullOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fullOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_fullOrder.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_fullOrder.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_fullOrder.RowTemplate.Height = 30;
            this.dgv_fullOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fullOrder.Size = new System.Drawing.Size(1149, 255);
            this.dgv_fullOrder.TabIndex = 0;
            this.dgv_fullOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_fullOrder.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_fullOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_fullOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgv_fullOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_fullOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_fullOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_fullOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.dgv_fullOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_fullOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_fullOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_fullOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_fullOrder.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_fullOrder.ThemeStyle.ReadOnly = true;
            this.dgv_fullOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_fullOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_fullOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_fullOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_fullOrder.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_fullOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dgv_fullOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_fullOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btn_detail_click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(34, 6);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(52, 53);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox3.TabIndex = 0;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(34, 6);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(52, 53);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(52, 53);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.FillWeight = 26.08093F;
            this.No.HeaderText = "STT";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // RecieptID
            // 
            this.RecieptID.DataPropertyName = "RecieptID";
            this.RecieptID.FillWeight = 100.5101F;
            this.RecieptID.HeaderText = "Mã hóa đơn";
            this.RecieptID.Name = "RecieptID";
            this.RecieptID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CustomerName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerName.FillWeight = 159.4831F;
            this.CustomerName.HeaderText = "Khách hàng";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.StaffName.DefaultCellStyle = dataGridViewCellStyle4;
            this.StaffName.FillWeight = 157.8104F;
            this.StaffName.HeaderText = "Nhân viên";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // CreateAt
            // 
            this.CreateAt.DataPropertyName = "CreateAt";
            this.CreateAt.FillWeight = 88.83249F;
            this.CreateAt.HeaderText = "Ngày tạo";
            this.CreateAt.Name = "CreateAt";
            this.CreateAt.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalPrice.FillWeight = 122.5083F;
            this.TotalPrice.HeaderText = "Tổng thanh toán";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // btn_detail
            // 
            this.btn_detail.DataPropertyName = "btn_detail";
            this.btn_detail.FillWeight = 44.77463F;
            this.btn_detail.HeaderText = "Chi tiết";
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.ReadOnly = true;
            this.btn_detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_detail.Text = "Xem";
            this.btn_detail.UseColumnTextForButtonValue = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1167, 585);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fullOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.Charts.WinForms.GunaChart chart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_totalCost;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_totalProfit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_totalSales;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_fullOrder;
        private DevExpress.Data.ODataLinq.ODataInstantFeedbackSource oDataInstantFeedbackSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn btn_detail;
    }
}