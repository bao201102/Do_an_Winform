namespace Do_an_Winform.PL.Nhanvien
{
    partial class UserControlSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSanPham));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoc = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.cbLoaiSP = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbGia = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbThuongHieu = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbTenSP = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvAllProduct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lbl1.Location = new System.Drawing.Point(506, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(253, 32);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Danh Sách Sản Phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thương hiệu";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(710, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại sản phẩm";
            // 
            // btnLoc
            // 
            this.btnLoc.ActiveBorderThickness = 1;
            this.btnLoc.ActiveCornerRadius = 20;
            this.btnLoc.ActiveFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoc.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLoc.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoc.BackgroundImage")));
            this.btnLoc.ButtonText = "Lọc";
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.IdleBorderThickness = 1;
            this.btnLoc.IdleCornerRadius = 20;
            this.btnLoc.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnLoc.IdleForecolor = System.Drawing.Color.Black;
            this.btnLoc.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnLoc.Location = new System.Drawing.Point(1095, 176);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 44);
            this.btnLoc.TabIndex = 33;
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 15;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.cbLoaiSP);
            this.bunifuPanel2.Controls.Add(this.cbGia);
            this.bunifuPanel2.Controls.Add(this.cbThuongHieu);
            this.bunifuPanel2.Controls.Add(this.cbTenSP);
            this.bunifuPanel2.Controls.Add(this.btnLoc);
            this.bunifuPanel2.Controls.Add(this.dgvAllProduct);
            this.bunifuPanel2.Controls.Add(this.label4);
            this.bunifuPanel2.Controls.Add(this.label1);
            this.bunifuPanel2.Controls.Add(this.label3);
            this.bunifuPanel2.Controls.Add(this.lbl1);
            this.bunifuPanel2.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1203, 602);
            this.bunifuPanel2.TabIndex = 14;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.cbLoaiSP.BorderColor = System.Drawing.Color.Silver;
            this.cbLoaiSP.BorderRadius = 1;
            this.cbLoaiSP.Color = System.Drawing.Color.Silver;
            this.cbLoaiSP.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbLoaiSP.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbLoaiSP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbLoaiSP.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbLoaiSP.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbLoaiSP.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiSP.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbLoaiSP.FillDropDown = true;
            this.cbLoaiSP.FillIndicator = false;
            this.cbLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbLoaiSP.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Icon = null;
            this.cbLoaiSP.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbLoaiSP.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbLoaiSP.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbLoaiSP.IndicatorThickness = 2;
            this.cbLoaiSP.IsDropdownOpened = false;
            this.cbLoaiSP.ItemBackColor = System.Drawing.Color.White;
            this.cbLoaiSP.ItemBorderColor = System.Drawing.Color.White;
            this.cbLoaiSP.ItemForeColor = System.Drawing.Color.Black;
            this.cbLoaiSP.ItemHeight = 26;
            this.cbLoaiSP.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbLoaiSP.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbLoaiSP.ItemTopMargin = 3;
            this.cbLoaiSP.Location = new System.Drawing.Point(827, 182);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(227, 32);
            this.cbLoaiSP.TabIndex = 37;
            this.cbLoaiSP.Text = null;
            this.cbLoaiSP.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbLoaiSP.TextLeftMargin = 5;
            // 
            // cbGia
            // 
            this.cbGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGia.BackColor = System.Drawing.Color.Transparent;
            this.cbGia.BackgroundColor = System.Drawing.Color.White;
            this.cbGia.BorderColor = System.Drawing.Color.Silver;
            this.cbGia.BorderRadius = 1;
            this.cbGia.Color = System.Drawing.Color.Silver;
            this.cbGia.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbGia.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbGia.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbGia.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbGia.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbGia.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGia.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGia.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbGia.FillDropDown = true;
            this.cbGia.FillIndicator = false;
            this.cbGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbGia.ForeColor = System.Drawing.Color.Black;
            this.cbGia.FormattingEnabled = true;
            this.cbGia.Icon = null;
            this.cbGia.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbGia.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbGia.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbGia.IndicatorThickness = 2;
            this.cbGia.IsDropdownOpened = false;
            this.cbGia.ItemBackColor = System.Drawing.Color.White;
            this.cbGia.ItemBorderColor = System.Drawing.Color.White;
            this.cbGia.ItemForeColor = System.Drawing.Color.Black;
            this.cbGia.ItemHeight = 26;
            this.cbGia.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbGia.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbGia.ItemTopMargin = 3;
            this.cbGia.Location = new System.Drawing.Point(451, 182);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(227, 32);
            this.cbGia.TabIndex = 36;
            this.cbGia.Text = null;
            this.cbGia.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbGia.TextLeftMargin = 5;
            // 
            // cbThuongHieu
            // 
            this.cbThuongHieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.cbThuongHieu.BackgroundColor = System.Drawing.Color.White;
            this.cbThuongHieu.BorderColor = System.Drawing.Color.Silver;
            this.cbThuongHieu.BorderRadius = 1;
            this.cbThuongHieu.Color = System.Drawing.Color.Silver;
            this.cbThuongHieu.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbThuongHieu.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbThuongHieu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbThuongHieu.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbThuongHieu.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbThuongHieu.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbThuongHieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThuongHieu.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThuongHieu.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbThuongHieu.FillDropDown = true;
            this.cbThuongHieu.FillIndicator = false;
            this.cbThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbThuongHieu.ForeColor = System.Drawing.Color.Black;
            this.cbThuongHieu.FormattingEnabled = true;
            this.cbThuongHieu.Icon = null;
            this.cbThuongHieu.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbThuongHieu.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbThuongHieu.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbThuongHieu.IndicatorThickness = 2;
            this.cbThuongHieu.IsDropdownOpened = false;
            this.cbThuongHieu.ItemBackColor = System.Drawing.Color.White;
            this.cbThuongHieu.ItemBorderColor = System.Drawing.Color.White;
            this.cbThuongHieu.ItemForeColor = System.Drawing.Color.Black;
            this.cbThuongHieu.ItemHeight = 26;
            this.cbThuongHieu.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbThuongHieu.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbThuongHieu.ItemTopMargin = 3;
            this.cbThuongHieu.Location = new System.Drawing.Point(149, 182);
            this.cbThuongHieu.Name = "cbThuongHieu";
            this.cbThuongHieu.Size = new System.Drawing.Size(227, 32);
            this.cbThuongHieu.TabIndex = 35;
            this.cbThuongHieu.Text = null;
            this.cbThuongHieu.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbThuongHieu.TextLeftMargin = 5;
            // 
            // cbTenSP
            // 
            this.cbTenSP.AcceptsReturn = false;
            this.cbTenSP.AcceptsTab = false;
            this.cbTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTenSP.AnimationSpeed = 200;
            this.cbTenSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTenSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbTenSP.AutoSizeHeight = true;
            this.cbTenSP.BackColor = System.Drawing.Color.Transparent;
            this.cbTenSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbTenSP.BackgroundImage")));
            this.cbTenSP.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.cbTenSP.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbTenSP.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbTenSP.BorderColorIdle = System.Drawing.Color.Silver;
            this.cbTenSP.BorderRadius = 15;
            this.cbTenSP.BorderThickness = 1;
            this.cbTenSP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTenSP.DefaultFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSP.DefaultText = "";
            this.cbTenSP.FillColor = System.Drawing.Color.White;
            this.cbTenSP.HideSelection = true;
            this.cbTenSP.IconLeft = global::Do_an_Winform.Properties.Resources.search;
            this.cbTenSP.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTenSP.IconPadding = 10;
            this.cbTenSP.IconRight = null;
            this.cbTenSP.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTenSP.Lines = new string[0];
            this.cbTenSP.Location = new System.Drawing.Point(16, 105);
            this.cbTenSP.MaxLength = 32767;
            this.cbTenSP.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbTenSP.Modified = false;
            this.cbTenSP.Multiline = false;
            this.cbTenSP.Name = "cbTenSP";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cbTenSP.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.cbTenSP.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cbTenSP.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cbTenSP.OnIdleState = stateProperties4;
            this.cbTenSP.Padding = new System.Windows.Forms.Padding(3);
            this.cbTenSP.PasswordChar = '\0';
            this.cbTenSP.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.cbTenSP.PlaceholderText = "Tìm kiếm tên sản phẩm";
            this.cbTenSP.ReadOnly = false;
            this.cbTenSP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cbTenSP.SelectedText = "";
            this.cbTenSP.SelectionLength = 0;
            this.cbTenSP.SelectionStart = 0;
            this.cbTenSP.ShortcutsEnabled = true;
            this.cbTenSP.Size = new System.Drawing.Size(1169, 44);
            this.cbTenSP.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cbTenSP.TabIndex = 34;
            this.cbTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cbTenSP.TextMarginBottom = 0;
            this.cbTenSP.TextMarginLeft = 20;
            this.cbTenSP.TextMarginTop = 1;
            this.cbTenSP.TextPlaceholder = "Tìm kiếm tên sản phẩm";
            this.cbTenSP.UseSystemPasswordChar = false;
            this.cbTenSP.WordWrap = true;
            this.cbTenSP.TextChange += new System.EventHandler(this.cbTenSP_TextChanged);
            // 
            // dgvAllProduct
            // 
            this.dgvAllProduct.AllowCustomTheming = false;
            this.dgvAllProduct.AllowUserToAddRows = false;
            this.dgvAllProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAllProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllProduct.ColumnHeadersHeight = 40;
            this.dgvAllProduct.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllProduct.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllProduct.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllProduct.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAllProduct.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAllProduct.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllProduct.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllProduct.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvAllProduct.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllProduct.CurrentTheme.Name = null;
            this.dgvAllProduct.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllProduct.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllProduct.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllProduct.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllProduct.EnableHeadersVisualStyles = false;
            this.dgvAllProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAllProduct.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAllProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAllProduct.Location = new System.Drawing.Point(16, 258);
            this.dgvAllProduct.Name = "dgvAllProduct";
            this.dgvAllProduct.ReadOnly = true;
            this.dgvAllProduct.RowHeadersVisible = false;
            this.dgvAllProduct.RowTemplate.Height = 40;
            this.dgvAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProduct.Size = new System.Drawing.Size(1169, 328);
            this.dgvAllProduct.TabIndex = 14;
            this.dgvAllProduct.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = false;
            this.bunifuSnackbar1.ClickToClose = false;
            this.bunifuSnackbar1.DoubleClickToClose = false;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 20;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = true;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 20;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = true;
            this.bunifuSnackbar1.ShowCloseIcon = true;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 20;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 20;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // UserControlSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bunifuPanel2);
            this.Name = "UserControlSanPham";
            this.Size = new System.Drawing.Size(1209, 608);
            this.Load += new System.EventHandler(this.UserControlSanPham_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoc;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvAllProduct;
        private Bunifu.UI.WinForms.BunifuTextBox cbTenSP;
        private Bunifu.UI.WinForms.BunifuDropdown cbLoaiSP;
        private Bunifu.UI.WinForms.BunifuDropdown cbGia;
        private Bunifu.UI.WinForms.BunifuDropdown cbThuongHieu;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}
