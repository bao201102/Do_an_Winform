
namespace Do_an_Winform.PL.Nhanvien
{
    partial class frm_XemHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XemHD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblNgayTao = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTenNV = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.gridXemHD = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblBillId = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblMaHD = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXemHD)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuPanel1.BorderRadius = 15;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblMaHD);
            this.bunifuPanel1.Controls.Add(this.lblBillId);
            this.bunifuPanel1.Controls.Add(this.lblNgayTao);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel1.Controls.Add(this.lblTenNV);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.gridXemHD);
            this.bunifuPanel1.Location = new System.Drawing.Point(5, 35);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1033, 519);
            this.bunifuPanel1.TabIndex = 42;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AllowParentOverrides = false;
            this.lblNgayTao.AutoEllipsis = false;
            this.lblNgayTao.CursorType = null;
            this.lblNgayTao.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTao.Location = new System.Drawing.Point(214, 84);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNgayTao.Size = new System.Drawing.Size(32, 21);
            this.lblNgayTao.TabIndex = 12;
            this.lblNgayTao.Text = "Date";
            this.lblNgayTao.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNgayTao.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(67, 84);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(66, 21);
            this.bunifuLabel3.TabIndex = 11;
            this.bunifuLabel3.Text = "Ngày tạo:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AllowParentOverrides = false;
            this.lblTenNV.AutoEllipsis = false;
            this.lblTenNV.CursorType = null;
            this.lblTenNV.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(214, 36);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTenNV.Size = new System.Drawing.Size(42, 21);
            this.lblTenNV.TabIndex = 10;
            this.lblTenNV.Text = "Name";
            this.lblTenNV.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTenNV.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(67, 36);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(74, 21);
            this.bunifuLabel1.TabIndex = 9;
            this.bunifuLabel1.Text = "Nhân viên:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // gridXemHD
            // 
            this.gridXemHD.AllowCustomTheming = false;
            this.gridXemHD.AllowUserToAddRows = false;
            this.gridXemHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridXemHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridXemHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridXemHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridXemHD.BackgroundColor = System.Drawing.Color.White;
            this.gridXemHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridXemHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridXemHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridXemHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridXemHD.ColumnHeadersHeight = 40;
            this.gridXemHD.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridXemHD.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridXemHD.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridXemHD.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gridXemHD.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridXemHD.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gridXemHD.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gridXemHD.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridXemHD.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gridXemHD.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridXemHD.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gridXemHD.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridXemHD.CurrentTheme.Name = null;
            this.gridXemHD.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridXemHD.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridXemHD.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridXemHD.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gridXemHD.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridXemHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridXemHD.EnableHeadersVisualStyles = false;
            this.gridXemHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gridXemHD.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gridXemHD.HeaderBgColor = System.Drawing.Color.Empty;
            this.gridXemHD.HeaderForeColor = System.Drawing.Color.White;
            this.gridXemHD.Location = new System.Drawing.Point(11, 142);
            this.gridXemHD.Name = "gridXemHD";
            this.gridXemHD.ReadOnly = true;
            this.gridXemHD.RowHeadersVisible = false;
            this.gridXemHD.RowTemplate.Height = 40;
            this.gridXemHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridXemHD.Size = new System.Drawing.Size(1010, 359);
            this.gridXemHD.TabIndex = 8;
            this.gridXemHD.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturn.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(12, 9);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(74, 23);
            this.lblReturn.TabIndex = 43;
            this.lblReturn.Text = "< Trở lại";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // lblBillId
            // 
            this.lblBillId.AllowParentOverrides = false;
            this.lblBillId.AutoEllipsis = false;
            this.lblBillId.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBillId.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblBillId.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.Location = new System.Drawing.Point(606, 36);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBillId.Size = new System.Drawing.Size(87, 21);
            this.lblBillId.TabIndex = 13;
            this.lblBillId.Text = "Mã hóa đơn:";
            this.lblBillId.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBillId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AllowParentOverrides = false;
            this.lblMaHD.AutoEllipsis = false;
            this.lblMaHD.CursorType = null;
            this.lblMaHD.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(795, 36);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMaHD.Size = new System.Drawing.Size(40, 21);
            this.lblMaHD.TabIndex = 14;
            this.lblMaHD.Text = "Bill ID";
            this.lblMaHD.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMaHD.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frm_XemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 557);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "frm_XemHD";
            this.Text = "frm_XemHDon";
            this.Load += new System.EventHandler(this.frm_XemHD_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXemHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblNgayTao;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel lblTenNV;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        internal Bunifu.UI.WinForms.BunifuDataGridView gridXemHD;
        private System.Windows.Forms.Label lblReturn;
        private Bunifu.UI.WinForms.BunifuLabel lblMaHD;
        private Bunifu.UI.WinForms.BunifuLabel lblBillId;
    }
}