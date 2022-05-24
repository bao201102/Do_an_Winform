
namespace Do_an_Winform.PL.Thukho
{
    partial class frm_DanhSachPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhSachPN));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTaoDon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gridviewDSNhap = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDSNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundColor = System.Drawing.Color.White;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 15;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.btnRefresh);
            this.mainPanel.Controls.Add(this.btnTaoDon);
            this.mainPanel.Controls.Add(this.gridviewDSNhap);
            this.mainPanel.Controls.Add(this.bunifuLabel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShowBorders = true;
            this.mainPanel.Size = new System.Drawing.Size(1222, 528);
            this.mainPanel.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowMouseEffects = true;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AnimationSpeed = 200;
            this.btnRefresh.AutoGenerateColors = false;
            this.btnRefresh.AutoRoundBorders = true;
            this.btnRefresh.AutoSizeLeftIcon = false;
            this.btnRefresh.AutoSizeRightIcon = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.ButtonText = "Làm mới";
            this.btnRefresh.ButtonTextMarginLeft = 0;
            this.btnRefresh.ColorContrastOnClick = 45;
            this.btnRefresh.ColorContrastOnHover = 45;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges1;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefresh.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnRefresh.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnRefresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRefresh.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconLeft = null;
            this.btnRefresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRefresh.IconMarginLeft = 11;
            this.btnRefresh.IconPadding = 10;
            this.btnRefresh.IconRight = global::Do_an_Winform.Properties.Resources.sync;
            this.btnRefresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRefresh.IconSize = 18;
            this.btnRefresh.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnRefresh.IdleBorderRadius = 0;
            this.btnRefresh.IdleBorderThickness = 0;
            this.btnRefresh.IdleFillColor = System.Drawing.Color.Empty;
            this.btnRefresh.IdleIconLeftImage = null;
            this.btnRefresh.IdleIconRightImage = global::Do_an_Winform.Properties.Resources.sync;
            this.btnRefresh.IndicateFocus = false;
            this.btnRefresh.Location = new System.Drawing.Point(988, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefresh.OnDisabledState.BorderRadius = 45;
            this.btnRefresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnDisabledState.BorderThickness = 1;
            this.btnRefresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefresh.OnDisabledState.IconLeftImage = null;
            this.btnRefresh.OnDisabledState.IconRightImage = null;
            this.btnRefresh.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRefresh.onHoverState.BorderRadius = 45;
            this.btnRefresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.onHoverState.BorderThickness = 1;
            this.btnRefresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRefresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.onHoverState.IconLeftImage = null;
            this.btnRefresh.onHoverState.IconRightImage = null;
            this.btnRefresh.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnRefresh.OnIdleState.BorderRadius = 45;
            this.btnRefresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnIdleState.BorderThickness = 1;
            this.btnRefresh.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnRefresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnIdleState.IconLeftImage = null;
            this.btnRefresh.OnIdleState.IconRightImage = global::Do_an_Winform.Properties.Resources.sync;
            this.btnRefresh.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefresh.OnPressedState.BorderRadius = 45;
            this.btnRefresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnPressedState.BorderThickness = 1;
            this.btnRefresh.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnPressedState.IconLeftImage = null;
            this.btnRefresh.OnPressedState.IconRightImage = null;
            this.btnRefresh.Size = new System.Drawing.Size(181, 45);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.TextMarginLeft = 0;
            this.btnRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefresh.UseDefaultRadiusAndThickness = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.AllowAnimations = true;
            this.btnTaoDon.AllowMouseEffects = true;
            this.btnTaoDon.AllowToggling = false;
            this.btnTaoDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoDon.AnimationSpeed = 200;
            this.btnTaoDon.AutoGenerateColors = false;
            this.btnTaoDon.AutoRoundBorders = true;
            this.btnTaoDon.AutoSizeLeftIcon = false;
            this.btnTaoDon.AutoSizeRightIcon = true;
            this.btnTaoDon.BackColor = System.Drawing.Color.Transparent;
            this.btnTaoDon.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnTaoDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoDon.BackgroundImage")));
            this.btnTaoDon.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTaoDon.ButtonText = "Tạo đơn nhập hàng";
            this.btnTaoDon.ButtonTextMarginLeft = 0;
            this.btnTaoDon.ColorContrastOnClick = 45;
            this.btnTaoDon.ColorContrastOnHover = 45;
            this.btnTaoDon.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.btnTaoDon.CustomizableEdges = borderEdges2;
            this.btnTaoDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTaoDon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTaoDon.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnTaoDon.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnTaoDon.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTaoDon.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.IconLeft = global::Do_an_Winform.Properties.Resources.plus;
            this.btnTaoDon.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoDon.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTaoDon.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTaoDon.IconMarginLeft = 11;
            this.btnTaoDon.IconPadding = 10;
            this.btnTaoDon.IconRight = null;
            this.btnTaoDon.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoDon.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTaoDon.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTaoDon.IconSize = 18;
            this.btnTaoDon.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnTaoDon.IdleBorderRadius = 0;
            this.btnTaoDon.IdleBorderThickness = 0;
            this.btnTaoDon.IdleFillColor = System.Drawing.Color.Empty;
            this.btnTaoDon.IdleIconLeftImage = global::Do_an_Winform.Properties.Resources.plus;
            this.btnTaoDon.IdleIconRightImage = null;
            this.btnTaoDon.IndicateFocus = false;
            this.btnTaoDon.Location = new System.Drawing.Point(801, 31);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTaoDon.OnDisabledState.BorderRadius = 45;
            this.btnTaoDon.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTaoDon.OnDisabledState.BorderThickness = 1;
            this.btnTaoDon.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTaoDon.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTaoDon.OnDisabledState.IconLeftImage = null;
            this.btnTaoDon.OnDisabledState.IconRightImage = null;
            this.btnTaoDon.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTaoDon.onHoverState.BorderRadius = 45;
            this.btnTaoDon.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTaoDon.onHoverState.BorderThickness = 1;
            this.btnTaoDon.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnTaoDon.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.onHoverState.IconLeftImage = null;
            this.btnTaoDon.onHoverState.IconRightImage = null;
            this.btnTaoDon.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnTaoDon.OnIdleState.BorderRadius = 45;
            this.btnTaoDon.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTaoDon.OnIdleState.BorderThickness = 1;
            this.btnTaoDon.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnTaoDon.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.OnIdleState.IconLeftImage = global::Do_an_Winform.Properties.Resources.plus;
            this.btnTaoDon.OnIdleState.IconRightImage = null;
            this.btnTaoDon.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTaoDon.OnPressedState.BorderRadius = 45;
            this.btnTaoDon.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTaoDon.OnPressedState.BorderThickness = 1;
            this.btnTaoDon.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTaoDon.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.OnPressedState.IconLeftImage = null;
            this.btnTaoDon.OnPressedState.IconRightImage = null;
            this.btnTaoDon.Size = new System.Drawing.Size(181, 45);
            this.btnTaoDon.TabIndex = 4;
            this.btnTaoDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoDon.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTaoDon.TextMarginLeft = 0;
            this.btnTaoDon.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTaoDon.UseDefaultRadiusAndThickness = true;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // gridviewDSNhap
            // 
            this.gridviewDSNhap.AllowCustomTheming = false;
            this.gridviewDSNhap.AllowUserToAddRows = false;
            this.gridviewDSNhap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridviewDSNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewDSNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewDSNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewDSNhap.BackgroundColor = System.Drawing.Color.White;
            this.gridviewDSNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewDSNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewDSNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewDSNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewDSNhap.ColumnHeadersHeight = 40;
            this.gridviewDSNhap.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridviewDSNhap.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridviewDSNhap.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridviewDSNhap.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gridviewDSNhap.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridviewDSNhap.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gridviewDSNhap.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gridviewDSNhap.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridviewDSNhap.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gridviewDSNhap.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewDSNhap.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gridviewDSNhap.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridviewDSNhap.CurrentTheme.Name = null;
            this.gridviewDSNhap.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewDSNhap.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridviewDSNhap.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridviewDSNhap.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gridviewDSNhap.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewDSNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewDSNhap.EnableHeadersVisualStyles = false;
            this.gridviewDSNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gridviewDSNhap.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gridviewDSNhap.HeaderBgColor = System.Drawing.Color.Empty;
            this.gridviewDSNhap.HeaderForeColor = System.Drawing.Color.White;
            this.gridviewDSNhap.Location = new System.Drawing.Point(12, 112);
            this.gridviewDSNhap.Name = "gridviewDSNhap";
            this.gridviewDSNhap.ReadOnly = true;
            this.gridviewDSNhap.RowHeadersVisible = false;
            this.gridviewDSNhap.RowTemplate.Height = 40;
            this.gridviewDSNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewDSNhap.Size = new System.Drawing.Size(1196, 401);
            this.gridviewDSNhap.TabIndex = 2;
            this.gridviewDSNhap.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.gridviewDSNhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewDSNhap_CellDoubleClick);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(30, 31);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(316, 33);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Danh sách phiếu nhập hàng";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frm_DanhSachPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 528);
            this.Controls.Add(this.mainPanel);
            this.Name = "frm_DanhSachPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DanhSachPN";
            this.Load += new System.EventHandler(this.frm_DanhSachPN_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDSNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel mainPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTaoDon;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        public Bunifu.UI.WinForms.BunifuDataGridView gridviewDSNhap;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
    }
}