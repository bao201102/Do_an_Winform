using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    class SanPhamDAL
    {
        public static List<SanPhamDTO> GetProduct()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var emp = (from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       select sp);
                      
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham item in emp)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(item);

                sanPhamDTOs.Add(sanPham);
            }
            return sanPhamDTOs;

        }
    }
}
