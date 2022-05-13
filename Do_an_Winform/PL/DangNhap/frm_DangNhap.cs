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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        //private void label3_Click(object sender, EventArgs e)
        //{
        //    DialogResult result;
        //    result = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    DialogResult result;
        //    result = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}
        //bool seePass = false;
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    seePass = !seePass;
        //    if (seePass)
        //    {
        //        button2.BackgroundImage = Properties.Resources.icons8_eyelashes_2d_32;
        //        txtPassword.UseSystemPasswordChar = false; ;
        //    }
        //    else
        //    {
        //        button2.BackgroundImage = Properties.Resources.eye_icon;
        //        txtPassword.UseSystemPasswordChar = true;
        //    }
        //}

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
