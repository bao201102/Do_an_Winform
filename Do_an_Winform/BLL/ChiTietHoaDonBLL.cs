using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    public class ChiTietHoaDonBLL
    {
        public static bool AddNewBillDetail(ChiTietHoaDonDTO chitiethd)
        {
            return ChiTietHoaDonDAL.AddNewBillDetail(chitiethd);
        }
        public static List<ChiTietHoaDonDTO> GetAllDetailBillById(string maHD)
        {
            return ChiTietHoaDonDAL.GetAllDetailBillById(maHD);
        }
        public static List<ChiTietHoaDonDTO> GetAllDetailBill()
        {
            return ChiTietHoaDonDAL.GetAllDetailBill();
        }
    }
}
