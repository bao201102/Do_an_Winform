using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_Winform.PL.Nhanvien
{
    public partial class frm_XemHD : Form
    {
        string tennv = "";
        string ngayTao = "";
        public frm_XemHD(string tennv1, string ngayTao1)
        {
            InitializeComponent();
            tennv = tennv1;
            ngayTao = ngayTao1;

            gridXemHD.AllowUserToResizeColumns = false;
            gridXemHD.AllowUserToResizeRows = false;
        }

        private void frm_XemHD_Load(object sender, EventArgs e)
        {
            lblTenNV.Text = tennv;
            lblNgayTao.Text = ngayTao;
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }
    }
}
