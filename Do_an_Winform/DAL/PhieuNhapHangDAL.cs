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
                          where (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday)
                          select new
                          {
                              pn.MaPN,
                              //NgayTaoPN = ((DateTime)pn.NgayTaopn).ToString("dd/MM/yyyy HH:mm"),              
                              pn.NgayTaoPN,
                              pn.MaNV,
                              pn.MaNCC,
                              pn.ThanhTien
                          };

            List<PhieuNhapHangDTO> listKQ = new List<PhieuNhapHangDTO>();
            for (int i = 0; i < truyvan.Count(); i++)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO pndto = mapper.Map<PhieuNhapHangDTO>(i);
                listKQ.Add(pndto);
            }
            return listKQ;
        }
        public static List<PhieuNhapHangDTO> ThongKeTheoMaPN(PhieuNhapHangDTO pnsearch, DateTime startday, DateTime endday)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from pn in data.PhieuNhapHangs
                          where (pn.MaPN == pnsearch.MaPN) && (pn.NgayTaoPN >= startday) && (pn.NgayTaoPN <= endday)
                          select new
                          {
                              pn.MaPN,
                              //NgayTaopn = ((DateTime)pn.NgayTaopn).ToString("dd/MM/yyyy HH:mm"),              
                              pn.NgayTaoPN,
                              pn.MaNV,
                              pn.MaNCC,
                              pn.ThanhTien
                          };
            List<PhieuNhapHangDTO> listKQ = new List<PhieuNhapHangDTO>();
            for (int i = 0; i < truyvan.Count(); i++)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuNhapHang, PhieuNhapHangDTO>());
                var mapper = new Mapper(config);
                PhieuNhapHangDTO pndto = mapper.Map<PhieuNhapHangDTO>(i);
                listKQ.Add(pndto);
            }
            return listKQ;
        }
        public static double ThongKeChiPhiTheoTDHT(DateTime today)
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);

            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                          where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= today)
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
        public static double ThongKeChiPhiTheoQuy(int quyTK)
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
            if (quyTK == 2)
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
            if (quyTK == 4)
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
        public static double ThongKeChiPhiTheoThang(int ThangTK)
        {
            var firstDayOfMonth = GetLastDayOfMonth(ThangTK);
            var lastDayOfMonth = GetLastDayOfMonth(ThangTK);
            CHDTEntities1 data = new CHDTEntities1();
            var truyvan = from hd in data.HoaDons
                          where (hd.NgayTaoHD >= firstDayOfMonth) && (hd.NgayTaoHD <= lastDayOfMonth)
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
