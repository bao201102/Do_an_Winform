namespace Do_an_Winform.PL.Nhanvien
{
    partial class UserControlKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlKhachHang));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvAllCustomer = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.cbTenKhachHang = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomer)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lbl1.Location = new System.Drawing.Point(421, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(278, 32);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Danh Sách Khách Hàng";
            // 
            // dgvAllCustomer
            // 
            this.dgvAllCustomer.AllowCustomTheming = false;
            this.dgvAllCustomer.AllowUserToAddRows = false;
            this.dgvAllCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllCustomer.ColumnHeadersHeight = 40;
            this.dgvAllCustomer.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAllCustomer.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllCustomer.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomer.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllCustomer.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomer.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAllCustomer.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllCustomer.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAllCustomer.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllCustomer.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllCustomer.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvAllCustomer.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAllCustomer.CurrentTheme.Name = null;
            this.dgvAllCustomer.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllCustomer.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAllCustomer.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAllCustomer.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAllCustomer.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllCustomer.EnableHeadersVisualStyles = false;
            this.dgvAllCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAllCustomer.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAllCustomer.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAllCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAllCustomer.Location = new System.Drawing.Point(14, 223);
            this.dgvAllCustomer.Name = "dgvAllCustomer";
            this.dgvAllCustomer.ReadOnly = true;
            this.dgvAllCustomer.RowHeadersVisible = false;
            this.dgvAllCustomer.RowTemplate.Height = 40;
            this.dgvAllCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllCustomer.Size = new System.Drawing.Size(1115, 341);
            this.dgvAllCustomer.TabIndex = 6;
            this.dgvAllCustomer.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.cbTenKhachHang);
            this.bunifuPanel1.Controls.Add(this.lbl1);
            this.bunifuPanel1.Controls.Add(this.dgvAllCustomer);
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1143, 579);
            this.bunifuPanel1.TabIndex = 7;
            // 
            // cbTenKhachHang
            // 
            this.cbTenKhachHang.AcceptsReturn = false;
            this.cbTenKhachHang.AcceptsTab = false;
            this.cbTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTenKhachHang.AnimationSpeed = 200;
            this.cbTenKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTenKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cbTenKhachHang.AutoSizeHeight = true;
            this.cbTenKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cbTenKhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbTenKhachHang.BackgroundImage")));
            this.cbTenKhachHang.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.cbTenKhachHang.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbTenKhachHang.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.cbTenKhachHang.BorderColorIdle = System.Drawing.Color.Silver;
            this.cbTenKhachHang.BorderRadius = 15;
            this.cbTenKhachHang.BorderThickness = 1;
            this.cbTenKhachHang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTenKhachHang.DefaultFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenKhachHang.DefaultText = "";
            this.cbTenKhachHang.FillColor = System.Drawing.Color.White;
            this.cbTenKhachHang.HideSelection = true;
            this.cbTenKhachHang.IconLeft = null;
            this.cbTenKhachHang.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTenKhachHang.IconPadding = 10;
            this.cbTenKhachHang.IconRight = global::Do_an_Winform.Properties.Resources.search;
            this.cbTenKhachHang.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.cbTenKhachHang.Lines = new string[0];
            this.cbTenKhachHang.Location = new System.Drawing.Point(316, 133);
            this.cbTenKhachHang.MaxLength = 32767;
            this.cbTenKhachHang.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbTenKhachHang.Modified = false;
            this.cbTenKhachHang.Multiline = false;
            this.cbTenKhachHang.Name = "cbTenKhachHang";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cbTenKhachHang.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.cbTenKhachHang.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cbTenKhachHang.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.cbTenKhachHang.OnIdleState = stateProperties4;
            this.cbTenKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.cbTenKhachHang.PasswordChar = '\0';
            this.cbTenKhachHang.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.cbTenKhachHang.PlaceholderText = "Tìm kiếm tên khách hàng";
            this.cbTenKhachHang.ReadOnly = false;
            this.cbTenKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cbTenKhachHang.SelectedText = "";
            this.cbTenKhachHang.SelectionLength = 0;
            this.cbTenKhachHang.SelectionStart = 0;
            this.cbTenKhachHang.ShortcutsEnabled = true;
            this.cbTenKhachHang.Size = new System.Drawing.Size(538, 44);
            this.cbTenKhachHang.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.cbTenKhachHang.TabIndex = 7;
            this.cbTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cbTenKhachHang.TextMarginBottom = 0;
            this.cbTenKhachHang.TextMarginLeft = 3;
            this.cbTenKhachHang.TextMarginTop = 1;
            this.cbTenKhachHang.TextPlaceholder = "Tìm kiếm tên khách hàng";
            this.cbTenKhachHang.UseSystemPasswordChar = false;
            this.cbTenKhachHang.WordWrap = true;
            this.cbTenKhachHang.TextChange += new System.EventHandler(this.cbTenKhachHang_TextChanged);
            // 
            // UserControlKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "UserControlKhachHang";
            this.Size = new System.Drawing.Size(1149, 585);
            this.Load += new System.EventHandler(this.UserControlKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomer)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvAllCustomer;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox cbTenKhachHang;
    }
}
