using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1600;
            this.Height = 900;
        }

        private void slideBtn_Click(object sender, EventArgs e)
        {

            if (sidemenu.Width == 55)
            {
                Transition.HideSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
                sidemenu.Visible = false;
                sidemenu.Width = 250;
                mainPanel.Location = new Point(260, 45);
                mainPanel.Width -= 195;
                Transition.ShowSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
            }
            else
            {
                Transition.HideSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
                sidemenu.Visible = false;
                sidemenu.Width = 55;
                mainPanel.Location = new Point(65, 45);
                subuserPanel.Visible = false;
                mainPanel.Width += 195;
                Transition.ShowSync(sidemenu, false, BunifuAnimatorNS.Animation.HorizSlide);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
