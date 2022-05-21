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
        public static double ThongKeDoanhThuTheoQuy(int quyTK)
        {
            return HoaDonDAL.ThongKeDoanhThuTheoQuy(quyTK);
        }
        public static double ThongKeDoanhThuTheoThang(int thangTK)
        {
            return HoaDonDAL.ThongKeDoanhThuTheoThang(thangTK);
        }
        public static List<HoaDonDTO> GetAllBill()
        {
            return HoaDonDAL.GetAllBill();
        }
    }
}
