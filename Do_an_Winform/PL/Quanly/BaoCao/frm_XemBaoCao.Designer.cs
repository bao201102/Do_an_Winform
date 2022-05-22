
namespace Do_an_Winform.PL.Quanly.BaoCao
{
    partial class frm_XemBaoCao
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
            this.reportViewerResult = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerResult
            // 
            this.reportViewerResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerResult.Location = new System.Drawing.Point(0, 0);
            this.reportViewerResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewerResult.Name = "reportViewerResult";
            this.reportViewerResult.ServerReport.BearerToken = null;
            this.reportViewerResult.Size = new System.Drawing.Size(871, 556);
            this.reportViewerResult.TabIndex = 0;
            // 
            // frm_XemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 556);
            this.Controls.Add(this.reportViewerResult);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_XemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_XemBaoCao";
            this.Load += new System.EventHandler(this.frm_XemBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerResult;
    }
}