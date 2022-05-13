using Do_an_Winform.PL.DangNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Loading
{
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void frm_Loading_Load(object sender, EventArgs e)
        {

        }
        int startpoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgress.Value = startpoint;
            if (MyProgress.Value % 2 == 0 && MyProgress.Value % 3 != 0 && MyProgress.Value % 5 != 0)
            {
                lbl1.Text = "Loading.";
            }
            else if (MyProgress.Value % 3 == 0 && MyProgress.Value % 2 != 0 && MyProgress.Value % 5 != 0)
            {
                lbl1.Text = "Loading..";
            }
            else if (MyProgress.Value % 5 == 0 && MyProgress.Value % 2 != 0 && MyProgress.Value % 3 != 0)
            {
                lbl1.Text = "Loading...";
            }
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Enabled = false;

                this.Hide();
                frm_DangNhap frmLogin = new frm_DangNhap();
                frmLogin.Show();
            }
        }
    }
}
