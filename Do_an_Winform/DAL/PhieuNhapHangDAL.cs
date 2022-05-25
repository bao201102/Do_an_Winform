using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    class PhieuNhapHangDAL
    {
        public static List<PhieuNhapHangDTO> ThongKeTatCaPN(DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                        where pn.TrangThai == "1" && (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday)
                        select pn;
            List<PhieuNhapHangDTO> listpn = new List<PhieuNhapHangDTO>();
            foreach (PhieuNhapHang pn in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO phieunhap = mapper.Map<PhieuNhapHangDTO>(pn);
                listpn.Add(phieunhap);
            }
            return listpn;
        }
        public static List<PhieuNhapHangDTO> ThongKeTheoMaPN(PhieuNhapHangDTO pnsearch, DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.MaPN == pnsearch.MaPN)&& (pn.TrangThai == "1") && (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday)
                          select pn;
            List<PhieuNhapHangDTO> listpn = new List<PhieuNhapHangDTO>();
            foreach (PhieuNhapHang pn in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO pndto = mapper.Map<PhieuNhapHangDTO>(pn);
                listpn.Add(pndto);
            }
            return listpn;
        }
        public static PhieuNhapHangDTO LayTheoMaPN(string mapn)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            PhieuNhapHang truyvan = (from pn in entities.PhieuNhapHangs
                              where pn.MaPN == mapn && pn.TrangThai == "1"
                              select pn).SingleOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
            var mapper = new Mapper(config);
            PhieuNhapHangDTO pnhap = mapper.Map<PhieuNhapHangDTO>(truyvan);
            return pnhap;
        }
        public static double ChiPhiTatCaPN(DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };

            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ChiPhiTheoMaPN(PhieuNhapHangDTO pnsearch, DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.MaPN ==pnsearch.MaPN) && (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };

            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ThongKeChiPhiTheoTDHT(DateTime today)
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.PhieuNhapHangs
                          where (hd.NgayTaoPN >= firstDayOfMonth) && (hd.NgayTaoPN <= today) && (hd.TrangThai == "1")
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
        public static double ThongKeChiPhiTheoNam(string namTK)
        {
            var firstDayOfMonth = GetLastDayOfMonth("1", namTK);
            var lastDayOfMonth = GetLastDayOfMonth("12", namTK);
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };
            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        public static double ThongKeChiPhiTheoQuy(string quyTK, string namTK)
        {
            DateTime firstDayOfMonth;
            DateTime lastDayOfMonth;

            double reusultDT = 0;
            if (quyTK == "1")
            {
                firstDayOfMonth = GetFirstDayOfMonth("1", namTK);
                lastDayOfMonth = GetLastDayOfMonth("3", namTK);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if (quyTK == "2")
            {
                firstDayOfMonth = GetFirstDayOfMonth("4", namTK);
                lastDayOfMonth = GetLastDayOfMonth("6", namTK);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if (quyTK == "3")
            {
                firstDayOfMonth = GetFirstDayOfMonth("7", namTK);
                lastDayOfMonth = GetLastDayOfMonth("9", namTK);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }
            if (quyTK == "4")
            {
                firstDayOfMonth = GetFirstDayOfMonth("10", namTK);
                lastDayOfMonth = GetLastDayOfMonth("12", namTK);
                CHDTEntities1 data = new CHDTEntities1();
                var truyvan = from pn in data.PhieuNhapHangs
                              where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                              select new
                              {
                                  pn.ThanhTien
                              };
                foreach (var i in truyvan)
                {
                    reusultDT += i.ThanhTien;
                };
            }

            return reusultDT;
        }
        public static double ThongKeChiPhiTheoThang(string thangTK, string namTK)
        {
            var firstDayOfMonth = GetLastDayOfMonth(thangTK, namTK);
            var lastDayOfMonth = GetLastDayOfMonth(thangTK, namTK);
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.NgayTaoPN >= firstDayOfMonth) && (pn.NgayTaoPN <= lastDayOfMonth) && (pn.TrangThai == "1")
                          select new
                          {
                              pn.ThanhTien
                          };
            double reusultDT = 0;
            foreach (var i in truyvan)
            {
                reusultDT += i.ThanhTien;
            };
            return reusultDT;
        }
        //Hàm lấy ra ngày đầu tiên của tháng
        public static DateTime GetFirstDayOfMonth(string strMonth, string strYear)
        {
            int iMonth = int.Parse(strMonth);
            int iYear = int.Parse(strYear);
            DateTime dtResult = new DateTime(iYear, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        //Hàm lấy ra ngày cuối cùng của tháng
        public static DateTime GetLastDayOfMonth(string strMonth, string strYear)
        {
            int iMonth = int.Parse(strMonth);
            int iYear = int.Parse(strYear);
            DateTime dtResult = new DateTime(iYear, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        // Thêm Phiếu nhập
        public static bool AddPhieuNhap(PhieuNhapHangDTO phieuNhapHangDTO)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            phieuNhapHangDTO.TrangThai = "1";

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHangDTO, PhieuNhapHang>());
            var mapper = new Mapper(config);
            PhieuNhapHang pn = mapper.Map<PhieuNhapHang>(phieuNhapHangDTO);
            entities.PhieuNhapHangs.Add(pn);

            return entities.SaveChanges() > 0 ? true : false;
        }
        // Lấy mã Phiếu nhập
        public static string CountMaPN()
        {
            CHDTEntities1 entities = new CHDTEntities1();

            var query = (from x in entities.PhieuNhapHangs
                         select x).Count();
            string count =  "PN" + (query + 1).ToString("000");
            return count;
        }
        // Lấy tất cả 
        public static List<PhieuNhapHangDTO> GetAll()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var query = from pn in entities.PhieuNhapHangs
                           where pn.TrangThai == "1"
                           select pn;
            List<PhieuNhapHangDTO> phieuNhaps = new List<PhieuNhapHangDTO>();
            foreach (PhieuNhapHang item in query)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO phieuNhap = mapper.Map<PhieuNhapHangDTO>(item);
                phieuNhaps.Add(phieuNhap);
            }
            return phieuNhaps;
        }
    }
}
