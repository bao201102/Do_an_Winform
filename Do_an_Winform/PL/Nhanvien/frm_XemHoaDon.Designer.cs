namespace Do_an_Winform.PL.Nhanvien
{
    partial class frm_XemHoaDon
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
            this.rptHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptHoaDon
            // 
            this.rptHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHoaDon.LocalReport.ReportEmbeddedResource = "Do_an_Winform.PL.Nhanvien.rpt_HoaDon.rdlc";
            this.rptHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rptHoaDon.Name = "rptHoaDon";
            this.rptHoaDon.ServerReport.BearerToken = null;
            this.rptHoaDon.Size = new System.Drawing.Size(800, 450);
            this.rptHoaDon.TabIndex = 0;
            this.rptHoaDon.Load += new System.EventHandler(this.rptHoaDon_Load);
            // 
            // frm_XemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptHoaDon);
            this.Name = "frm_XemHoaDon";
            this.Text = "frm_XemHoaDon";
            this.Load += new System.EventHandler(this.frm_XemHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptHoaDon;
    }
}