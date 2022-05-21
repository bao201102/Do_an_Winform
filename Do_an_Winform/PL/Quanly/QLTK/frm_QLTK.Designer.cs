namespace Do_an_Winform.PL.Quanly.QLTK
{
    partial class frm_QLTK
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLTK));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblTonKho = new System.Windows.Forms.Label();
            this.txtTimKiemTonKho = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btXuatThongTin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbLoaiSP = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dgTonKho = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Transition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation3;
            // 
            // lblTonKho
            // 
            this.lblTonKho.AutoSize = true;
            this.Transition.SetDecoration(this.lblTonKho, BunifuAnimatorNS.DecorationType.None);
            this.lblTonKho.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTonKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.lblTonKho.Location = new System.Drawing.Point(36, 30);
            this.lblTonKho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(238, 28);
            this.lblTonKho.TabIndex = 2;
            this.lblTonKho.Text = "Danh sách hàng tồn kho";
            // 
            // txtTimKiemTonKho
            // 
            this.txtTimKiemTonKho.AcceptsReturn = false;
            this.txtTimKiemTonKho.AcceptsTab = false;
            this.txtTimKiemTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTonKho.AnimationSpeed = 200;
            this.txtTimKiemTonKho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiemTonKho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiemTonKho.AutoSizeHeight = true;
            this.txtTimKiemTonKho.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemTonKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimKiemTonKho.BackgroundImage")));
            this.txtTimKiemTonKho.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTimKiemTonKho.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTimKiemTonKho.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTimKiemTonKho.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTimKiemTonKho.BorderRadius = 15;
            this.txtTimKiemTonKho.BorderThickness = 1;
            this.txtTimKiemTonKho.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemTonKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.txtTimKiemTonKho, BunifuAnimatorNS.DecorationType.None);
            this.txtTimKiemTonKho.DefaultFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTonKho.DefaultText = "";
            this.txtTimKiemTonKho.FillColor = System.Drawing.Color.White;
            this.txtTimKiemTonKho.HideSelection = true;
            this.txtTimKiemTonKho.IconLeft = null;
            this.txtTimKiemTonKho.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemTonKho.IconPadding = 10;
            this.txtTimKiemTonKho.IconRight = null;
            this.txtTimKiemTonKho.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemTonKho.Lines = new string[0];
            this.txtTimKiemTonKho.Location = new System.Drawing.Point(289, 30);
            this.txtTimKiemTonKho.MaxLength = 32767;
            this.txtTimKiemTonKho.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTimKiemTonKho.Modified = false;
            this.txtTimKiemTonKho.Multiline = false;
            this.txtTimKiemTonKho.Name = "txtTimKiemTonKho";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemTonKho.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemTonKho.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemTonKho.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemTonKho.OnIdleState = stateProperties12;
            this.txtTimKiemTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.txtTimKiemTonKho.PasswordChar = '\0';
            this.txtTimKiemTonKho.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiemTonKho.PlaceholderText = "Tìm kiếm tên hàng tồn kho";
            this.txtTimKiemTonKho.ReadOnly = false;
            this.txtTimKiemTonKho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiemTonKho.SelectedText = "";
            this.txtTimKiemTonKho.SelectionLength = 0;
            this.txtTimKiemTonKho.SelectionStart = 0;
            this.txtTimKiemTonKho.ShortcutsEnabled = true;
            this.txtTimKiemTonKho.Size = new System.Drawing.Size(506, 44);
            this.txtTimKiemTonKho.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTimKiemTonKho.TabIndex = 7;
            this.txtTimKiemTonKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemTonKho.TextMarginBottom = 0;
            this.txtTimKiemTonKho.TextMarginLeft = 3;
            this.txtTimKiemTonKho.TextMarginTop = 1;
            this.txtTimKiemTonKho.TextPlaceholder = "Tìm kiếm tên hàng tồn kho";
            this.txtTimKiemTonKho.UseSystemPasswordChar = false;
            this.txtTimKiemTonKho.WordWrap = true;
            // 
            // btXuatThongTin
            // 
            this.btXuatThongTin.ActiveBorderThickness = 1;
            this.btXuatThongTin.ActiveCornerRadius = 20;
            this.btXuatThongTin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btXuatThongTin.ActiveForecolor = System.Drawing.Color.White;
            this.btXuatThongTin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btXuatThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXuatThongTin.BackColor = System.Drawing.SystemColors.Control;
            this.btXuatThongTin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXuatThongTin.BackgroundImage")));
            this.btXuatThongTin.ButtonText = "Xuất thông tin";
            this.btXuatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btXuatThongTin, BunifuAnimatorNS.DecorationType.None);
            this.btXuatThongTin.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatThongTin.ForeColor = System.Drawing.Color.White;
            this.btXuatThongTin.IdleBorderThickness = 1;
            this.btXuatThongTin.IdleCornerRadius = 20;
            this.btXuatThongTin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btXuatThongTin.IdleForecolor = System.Drawing.Color.White;
            this.btXuatThongTin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btXuatThongTin.Location = new System.Drawing.Point(1164, 24);
            this.btXuatThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXuatThongTin.Name = "btXuatThongTin";
            this.btXuatThongTin.Size = new System.Drawing.Size(100, 50);
            this.btXuatThongTin.TabIndex = 15;
            this.btXuatThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btXuatThongTin.Click += new System.EventHandler(this.btXuatThongTin_Click);
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.cbLoaiSP.BorderColor = System.Drawing.Color.Silver;
            this.cbLoaiSP.BorderRadius = 1;
            this.cbLoaiSP.Color = System.Drawing.Color.Silver;
            this.Transition.SetDecoration(this.cbLoaiSP, BunifuAnimatorNS.DecorationType.None);
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
            this.cbLoaiSP.Location = new System.Drawing.Point(801, 38);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(149, 32);
            this.cbLoaiSP.TabIndex = 17;
            this.cbLoaiSP.Text = null;
            this.cbLoaiSP.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbLoaiSP.TextLeftMargin = 5;
            // 
            // dgTonKho
            // 
            this.dgTonKho.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgTonKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgTonKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTonKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTonKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgTonKho.ColumnHeadersHeight = 40;
            this.dgTonKho.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgTonKho.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgTonKho.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgTonKho.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgTonKho.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgTonKho.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgTonKho.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgTonKho.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgTonKho.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgTonKho.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgTonKho.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgTonKho.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgTonKho.CurrentTheme.Name = null;
            this.dgTonKho.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTonKho.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgTonKho.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgTonKho.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgTonKho.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Transition.SetDecoration(this.dgTonKho, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTonKho.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgTonKho.EnableHeadersVisualStyles = false;
            this.dgTonKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgTonKho.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgTonKho.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgTonKho.HeaderForeColor = System.Drawing.Color.White;
            this.dgTonKho.Location = new System.Drawing.Point(56, 111);
            this.dgTonKho.Name = "dgTonKho";
            this.dgTonKho.RowHeadersVisible = false;
            this.dgTonKho.RowHeadersWidth = 51;
            this.dgTonKho.RowTemplate.Height = 40;
            this.dgTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTonKho.Size = new System.Drawing.Size(1221, 708);
            this.dgTonKho.TabIndex = 18;
            this.dgTonKho.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // frm_QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 844);
            this.Controls.Add(this.dgTonKho);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.btXuatThongTin);
            this.Controls.Add(this.txtTimKiemTonKho);
            this.Controls.Add(this.lblTonKho);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLTK";
            this.Text = "frm_QLTK";
            this.Load += new System.EventHandler(this.frm_QLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition Transition;
        private System.Windows.Forms.Label lblTonKho;
        private Bunifu.UI.WinForms.BunifuTextBox txtTimKiemTonKho;
        private Bunifu.Framework.UI.BunifuThinButton2 btXuatThongTin;
        private Bunifu.UI.WinForms.BunifuDropdown cbLoaiSP;
        private Bunifu.UI.WinForms.BunifuDataGridView dgTonKho;
    }
}