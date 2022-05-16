using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class SanPhamDAL
    {
        public static List<object> GetProduct()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       select new
                       {
                           sp.TenSP,
                           sp.SoLuong,
                           sp.DonGia,
                           nsx.TenNhaSX
                       };
                      
            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in pros)
            {
                sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;

        }
        public static List<object> GetProductByName(string tensp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       where sp.TenSP.Contains(tensp) && sp.TrangThai == "1"
                       select new
                       {
                           sp.TenSP,
                           sp.SoLuong,
                           sp.DonGia,
                           nsx.TenNhaSX
                       };

            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in pros)
            {               
                    sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;

        }
    }
}
