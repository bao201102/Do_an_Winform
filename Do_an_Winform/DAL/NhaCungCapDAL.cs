using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    class NhaCungCapDAL
    {
        public static List<NhaCungCapDTO> GetNhaCungCap()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var ncc = (from cc in entities.NhaCungCaps
                        select cc);

            List<NhaCungCapDTO> nhaCungCapDTOs = new List<NhaCungCapDTO>();
            foreach (NhaCungCap item in ncc)
            {
                
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCap, NhaCungCapDTO>());
                    var mapper = new Mapper(config);
                    NhaCungCapDTO nhaCungCap = mapper.Map<NhaCungCapDTO>(item);
                    nhaCungCapDTOs.Add(nhaCungCap);
                
            }
            return nhaCungCapDTOs;

        }
        public static bool AddNCC(NhaCungCapDTO dto)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCapDTO, NhaCungCap>());
            var mapper = new Mapper(config);
            NhaCungCap ncc = mapper.Map<NhaCungCap>(dto);
            data.NhaCungCaps.Add(ncc);
            return data.SaveChanges() > 0 ? true : false;
        }
        public static List<NhaCungCapDTO> GetSupplyWithName(string name)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var nhacungcap = from ncc in data.NhaCungCaps
                              where ncc.TenNCC.Contains(name.Trim().ToLower())
                              select ncc;
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            foreach(NhaCungCap ncc in nhacungcap)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCap, NhaCungCapDTO>());
                var mapper = new Mapper(config);
                NhaCungCapDTO dto = mapper.Map<NhaCungCapDTO>(ncc);
                list.Add(dto);
            }
            return list;
        }
        public static List<NhaCungCapDTO> GetAllSupply()
        {
            CHDTEntities1 data = new CHDTEntities1();
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            var nhacungcap = from ncc in data.NhaCungCaps
                             select ncc;
            foreach (NhaCungCap ncc in nhacungcap)
            {
                NhaCungCapDTO dto = new NhaCungCapDTO();
                dto.MaNCC = ncc.MaNCC;
                dto.TenNCC = ncc.TenNCC;
                list.Add(dto);
            }
            return list;
        }

    }
}
