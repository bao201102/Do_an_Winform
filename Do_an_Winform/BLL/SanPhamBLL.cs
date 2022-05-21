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
        public static List<object> GetProductByManufacId(string maNhaSX)
        {
            return SanPhamDAL.GetProductByManufacId(maNhaSX);
        }
        public static List<object> GetProductByCondition(string maNhaSX, int minprice, int maxprice, string maLoaiSP)
        {
            
            return SanPhamDAL.GetProductByCondition(maNhaSX, minprice, maxprice, maLoaiSP);
        }
        public static bool InsertProduct(SanPhamDTO product)
        {
            return SanPhamDAL.InsertProdut(product);
        }
        public static SanPhamDTO GetProductEqualsName(string ten)
        {
            return SanPhamDAL.GetProductEqualsName(ten);
        }
        public static bool UpdateQuantityProduct(ChiTietPhieuNhapDTO pn)
        {
            return SanPhamDAL.UpdateQuantityProduct(pn);
        }
    }
}
