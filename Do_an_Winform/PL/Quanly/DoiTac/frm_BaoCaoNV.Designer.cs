namespace Do_an_Winform.PL.Quanly.DoiTac
{
    partial class frm_BaoCaoNV
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
            this.rptBaoCaoNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBaoCaoNV
            // 
            this.rptBaoCaoNV.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.DoiTac.ReportNV.rdlc";
            this.rptBaoCaoNV.Location = new System.Drawing.Point(3, 1);
            this.rptBaoCaoNV.Name = "rptBaoCaoNV";
            this.rptBaoCaoNV.ServerReport.BearerToken = null;
            this.rptBaoCaoNV.Size = new System.Drawing.Size(795, 449);
            this.rptBaoCaoNV.TabIndex = 0;
            this.rptBaoCaoNV.Load += new System.EventHandler(this.rptBaoCaoNV_Load);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(Do_an_Winform.NhanVien);
            // 
            // frm_BaoCaoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBaoCaoNV);
            this.Name = "frm_BaoCaoNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_BaoCaoNV";
            this.Load += new System.EventHandler(this.frm_BaoCaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCaoNV;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
    }
}