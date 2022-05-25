using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    class HoaDonBLL
    {
        public static bool AddNewBill(HoaDonDTO hoaDon)
        {
            return HoaDonDAL.AddNewBill(hoaDon);
        }
        public static List<HoaDonDTO> ThongKeTatCaHD(DateTime startday, DateTime endday)
        {
            return HoaDonDAL.ThongKeTatCaHD(startday, endday);
        }
        public static List<HoaDonDTO> ThongKeTheoMaHD(HoaDonDTO hdsearch, DateTime startday, DateTime endday)
        {
            return HoaDonDAL.ThongKeTheoMaHD(hdsearch, startday, endday);
        }
        public static HoaDonDTO LayTheoMaHD(string hdsearch)
        {
            return HoaDonDAL.LayTheoMaHD(hdsearch);
        }
        public static List<string> LayTatCaMaHD()
        {
            return HoaDonDAL.LayTatCaMaHD();
        }
        public static double DoanhThuTatCaHD(DateTime startday, DateTime endday)
        {
            return HoaDonDAL.DoanhThuTatCaHD(startday, endday);
        }
        public static double DoanhThuTheoMaHD(HoaDonDTO hdsearch, DateTime startday, DateTime endday)
        {
            return HoaDonDAL.DoanhThuTheoMaHD(hdsearch, startday, endday);
        }
        public static double ThongKeDoanhThuTheoTDHT(DateTime today)
        {
            return HoaDonDAL.ThongKeDoanhThuTheoTDHT(today);
        }
        public static double ThongKeDoanhThuTheoNam(string namTK)
        {
            return HoaDonDAL.ThongKeDoanhThuTheoNam(namTK);
        }
        public static double ThongKeDoanhThuTheoQuy(string quyTK, string namTK)
        {
            return HoaDonDAL.ThongKeDoanhThuTheoQuy(quyTK, namTK);
        }
        public static double ThongKeDoanhThuTheoThang(string thangTK, string namTK)
        {
            return HoaDonDAL.ThongKeDoanhThuTheoThang(thangTK, namTK);
        }
        public static DateTime GetFirstDayOfMonth(string iMonth, string iYear)
        {
            return HoaDonDAL.GetFirstDayOfMonth(iMonth, iYear);
        }
        public static DateTime GetLastDayOfMonth(string iMonth, string iYear)
        {
            return HoaDonDAL.GetLastDayOfMonth(iMonth, iYear);
        }
        public static List<HoaDonDTO> GetAllBill()
        {
            return HoaDonDAL.GetAllBill();
        }
        public static bool EditBill(HoaDonDTO hd)
        {
            return HoaDonDAL.EditBill(hd);
        }
    }
}
