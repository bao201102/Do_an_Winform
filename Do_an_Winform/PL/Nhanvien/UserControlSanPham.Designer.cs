﻿namespace Do_an_Winform.PL.Nhanvien
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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSanPham));
            this.dgvAllProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cbDonGia = new System.Windows.Forms.ComboBox();
<<<<<<< Updated upstream
=======
>>>>>>> 1e6951c3e3d3fdec1868c43a944d47680346cbc1
>>>>>>> Stashed changes
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThuongHieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnLoc = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllProduct
            // 
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(80, 188);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.DividerHeight = 1;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(932, 361);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(249, 144);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(180, 21);
            this.cbKhachHang.TabIndex = 5;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
=======
>>>>>>> Stashed changes
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAllProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAllProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAllProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAllProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllProduct.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllProduct.DoubleBuffered = true;
            this.dgvAllProduct.EnableHeadersVisualStyles = false;
            this.dgvAllProduct.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAllProduct.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvAllProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAllProduct.Location = new System.Drawing.Point(3, 165);
            this.dgvAllProduct.Name = "dgvAllProduct";
            this.dgvAllProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAllProduct.RowTemplate.DividerHeight = 1;
            this.dgvAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProduct.Size = new System.Drawing.Size(796, 386);
            this.dgvAllProduct.TabIndex = 3;
            // 
            // cbDonGia
            // 
            this.cbDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDonGia.AutoCompleteCustomSource.AddRange(new string[] {
            "Từ 500 -> 1 triệu",
            "Từ 1 -> 5 triệu",
            "Từ 5 -> 10 triệu",
            "Từ 10 -> 20 triệu",
            "Từ 20 -> 30 triệu",
            "Từ 30 -> 50 triệu"});
            this.cbDonGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDonGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDonGia.FormattingEnabled = true;
            this.cbDonGia.Items.AddRange(new object[] {
            "Từ 500-> 1 triệu",
            "Từ 1-> 5 triệu",
            "Từ 5-> 10 triệu",
            "Từ 10-> 20 triệu",
            "Từ 20-> 30 triệu",
            "Từ 30-> 50 triệu"});
            this.cbDonGia.Location = new System.Drawing.Point(110, 221);
            this.cbDonGia.Name = "cbDonGia";
            this.cbDonGia.Size = new System.Drawing.Size(139, 21);
            this.cbDonGia.TabIndex = 5;
            this.cbDonGia.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
<<<<<<< Updated upstream
=======
>>>>>>> 1e6951c3e3d3fdec1868c43a944d47680346cbc1
>>>>>>> Stashed changes
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(373, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(258, 30);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thương hiệu";
            // 
            // cbThuongHieu
            // 
            this.cbThuongHieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbThuongHieu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbThuongHieu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbThuongHieu.FormattingEnabled = true;
            this.cbThuongHieu.Location = new System.Drawing.Point(110, 137);
            this.cbThuongHieu.Name = "cbThuongHieu";
            this.cbThuongHieu.Size = new System.Drawing.Size(139, 21);
            this.cbThuongHieu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tìm theo tên";
            // 
            // cbTenSP
            // 
            this.cbTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(200, 84);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(301, 21);
            this.cbTenSP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loại";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(110, 304);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(139, 21);
            this.cbLoaiSP.TabIndex = 12;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnLoc);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.cbLoaiSP);
            this.bunifuPanel1.Controls.Add(this.cbThuongHieu);
            this.bunifuPanel1.Controls.Add(this.label3);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.cbDonGia);
            this.bunifuPanel1.Location = new System.Drawing.Point(805, 80);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(264, 471);
            this.bunifuPanel1.TabIndex = 13;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(96, 29);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(71, 32);
            this.bunifuLabel1.TabIndex = 13;
            this.bunifuLabel1.Text = "Bộ lọc";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnLoc
            // 
            this.btnLoc.ActiveBorderThickness = 1;
            this.btnLoc.ActiveCornerRadius = 20;
            this.btnLoc.ActiveFillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoc.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLoc.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoc.BackColor = System.Drawing.Color.White;
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
            this.btnLoc.Location = new System.Drawing.Point(147, 393);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(102, 44);
            this.btnLoc.TabIndex = 32;
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTenSP);
            this.Controls.Add(this.dgvAllProduct);
            this.Controls.Add(this.lbl1);
            this.Name = "UserControlSanPham";
            this.Size = new System.Drawing.Size(1072, 590);
            this.Load += new System.EventHandler(this.UserControlSanPham_Load);
<<<<<<< Updated upstream
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
=======
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
>>>>>>> 1e6951c3e3d3fdec1868c43a944d47680346cbc1
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAllProduct;
        private System.Windows.Forms.ComboBox cbDonGia;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThuongHieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoc;
    }
}
