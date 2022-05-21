using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class NhanVienDAL
    {
        public static NhanVienDTO GetEmployee(string manguoidung)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            NhanVien emp = (from nv in entities.NhanViens
                            where nv.MaNguoiDung == manguoidung
                            select nv).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
            var mapper = new Mapper(config);
            NhanVienDTO nhanVien = mapper.Map<NhanVienDTO>(emp);
            return nhanVien;
        }
        public static List<NhanVienDTO> GetEmployeeWithName(string name)
        {

            CHDTEntities1 data = new CHDTEntities1();
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            var nhanvien = from nv in data.NhanViens
                                 where nv.TenNV.Contains(name.Trim().ToLower()) && nv.TrangThai == "1"
                                 select nv;
            foreach(NhanVien nv in nhanvien)
            {
                NhanVienDTO dto = new NhanVienDTO();
                dto.MaNV = nv.MaNV;
                dto.TenNV = nv.TenNV;
                dto.GioiTinh = nv.GioiTinh;
                dto.Email = nv.Email;
                dto.SĐT = nv.SĐT;
                dto.DiaChi = nv.DiaChi;
                dto.MaLoaiNV = nv.MaLoaiNV;
                dto.MaNguoiDung = nv.MaNguoiDung;
                dto.TrangThai = nv.TrangThai;
                list.Add(dto);
            }
            return list;
        }
        public static List<NhanVienDTO> GetAllEmployee()
        {
            CHDTEntities1 data = new CHDTEntities1();
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            var nhanvien = from nv in data.NhanViens
                           where nv.TrangThai == "1"
                           select nv;
            foreach (NhanVien nv in nhanvien)
            {
                NhanVienDTO dto = new NhanVienDTO();
                dto.MaNV = nv.MaNV;
                dto.TenNV = nv.TenNV;
                dto.GioiTinh = nv.GioiTinh;
                dto.Email = nv.Email;
                dto.SĐT = nv.SĐT;
                dto.DiaChi = nv.DiaChi;
                dto.MaLoaiNV = nv.MaLoaiNV;
                dto.MaNguoiDung = nv.MaNguoiDung;
                dto.TrangThai = nv.TrangThai;
                list.Add(dto);
            }
            return list;
        }
        public static bool AddEmployee(NhanVienDTO dto)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVienDTO, NhanVien>());
            var mapper = new Mapper(config);
            NhanVien nv = mapper.Map<NhanVien>(dto);
            data.NhanViens.Add(nv);
            return data.SaveChanges() > 0 ? true : false;
        }

        public static bool UpdateEmployee(NhanVienDTO empDTO)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            NhanVien emp = entities.NhanViens.Where(x => x.MaNV.Equals(empDTO.MaNV)).SingleOrDefault();

            emp.TenNV = empDTO.TenNV;
            emp.GioiTinh = empDTO.GioiTinh;
            emp.Email = empDTO.Email;
            emp.DiaChi = empDTO.DiaChi;
            emp.SĐT = empDTO.SĐT;

            try
            {
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}
