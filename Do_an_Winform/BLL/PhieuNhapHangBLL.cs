using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    class PhieuNhapHangBLL
    {
        public static List<PhieuNhapHangDTO> ThongKeTatCaPN(DateTime startday, DateTime endday)
        {
            return PhieuNhapHangDAL.ThongKeTatCaPN(startday, endday);
        }
        public static List<PhieuNhapHangDTO> ThongKeTheoMaPN(PhieuNhapHangDTO pnsearch, DateTime startday, DateTime endday)
        {
            return PhieuNhapHangDAL.ThongKeTheoMaPN(pnsearch, startday, endday);
        }
        public static double ThongKeChiPhiTheoTDHT(DateTime today)
        {
            return PhieuNhapHangDAL.ThongKeChiPhiTheoTDHT(today);
        }
        public static double ThongKeChiPhiTheoQuy(int quyTK)
        {
            return PhieuNhapHangDAL.ThongKeChiPhiTheoQuy(quyTK);
        }
        public static double ThongKeChiPhiTheoThang(int thangTK)
        {
            return PhieuNhapHangDAL.ThongKeChiPhiTheoThang(thangTK);
        }

    }
}
