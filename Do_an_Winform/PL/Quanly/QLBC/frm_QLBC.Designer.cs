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
            this.horizontalBarChartProduct = new Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart(this.components);
            this.chartCanvasProduct = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.cbDate = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.chartCanvasCat = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.horizontalBarChartCat = new Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart(this.components);
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
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
            // horizontalBarChartProduct
            // 
            this.horizontalBarChartProduct.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("horizontalBarChartProduct.BackgroundColor")));
            this.horizontalBarChartProduct.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("horizontalBarChartProduct.BorderColor")));
            this.horizontalBarChartProduct.BorderSkipped = null;
            this.horizontalBarChartProduct.BorderWidth = 0;
            this.horizontalBarChartProduct.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("horizontalBarChartProduct.Data")));
            this.horizontalBarChartProduct.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.horizontalBarChartProduct.HoverBorderColor = System.Drawing.Color.Empty;
            this.horizontalBarChartProduct.HoverBorderWidth = 0;
            this.horizontalBarChartProduct.Label = "Số lượng bán ra";
            this.horizontalBarChartProduct.TargetCanvas = this.chartCanvasProduct;
            // 
            // chartCanvasProduct
            // 
            this.chartCanvasProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCanvasProduct.AnimationDuration = 1000;
            this.chartCanvasProduct.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.chartCanvasProduct.BackColor = System.Drawing.Color.White;
            this.chartCanvasProduct.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.chartCanvasProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasProduct.Labels = null;
            this.chartCanvasProduct.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.chartCanvasProduct.LegendDisplay = true;
            this.chartCanvasProduct.LegendFont = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCanvasProduct.LegendForeColor = System.Drawing.Color.DarkGray;
            this.chartCanvasProduct.LegendFullWidth = true;
            this.chartCanvasProduct.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartCanvasProduct.LegendRevese = false;
            this.chartCanvasProduct.LegendRTL = false;
            this.chartCanvasProduct.Location = new System.Drawing.Point(1, 172);
            this.chartCanvasProduct.Name = "chartCanvasProduct";
            this.chartCanvasProduct.ShowXAxis = true;
            this.chartCanvasProduct.ShowYAxis = true;
            this.chartCanvasProduct.Size = new System.Drawing.Size(658, 490);
            this.chartCanvasProduct.TabIndex = 16;
            this.chartCanvasProduct.Title = "";
            this.chartCanvasProduct.TitleLineHeight = 1.2D;
            this.chartCanvasProduct.TitlePadding = 10;
            this.chartCanvasProduct.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartCanvasProduct.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasProduct.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasProduct.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.chartCanvasProduct.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.chartCanvasProduct.TooltipsEnabled = true;
            this.chartCanvasProduct.XAxesBeginAtZero = true;
            this.chartCanvasProduct.XAxesDrawTicks = true;
            this.chartCanvasProduct.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasProduct.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasProduct.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasProduct.XAxesGridLines = true;
            this.chartCanvasProduct.XAxesLabel = "";
            this.chartCanvasProduct.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasProduct.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasProduct.XAxesLineWidth = 1;
            this.chartCanvasProduct.XAxesStacked = false;
            this.chartCanvasProduct.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasProduct.XAxesZeroLineWidth = 1;
            this.chartCanvasProduct.YAxesBeginAtZero = true;
            this.chartCanvasProduct.YAxesDrawTicks = true;
            this.chartCanvasProduct.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasProduct.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasProduct.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasProduct.YAxesGridLines = true;
            this.chartCanvasProduct.YAxesLabel = "";
            this.chartCanvasProduct.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasProduct.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasProduct.YAxesLineWidth = 1;
            this.chartCanvasProduct.YAxesStacked = false;
            this.chartCanvasProduct.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasProduct.YAxesZeroLineWidth = 1;
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
            this.bunifuDatePicker1.Location = new System.Drawing.Point(1018, 81);
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
            this.cbDate.Location = new System.Drawing.Point(812, 86);
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
            this.bunifuLabel2.Location = new System.Drawing.Point(728, 91);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(70, 23);
            this.bunifuLabel2.TabIndex = 19;
            this.bunifuLabel2.Text = "Lọc theo:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // chartCanvasCat
            // 
            this.chartCanvasCat.AnimationDuration = 1000;
            this.chartCanvasCat.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.chartCanvasCat.BackColor = System.Drawing.Color.White;
            this.chartCanvasCat.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.chartCanvasCat.Labels = null;
            this.chartCanvasCat.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.chartCanvasCat.LegendDisplay = true;
            this.chartCanvasCat.LegendFont = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCanvasCat.LegendForeColor = System.Drawing.Color.DarkGray;
            this.chartCanvasCat.LegendFullWidth = true;
            this.chartCanvasCat.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartCanvasCat.LegendRevese = false;
            this.chartCanvasCat.LegendRTL = false;
            this.chartCanvasCat.Location = new System.Drawing.Point(665, 172);
            this.chartCanvasCat.Name = "chartCanvasCat";
            this.chartCanvasCat.ShowXAxis = true;
            this.chartCanvasCat.ShowYAxis = true;
            this.chartCanvasCat.Size = new System.Drawing.Size(645, 490);
            this.chartCanvasCat.TabIndex = 20;
            this.chartCanvasCat.Title = "";
            this.chartCanvasCat.TitleLineHeight = 1.2D;
            this.chartCanvasCat.TitlePadding = 10;
            this.chartCanvasCat.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.chartCanvasCat.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasCat.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasCat.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.chartCanvasCat.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.chartCanvasCat.TooltipsEnabled = true;
            this.chartCanvasCat.XAxesBeginAtZero = true;
            this.chartCanvasCat.XAxesDrawTicks = true;
            this.chartCanvasCat.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasCat.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasCat.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasCat.XAxesGridLines = true;
            this.chartCanvasCat.XAxesLabel = "";
            this.chartCanvasCat.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasCat.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasCat.XAxesLineWidth = 1;
            this.chartCanvasCat.XAxesStacked = false;
            this.chartCanvasCat.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasCat.XAxesZeroLineWidth = 1;
            this.chartCanvasCat.YAxesBeginAtZero = true;
            this.chartCanvasCat.YAxesDrawTicks = true;
            this.chartCanvasCat.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasCat.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasCat.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasCat.YAxesGridLines = true;
            this.chartCanvasCat.YAxesLabel = "";
            this.chartCanvasCat.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartCanvasCat.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.chartCanvasCat.YAxesLineWidth = 1;
            this.chartCanvasCat.YAxesStacked = false;
            this.chartCanvasCat.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCanvasCat.YAxesZeroLineWidth = 1;
            // 
            // horizontalBarChartCat
            // 
            this.horizontalBarChartCat.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("horizontalBarChartCat.BackgroundColor")));
            this.horizontalBarChartCat.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("horizontalBarChartCat.BorderColor")));
            this.horizontalBarChartCat.BorderSkipped = null;
            this.horizontalBarChartCat.BorderWidth = 0;
            this.horizontalBarChartCat.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("horizontalBarChartCat.Data")));
            this.horizontalBarChartCat.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.horizontalBarChartCat.HoverBorderColor = System.Drawing.Color.Empty;
            this.horizontalBarChartCat.HoverBorderWidth = 0;
            this.horizontalBarChartCat.Label = "Số lượng bán ra";
            this.horizontalBarChartCat.TargetCanvas = this.chartCanvasCat;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuLabel3.Location = new System.Drawing.Point(189, 695);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(310, 28);
            this.bunifuLabel3.TabIndex = 21;
            this.bunifuLabel3.Text = "Biểu đồ top 5 sản phẩm bán chạy";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuLabel4.Location = new System.Drawing.Point(831, 695);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(312, 28);
            this.bunifuLabel4.TabIndex = 22;
            this.bunifuLabel4.Text = "Biểu đồ top 5 danh mục bán chạy";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frm_QLBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 805);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.chartCanvasCat);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.chartCanvasProduct);
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
        private Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart horizontalBarChartProduct;
        private Bunifu.Charts.WinForms.BunifuChartCanvas chartCanvasProduct;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Bunifu.UI.WinForms.BunifuDropdown cbDate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Charts.WinForms.BunifuChartCanvas chartCanvasCat;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart horizontalBarChartCat;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}