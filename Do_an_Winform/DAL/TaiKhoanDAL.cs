using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class TaiKhoanDAL
    {
        public static TaiKhoanDTO GetUser(TaiKhoan account)
        {

            CHDTEntities1 entities = new CHDTEntities1();
            TaiKhoan user = (from us in entities.TaiKhoans
                             where us.UserName == account.UserName && us.MatKhau == account.MatKhau
                             select us).SingleOrDefault();

            if (user != null)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<TaiKhoan, TaiKhoanDTO>());
                var mapper = new Mapper(config);
                TaiKhoanDTO taikhoan = mapper.Map<TaiKhoanDTO>(user);
                return taikhoan;
            }
            else
            {
                return null;
            }
        }

        public static List<TaiKhoanDTO> GetMaLoaiNV(string maloai)
        {
            CHDTEntities1 data = new CHDTEntities1();
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            var query = from tk in data.TaiKhoans
                        where tk.MaLoaiNV == maloai
                        select tk;
            foreach (TaiKhoan tk in query)
            {
                TaiKhoanDTO dto = new TaiKhoanDTO();
                dto.MaLoaiNV = tk.MaLoaiNV;
                list.Add(dto);
            }
            return list;
        }

        public static bool AddAccount(TaiKhoanDTO dto)
        {
            CHDTEntities1 entities = new CHDTEntities1();

            var query = (from x in entities.TaiKhoans
                         select x).Count();
            dto.MaNguoiDung = "US" + (query + 1).ToString("000");

            var config = new MapperConfiguration(cfg => cfg.CreateMap<TaiKhoanDTO, TaiKhoan>());
            var mapper = new Mapper(config);
            TaiKhoan tk = mapper.Map<TaiKhoan>(dto);
            entities.TaiKhoans.Add(tk);
            try
            {
                entities.SaveChanges();
                return true;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                return false;
            }
        }

        public static bool RemoveAccount(TaiKhoanDTO dto, string manguoidung)
        {
            CHDTEntities1 entities = new CHDTEntities1();

            TaiKhoan query = (from tk in entities.TaiKhoans
                              where tk.MaNguoiDung == manguoidung
                             select tk).Single();

            entities.TaiKhoans.Remove(query);
            return entities.SaveChanges() > 0 ? true : false;
        }

        public static bool UpdatePassword(TaiKhoanDTO dto)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            TaiKhoan tk = entities.TaiKhoans.Where(x => x.MaNguoiDung.Equals(dto.MaNguoiDung)).Single();

            tk.MatKhau = dto.MatKhau;

            entities.SaveChanges();
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

        public static string GetUserId(string username)
        {
            CHDTEntities1 entities = new CHDTEntities1();

            var query = (from us in entities.TaiKhoans
                        where us.UserName.Equals(username)
                        select us).Single();

            return query.MaNguoiDung;
        }
    }
}
