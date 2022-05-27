namespace Do_an_Winform.PL.Quanly.DoiTac
{
    partial class frm_DoiTacKH
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiTacKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.dgKhachHang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtFind = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnCreateRP = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Transition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation2;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.Transition.SetDecoration(this.lblKhachHang, BunifuAnimatorNS.DecorationType.None);
            this.lblKhachHang.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.lblKhachHang.Location = new System.Drawing.Point(35, 35);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(268, 32);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgKhachHang
            // 
            this.dgKhachHang.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgKhachHang.ColumnHeadersHeight = 40;
            this.dgKhachHang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgKhachHang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgKhachHang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgKhachHang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgKhachHang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgKhachHang.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgKhachHang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgKhachHang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgKhachHang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgKhachHang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgKhachHang.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgKhachHang.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgKhachHang.CurrentTheme.Name = null;
            this.dgKhachHang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgKhachHang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgKhachHang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgKhachHang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgKhachHang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Transition.SetDecoration(this.dgKhachHang, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgKhachHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgKhachHang.EnableHeadersVisualStyles = false;
            this.dgKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgKhachHang.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgKhachHang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgKhachHang.HeaderForeColor = System.Drawing.Color.White;
            this.dgKhachHang.Location = new System.Drawing.Point(55, 110);
            this.dgKhachHang.Name = "dgKhachHang";
            this.dgKhachHang.RowHeadersVisible = false;
            this.dgKhachHang.RowHeadersWidth = 51;
            this.dgKhachHang.RowTemplate.Height = 40;
            this.dgKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKhachHang.Size = new System.Drawing.Size(1220, 710);
            this.dgKhachHang.TabIndex = 15;
            this.dgKhachHang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            this.Transition.SetDecoration(this.txtFind, BunifuAnimatorNS.DecorationType.None);
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
            this.txtFind.Location = new System.Drawing.Point(308, 31);
            this.txtFind.MaxLength = 32767;
            this.txtFind.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFind.Modified = false;
            this.txtFind.Multiline = false;
            this.txtFind.Name = "txtFind";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFind.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFind.OnIdleState = stateProperties8;
            this.txtFind.Padding = new System.Windows.Forms.Padding(3);
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFind.PlaceholderText = "Tìm kiếm tên khách hàng";
            this.txtFind.ReadOnly = false;
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFind.SelectedText = "";
            this.txtFind.SelectionLength = 0;
            this.txtFind.SelectionStart = 0;
            this.txtFind.ShortcutsEnabled = true;
            this.txtFind.Size = new System.Drawing.Size(506, 44);
            this.txtFind.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFind.TabIndex = 16;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFind.TextMarginBottom = 0;
            this.txtFind.TextMarginLeft = 3;
            this.txtFind.TextMarginTop = 1;
            this.txtFind.TextPlaceholder = "Tìm kiếm tên khách hàng";
            this.txtFind.UseSystemPasswordChar = false;
            this.txtFind.WordWrap = true;
            this.txtFind.TextChange += new System.EventHandler(this.txtFind_TextChange);
            // 
            // btnCreateRP
            // 
            this.btnCreateRP.ActiveBorderThickness = 1;
            this.btnCreateRP.ActiveCornerRadius = 20;
            this.btnCreateRP.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnCreateRP.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateRP.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnCreateRP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateRP.BackColor = System.Drawing.Color.White;
            this.btnCreateRP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateRP.BackgroundImage")));
            this.btnCreateRP.ButtonText = "Tạo báo cáo";
            this.btnCreateRP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btnCreateRP, BunifuAnimatorNS.DecorationType.None);
            this.btnCreateRP.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRP.ForeColor = System.Drawing.Color.White;
            this.btnCreateRP.IdleBorderThickness = 1;
            this.btnCreateRP.IdleCornerRadius = 20;
            this.btnCreateRP.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnCreateRP.IdleForecolor = System.Drawing.Color.White;
            this.btnCreateRP.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnCreateRP.Location = new System.Drawing.Point(1200, 25);
            this.btnCreateRP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateRP.Name = "btnCreateRP";
            this.btnCreateRP.Size = new System.Drawing.Size(100, 50);
            this.btnCreateRP.TabIndex = 20;
            this.btnCreateRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateRP.Click += new System.EventHandler(this.btnCreateRP_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frm_DoiTacKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 844);
            this.Controls.Add(this.btnCreateRP);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgKhachHang);
            this.Controls.Add(this.lblKhachHang);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DoiTacKH";
            this.Text = "frm_DoiTacKH";
            this.Load += new System.EventHandler(this.frm_DoiTacKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition Transition;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblKhachHang;
        private Bunifu.UI.WinForms.BunifuDataGridView dgKhachHang;
        private Bunifu.UI.WinForms.BunifuTextBox txtFind;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateRP;
    }
}