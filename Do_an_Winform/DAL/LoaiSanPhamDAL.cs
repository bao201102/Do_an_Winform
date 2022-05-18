using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class LoaiSanPhamDAL
    {
        public static LoaiSanPhamDTO GetProTypeById(string maLoaiSP)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            LoaiSanPham proType = (from loaisp in entities.LoaiSanPhams
                                   where loaisp.MaLoaiSP == maLoaiSP
                                   select loaisp).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiSanPham, LoaiSanPhamDTO>());
            var mapper = new Mapper(config);
            LoaiSanPhamDTO loaiSP = mapper.Map<LoaiSanPhamDTO>(proType);
            return loaiSP;
        }

        public static List<LoaiSanPhamDTO> GetAllCat()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var query = from lsp in entities.LoaiSanPhams
                        select lsp;

            List<LoaiSanPhamDTO> loaisps = new List<LoaiSanPhamDTO>();
            loaisps.Add(new LoaiSanPhamDTO("Tất cả", "Tất cả"));
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiSanPham, LoaiSanPhamDTO>());
            var mapper = new Mapper(config);
            foreach (var item in query)
            {
                LoaiSanPhamDTO loaisp = mapper.Map<LoaiSanPhamDTO>(item);
                loaisps.Add(loaisp);
            }
            return loaisps;
        }
    }
}
