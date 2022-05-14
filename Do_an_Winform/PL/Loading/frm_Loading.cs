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

        int startpoint = 1;
        int endpoint = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MyProgress.Value == 95)
            {
                startpoint = -1;
                MyProgress.animationIterval = 4;
            }
            else if (MyProgress.Value == 10)
            {
                startpoint = +1;
                MyProgress.animationIterval = 3;
            }
            MyProgress.Value += startpoint;
            endpoint += 1;
            if (endpoint == 180)
            {
                timer1.Enabled = false;
                frm_DangNhap loginform = new frm_DangNhap();
                this.Hide();
                loginform.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
