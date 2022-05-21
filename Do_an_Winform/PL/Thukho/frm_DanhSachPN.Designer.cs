
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnTaoDon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtFind = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.mainPanel.Controls.Add(this.btnTaoDon);
            this.mainPanel.Controls.Add(this.txtFind);
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.btnTaoDon.CustomizableEdges = borderEdges1;
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
            this.btnTaoDon.Location = new System.Drawing.Point(959, 22);
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
            // txtFind
            // 
            this.txtFind.AcceptsReturn = false;
            this.txtFind.AcceptsTab = false;
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.AnimationSpeed = 200;
            this.txtFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFind.AutoSizeHeight = true;
            this.txtFind.BackColor = System.Drawing.Color.Transparent;
            this.txtFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFind.BackgroundImage")));
            this.txtFind.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFind.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFind.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFind.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFind.BorderRadius = 15;
            this.txtFind.BorderThickness = 1;
            this.txtFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.DefaultText = "";
            this.txtFind.FillColor = System.Drawing.Color.White;
            this.txtFind.HideSelection = true;
            this.txtFind.IconLeft = null;
            this.txtFind.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.IconPadding = 10;
            this.txtFind.IconRight = global::Do_an_Winform.Properties.Resources.search;
            this.txtFind.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.Lines = new string[0];
            this.txtFind.Location = new System.Drawing.Point(318, 22);
            this.txtFind.MaxLength = 32767;
            this.txtFind.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFind.Modified = false;
            this.txtFind.Multiline = false;
            this.txtFind.Name = "txtFind";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnIdleState = stateProperties4;
            this.txtFind.Padding = new System.Windows.Forms.Padding(3);
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFind.PlaceholderText = "Tìm kiếm tên sản phẩm";
            this.txtFind.ReadOnly = false;
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.Size = new System.Drawing.Size(589, 44);
            this.txtFind.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFind.TabIndex = 3;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFind.TextMarginBottom = 0;
            this.txtFind.TextMarginLeft = 3;
            this.txtFind.TextMarginTop = 1;
            this.txtFind.TextPlaceholder = "Tìm kiếm tên sản phẩm";
            this.txtFind.UseSystemPasswordChar = false;
            this.txtFind.WordWrap = true;
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
            this.gridviewDSNhap.Location = new System.Drawing.Point(12, 86);
            this.gridviewDSNhap.Name = "gridviewDSNhap";
            this.gridviewDSNhap.ReadOnly = true;
            this.gridviewDSNhap.RowHeadersVisible = false;
            this.gridviewDSNhap.RowTemplate.Height = 40;
            this.gridviewDSNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewDSNhap.Size = new System.Drawing.Size(1196, 427);
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
            this.bunifuLabel1.Size = new System.Drawing.Size(125, 33);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Nhập hàng";
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
        private Bunifu.UI.WinForms.BunifuTextBox txtFind;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        public Bunifu.UI.WinForms.BunifuDataGridView gridviewDSNhap;
    }
}