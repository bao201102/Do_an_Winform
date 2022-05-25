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

        public static NhanVienDTO GetEmployeeById(string manv)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            NhanVien emp = entities.NhanViens.Where(x => x.MaNV.Equals(manv)).Single();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienDTO>());
            var mapper = new Mapper(config);
            NhanVienDTO empDTO = mapper.Map<NhanVienDTO>(emp);
            return empDTO;
        }
        public static List<object> GetEmployeeByName(string name)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            List<object> list = new List<object>();

            var query = from nv in entities.NhanViens
                        join lnv in entities.LoaiNhanViens
                        on nv.MaLoaiNV equals lnv.MaLoaiNV
                        join tk in entities.TaiKhoans
                        on nv.MaNguoiDung equals tk.MaNguoiDung
                        where nv.TenNV.Equals(name) && nv.TrangThai == "1"
                        select new
                        {
                            nv.MaNV,
                            nv.TenNV,
                            nv.GioiTinh,
                            nv.Email,
                            nv.SĐT,
                            nv.DiaChi,
                            lnv.TenLoaiNV,
                            tk.TaiKhoan1,
                        };

            foreach (var item in query)
            {
                list.Add(item);
            }
            return list;
        }

        public static List<object> GetAllEmployee()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            List<object> list = new List<object>();

            var query = from nv in entities.NhanViens
                        join lnv in entities.LoaiNhanViens
                        on nv.MaLoaiNV equals lnv.MaLoaiNV
                        join tk in entities.TaiKhoans
                        on nv.MaNguoiDung equals tk.MaNguoiDung
                        where nv.TrangThai == "1"
                        select new
                        {
                            nv.MaNV,
                            nv.TenNV,
                            nv.GioiTinh,
                            nv.Email,
                            nv.SĐT,
                            nv.DiaChi,
                            lnv.TenLoaiNV,
                            tk.TaiKhoan1,
                        };

            foreach (var item in query)
            {
                list.Add(item);
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
            NhanVien emp = entities.NhanViens.Where(x => x.MaNV.Equals(empDTO.MaNV)).Single();

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
        public static List<NhanVienDTO> LayTatCaNhanVien()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            var nhanvien = from nv in entities.NhanViens
                           select nv;
            foreach (NhanVien nv in nhanvien)
            {
                NhanVienDTO dto = new NhanVienDTO();
                dto.TenNV = nv.TenNV;
                dto.GioiTinh = nv.GioiTinh;
                dto.Email = nv.Email;
                dto.SĐT = nv.SĐT;
                dto.DiaChi = nv.DiaChi;
                list.Add(dto);
            }
            return list;
        }

    }

}
