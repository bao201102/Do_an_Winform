using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Do_an_Winform.DTO;

namespace Do_an_Winform.DAL
{
    public class HoaDonDAL
    {      
        public static bool AddNewBill(HoaDonDTO hd)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDonDTO, HoaDon>());
            var mapper = new Mapper(config);
            HoaDon hoaDon = mapper.Map<HoaDon>(hd);
            data.HoaDons.Add(hoaDon);
            return data.SaveChanges() > 0 ? true : false;
        }
        //Hàm lấy tất cả hóa đơn
        public static List<HoaDonDTO> GetAllBill()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var bills = from hd in entities.HoaDons
                        where hd.TrangThai == "1"
                        select hd;
            List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
            foreach (HoaDon bill in bills)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonDTO>());
                var mapper = new Mapper(config);
                HoaDonDTO hoadon = mapper.Map<HoaDonDTO>(bill);
                hoaDonDTOs.Add(hoadon);
            }
            return hoaDonDTOs;
        }
        public static List<HoaDonDTO> ThongKeTatCaHD(DateTime startday, DateTime endday)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var bills = from hd in entities.HoaDons
                        where hd.TrangThai == "1" && (hd.NgayTaoHD >= startday) && (hd.NgayTaoHD <= endday)
                        select hd;
            List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
            foreach (HoaDon bill in bills)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonDTO>());
                var mapper = new Mapper(config);
                HoaDonDTO hoadon = mapper.Map<HoaDonDTO>(bill);
                hoaDonDTOs.Add(hoadon);
            }
            return hoaDonDTOs;
        }

        public static List<HoaDonDTO> ThongKeTheoMaHD(HoaDonDTO hdsearch, DateTime startday, DateTime endday)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var bills = from hd in entities.HoaDons
                        where hd.TrangThai == "1" && (hd.NgayTaoHD >= startday) && (hd.NgayTaoHD <= endday) && (hd.MaHD == hdsearch.MaHD)
                        select hd;
            List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
            foreach (HoaDon bill in bills)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonDTO>());
                var mapper = new Mapper(config);
                HoaDonDTO hoadon = mapper.Map<HoaDonDTO>(bill);
                hoaDonDTOs.Add(hoadon);
            }
            return hoaDonDTOs;
        }
        public static double DoanhThuTatCaHD(DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                          where (hd.NgayTaoHD >= startday) && (hd.NgayTaoHD <= endday) && (hd.TrangThai == "1")
                          select new
                          {                             
                              hd.ThanhTien
                          };

            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double DoanhThuTheoMaHD(HoaDonDTO hdsearch, DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                          where (hd.MaHD == hdsearch.MaHD) && (hd.NgayTaoHD >= startday) && (hd.NgayTaoHD <= endday) && (hd.TrangThai == "1")
                          select new
                          {
                              hd.ThanhTien
                          };

            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ThongKeDoanhThuTheoTDHT(DateTime today)
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                           where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= today) && (hd.TrangThai == "1")
                          select new
                           {
                               hd.ThanhTien
                           };
            double reusultDT = 0;
            foreach(var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ThongKeDoanhThuTheoQuy(int quyTK)
        {
            DateTime firstDayOfMonth;
            DateTime lastDayOfMonth;
            double reusultDT = 0;
            if (quyTK == 1)
            {
                firstDayOfMonth = GetFirstDayOfMonth(1);
                lastDayOfMonth = GetLastDayOfMonth(3);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from hd in data.HoaDons
                              where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= lastDayOfMonth) && (hd.TrangThai == "1")
                              select new
                              {
                                  hd.ThanhTien
                              };

                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if(quyTK == 2)
            {
                firstDayOfMonth = GetFirstDayOfMonth(4);
                lastDayOfMonth = GetLastDayOfMonth(6);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from hd in data.HoaDons
                              where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= lastDayOfMonth)
                              select new
                              {
                                  hd.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if (quyTK == 3)
            {
                firstDayOfMonth = GetFirstDayOfMonth(7);
                lastDayOfMonth = GetLastDayOfMonth(9);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from hd in data.HoaDons
                              where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= lastDayOfMonth)
                              select new
                              {
                                  hd.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if(quyTK == 4)
            {
                firstDayOfMonth = GetFirstDayOfMonth(10);
                lastDayOfMonth = GetLastDayOfMonth(12);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from hd in data.HoaDons
                              where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= lastDayOfMonth)
                              select new
                              {
                                  hd.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            
            return reusultDT;
        }
        public static double ThongKeDoanhThuTheoThang(int ThangTK)
        {
            var firstDayOfMonth = GetLastDayOfMonth(ThangTK);
            var lastDayOfMonth = GetLastDayOfMonth(ThangTK);
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                          where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= lastDayOfMonth) && (hd.TrangThai == "1")
                          select new
                          {
                              hd.ThanhTien
                          };
            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }

        //Hàm lấy ra ngày đầu tiên của tháng
        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        //Hàm lấy ra ngày cuối cùng của tháng
        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        public static bool EditBill(HoaDonDTO hd)
        {
            CHDTEntities1 entities1 = new CHDTEntities1();
            var bill1 = (from bill in entities1.HoaDons
                         where bill.MaHD == hd.MaHD
                         select bill).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDonDTO, HoaDon>());
            var mapper = new Mapper(config);
            HoaDon hoaDon = mapper.Map<HoaDon>(bill1);
            hoaDon.MaNV = hd.MaNV;
            hoaDon.NgayTaoHD = hd.NgayTaoHD;
            hoaDon.MaNV = hd.MaNV;
            hoaDon.MaKH = hd.MaKH;
            hoaDon.ThanhTien = hd.ThanhTien;
            return entities1.SaveChanges() > 0 ? true : false;
        }
    }
}
