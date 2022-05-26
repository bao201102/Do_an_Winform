
namespace Do_an_Winform.PL.Quanly
{
    partial class frm_Quanly
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Quanly));
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sidemenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.subdoitacPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btDoiTac_NCC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btDoiTac_KH = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btDoiTac_NV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.doitacPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnQLDoiTac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.doanhthuPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnQLDoanhThu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.subhoadonPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnHDB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHDN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hoadonPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnQLHD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.banchayPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnQLBC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sanphamPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnQLSP = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tonkhoPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnTongquan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.subuserPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThongtin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.userBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.slideBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.titlePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu.SuspendLayout();
            this.subdoitacPanel.SuspendLayout();
            this.doitacPanel.SuspendLayout();
            this.doanhthuPanel.SuspendLayout();
            this.subhoadonPanel.SuspendLayout();
            this.hoadonPanel.SuspendLayout();
            this.banchayPanel.SuspendLayout();
            this.sanphamPanel.SuspendLayout();
            this.tonkhoPanel.SuspendLayout();
            this.subuserPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideBtn)).BeginInit();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // sidemenu
            // 
            this.sidemenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidemenu.BackgroundImage")));
            this.sidemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidemenu.Controls.Add(this.subdoitacPanel);
            this.sidemenu.Controls.Add(this.doitacPanel);
            this.sidemenu.Controls.Add(this.doanhthuPanel);
            this.sidemenu.Controls.Add(this.subhoadonPanel);
            this.sidemenu.Controls.Add(this.hoadonPanel);
            this.sidemenu.Controls.Add(this.banchayPanel);
            this.sidemenu.Controls.Add(this.sanphamPanel);
            this.sidemenu.Controls.Add(this.tonkhoPanel);
            this.sidemenu.Controls.Add(this.subuserPanel);
            this.sidemenu.Controls.Add(this.userPanel);
            this.sidemenu.Controls.Add(this.headerPanel);
            this.Transition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sidemenu.Location = new System.Drawing.Point(0, 38);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Quality = 10;
            this.sidemenu.Size = new System.Drawing.Size(250, 750);
            this.sidemenu.TabIndex = 3;
            // 
            // subdoitacPanel
            // 
            this.subdoitacPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subdoitacPanel.BackgroundImage")));
            this.subdoitacPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subdoitacPanel.Controls.Add(this.btDoiTac_NCC);
            this.subdoitacPanel.Controls.Add(this.btDoiTac_KH);
            this.subdoitacPanel.Controls.Add(this.btDoiTac_NV);
            this.Transition.SetDecoration(this.subdoitacPanel, BunifuAnimatorNS.DecorationType.None);
            this.subdoitacPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subdoitacPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subdoitacPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subdoitacPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subdoitacPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subdoitacPanel.Location = new System.Drawing.Point(0, 697);
            this.subdoitacPanel.Name = "subdoitacPanel";
            this.subdoitacPanel.Quality = 10;
            this.subdoitacPanel.Size = new System.Drawing.Size(250, 172);
            this.subdoitacPanel.TabIndex = 15;
            // 
            // btDoiTac_NCC
            // 
            this.btDoiTac_NCC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btDoiTac_NCC.BackColor = System.Drawing.Color.Transparent;
            this.btDoiTac_NCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDoiTac_NCC.BorderRadius = 0;
            this.btDoiTac_NCC.ButtonText = "Nhà cung cấp";
            this.btDoiTac_NCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btDoiTac_NCC, BunifuAnimatorNS.DecorationType.None);
            this.btDoiTac_NCC.DisabledColor = System.Drawing.Color.Gray;
            this.btDoiTac_NCC.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiTac_NCC.Iconcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_NCC.Iconimage = null;
            this.btDoiTac_NCC.Iconimage_right = null;
            this.btDoiTac_NCC.Iconimage_right_Selected = null;
            this.btDoiTac_NCC.Iconimage_Selected = null;
            this.btDoiTac_NCC.IconMarginLeft = 90;
            this.btDoiTac_NCC.IconMarginRight = 0;
            this.btDoiTac_NCC.IconRightVisible = false;
            this.btDoiTac_NCC.IconRightZoom = 0D;
            this.btDoiTac_NCC.IconVisible = true;
            this.btDoiTac_NCC.IconZoom = 60D;
            this.btDoiTac_NCC.IsTab = false;
            this.btDoiTac_NCC.Location = new System.Drawing.Point(0, 111);
            this.btDoiTac_NCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDoiTac_NCC.Name = "btDoiTac_NCC";
            this.btDoiTac_NCC.Normalcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_NCC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btDoiTac_NCC.OnHoverTextColor = System.Drawing.Color.White;
            this.btDoiTac_NCC.selected = false;
            this.btDoiTac_NCC.Size = new System.Drawing.Size(250, 48);
            this.btDoiTac_NCC.TabIndex = 13;
            this.btDoiTac_NCC.Text = "Nhà cung cấp";
            this.btDoiTac_NCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDoiTac_NCC.Textcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_NCC.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiTac_NCC.Click += new System.EventHandler(this.btDoiTac_NCC_Click);
            // 
            // btDoiTac_KH
            // 
            this.btDoiTac_KH.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btDoiTac_KH.BackColor = System.Drawing.Color.Transparent;
            this.btDoiTac_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDoiTac_KH.BorderRadius = 0;
            this.btDoiTac_KH.ButtonText = "Khách hàng";
            this.btDoiTac_KH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btDoiTac_KH, BunifuAnimatorNS.DecorationType.None);
            this.btDoiTac_KH.DisabledColor = System.Drawing.Color.Gray;
            this.btDoiTac_KH.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiTac_KH.Iconcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_KH.Iconimage = null;
            this.btDoiTac_KH.Iconimage_right = null;
            this.btDoiTac_KH.Iconimage_right_Selected = null;
            this.btDoiTac_KH.Iconimage_Selected = null;
            this.btDoiTac_KH.IconMarginLeft = 90;
            this.btDoiTac_KH.IconMarginRight = 0;
            this.btDoiTac_KH.IconRightVisible = false;
            this.btDoiTac_KH.IconRightZoom = 0D;
            this.btDoiTac_KH.IconVisible = true;
            this.btDoiTac_KH.IconZoom = 60D;
            this.btDoiTac_KH.IsTab = false;
            this.btDoiTac_KH.Location = new System.Drawing.Point(0, 57);
            this.btDoiTac_KH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDoiTac_KH.Name = "btDoiTac_KH";
            this.btDoiTac_KH.Normalcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_KH.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btDoiTac_KH.OnHoverTextColor = System.Drawing.Color.White;
            this.btDoiTac_KH.selected = false;
            this.btDoiTac_KH.Size = new System.Drawing.Size(250, 48);
            this.btDoiTac_KH.TabIndex = 12;
            this.btDoiTac_KH.Text = "Khách hàng";
            this.btDoiTac_KH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDoiTac_KH.Textcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_KH.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiTac_KH.Click += new System.EventHandler(this.btDoiTac_KH_Click);
            // 
            // btDoiTac_NV
            // 
            this.btDoiTac_NV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btDoiTac_NV.BackColor = System.Drawing.Color.Transparent;
            this.btDoiTac_NV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDoiTac_NV.BorderRadius = 0;
            this.btDoiTac_NV.ButtonText = "Nhân viên";
            this.btDoiTac_NV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btDoiTac_NV, BunifuAnimatorNS.DecorationType.None);
            this.btDoiTac_NV.DisabledColor = System.Drawing.Color.Gray;
            this.btDoiTac_NV.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiTac_NV.Iconcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_NV.Iconimage = null;
            this.btDoiTac_NV.Iconimage_right = null;
            this.btDoiTac_NV.Iconimage_right_Selected = null;
            this.btDoiTac_NV.Iconimage_Selected = null;
            this.btDoiTac_NV.IconMarginLeft = 90;
            this.btDoiTac_NV.IconMarginRight = 0;
            this.btDoiTac_NV.IconRightVisible = false;
            this.btDoiTac_NV.IconRightZoom = 0D;
            this.btDoiTac_NV.IconVisible = true;
            this.btDoiTac_NV.IconZoom = 60D;
            this.btDoiTac_NV.IsTab = false;
            this.btDoiTac_NV.Location = new System.Drawing.Point(0, 3);
            this.btDoiTac_NV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDoiTac_NV.Name = "btDoiTac_NV";
            this.btDoiTac_NV.Normalcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_NV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btDoiTac_NV.OnHoverTextColor = System.Drawing.Color.White;
            this.btDoiTac_NV.selected = true;
            this.btDoiTac_NV.Size = new System.Drawing.Size(250, 48);
            this.btDoiTac_NV.TabIndex = 11;
            this.btDoiTac_NV.Text = "Nhân viên";
            this.btDoiTac_NV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDoiTac_NV.Textcolor = System.Drawing.Color.Transparent;
            this.btDoiTac_NV.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiTac_NV.Click += new System.EventHandler(this.btDoiTac_NV_Click);
            // 
            // doitacPanel
            // 
            this.doitacPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doitacPanel.BackgroundImage")));
            this.doitacPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doitacPanel.Controls.Add(this.btnQLDoiTac);
            this.Transition.SetDecoration(this.doitacPanel, BunifuAnimatorNS.DecorationType.None);
            this.doitacPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.doitacPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doitacPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doitacPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doitacPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doitacPanel.Location = new System.Drawing.Point(0, 636);
            this.doitacPanel.Name = "doitacPanel";
            this.doitacPanel.Quality = 10;
            this.doitacPanel.Size = new System.Drawing.Size(250, 61);
            this.doitacPanel.TabIndex = 21;
            // 
            // btnQLDoiTac
            // 
            this.btnQLDoiTac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnQLDoiTac.BackColor = System.Drawing.Color.Transparent;
            this.btnQLDoiTac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLDoiTac.BorderRadius = 0;
            this.btnQLDoiTac.ButtonText = "Quản lý đối tác";
            this.btnQLDoiTac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnQLDoiTac, BunifuAnimatorNS.DecorationType.None);
            this.btnQLDoiTac.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLDoiTac.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDoiTac.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLDoiTac.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLDoiTac.Iconimage")));
            this.btnQLDoiTac.Iconimage_right = null;
            this.btnQLDoiTac.Iconimage_right_Selected = null;
            this.btnQLDoiTac.Iconimage_Selected = null;
            this.btnQLDoiTac.IconMarginLeft = 12;
            this.btnQLDoiTac.IconMarginRight = 0;
            this.btnQLDoiTac.IconRightVisible = false;
            this.btnQLDoiTac.IconRightZoom = 0D;
            this.btnQLDoiTac.IconVisible = true;
            this.btnQLDoiTac.IconZoom = 60D;
            this.btnQLDoiTac.IsTab = false;
            this.btnQLDoiTac.Location = new System.Drawing.Point(0, 3);
            this.btnQLDoiTac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLDoiTac.Name = "btnQLDoiTac";
            this.btnQLDoiTac.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQLDoiTac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnQLDoiTac.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLDoiTac.selected = false;
            this.btnQLDoiTac.Size = new System.Drawing.Size(250, 48);
            this.btnQLDoiTac.TabIndex = 2;
            this.btnQLDoiTac.Text = "Quản lý đối tác";
            this.btnQLDoiTac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQLDoiTac.Textcolor = System.Drawing.Color.Transparent;
            this.btnQLDoiTac.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDoiTac.Click += new System.EventHandler(this.btnQLDoiTac_Click);
            // 
            // doanhthuPanel
            // 
            this.doanhthuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doanhthuPanel.BackgroundImage")));
            this.doanhthuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doanhthuPanel.Controls.Add(this.btnQLDoanhThu);
            this.Transition.SetDecoration(this.doanhthuPanel, BunifuAnimatorNS.DecorationType.None);
            this.doanhthuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.doanhthuPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doanhthuPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doanhthuPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doanhthuPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.doanhthuPanel.Location = new System.Drawing.Point(0, 579);
            this.doanhthuPanel.Name = "doanhthuPanel";
            this.doanhthuPanel.Quality = 10;
            this.doanhthuPanel.Size = new System.Drawing.Size(250, 57);
            this.doanhthuPanel.TabIndex = 16;
            // 
            // btnQLDoanhThu
            // 
            this.btnQLDoanhThu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnQLDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.btnQLDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLDoanhThu.BorderRadius = 0;
            this.btnQLDoanhThu.ButtonText = "Quản lý doanh thu";
            this.btnQLDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnQLDoanhThu, BunifuAnimatorNS.DecorationType.None);
            this.btnQLDoanhThu.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLDoanhThu.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDoanhThu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLDoanhThu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLDoanhThu.Iconimage")));
            this.btnQLDoanhThu.Iconimage_right = null;
            this.btnQLDoanhThu.Iconimage_right_Selected = null;
            this.btnQLDoanhThu.Iconimage_Selected = null;
            this.btnQLDoanhThu.IconMarginLeft = 12;
            this.btnQLDoanhThu.IconMarginRight = 0;
            this.btnQLDoanhThu.IconRightVisible = false;
            this.btnQLDoanhThu.IconRightZoom = 0D;
            this.btnQLDoanhThu.IconVisible = true;
            this.btnQLDoanhThu.IconZoom = 60D;
            this.btnQLDoanhThu.IsTab = false;
            this.btnQLDoanhThu.Location = new System.Drawing.Point(0, 3);
            this.btnQLDoanhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLDoanhThu.Name = "btnQLDoanhThu";
            this.btnQLDoanhThu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQLDoanhThu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnQLDoanhThu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLDoanhThu.selected = false;
            this.btnQLDoanhThu.Size = new System.Drawing.Size(250, 48);
            this.btnQLDoanhThu.TabIndex = 2;
            this.btnQLDoanhThu.Text = "Quản lý doanh thu";
            this.btnQLDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQLDoanhThu.Textcolor = System.Drawing.Color.Transparent;
            this.btnQLDoanhThu.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDoanhThu.Click += new System.EventHandler(this.btnQLDoanhThu_Click_1);
            // 
            // subhoadonPanel
            // 
            this.subhoadonPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subhoadonPanel.BackgroundImage")));
            this.subhoadonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subhoadonPanel.Controls.Add(this.btnHDB);
            this.subhoadonPanel.Controls.Add(this.btnHDN);
            this.Transition.SetDecoration(this.subhoadonPanel, BunifuAnimatorNS.DecorationType.None);
            this.subhoadonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subhoadonPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subhoadonPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subhoadonPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subhoadonPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subhoadonPanel.Location = new System.Drawing.Point(0, 464);
            this.subhoadonPanel.Name = "subhoadonPanel";
            this.subhoadonPanel.Quality = 10;
            this.subhoadonPanel.Size = new System.Drawing.Size(250, 115);
            this.subhoadonPanel.TabIndex = 14;
            // 
            // btnHDB
            // 
            this.btnHDB.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnHDB.BackColor = System.Drawing.Color.Transparent;
            this.btnHDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHDB.BorderRadius = 0;
            this.btnHDB.ButtonText = "Hóa đơn bán";
            this.btnHDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnHDB, BunifuAnimatorNS.DecorationType.None);
            this.btnHDB.DisabledColor = System.Drawing.Color.Gray;
            this.btnHDB.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDB.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHDB.Iconimage = null;
            this.btnHDB.Iconimage_right = null;
            this.btnHDB.Iconimage_right_Selected = null;
            this.btnHDB.Iconimage_Selected = null;
            this.btnHDB.IconMarginLeft = 90;
            this.btnHDB.IconMarginRight = 0;
            this.btnHDB.IconRightVisible = false;
            this.btnHDB.IconRightZoom = 0D;
            this.btnHDB.IconVisible = true;
            this.btnHDB.IconZoom = 60D;
            this.btnHDB.IsTab = false;
            this.btnHDB.Location = new System.Drawing.Point(0, 57);
            this.btnHDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHDB.Name = "btnHDB";
            this.btnHDB.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHDB.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnHDB.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHDB.selected = false;
            this.btnHDB.Size = new System.Drawing.Size(247, 48);
            this.btnHDB.TabIndex = 12;
            this.btnHDB.Text = "Hóa đơn bán";
            this.btnHDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDB.Textcolor = System.Drawing.Color.Transparent;
            this.btnHDB.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDB.Click += new System.EventHandler(this.btnHDB_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnHDN.BackColor = System.Drawing.Color.Transparent;
            this.btnHDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHDN.BorderRadius = 0;
            this.btnHDN.ButtonText = "Hóa đơn nhập";
            this.btnHDN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnHDN, BunifuAnimatorNS.DecorationType.None);
            this.btnHDN.DisabledColor = System.Drawing.Color.Gray;
            this.btnHDN.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDN.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHDN.Iconimage = null;
            this.btnHDN.Iconimage_right = null;
            this.btnHDN.Iconimage_right_Selected = null;
            this.btnHDN.Iconimage_Selected = null;
            this.btnHDN.IconMarginLeft = 90;
            this.btnHDN.IconMarginRight = 0;
            this.btnHDN.IconRightVisible = false;
            this.btnHDN.IconRightZoom = 0D;
            this.btnHDN.IconVisible = true;
            this.btnHDN.IconZoom = 60D;
            this.btnHDN.IsTab = false;
            this.btnHDN.Location = new System.Drawing.Point(0, 3);
            this.btnHDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHDN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnHDN.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHDN.selected = true;
            this.btnHDN.Size = new System.Drawing.Size(247, 48);
            this.btnHDN.TabIndex = 11;
            this.btnHDN.Text = "Hóa đơn nhập";
            this.btnHDN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHDN.Textcolor = System.Drawing.Color.Transparent;
            this.btnHDN.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDN.Click += new System.EventHandler(this.btnHDN_Click);
            // 
            // hoadonPanel
            // 
            this.hoadonPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hoadonPanel.BackgroundImage")));
            this.hoadonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hoadonPanel.Controls.Add(this.btnQLHD);
            this.Transition.SetDecoration(this.hoadonPanel, BunifuAnimatorNS.DecorationType.None);
            this.hoadonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hoadonPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.hoadonPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.hoadonPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.hoadonPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.hoadonPanel.Location = new System.Drawing.Point(0, 407);
            this.hoadonPanel.Name = "hoadonPanel";
            this.hoadonPanel.Quality = 10;
            this.hoadonPanel.Size = new System.Drawing.Size(250, 57);
            this.hoadonPanel.TabIndex = 20;
            // 
            // btnQLHD
            // 
            this.btnQLHD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnQLHD.BackColor = System.Drawing.Color.Transparent;
            this.btnQLHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLHD.BorderRadius = 0;
            this.btnQLHD.ButtonText = "Quản lý hóa đơn";
            this.btnQLHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnQLHD, BunifuAnimatorNS.DecorationType.None);
            this.btnQLHD.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLHD.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLHD.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLHD.Iconimage")));
            this.btnQLHD.Iconimage_right = null;
            this.btnQLHD.Iconimage_right_Selected = null;
            this.btnQLHD.Iconimage_Selected = null;
            this.btnQLHD.IconMarginLeft = 12;
            this.btnQLHD.IconMarginRight = 0;
            this.btnQLHD.IconRightVisible = false;
            this.btnQLHD.IconRightZoom = 0D;
            this.btnQLHD.IconVisible = true;
            this.btnQLHD.IconZoom = 60D;
            this.btnQLHD.IsTab = false;
            this.btnQLHD.Location = new System.Drawing.Point(0, 3);
            this.btnQLHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQLHD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnQLHD.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLHD.selected = false;
            this.btnQLHD.Size = new System.Drawing.Size(250, 48);
            this.btnQLHD.TabIndex = 2;
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQLHD.Textcolor = System.Drawing.Color.Transparent;
            this.btnQLHD.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // banchayPanel
            // 
            this.banchayPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("banchayPanel.BackgroundImage")));
            this.banchayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.banchayPanel.Controls.Add(this.btnQLBC);
            this.Transition.SetDecoration(this.banchayPanel, BunifuAnimatorNS.DecorationType.None);
            this.banchayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.banchayPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.banchayPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.banchayPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.banchayPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.banchayPanel.Location = new System.Drawing.Point(0, 350);
            this.banchayPanel.Name = "banchayPanel";
            this.banchayPanel.Quality = 10;
            this.banchayPanel.Size = new System.Drawing.Size(250, 57);
            this.banchayPanel.TabIndex = 19;
            // 
            // btnQLBC
            // 
            this.btnQLBC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnQLBC.BackColor = System.Drawing.Color.Transparent;
            this.btnQLBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLBC.BorderRadius = 0;
            this.btnQLBC.ButtonText = "Quản lý bán chạy";
            this.btnQLBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnQLBC, BunifuAnimatorNS.DecorationType.None);
            this.btnQLBC.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLBC.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLBC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLBC.Iconimage")));
            this.btnQLBC.Iconimage_right = null;
            this.btnQLBC.Iconimage_right_Selected = null;
            this.btnQLBC.Iconimage_Selected = null;
            this.btnQLBC.IconMarginLeft = 12;
            this.btnQLBC.IconMarginRight = 0;
            this.btnQLBC.IconRightVisible = false;
            this.btnQLBC.IconRightZoom = 0D;
            this.btnQLBC.IconVisible = true;
            this.btnQLBC.IconZoom = 60D;
            this.btnQLBC.IsTab = false;
            this.btnQLBC.Location = new System.Drawing.Point(0, 3);
            this.btnQLBC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLBC.Name = "btnQLBC";
            this.btnQLBC.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQLBC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnQLBC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLBC.selected = false;
            this.btnQLBC.Size = new System.Drawing.Size(250, 48);
            this.btnQLBC.TabIndex = 2;
            this.btnQLBC.Text = "Quản lý bán chạy";
            this.btnQLBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQLBC.Textcolor = System.Drawing.Color.Transparent;
            this.btnQLBC.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBC.Click += new System.EventHandler(this.btnQLBC_Click);
            // 
            // sanphamPanel
            // 
            this.sanphamPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sanphamPanel.BackgroundImage")));
            this.sanphamPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sanphamPanel.Controls.Add(this.btnQLSP);
            this.Transition.SetDecoration(this.sanphamPanel, BunifuAnimatorNS.DecorationType.None);
            this.sanphamPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sanphamPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sanphamPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sanphamPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sanphamPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.sanphamPanel.Location = new System.Drawing.Point(0, 293);
            this.sanphamPanel.Name = "sanphamPanel";
            this.sanphamPanel.Quality = 10;
            this.sanphamPanel.Size = new System.Drawing.Size(250, 57);
            this.sanphamPanel.TabIndex = 18;
            // 
            // btnQLSP
            // 
            this.btnQLSP.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnQLSP.BackColor = System.Drawing.Color.Transparent;
            this.btnQLSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLSP.BorderRadius = 0;
            this.btnQLSP.ButtonText = "Quản lý sản phẩm";
            this.btnQLSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnQLSP, BunifuAnimatorNS.DecorationType.None);
            this.btnQLSP.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLSP.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSP.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLSP.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQLSP.Iconimage")));
            this.btnQLSP.Iconimage_right = null;
            this.btnQLSP.Iconimage_right_Selected = null;
            this.btnQLSP.Iconimage_Selected = null;
            this.btnQLSP.IconMarginLeft = 12;
            this.btnQLSP.IconMarginRight = 0;
            this.btnQLSP.IconRightVisible = false;
            this.btnQLSP.IconRightZoom = 0D;
            this.btnQLSP.IconVisible = true;
            this.btnQLSP.IconZoom = 60D;
            this.btnQLSP.IsTab = false;
            this.btnQLSP.Location = new System.Drawing.Point(0, 3);
            this.btnQLSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQLSP.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnQLSP.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLSP.selected = false;
            this.btnQLSP.Size = new System.Drawing.Size(250, 48);
            this.btnQLSP.TabIndex = 2;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQLSP.Textcolor = System.Drawing.Color.Transparent;
            this.btnQLSP.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // tonkhoPanel
            // 
            this.tonkhoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tonkhoPanel.BackgroundImage")));
            this.tonkhoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tonkhoPanel.Controls.Add(this.btnTongquan);
            this.Transition.SetDecoration(this.tonkhoPanel, BunifuAnimatorNS.DecorationType.None);
            this.tonkhoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tonkhoPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.tonkhoPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.tonkhoPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.tonkhoPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.tonkhoPanel.Location = new System.Drawing.Point(0, 236);
            this.tonkhoPanel.Name = "tonkhoPanel";
            this.tonkhoPanel.Quality = 10;
            this.tonkhoPanel.Size = new System.Drawing.Size(250, 57);
            this.tonkhoPanel.TabIndex = 17;
            // 
            // btnTongquan
            // 
            this.btnTongquan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnTongquan.BackColor = System.Drawing.Color.Transparent;
            this.btnTongquan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTongquan.BorderRadius = 0;
            this.btnTongquan.ButtonText = "Tổng quan";
            this.btnTongquan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnTongquan, BunifuAnimatorNS.DecorationType.None);
            this.btnTongquan.DisabledColor = System.Drawing.Color.Gray;
            this.btnTongquan.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongquan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTongquan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTongquan.Iconimage")));
            this.btnTongquan.Iconimage_right = null;
            this.btnTongquan.Iconimage_right_Selected = null;
            this.btnTongquan.Iconimage_Selected = null;
            this.btnTongquan.IconMarginLeft = 12;
            this.btnTongquan.IconMarginRight = 0;
            this.btnTongquan.IconRightVisible = false;
            this.btnTongquan.IconRightZoom = 0D;
            this.btnTongquan.IconVisible = true;
            this.btnTongquan.IconZoom = 60D;
            this.btnTongquan.IsTab = false;
            this.btnTongquan.Location = new System.Drawing.Point(0, 3);
            this.btnTongquan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTongquan.Name = "btnTongquan";
            this.btnTongquan.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTongquan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnTongquan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTongquan.selected = false;
            this.btnTongquan.Size = new System.Drawing.Size(250, 48);
            this.btnTongquan.TabIndex = 2;
            this.btnTongquan.Text = "Tổng quan";
            this.btnTongquan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTongquan.Textcolor = System.Drawing.Color.Transparent;
            this.btnTongquan.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongquan.Click += new System.EventHandler(this.btnTongquan_Click);
            // 
            // subuserPanel
            // 
            this.subuserPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subuserPanel.BackgroundImage")));
            this.subuserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subuserPanel.Controls.Add(this.btnLogout);
            this.subuserPanel.Controls.Add(this.btnThongtin);
            this.Transition.SetDecoration(this.subuserPanel, BunifuAnimatorNS.DecorationType.None);
            this.subuserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subuserPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(111)))), ((int)(((byte)(133)))));
            this.subuserPanel.Location = new System.Drawing.Point(0, 121);
            this.subuserPanel.Name = "subuserPanel";
            this.subuserPanel.Quality = 10;
            this.subuserPanel.Size = new System.Drawing.Size(250, 115);
            this.subuserPanel.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Đăng xuất";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = null;
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 90;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = false;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 60D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 57);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(250, 48);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.Transparent;
            this.btnLogout.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThongtin
            // 
            this.btnThongtin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.btnThongtin.BackColor = System.Drawing.Color.Transparent;
            this.btnThongtin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongtin.BorderRadius = 0;
            this.btnThongtin.ButtonText = "Thông tin";
            this.btnThongtin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnThongtin, BunifuAnimatorNS.DecorationType.None);
            this.btnThongtin.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongtin.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongtin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongtin.Iconimage = null;
            this.btnThongtin.Iconimage_right = null;
            this.btnThongtin.Iconimage_right_Selected = null;
            this.btnThongtin.Iconimage_Selected = null;
            this.btnThongtin.IconMarginLeft = 90;
            this.btnThongtin.IconMarginRight = 0;
            this.btnThongtin.IconRightVisible = false;
            this.btnThongtin.IconRightZoom = 0D;
            this.btnThongtin.IconVisible = true;
            this.btnThongtin.IconZoom = 60D;
            this.btnThongtin.IsTab = false;
            this.btnThongtin.Location = new System.Drawing.Point(0, 3);
            this.btnThongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongtin.Name = "btnThongtin";
            this.btnThongtin.Normalcolor = System.Drawing.Color.Transparent;
            this.btnThongtin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.btnThongtin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongtin.selected = true;
            this.btnThongtin.Size = new System.Drawing.Size(250, 48);
            this.btnThongtin.TabIndex = 11;
            this.btnThongtin.Text = "Thông tin";
            this.btnThongtin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongtin.Textcolor = System.Drawing.Color.Transparent;
            this.btnThongtin.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongtin.Click += new System.EventHandler(this.btnThongtin_Click);
            // 
            // userPanel
            // 
            this.userPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPanel.BackgroundImage")));
            this.userPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPanel.Controls.Add(this.userBtn);
            this.Transition.SetDecoration(this.userPanel, BunifuAnimatorNS.DecorationType.None);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(211)))));
            this.userPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.userPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.userPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.userPanel.Location = new System.Drawing.Point(0, 56);
            this.userPanel.Name = "userPanel";
            this.userPanel.Quality = 10;
            this.userPanel.Size = new System.Drawing.Size(250, 65);
            this.userPanel.TabIndex = 14;
            // 
            // userBtn
            // 
            this.userBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.userBtn.BackColor = System.Drawing.Color.Transparent;
            this.userBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userBtn.BorderRadius = 0;
            this.userBtn.ButtonText = "Lồ Sìn Dậu";
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.userBtn, BunifuAnimatorNS.DecorationType.None);
            this.userBtn.DisabledColor = System.Drawing.Color.Gray;
            this.userBtn.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.userBtn.Iconimage = global::Do_an_Winform.Properties.Resources.user;
            this.userBtn.Iconimage_right = null;
            this.userBtn.Iconimage_right_Selected = null;
            this.userBtn.Iconimage_Selected = null;
            this.userBtn.IconMarginLeft = 5;
            this.userBtn.IconMarginRight = 0;
            this.userBtn.IconRightVisible = false;
            this.userBtn.IconRightZoom = 0D;
            this.userBtn.IconVisible = true;
            this.userBtn.IconZoom = 90D;
            this.userBtn.IsTab = false;
            this.userBtn.Location = new System.Drawing.Point(0, 6);
            this.userBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userBtn.Name = "userBtn";
            this.userBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.userBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.userBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.userBtn.selected = true;
            this.userBtn.Size = new System.Drawing.Size(250, 48);
            this.userBtn.TabIndex = 4;
            this.userBtn.Text = "Lồ Sìn Dậu";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userBtn.Textcolor = System.Drawing.Color.Transparent;
            this.userBtn.TextFont = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPanel.BackgroundImage")));
            this.headerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerPanel.Controls.Add(this.slideBtn);
            this.Transition.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Quality = 10;
            this.headerPanel.Size = new System.Drawing.Size(250, 56);
            this.headerPanel.TabIndex = 15;
            // 
            // slideBtn
            // 
            this.slideBtn.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.slideBtn, BunifuAnimatorNS.DecorationType.None);
            this.slideBtn.Image = ((System.Drawing.Image)(resources.GetObject("slideBtn.Image")));
            this.slideBtn.ImageActive = null;
            this.slideBtn.Location = new System.Drawing.Point(9, 19);
            this.slideBtn.Name = "slideBtn";
            this.slideBtn.Size = new System.Drawing.Size(35, 20);
            this.slideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slideBtn.TabIndex = 6;
            this.slideBtn.TabStop = false;
            this.slideBtn.Zoom = 10;
            this.slideBtn.Click += new System.EventHandler(this.slideBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.mainPanel.GradientBottomLeft = System.Drawing.SystemColors.Control;
            this.mainPanel.GradientBottomRight = System.Drawing.SystemColors.Control;
            this.mainPanel.GradientTopLeft = System.Drawing.SystemColors.Control;
            this.mainPanel.GradientTopRight = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(260, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Quality = 10;
            this.mainPanel.Size = new System.Drawing.Size(1108, 732);
            this.mainPanel.TabIndex = 5;
            // 
            // titlePanel
            // 
            this.titlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePanel.BackgroundImage")));
            this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePanel.Controls.Add(this.btnMaximize);
            this.titlePanel.Controls.Add(this.btnMinimize);
            this.titlePanel.Controls.Add(this.btnClose);
            this.Transition.SetDecoration(this.titlePanel, BunifuAnimatorNS.DecorationType.None);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.titlePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.titlePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.titlePanel.GradientTopRight = System.Drawing.Color.White;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Quality = 10;
            this.titlePanel.Size = new System.Drawing.Size(1380, 38);
            this.titlePanel.TabIndex = 4;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Image = global::Do_an_Winform.Properties.Resources.full_screen;
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.Location = new System.Drawing.Point(1311, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(18, 22);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Zoom = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = global::Do_an_Winform.Properties.Resources.minus;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1267, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 22);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = global::Do_an_Winform.Properties.Resources.crossed;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1347, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frm_Quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 788);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titlePanel);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Quanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Quanly_Load);
            this.sidemenu.ResumeLayout(false);
            this.subdoitacPanel.ResumeLayout(false);
            this.doitacPanel.ResumeLayout(false);
            this.doanhthuPanel.ResumeLayout(false);
            this.subhoadonPanel.ResumeLayout(false);
            this.hoadonPanel.ResumeLayout(false);
            this.banchayPanel.ResumeLayout(false);
            this.sanphamPanel.ResumeLayout(false);
            this.tonkhoPanel.ResumeLayout(false);
            this.subuserPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slideBtn)).EndInit();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition Transition;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton slideBtn;
        private Bunifu.Framework.UI.BunifuFlatButton userBtn;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongtin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel subuserPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel userPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel sidemenu;
        private Bunifu.Framework.UI.BunifuGradientPanel headerPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel mainPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel titlePanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel subhoadonPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnHDB;
        private Bunifu.Framework.UI.BunifuFlatButton btnHDN;
        private Bunifu.Framework.UI.BunifuGradientPanel doanhthuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLDoanhThu;
        private Bunifu.Framework.UI.BunifuGradientPanel subdoitacPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btDoiTac_KH;
        private Bunifu.Framework.UI.BunifuFlatButton btDoiTac_NV;
        private Bunifu.Framework.UI.BunifuGradientPanel doitacPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLDoiTac;
        private Bunifu.Framework.UI.BunifuGradientPanel hoadonPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLHD;
        private Bunifu.Framework.UI.BunifuGradientPanel banchayPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLBC;
        private Bunifu.Framework.UI.BunifuGradientPanel sanphamPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLSP;
        private Bunifu.Framework.UI.BunifuGradientPanel tonkhoPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnTongquan;
        private Bunifu.Framework.UI.BunifuFlatButton btDoiTac_NCC;
    }
}