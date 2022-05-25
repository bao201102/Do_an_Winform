using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    public class LoaiSanPhamBLL
    {
        public static LoaiSanPhamDTO GetProTypeById(string maLoaiSP)
        {
            return LoaiSanPhamDAL.GetProTypeById(maLoaiSP);
        }

        public static List<LoaiSanPhamDTO> GetAllCat()
        {
            return LoaiSanPhamDAL.GetAllCat();
        }

        public static Dictionary<string, double> GetTopProductCatByDay(DateTime time)
        {
            return LoaiSanPhamDAL.GetTopProductCatByDay(time);
        }

        public static Dictionary<string, double> GetTopProductCatByMonth(DateTime time)
        {
            return LoaiSanPhamDAL.GetTopProductCatByMonth(time);
        }

        public static Dictionary<string, double> GetTopProductCatByYear(DateTime time)
        {
            return LoaiSanPhamDAL.GetTopProductCatByYear(time);
        }
    }
}
