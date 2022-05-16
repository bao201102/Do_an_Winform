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
        public static List<SanPhamDTO> GetProduct()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = (from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       select sp);
                      
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham item in pros)
            {
                if(item.TrangThai == "1")
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                    var mapper = new Mapper(config);
                    SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(item);
                    sanPhamDTOs.Add(sanPham);
                }
            }
            return sanPhamDTOs;

        }
        public static List<SanPhamDTO> GetProductByName(string tensp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = (from sp in entities.SanPhams
                        join nsx in entities.NhaSanXuats
                        on sp.MaNhaSX equals nsx.MaNhaSX
                        where sp.TenSP.Contains(tensp)
                        select sp);

            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham item in pros)
            {
                if (item.TrangThai == "1")
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                    var mapper = new Mapper(config);
                    SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(item);
                    sanPhamDTOs.Add(sanPham);
                }
            }
            return sanPhamDTOs;

        }
        public static List<SanPhamDTO> GetProByTxtNameChanged(string txtNameChanged)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var products = from pro in entities.SanPhams
                            where pro.TenSP.Contains(txtNameChanged)
                            select pro;
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham pro in products)
            {
                if (pro.TrangThai == "1")
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                    var mapper = new Mapper(config);
                    SanPhamDTO khachhang = mapper.Map<SanPhamDTO>(pro);
                    sanPhamDTOs.Add(khachhang);
                }
            }
            return sanPhamDTOs;
        }
    }
}
