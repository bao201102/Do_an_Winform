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

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            txtPassword.ForeColor = Color.Black;
            txtPassword._TextBox.UseSystemPasswordChar = true;
            txtPassword._TextBox.PasswordChar = '*';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        bool seePass = true;
        private void btnEye_Click(object sender, EventArgs e)
        {
            seePass = !seePass;
            if (seePass)
            {
                txtPassword._TextBox.UseSystemPasswordChar = true;
                txtPassword._TextBox.PasswordChar = '*';
            }
            else
            {
                txtPassword._TextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
