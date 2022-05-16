
namespace Do_an_Winform.PL.Quanly
{
    partial class frm_TKDT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TKDT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTKDT = new System.Windows.Forms.Label();
            this.panelhead = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelcontent = new Bunifu.UI.WinForms.BunifuPanel();
            this.gbxLoaiTK = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelhead.SuspendLayout();
            this.panelcontent.SuspendLayout();
            this.gbxLoaiTK.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTKDT
            // 
            this.lblTKDT.AutoSize = true;
            this.lblTKDT.Font = new System.Drawing.Font("UTM Seagull", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.lblTKDT.Location = new System.Drawing.Point(30, 16);
            this.lblTKDT.Name = "lblTKDT";
            this.lblTKDT.Size = new System.Drawing.Size(211, 28);
            this.lblTKDT.TabIndex = 59;
            this.lblTKDT.Text = "Thống kê doanh thu";
            // 
            // panelhead
            // 
            this.panelhead.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelhead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelhead.BackgroundImage")));
            this.panelhead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelhead.BorderColor = System.Drawing.Color.Transparent;
            this.panelhead.BorderRadius = 3;
            this.panelhead.BorderThickness = 1;
            this.panelhead.Controls.Add(this.bunifuPanel1);
            this.panelhead.Controls.Add(this.lblTKDT);
            this.panelhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhead.Location = new System.Drawing.Point(0, 0);
            this.panelhead.Name = "panelhead";
            this.panelhead.ShowBorders = true;
            this.panelhead.Size = new System.Drawing.Size(1459, 219);
            this.panelhead.TabIndex = 63;
            // 
            // panelcontent
            // 
            this.panelcontent.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelcontent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcontent.BackgroundImage")));
            this.panelcontent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontent.BorderColor = System.Drawing.Color.Transparent;
            this.panelcontent.BorderRadius = 3;
            this.panelcontent.BorderThickness = 1;
            this.panelcontent.Controls.Add(this.bunifuDataGridView1);
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcontent.Location = new System.Drawing.Point(0, 225);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.ShowBorders = true;
            this.panelcontent.Size = new System.Drawing.Size(1459, 629);
            this.panelcontent.TabIndex = 64;
            // 
            // gbxLoaiTK
            // 
            this.gbxLoaiTK.Controls.Add(this.txtYear);
            this.gbxLoaiTK.Controls.Add(this.comboBox4);
            this.gbxLoaiTK.Controls.Add(this.lblMonth);
            this.gbxLoaiTK.Controls.Add(this.comboBox3);
            this.gbxLoaiTK.Controls.Add(this.lblQuarter);
            this.gbxLoaiTK.Controls.Add(this.lblYear);
            this.gbxLoaiTK.Controls.Add(this.comboBox1);
            this.gbxLoaiTK.Controls.Add(this.label1);
            this.gbxLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLoaiTK.Location = new System.Drawing.Point(161, 33);
            this.gbxLoaiTK.Name = "gbxLoaiTK";
            this.gbxLoaiTK.Size = new System.Drawing.Size(438, 165);
            this.gbxLoaiTK.TabIndex = 60;
            this.gbxLoaiTK.TabStop = false;
            this.gbxLoaiTK.Text = "Chọn hình thức thống kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hình thức thống kê";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tháng",
            "Quý",
            "Năm"});
            this.comboBox1.Location = new System.Drawing.Point(172, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 60);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(112, 20);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Năm thống kê";
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(6, 95);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(39, 20);
            this.lblQuarter.TabIndex = 4;
            this.lblQuarter.Text = "Quý";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox3.Location = new System.Drawing.Point(172, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(213, 28);
            this.comboBox3.TabIndex = 5;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(6, 133);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(55, 20);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Tháng";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "Tất cả"});
            this.comboBox4.Location = new System.Drawing.Point(172, 130);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(213, 28);
            this.comboBox4.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(172, 60);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(213, 27);
            this.txtYear.TabIndex = 8;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnPrint);
            this.bunifuPanel1.Controls.Add(this.btnView);
            this.bunifuPanel1.Controls.Add(this.gbxLoaiTK);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuPanel1.Location = new System.Drawing.Point(323, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1136, 219);
            this.bunifuPanel1.TabIndex = 61;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(1459, 629);
            this.bunifuDataGridView1.TabIndex = 0;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveBorderThickness = 1;
            this.btnPrint.ActiveCornerRadius = 20;
            this.btnPrint.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnPrint.ActiveForecolor = System.Drawing.Color.White;
            this.btnPrint.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.ButtonText = "In file";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleCornerRadius = 10;
            this.btnPrint.IdleFillColor = System.Drawing.Color.White;
            this.btnPrint.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnPrint.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnPrint.Location = new System.Drawing.Point(758, 113);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 37);
            this.btnPrint.TabIndex = 66;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            this.btnView.ActiveBorderThickness = 1;
            this.btnView.ActiveCornerRadius = 20;
            this.btnView.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnView.ActiveForecolor = System.Drawing.Color.White;
            this.btnView.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnView.BackColor = System.Drawing.SystemColors.Control;
            this.btnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnView.BackgroundImage")));
            this.btnView.ButtonText = "Xem file";
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnView.IdleBorderThickness = 1;
            this.btnView.IdleCornerRadius = 10;
            this.btnView.IdleFillColor = System.Drawing.Color.White;
            this.btnView.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnView.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(234)))));
            this.btnView.Location = new System.Drawing.Point(758, 83);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 37);
            this.btnView.TabIndex = 65;
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_TKDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 854);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panelhead);
            this.Name = "frm_TKDT";
            this.Text = "frm_TKDT";
            this.panelhead.ResumeLayout(false);
            this.panelhead.PerformLayout();
            this.panelcontent.ResumeLayout(false);
            this.gbxLoaiTK.ResumeLayout(false);
            this.gbxLoaiTK.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTKDT;
        private Bunifu.UI.WinForms.BunifuPanel panelhead;
        private Bunifu.UI.WinForms.BunifuPanel panelcontent;
        private System.Windows.Forms.GroupBox gbxLoaiTK;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 btnView;
    }
}