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
        public static List<NhaCungCapDTO> GetAllSupplier()
        {
            CHDTEntities entities = new CHDTEntities();
            var ncc = (from cc in entities.NhaCungCaps
                       where cc.TrangThai == "1"
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

        public static bool InsertSupplier(NhaCungCapDTO dto)
        {
            CHDTEntities data = new CHDTEntities();

            var query = data.NhaCungCaps.Select(t => t).Count();

            dto.MaNCC = "NCC" + (query + 1).ToString("000");
            dto.TrangThai = "1";

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCapDTO, NhaCungCap>());
            var mapper = new Mapper(config);

            NhaCungCap ncc = mapper.Map<NhaCungCap>(dto);
            data.NhaCungCaps.Add(ncc);
            return data.SaveChanges() > 0 ? true : false;
        }

        public static List<NhaCungCapDTO> GetAllSupplierByName(string name)
        {
            CHDTEntities entities = new CHDTEntities();
            var ncc = (from cc in entities.NhaCungCaps
                       where cc.TrangThai == "1" && cc.TenNCC.Contains(name)
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

        public static NhaCungCapDTO GetNhaCungCapByID(string mancc)
        {
            CHDTEntities entities = new CHDTEntities();
            NhaCungCap ncc = (from cc in entities.NhaCungCaps
                       where cc.MaNCC.Equals(mancc)
                       select cc).FirstOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaCungCap, NhaCungCapDTO>());
            var mapper = new Mapper(config);
            NhaCungCapDTO nhaCungCap = mapper.Map<NhaCungCapDTO>(ncc);

            return nhaCungCap;

        }
    }
}
