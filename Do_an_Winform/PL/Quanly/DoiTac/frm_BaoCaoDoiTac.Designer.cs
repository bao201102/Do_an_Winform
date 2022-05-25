namespace Do_an_Winform.PL.Quanly.DoiTac
{
    partial class frm_BaoCaoDoiTac
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
            this.rptBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBaoCao
            // 
            this.rptBaoCao.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.DoiTac.ReportNV.rdlc";
            this.rptBaoCao.Location = new System.Drawing.Point(3, 1);
            this.rptBaoCao.Name = "rptBaoCao";
            this.rptBaoCao.ServerReport.BearerToken = null;
            this.rptBaoCao.Size = new System.Drawing.Size(795, 449);
            this.rptBaoCao.TabIndex = 0;
            this.rptBaoCao.Load += new System.EventHandler(this.rptBaoCaoNV_Load);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(Do_an_Winform.NhanVien);
            // 
            // frm_BaoCaoDoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBaoCao);
            this.Name = "frm_BaoCaoDoiTac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_BaoCaoDoiTac";
            this.Load += new System.EventHandler(this.frm_BaoCaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCao;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
    }
}