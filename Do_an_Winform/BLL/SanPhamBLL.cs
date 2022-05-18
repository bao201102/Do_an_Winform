using Do_an_Winform.DAL;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.BLL
{
    class SanPhamBLL
    {
        public static List<SanPhamDTO> GetAllProduct()
        {
            return SanPhamDAL.GetAllProduct();
        }

        public static List<object> GetProduct()
        {
            return SanPhamDAL.GetProduct();
        }

        public static List<object> GetAllProductByName(string tensp)
        {
            return SanPhamDAL.GetAllProductByName(tensp);
        }

        public static List<SanPhamDTO> GetProByTxtNameChanged(string txtNameChanged)
        {
            return SanPhamDAL.GetProByTxtNameChanged(txtNameChanged);
        }

        public static SanPhamDTO GetProductById(string masp)
        {
            return SanPhamDAL.GetProductById(masp);
        }

        public static SanPhamDTO GetProductByName(string tensp)
        {
            return SanPhamDAL.GetProductByName(tensp);
        }

        public static List<object> GetAllProductByCat(string maloaisp)
        {
            return SanPhamDAL.GetAllProductByCat(maloaisp);
        }
    }
}
