using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Thukho
{
    public partial class frm_XemPN : Form
    {
        public frm_XemPN()
        {
            InitializeComponent();
            gridXemPN.AllowUserToResizeColumns = false;
            gridXemPN.AllowUserToResizeRows = false;
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }

        private void lblReturn_MouseHover(object sender, EventArgs e)
        {
            lblReturn.Font = new Font(lblReturn.Font, FontStyle.Underline);
        }

        private void lblReturn_MouseLeave(object sender, EventArgs e)
        {
            lblReturn.Font = new Font(lblReturn.Font, FontStyle.Regular);
        }
    }
}
