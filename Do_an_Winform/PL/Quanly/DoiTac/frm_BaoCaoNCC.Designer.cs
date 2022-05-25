namespace Do_an_Winform.PL.Quanly.DoiTac
{
    partial class frm_BaoCaoNCC
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
            this.rptBaoCaoNCC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptBaoCaoNCC
            // 
            this.rptBaoCaoNCC.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Quanly.DoiTac.ReportNCC.rdlc";
            this.rptBaoCaoNCC.Location = new System.Drawing.Point(3, 1);
            this.rptBaoCaoNCC.Name = "rptBaoCaoNCC";
            this.rptBaoCaoNCC.ServerReport.BearerToken = null;
            this.rptBaoCaoNCC.Size = new System.Drawing.Size(795, 449);
            this.rptBaoCaoNCC.TabIndex = 0;
            this.rptBaoCaoNCC.Load += new System.EventHandler(this.rptBaoCaoKH_Load);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataSource = typeof(Do_an_Winform.NhanVien);
            // 
            // frm_BaoCaoNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptBaoCaoNCC);
            this.Name = "frm_BaoCaoNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_BaoCaoNV";
            this.Load += new System.EventHandler(this.frm_BaoCaoKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCaoNCC;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
    }
}