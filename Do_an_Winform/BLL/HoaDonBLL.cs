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
        public static List<HoaDonDTO> TKTheoMaHD(string hdsearch, DateTime today)
        {
            return HoaDonDAL.TKTheoMaHD(hdsearch, today);
        }
        public static HoaDonDTO LayTheoMaHD(string hdsearch)
        {
            return HoaDonDAL.LayTheoMaHD(hdsearch);
        }

        public static List<object> LayTatCaMaHD()
        {
            return HoaDonDAL.LayTatCaMaHD();
        }

        public static double DoanhThuTatCaHD(DateTime startday, DateTime endday)
        {
            return HoaDonDAL.DoanhThuTatCaHD(startday, endday);
        }

        public static double DoanhThuTheoMaHD(string hdsearch, DateTime today)
        {
            return HoaDonDAL.DoanhThuTheoMaHD(hdsearch, today);
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

        public static List<HoaDonDTO> GetAllBillById(string maHD)
        {
            return HoaDonDAL.GetAllBillById(maHD);
        }

        public static Dictionary<int, double> GetRevenueByThisMonth(DateTime time)
        {
            return HoaDonDAL.GetRevenueByThisMonth(time);
        }

        public static Dictionary<int, double> GetRevenueByThisYear(DateTime time)
        {
            return HoaDonDAL.GetRevenueByThisYear(time);
        }

        public static int CountBillThisMonth(DateTime time)
        {
            return HoaDonDAL.CountBillThisMonth(time);
        }

        public static int CountBillThisYear(DateTime time)
        {
            return HoaDonDAL.CountBillThisYear(time);
        }

        public static int CountRejectedBillThisMonth(DateTime time)
        {
            return HoaDonDAL.CountRejectedBillThisMonth(time);
        }

        public static int CountRejectedBillThisYear(DateTime time)
        {
            return HoaDonDAL.CountRejectedBillThisYear(time);
        }
    }
}
