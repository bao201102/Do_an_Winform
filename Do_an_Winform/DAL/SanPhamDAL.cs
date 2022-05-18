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
        public static List<SanPhamDTO> GetAllProduct()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var products = from pro in entities.SanPhams
                           where pro.TrangThai == "1"
                           select pro;
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham pro in products)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                sanPhamDTOs.Add(sanpham);
            }
            return sanPhamDTOs;
        }
        public static List<object> GetProduct()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       join lsp in entities.LoaiSanPhams
                       on sp.MaLoaiSP equals lsp.MaLoaiSP
                       select new
                       {
                           sp.TenSP,
                           sp.SoLuong,
                           sp.DonGia,
                           lsp.TenLoaiSP,
                           nsx.TenNhaSX
                       };
                      
            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in pros)
            {
                sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;

        }
        public static List<object> GetAllProductByName(string tensp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       join lsp in entities.LoaiSanPhams
                       on sp.MaLoaiSP equals lsp.MaLoaiSP
                       where sp.TenSP.Contains(tensp) && sp.TrangThai == "1"
                       select new
                       {
                           sp.TenSP,
                           sp.SoLuong,
                           sp.DonGia,
                           lsp.TenLoaiSP,
                           nsx.TenNhaSX
                       };

            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in pros)
            {               
               sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;

        }
        public static List<SanPhamDTO> GetProByTxtNameChanged(string txtNameChanged)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var products = from pro in entities.SanPhams
                           where pro.TenSP.Contains(txtNameChanged) && pro.TrangThai == "1"
                           select pro;
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham pro in products)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                sanPhamDTOs.Add(sanpham);
            }
            return sanPhamDTOs;
        }
        public static SanPhamDTO GetProductById(string masp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            SanPham product = (from sp in entities.SanPhams
                               where sp.MaSP == masp && sp.TrangThai == "1"
                               select sp).SingleOrDefault();
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
            var mapper = new Mapper(config);
            SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(product);
            return sanPham;
        }
        public static SanPhamDTO GetProductByName(string ten)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var product = (from sp in entities.SanPhams
                               where sp.TenSP.Contains(ten) && sp.TrangThai == "1"
                               select sp).FirstOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
            var mapper = new Mapper(config);
            SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(product);
            return sanPham;
        }
    }
}
