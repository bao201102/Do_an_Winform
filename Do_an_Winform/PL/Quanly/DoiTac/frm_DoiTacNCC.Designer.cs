namespace Do_an_Winform.PL.Quanly.DoiTac
{
    partial class frm_DoiTacNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiTacNCC));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.txtTimKiemNCC = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btTimKiemNCC = new System.Windows.Forms.Button();
            this.btThemNCC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgNhaCungCap = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaCungCap)).BeginInit();
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
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.Transition.SetDecoration(this.lblNhaCungCap, BunifuAnimatorNS.DecorationType.None);
            this.lblNhaCungCap.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.lblNhaCungCap.Location = new System.Drawing.Point(36, 30);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(238, 28);
            this.lblNhaCungCap.TabIndex = 2;
            this.lblNhaCungCap.Text = "Danh sách nhà cung cấp";
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.AcceptsReturn = false;
            this.txtTimKiemNCC.AcceptsTab = false;
            this.txtTimKiemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemNCC.AnimationSpeed = 200;
            this.txtTimKiemNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiemNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiemNCC.AutoSizeHeight = true;
            this.txtTimKiemNCC.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimKiemNCC.BackgroundImage")));
            this.txtTimKiemNCC.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTimKiemNCC.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTimKiemNCC.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTimKiemNCC.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTimKiemNCC.BorderRadius = 15;
            this.txtTimKiemNCC.BorderThickness = 1;
            this.txtTimKiemNCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.txtTimKiemNCC, BunifuAnimatorNS.DecorationType.None);
            this.txtTimKiemNCC.DefaultFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNCC.DefaultText = "";
            this.txtTimKiemNCC.FillColor = System.Drawing.Color.White;
            this.txtTimKiemNCC.HideSelection = true;
            this.txtTimKiemNCC.IconLeft = null;
            this.txtTimKiemNCC.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNCC.IconPadding = 10;
            this.txtTimKiemNCC.IconRight = null;
            this.txtTimKiemNCC.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNCC.Lines = new string[0];
            this.txtTimKiemNCC.Location = new System.Drawing.Point(279, 30);
            this.txtTimKiemNCC.MaxLength = 32767;
            this.txtTimKiemNCC.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTimKiemNCC.Modified = false;
            this.txtTimKiemNCC.Multiline = false;
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemNCC.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemNCC.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemNCC.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemNCC.OnIdleState = stateProperties4;
            this.txtTimKiemNCC.Padding = new System.Windows.Forms.Padding(3);
            this.txtTimKiemNCC.PasswordChar = '\0';
            this.txtTimKiemNCC.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiemNCC.PlaceholderText = "Tìm kiếm tên nhà cung cấp";
            this.txtTimKiemNCC.ReadOnly = false;
            this.txtTimKiemNCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiemNCC.SelectedText = "";
            this.txtTimKiemNCC.SelectionLength = 0;
            this.txtTimKiemNCC.SelectionStart = 0;
            this.txtTimKiemNCC.ShortcutsEnabled = true;
            this.txtTimKiemNCC.Size = new System.Drawing.Size(506, 44);
            this.txtTimKiemNCC.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTimKiemNCC.TabIndex = 7;
            this.txtTimKiemNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemNCC.TextMarginBottom = 0;
            this.txtTimKiemNCC.TextMarginLeft = 3;
            this.txtTimKiemNCC.TextMarginTop = 1;
            this.txtTimKiemNCC.TextPlaceholder = "Tìm kiếm tên nhà cung cấp";
            this.txtTimKiemNCC.UseSystemPasswordChar = false;
            this.txtTimKiemNCC.WordWrap = true;
            // 
            // btTimKiemNCC
            // 
            this.btTimKiemNCC.BackgroundImage = global::Do_an_Winform.Properties.Resources.search;
            this.btTimKiemNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.btTimKiemNCC, BunifuAnimatorNS.DecorationType.None);
            this.btTimKiemNCC.Location = new System.Drawing.Point(790, 30);
            this.btTimKiemNCC.Margin = new System.Windows.Forms.Padding(2);
            this.btTimKiemNCC.Name = "btTimKiemNCC";
            this.btTimKiemNCC.Size = new System.Drawing.Size(40, 44);
            this.btTimKiemNCC.TabIndex = 8;
            this.btTimKiemNCC.UseVisualStyleBackColor = true;
            this.btTimKiemNCC.Click += new System.EventHandler(this.btTimKiemNCC_Click);
            // 
            // btThemNCC
            // 
            this.btThemNCC.ActiveBorderThickness = 1;
            this.btThemNCC.ActiveCornerRadius = 20;
            this.btThemNCC.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNCC.ActiveForecolor = System.Drawing.Color.White;
            this.btThemNCC.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemNCC.BackColor = System.Drawing.SystemColors.Control;
            this.btThemNCC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThemNCC.BackgroundImage")));
            this.btThemNCC.ButtonText = "Thêm";
            this.btThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btThemNCC, BunifuAnimatorNS.DecorationType.None);
            this.btThemNCC.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNCC.ForeColor = System.Drawing.Color.White;
            this.btThemNCC.IdleBorderThickness = 1;
            this.btThemNCC.IdleCornerRadius = 20;
            this.btThemNCC.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNCC.IdleForecolor = System.Drawing.Color.White;
            this.btThemNCC.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNCC.Location = new System.Drawing.Point(1090, 24);
            this.btThemNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThemNCC.Name = "btThemNCC";
            this.btThemNCC.Size = new System.Drawing.Size(100, 50);
            this.btThemNCC.TabIndex = 15;
            this.btThemNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThemNCC.Click += new System.EventHandler(this.btThemNCC_Click);
            // 
            // dgNhaCungCap
            // 
            this.dgNhaCungCap.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgNhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dgNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgNhaCungCap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNhaCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNhaCungCap.ColumnHeadersHeight = 40;
            this.dgNhaCungCap.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgNhaCungCap.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgNhaCungCap.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgNhaCungCap.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgNhaCungCap.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgNhaCungCap.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgNhaCungCap.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgNhaCungCap.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgNhaCungCap.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgNhaCungCap.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgNhaCungCap.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgNhaCungCap.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgNhaCungCap.CurrentTheme.Name = null;
            this.dgNhaCungCap.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgNhaCungCap.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgNhaCungCap.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgNhaCungCap.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgNhaCungCap.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Transition.SetDecoration(this.dgNhaCungCap, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNhaCungCap.EnableHeadersVisualStyles = false;
            this.dgNhaCungCap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgNhaCungCap.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgNhaCungCap.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgNhaCungCap.HeaderForeColor = System.Drawing.Color.White;
            this.dgNhaCungCap.Location = new System.Drawing.Point(56, 111);
            this.dgNhaCungCap.Name = "dgNhaCungCap";
            this.dgNhaCungCap.RowHeadersVisible = false;
            this.dgNhaCungCap.RowHeadersWidth = 51;
            this.dgNhaCungCap.RowTemplate.Height = 40;
            this.dgNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhaCungCap.Size = new System.Drawing.Size(1221, 708);
            this.dgNhaCungCap.TabIndex = 16;
            this.dgNhaCungCap.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhaCungCap_CellClick);
            // 
            // frm_DoiTacNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 844);
            this.Controls.Add(this.dgNhaCungCap);
            this.Controls.Add(this.btThemNCC);
            this.Controls.Add(this.btTimKiemNCC);
            this.Controls.Add(this.txtTimKiemNCC);
            this.Controls.Add(this.lblNhaCungCap);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DoiTacNCC";
            this.Text = "frm_DoiTacNCC";
            ((System.ComponentModel.ISupportInitialize)(this.dgNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition Transition;
        private System.Windows.Forms.Label lblNhaCungCap;
        private Bunifu.UI.WinForms.BunifuTextBox txtTimKiemNCC;
        private System.Windows.Forms.Button btTimKiemNCC;
        private Bunifu.Framework.UI.BunifuThinButton2 btThemNCC;
        private Bunifu.UI.WinForms.BunifuDataGridView dgNhaCungCap;
    }
}