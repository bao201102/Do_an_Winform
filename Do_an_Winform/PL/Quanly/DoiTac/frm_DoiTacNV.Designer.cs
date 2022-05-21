namespace Do_an_Winform.PL.Quanly.DoiTac
{
    partial class frm_DoiTacNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiTacNV));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtTimKiemNhanVien = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btTimKiemNhanVien = new System.Windows.Forms.Button();
            this.btThemNV = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgNhanVien = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
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
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.Transition.SetDecoration(this.lblNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.lblNhanVien.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.lblNhanVien.Location = new System.Drawing.Point(36, 30);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(206, 28);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Danh sách nhân viên";
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.AcceptsReturn = false;
            this.txtTimKiemNhanVien.AcceptsTab = false;
            this.txtTimKiemNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemNhanVien.AnimationSpeed = 200;
            this.txtTimKiemNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiemNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiemNhanVien.AutoSizeHeight = true;
            this.txtTimKiemNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimKiemNhanVien.BackgroundImage")));
            this.txtTimKiemNhanVien.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTimKiemNhanVien.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTimKiemNhanVien.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTimKiemNhanVien.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTimKiemNhanVien.BorderRadius = 15;
            this.txtTimKiemNhanVien.BorderThickness = 1;
            this.txtTimKiemNhanVien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.txtTimKiemNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.txtTimKiemNhanVien.DefaultFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanVien.DefaultText = "";
            this.txtTimKiemNhanVien.FillColor = System.Drawing.Color.White;
            this.txtTimKiemNhanVien.HideSelection = true;
            this.txtTimKiemNhanVien.IconLeft = null;
            this.txtTimKiemNhanVien.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanVien.IconPadding = 10;
            this.txtTimKiemNhanVien.IconRight = null;
            this.txtTimKiemNhanVien.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNhanVien.Lines = new string[0];
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(258, 30);
            this.txtTimKiemNhanVien.MaxLength = 32767;
            this.txtTimKiemNhanVien.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTimKiemNhanVien.Modified = false;
            this.txtTimKiemNhanVien.Multiline = false;
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemNhanVien.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemNhanVien.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemNhanVien.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiemNhanVien.OnIdleState = stateProperties4;
            this.txtTimKiemNhanVien.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtTimKiemNhanVien.PasswordChar = '\0';
            this.txtTimKiemNhanVien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiemNhanVien.PlaceholderText = "Tìm kiếm tên nhân viên";
            this.txtTimKiemNhanVien.ReadOnly = false;
            this.txtTimKiemNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiemNhanVien.SelectedText = "";
            this.txtTimKiemNhanVien.SelectionLength = 0;
            this.txtTimKiemNhanVien.SelectionStart = 0;
            this.txtTimKiemNhanVien.ShortcutsEnabled = true;
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(506, 44);
            this.txtTimKiemNhanVien.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTimKiemNhanVien.TabIndex = 5;
            this.txtTimKiemNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemNhanVien.TextMarginBottom = 0;
            this.txtTimKiemNhanVien.TextMarginLeft = 3;
            this.txtTimKiemNhanVien.TextMarginTop = 1;
            this.txtTimKiemNhanVien.TextPlaceholder = "Tìm kiếm tên nhân viên";
            this.txtTimKiemNhanVien.UseSystemPasswordChar = false;
            this.txtTimKiemNhanVien.WordWrap = true;
            // 
            // btTimKiemNhanVien
            // 
            this.btTimKiemNhanVien.BackgroundImage = global::Do_an_Winform.Properties.Resources.search;
            this.btTimKiemNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.btTimKiemNhanVien, BunifuAnimatorNS.DecorationType.None);
            this.btTimKiemNhanVien.Location = new System.Drawing.Point(770, 30);
            this.btTimKiemNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTimKiemNhanVien.Name = "btTimKiemNhanVien";
            this.btTimKiemNhanVien.Size = new System.Drawing.Size(40, 44);
            this.btTimKiemNhanVien.TabIndex = 6;
            this.btTimKiemNhanVien.UseVisualStyleBackColor = true;
            this.btTimKiemNhanVien.Click += new System.EventHandler(this.btTimKiemNhanVien_Click);
            // 
            // btThemNV
            // 
            this.btThemNV.ActiveBorderThickness = 1;
            this.btThemNV.ActiveCornerRadius = 20;
            this.btThemNV.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNV.ActiveForecolor = System.Drawing.Color.White;
            this.btThemNV.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(68)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThemNV.BackColor = System.Drawing.Color.White;
            this.btThemNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThemNV.BackgroundImage")));
            this.btThemNV.ButtonText = "Thêm";
            this.btThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.btThemNV, BunifuAnimatorNS.DecorationType.None);
            this.btThemNV.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.ForeColor = System.Drawing.Color.White;
            this.btThemNV.IdleBorderThickness = 1;
            this.btThemNV.IdleCornerRadius = 20;
            this.btThemNV.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNV.IdleForecolor = System.Drawing.Color.White;
            this.btThemNV.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btThemNV.Location = new System.Drawing.Point(1090, 24);
            this.btThemNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(100, 50);
            this.btThemNV.TabIndex = 13;
            this.btThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btThemNV.Click += new System.EventHandler(this.btThemNV_Click);
            // 
            // dgNhanVien
            // 
            this.dgNhanVien.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNhanVien.ColumnHeadersHeight = 40;
            this.dgNhanVien.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgNhanVien.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgNhanVien.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgNhanVien.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgNhanVien.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgNhanVien.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgNhanVien.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgNhanVien.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgNhanVien.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgNhanVien.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgNhanVien.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgNhanVien.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgNhanVien.CurrentTheme.Name = null;
            this.dgNhanVien.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgNhanVien.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgNhanVien.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgNhanVien.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgNhanVien.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Transition.SetDecoration(this.dgNhanVien, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNhanVien.EnableHeadersVisualStyles = false;
            this.dgNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgNhanVien.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgNhanVien.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.dgNhanVien.Location = new System.Drawing.Point(56, 111);
            this.dgNhanVien.Name = "dgNhanVien";
            this.dgNhanVien.RowHeadersVisible = false;
            this.dgNhanVien.RowHeadersWidth = 51;
            this.dgNhanVien.RowTemplate.Height = 40;
            this.dgNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhanVien.Size = new System.Drawing.Size(1221, 708);
            this.dgNhanVien.TabIndex = 14;
            this.dgNhanVien.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanVien_CellClick);
            // 
            // frm_DoiTacNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 844);
            this.Controls.Add(this.dgNhanVien);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.btTimKiemNhanVien);
            this.Controls.Add(this.txtTimKiemNhanVien);
            this.Controls.Add(this.lblNhanVien);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_DoiTacNV";
            this.Text = "frm_DoiTacNV";
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition Transition;
        private System.Windows.Forms.Label lblNhanVien;
        private Bunifu.UI.WinForms.BunifuTextBox txtTimKiemNhanVien;
        private System.Windows.Forms.Button btTimKiemNhanVien;
        private Bunifu.Framework.UI.BunifuThinButton2 btThemNV;
        private Bunifu.UI.WinForms.BunifuDataGridView dgNhanVien;
    }
}