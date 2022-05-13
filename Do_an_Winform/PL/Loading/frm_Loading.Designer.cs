namespace Do_an_Winform.PL.Loading
{
    partial class frm_Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Loading));
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MyProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Leelawadee UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(69)))), ((int)(((byte)(210)))));
            this.lbl1.Location = new System.Drawing.Point(325, 96);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(168, 45);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Loading...";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyProgress
            // 
            this.MyProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyProgress.animated = false;
            this.MyProgress.animationIterval = 5;
            this.MyProgress.animationSpeed = 300;
            this.MyProgress.AutoSize = true;
            this.MyProgress.BackColor = System.Drawing.Color.Transparent;
            this.MyProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyProgress.BackgroundImage")));
            this.MyProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MyProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.MyProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(211)))), ((int)(((byte)(231)))));
            this.MyProgress.LabelVisible = true;
            this.MyProgress.LineProgressThickness = 8;
            this.MyProgress.LineThickness = 5;
            this.MyProgress.Location = new System.Drawing.Point(295, 150);
            this.MyProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MyProgress.MaxValue = 100;
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(211)))), ((int)(((byte)(231)))));
            this.MyProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.MyProgress.Size = new System.Drawing.Size(201, 201);
            this.MyProgress.TabIndex = 3;
            this.MyProgress.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(355, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 100);
            this.label1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Image = global::Do_an_Winform.Properties.Resources.icons8_smartphones_96;
            this.label3.Location = new System.Drawing.Point(348, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 82);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Do_an_Winform.Properties.Resources.hinh_anh_background_mau_sac_that_dep_034909644;
            this.ClientSize = new System.Drawing.Size(813, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Loading";
            this.Load += new System.EventHandler(this.frm_Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar MyProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}