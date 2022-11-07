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
            CHDTEntities entities = new CHDTEntities();
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
            CHDTEntities entities = new CHDTEntities();
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

        public static Dictionary<string, double> GetTopProductCatByDay(DateTime time)
        {
            CHDTEntities entities = new CHDTEntities();

            var query1 = from cthd in entities.ChiTietHoaDons
                         join hd in entities.HoaDons
                         on cthd.MaHD equals hd.MaHD
                         where hd.TrangThai == "1" && hd.NgayTaoHD.Day.Equals(time.Day) && hd.NgayTaoHD.Month.Equals(time.Month) && hd.NgayTaoHD.Year.Equals(time.Year)
                         select new
                         {
                             cthd.MaSP,
                             cthd.TenSP,
                             cthd.SoLuong
                         };

            var query2 = from sp in entities.SanPhams
                         join lsp in entities.LoaiSanPhams
                         on sp.MaLoaiSP equals lsp.MaLoaiSP
                         where sp.TrangThai == "1"
                         select new
                         {
                             sp.MaSP,
                             lsp.TenLoaiSP
                         };

            var query3 = from sp in query2
                         join cthd in query1
                         on sp.MaSP equals cthd.MaSP into X
                         from Y in X
                         group Y by sp.TenLoaiSP into Top
                         select new
                         {
                             Key = Top.Key,
                             Value = Top.Sum(t => t.SoLuong)
                         };

            Dictionary<string, double> list = new Dictionary<string, double>();
            foreach (var item in query3.OrderByDescending(t => t.Value).Take(5))
            {
                list.Add(item.Key, item.Value);
            }
            return list;
        }

        public static Dictionary<string, double> GetTopProductCatByMonth(DateTime time)
        {
            CHDTEntities entities = new CHDTEntities();

            var query1 = from cthd in entities.ChiTietHoaDons
                         join hd in entities.HoaDons
                         on cthd.MaHD equals hd.MaHD
                         where hd.TrangThai == "1" && hd.NgayTaoHD.Month.Equals(time.Month) && hd.NgayTaoHD.Year.Equals(time.Year)
                         select new
                         {
                             cthd.MaSP,
                             cthd.TenSP,
                             cthd.SoLuong
                         };

            var query2 = from sp in entities.SanPhams
                         join lsp in entities.LoaiSanPhams
                         on sp.MaLoaiSP equals lsp.MaLoaiSP
                         where sp.TrangThai == "1"
                         select new
                         {
                             sp.MaSP,
                             lsp.TenLoaiSP
                         };

            var query3 = from sp in query2
                         join cthd in query1
                         on sp.MaSP equals cthd.MaSP into X
                         from Y in X
                         group Y by sp.TenLoaiSP into Top
                         select new
                         {
                             Key = Top.Key,
                             Value = Top.Sum(t => t.SoLuong)
                         };

            Dictionary<string, double> list = new Dictionary<string, double>();
            foreach (var item in query3.OrderByDescending(t => t.Value).Take(5))
            {
                list.Add(item.Key, item.Value);
            }
            return list;
        }

        public static Dictionary<string, double> GetTopProductCatByYear(DateTime time)
        {
            CHDTEntities entities = new CHDTEntities();

            var query1 = from cthd in entities.ChiTietHoaDons
                         join hd in entities.HoaDons
                         on cthd.MaHD equals hd.MaHD
                         where hd.TrangThai == "1" && hd.NgayTaoHD.Year.Equals(time.Year)
                         select new
                         {
                             cthd.MaSP,
                             cthd.TenSP,
                             cthd.SoLuong
                         };

            var query2 = from sp in entities.SanPhams
                         join lsp in entities.LoaiSanPhams
                         on sp.MaLoaiSP equals lsp.MaLoaiSP
                         where sp.TrangThai == "1"
                         select new
                         {
                             sp.MaSP,
                             lsp.TenLoaiSP
                         };

            var query3 = from sp in query2
                         join cthd in query1
                         on sp.MaSP equals cthd.MaSP into X
                         from Y in X
                         group Y by sp.TenLoaiSP into Top
                         select new
                         {
                             Key = Top.Key,
                             Value = Top.Sum(t => t.SoLuong)
                         };

            Dictionary<string, double> list = new Dictionary<string, double>();
            foreach (var item in query3.OrderByDescending(t => t.Value).Take(5))
            {
                list.Add(item.Key, item.Value);
            }
            return list;
        }
    }
}
