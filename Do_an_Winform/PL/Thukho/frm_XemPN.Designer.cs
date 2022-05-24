
namespace Do_an_Winform.PL.Thukho
{
    partial class frm_XemPN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XemPN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenNV = new Bunifu.UI.WinForms.BunifuLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblReturn = new System.Windows.Forms.Label();
            this.gridXemPN = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblNCC = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXemPN)).BeginInit();
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
            this.bunifuPanel1.Controls.Add(this.lblNCC);
            this.bunifuPanel1.Controls.Add(this.gridXemPN);
            this.bunifuPanel1.Controls.Add(this.lblDate);
            this.bunifuPanel1.Controls.Add(this.label11);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.lblTenNV);
            this.bunifuPanel1.Location = new System.Drawing.Point(13, 37);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1161, 539);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tạo";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AllowParentOverrides = false;
            this.lblTenNV.AutoEllipsis = false;
            this.lblTenNV.AutoSize = false;
            this.lblTenNV.CursorType = null;
            this.lblTenNV.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.lblTenNV.Location = new System.Drawing.Point(195, 27);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTenNV.Size = new System.Drawing.Size(212, 21);
            this.lblTenNV.TabIndex = 5;
            this.lblTenNV.Text = "Nguyễn ngọc bảo";
            this.lblTenNV.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTenNV.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(637, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nhà cung cấp";
            // 
            // lblDate
            // 
            this.lblDate.AllowParentOverrides = false;
            this.lblDate.AutoEllipsis = false;
            this.lblDate.AutoSize = false;
            this.lblDate.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.lblDate.Location = new System.Drawing.Point(195, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(212, 21);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "bunifuLabel1";
            this.lblDate.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturn.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(16, 9);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(74, 23);
            this.lblReturn.TabIndex = 39;
            this.lblReturn.Text = "< Trở lại";
            // 
            // gridXemPN
            // 
            this.gridXemPN.AllowCustomTheming = false;
            this.gridXemPN.AllowUserToAddRows = false;
            this.gridXemPN.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridXemPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridXemPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridXemPN.BackgroundColor = System.Drawing.Color.White;
            this.gridXemPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridXemPN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridXemPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridXemPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridXemPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridXemPN.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridXemPN.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridXemPN.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridXemPN.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gridXemPN.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridXemPN.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gridXemPN.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gridXemPN.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridXemPN.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gridXemPN.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridXemPN.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gridXemPN.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridXemPN.CurrentTheme.Name = null;
            this.gridXemPN.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridXemPN.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridXemPN.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridXemPN.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gridXemPN.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridXemPN.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridXemPN.EnableHeadersVisualStyles = false;
            this.gridXemPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gridXemPN.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gridXemPN.HeaderBgColor = System.Drawing.Color.Empty;
            this.gridXemPN.HeaderForeColor = System.Drawing.Color.White;
            this.gridXemPN.Location = new System.Drawing.Point(22, 184);
            this.gridXemPN.Name = "gridXemPN";
            this.gridXemPN.ReadOnly = true;
            this.gridXemPN.RowHeadersVisible = false;
            this.gridXemPN.RowTemplate.Height = 40;
            this.gridXemPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridXemPN.Size = new System.Drawing.Size(1112, 337);
            this.gridXemPN.TabIndex = 7;
            this.gridXemPN.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lblNCC
            // 
            this.lblNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblNCC.Location = new System.Drawing.Point(806, 27);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(52, 21);
            this.lblNCC.TabIndex = 8;
            this.lblNCC.Text = "label1";
            // 
            // frm_XemPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 579);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.bunifuPanel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_XemPN";
            this.Text = "frm_XemPN";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXemPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblReturn;
        internal Bunifu.UI.WinForms.BunifuLabel lblTenNV;
        internal Bunifu.UI.WinForms.BunifuLabel lblDate;
        internal Bunifu.UI.WinForms.BunifuDataGridView gridXemPN;
        internal System.Windows.Forms.Label lblNCC;
    }
}