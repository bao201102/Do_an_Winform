
namespace Do_an_Winform
{
    partial class frm_ThuKho_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThuKho_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOverview = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnStoreKeeper = new System.Windows.Forms.Button();
            this.panelStorekeeperSub = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panelSettingSub = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelStorekeeperSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panelSettingSub);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.panelStorekeeperSub);
            this.panel1.Controls.Add(this.btnStoreKeeper);
            this.panel1.Controls.Add(this.btnOverview);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 508);
            this.panel1.TabIndex = 0;
            // 
            // btnOverview
            // 
            this.btnOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.Image = ((System.Drawing.Image)(resources.GetObject("btnOverview.Image")));
            this.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.Location = new System.Drawing.Point(0, 107);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(278, 46);
            this.btnOverview.TabIndex = 1;
            this.btnOverview.TabStop = false;
            this.btnOverview.Text = "   Tổng quan";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOverview.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 107);
            this.panel2.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.Location = new System.Drawing.Point(297, 11);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(766, 485);
            this.panelChildForm.TabIndex = 1;
            // 
            // btnStoreKeeper
            // 
            this.btnStoreKeeper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStoreKeeper.FlatAppearance.BorderSize = 0;
            this.btnStoreKeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreKeeper.Location = new System.Drawing.Point(0, 153);
            this.btnStoreKeeper.Name = "btnStoreKeeper";
            this.btnStoreKeeper.Size = new System.Drawing.Size(278, 46);
            this.btnStoreKeeper.TabIndex = 2;
            this.btnStoreKeeper.TabStop = false;
            this.btnStoreKeeper.Text = "Thủ kho";
            this.btnStoreKeeper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreKeeper.UseVisualStyleBackColor = true;
            this.btnStoreKeeper.Click += new System.EventHandler(this.btnStoreKeeper_Click);
            // 
            // panelStorekeeperSub
            // 
            this.panelStorekeeperSub.Controls.Add(this.button1);
            this.panelStorekeeperSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStorekeeperSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStorekeeperSub.Location = new System.Drawing.Point(0, 199);
            this.panelStorekeeperSub.Margin = new System.Windows.Forms.Padding(4);
            this.panelStorekeeperSub.Name = "panelStorekeeperSub";
            this.panelStorekeeperSub.Size = new System.Drawing.Size(278, 142);
            this.panelStorekeeperSub.TabIndex = 3;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(0, 341);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(278, 46);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // panelSettingSub
            // 
            this.panelSettingSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSettingSub.Location = new System.Drawing.Point(0, 387);
            this.panelSettingSub.Margin = new System.Windows.Forms.Padding(4);
            this.panelSettingSub.Name = "panelSettingSub";
            this.panelSettingSub.Size = new System.Drawing.Size(278, 90);
            this.panelSettingSub.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(278, 46);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Nhập hàng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ThuKho_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1077, 508);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThuKho_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelStorekeeperSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelSettingSub;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelStorekeeperSub;
        private System.Windows.Forms.Button btnStoreKeeper;
        private System.Windows.Forms.Button button1;
    }
}