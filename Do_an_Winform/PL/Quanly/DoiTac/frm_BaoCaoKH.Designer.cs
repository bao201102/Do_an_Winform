namespace Do_an_Winform.PL.Quanly.DoiTac
{
    partial class frm_BaoCaoKH
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
            this.rptBaoCaoKH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBaoCaoKH
            // 
            this.rptBaoCaoKH.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.DoiTac.ReportKH.rdlc";
            this.rptBaoCaoKH.Location = new System.Drawing.Point(3, 1);
            this.rptBaoCaoKH.Name = "rptBaoCaoKH";
            this.rptBaoCaoKH.ServerReport.BearerToken = null;
            this.rptBaoCaoKH.Size = new System.Drawing.Size(795, 449);
            this.rptBaoCaoKH.TabIndex = 0;
            this.rptBaoCaoKH.Load += new System.EventHandler(this.rptBaoCaoKH_Load);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(Do_an_Winform.NhanVien);
            // 
            // frm_BaoCaoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBaoCaoKH);
            this.Name = "frm_BaoCaoKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_BaoCaoNV";
            this.Load += new System.EventHandler(this.frm_BaoCaoKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCaoKH;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
    }
}