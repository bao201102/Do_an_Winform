using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class LoaiNhanVienDAL
    {
        public static LoaiNhanVienDTO GetEmpType(string maLoaiNV)
        {
            CHDTEntities entities = new CHDTEntities();
            LoaiNhanVien empType = (from lnv in entities.LoaiNhanViens
                            where lnv.MaLoaiNV == maLoaiNV
                            select lnv).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiNhanVien, LoaiNhanVienDTO>());
            var mapper = new Mapper(config);
            LoaiNhanVienDTO loaiNV = mapper.Map<LoaiNhanVienDTO>(empType);
            return loaiNV;
        }
        public static List<LoaiNhanVienDTO> GetAllEmpType()
        {
            CHDTEntities entities = new CHDTEntities();
            List<LoaiNhanVienDTO> list = new List<LoaiNhanVienDTO>();
            var empType = from lnv in entities.LoaiNhanViens
                                    select lnv;
            foreach (LoaiNhanVien lnv in empType)
            {
                LoaiNhanVienDTO dto = new LoaiNhanVienDTO();
                dto.MaLoaiNV = lnv.MaLoaiNV;
                dto.TenLoaiNV = lnv.TenLoaiNV;
                list.Add(dto);
            }
            return list;
        }
    }
}
