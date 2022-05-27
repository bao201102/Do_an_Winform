using Do_an_Winform.BLL;
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
        string maHD = "";
        public frm_XemHD(string tennv1, string ngayTao1, string maHD1)
        {
            InitializeComponent();
            tennv = tennv1;
            ngayTao = ngayTao1;
            maHD = maHD1;

            gridXemHD.AllowUserToResizeColumns = false;
            gridXemHD.AllowUserToResizeRows = false;
            gridXemHD.DataSource = ChiTietHoaDonBLL.GetAllDetailBillById(maHD);
            gridXemHD.Columns[0].Visible = false;
            gridXemHD.Columns[1].HeaderText = "Mã SP";
            gridXemHD.Columns[2].HeaderText = "Tên SP";
            gridXemHD.Columns[3].HeaderText = "Số lượng";
            gridXemHD.Columns[4].HeaderText = "Thành tiền";
            gridXemHD.Columns[5].Visible = false;
        }
        private void frm_XemHD_Load(object sender, EventArgs e)
        {
            lblTenNV.Text = tennv;
            lblNgayTao.Text = ngayTao;
            lblMaHD.Text = maHD;
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }
    }
}
