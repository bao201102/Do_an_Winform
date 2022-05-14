using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.DangNhap
{
    public partial class MessBox : Form
    {
        bool result;
        public MessBox()
        {
            InitializeComponent();
        }

        public bool ShowMess(string text)
        {
            lblText.Text = text;
            this.ShowDialog();
            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}
