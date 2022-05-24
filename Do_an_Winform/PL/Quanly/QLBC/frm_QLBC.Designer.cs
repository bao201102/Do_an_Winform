namespace Do_an_Winform.PL.Quanly.QLBC
{
    partial class frm_QLBC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLBC));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuHorizontalBarChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart(this.components);
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.cbDate = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(35, 35);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(161, 28);
            this.bunifuLabel1.TabIndex = 15;
            this.bunifuLabel1.Text = "Quản lý bán chạy";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuHorizontalBarChart1
            // 
            this.bunifuHorizontalBarChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuHorizontalBarChart1.BackgroundColor")));
            this.bunifuHorizontalBarChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuHorizontalBarChart1.BorderColor")));
            this.bunifuHorizontalBarChart1.BorderSkipped = null;
            this.bunifuHorizontalBarChart1.BorderWidth = 0;
            this.bunifuHorizontalBarChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuHorizontalBarChart1.Data")));
            this.bunifuHorizontalBarChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuHorizontalBarChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuHorizontalBarChart1.HoverBorderWidth = 0;
            this.bunifuHorizontalBarChart1.Label = "Số lượng bán ra";
            this.bunifuHorizontalBarChart1.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuChartCanvas1.AnimationDuration = 1000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas1.BackColor = System.Drawing.Color.White;
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.Labels = null;
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas1.LegendFullWidth = true;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.LegendRevese = false;
            this.bunifuChartCanvas1.LegendRTL = false;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(12, 198);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = true;
            this.bunifuChartCanvas1.ShowYAxis = true;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(1288, 595);
            this.bunifuChartCanvas1.TabIndex = 16;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 10;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesGridLines = true;
            this.bunifuChartCanvas1.XAxesLabel = "";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesGridLines = true;
            this.bunifuChartCanvas1.YAxesLabel = "";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.bunifuDatePicker1.BorderRadius = 10;
            this.bunifuDatePicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 15;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(1020, 105);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(40, 40);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(245, 40);
            this.bunifuDatePicker1.TabIndex = 17;
            this.bunifuDatePicker1.Value = new System.DateTime(2022, 5, 24, 19, 0, 0, 0);
            this.bunifuDatePicker1.ValueChanged += new System.EventHandler(this.bunifuDatePicker1_ValueChanged);
            // 
            // cbDate
            // 
            this.cbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDate.BackColor = System.Drawing.Color.Transparent;
            this.cbDate.BackgroundColor = System.Drawing.Color.White;
            this.cbDate.BorderColor = System.Drawing.Color.Silver;
            this.cbDate.BorderRadius = 1;
            this.cbDate.Color = System.Drawing.Color.Silver;
            this.cbDate.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbDate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbDate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbDate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbDate.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbDate.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDate.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbDate.FillDropDown = true;
            this.cbDate.FillIndicator = false;
            this.cbDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDate.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDate.ForeColor = System.Drawing.Color.Black;
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Icon = null;
            this.cbDate.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbDate.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbDate.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbDate.IndicatorThickness = 2;
            this.cbDate.IsDropdownOpened = false;
            this.cbDate.ItemBackColor = System.Drawing.Color.White;
            this.cbDate.ItemBorderColor = System.Drawing.Color.White;
            this.cbDate.ItemForeColor = System.Drawing.Color.Black;
            this.cbDate.ItemHeight = 26;
            this.cbDate.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbDate.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbDate.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbDate.ItemTopMargin = 3;
            this.cbDate.Location = new System.Drawing.Point(814, 110);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(149, 32);
            this.cbDate.TabIndex = 18;
            this.cbDate.Text = null;
            this.cbDate.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbDate.TextLeftMargin = 5;
            this.cbDate.SelectionChangeCommitted += new System.EventHandler(this.cbLoaisp_SelectionChangeCommitted);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(730, 115);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(70, 23);
            this.bunifuLabel2.TabIndex = 19;
            this.bunifuLabel2.Text = "Lọc theo:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frm_QLBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 805);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.bunifuChartCanvas1);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLBC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QLBC";
            this.Load += new System.EventHandler(this.frm_QLBC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart bunifuHorizontalBarChart1;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.UI.WinForms.BunifuDropdown cbDate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}