using Do_an_Winform.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace Do_an_Winform.DTO
{
    public partial class frm_HDBH : Form
    {
        public frm_HDBH()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm mã hóa đơn")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm mã hóa đơn";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void frm_HDBH_Load(object sender, EventArgs e)
        {
            //load Date
            maskedtxtStartDay.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");
            maskedtxtEndDay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            //load Datagridview
            DateTime startday, endday;
            startday = DateTime.ParseExact(maskedtxtStartDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            endday = DateTime.ParseExact(maskedtxtEndDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            List<HoaDonDTO> listhd = HoaDonDAL.ThongKeTatCaHD(startday, endday);
            gvHDBH.DataSource = listhd;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startday, endday;
            startday = DateTime.ParseExact(maskedtxtStartDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            endday = DateTime.ParseExact(maskedtxtEndDay.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            if (txtSearch.Text.Trim() != "")
            {
                HoaDonDTO hdsearch = new HoaDonDTO();
                hdsearch.MaHD = txtSearch.Text;

                List<HoaDonDTO> listhd = HoaDonDAL.ThongKeTheoMaHD(hdsearch, startday, endday);
                gvHDBH.DataSource = listhd;
            }
            else
            {
                List<HoaDonDTO> listhd = HoaDonDAL.ThongKeTatCaHD(startday, endday);
                gvHDBH.DataSource = listhd;
            }
        }

        //Print gvHDBH
        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = gvHDBH.Height;
            gvHDBH.Height = gvHDBH.RowCount * gvHDBH.RowTemplate.Height * 2;
            bmp = new Bitmap(gvHDBH.Width, gvHDBH.Height);
            gvHDBH.DrawToBitmap(bmp, new Rectangle(0, 0, gvHDBH.Width, gvHDBH.Height));
            gvHDBH.Height = height;
            printPreviewDialogHDBH.ShowDialog();
        }

        private void printHDBH_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printPreviewDialogHDBH_Load(object sender, EventArgs e)
        {

        }
    }
}