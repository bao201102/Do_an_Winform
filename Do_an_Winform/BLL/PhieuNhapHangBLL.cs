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
        public static double ThongKeChiPhiTheoNam(string namTK)
        {
            return PhieuNhapHangDAL.ThongKeChiPhiTheoNam(namTK);
        }
        public static double ThongKeChiPhiTheoQuy(string quyTK, string namTK)
        {
            return PhieuNhapHangDAL.ThongKeChiPhiTheoQuy(quyTK, namTK);
        }
        public static double ThongKeChiPhiTheoThang(string thangTK, string namTK)
        {
            return PhieuNhapHangDAL.ThongKeChiPhiTheoThang(thangTK, namTK);
        }
        public static DateTime GetFirstDayOfMonth(string iMonth, string iYear)
        {
            return PhieuNhapHangDAL.GetFirstDayOfMonth(iMonth, iYear);
        }
        public static DateTime GetLastDayOfMonth(string iMonth, string iYear)
        {
            return PhieuNhapHangDAL.GetLastDayOfMonth(iMonth, iYear);
        }
        public static string CountMaPN()
        {
            return PhieuNhapHangDAL.CountMaPN();
        }
        public static bool AddPhieuNhap(PhieuNhapHangDTO phieuNhapHangDTO)
        {
            return PhieuNhapHangDAL.AddPhieuNhap(phieuNhapHangDTO);
        }
        public static List<PhieuNhapHangDTO> GetAll()
        {
            return PhieuNhapHangDAL.GetAll();
        }

    }
}
