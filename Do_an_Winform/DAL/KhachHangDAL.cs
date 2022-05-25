using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class KhachHangDAL
    { 
        public static List<object> GetAllCustomer()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            List<object> list = new List<object>();

            var query = from kh in entities.KhachHangs
                        join ltv in entities.LoaiThanhViens
                        on kh.MaLoaiTVien equals ltv.MaLoaiTVien
                        where kh.TrangThai == "1"
                        select new
                        {
                            kh.MaKH,
                            kh.TenKH,
                            kh.GioiTinh,
                            kh.Email,
                            kh.SĐT,
                            kh.DiaChi,
                            ltv.TenLoaiTVien,
                            kh.DiemTichLuy,
                        };

            foreach (var item in query)
            {
                list.Add(item);
            }
            return list;
        }
        public static List<KhachHangDTO> GetCusByTxtNameChanged(string txtNameChanged)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var customers = from kh in entities.KhachHangs
                            where kh.TenKH.Contains(txtNameChanged)
                            select kh;
            List<KhachHangDTO> khachHangDTOs = new List<KhachHangDTO>();
            foreach (KhachHang ctm in customers)
            {
                if (ctm.TrangThai == "1")
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
                    var mapper = new Mapper(config);
                    KhachHangDTO khachhang = mapper.Map<KhachHangDTO>(ctm);
                    khachHangDTOs.Add(khachhang);
                }
            }
            return khachHangDTOs;
        }
        public static bool AddNewCustomer(KhachHangDTO kh) 
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHangDTO, KhachHang>());
            var mapper = new Mapper(config);
            KhachHang khachHang = mapper.Map<KhachHang>(kh);
            CHDTEntities1 entities = new CHDTEntities1();
            entities.KhachHangs.Add(khachHang);
            return entities.SaveChanges() > 0 ? true : false;
        }
        public static List<object> GetCustomerByName(string name)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            List<object> list = new List<object>();

            var query = from kh in entities.KhachHangs
                        join ltv in entities.LoaiThanhViens
                        on kh.MaLoaiTVien equals ltv.MaLoaiTVien
                        where kh.TenKH.Contains(name) && kh.TrangThai == "1"
                        select new
                        {
                            kh.MaKH,
                            kh.TenKH,
                            kh.GioiTinh,
                            kh.Email,
                            kh.SĐT,
                            kh.DiaChi,
                            ltv.TenLoaiTVien,
                            kh.DiemTichLuy,
                        };

            foreach (var item in query)
            {
                list.Add(item);
            }
            return list;
        }
        public static bool AddCustomer(KhachHangDTO dto)
        {
            CHDTEntities1 data = new CHDTEntities1();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHangDTO, KhachHang>());
            var mapper = new Mapper(config);
            KhachHang kh = mapper.Map<KhachHang>(dto);
            data.KhachHangs.Add(kh);
            return data.SaveChanges() > 0 ? true : false;
        }
        public static KhachHangDTO GetCustomerByPhone(string phone) 
        {
            CHDTEntities1 entities = new CHDTEntities1();
            KhachHang cus = (from kh in entities.KhachHangs
                                where kh.SĐT.Equals(phone) && kh.TrangThai == "1"
                                select kh).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
            var mapper = new Mapper(config);
            KhachHangDTO khachHang = mapper.Map<KhachHangDTO>(cus);
            return khachHang;
        }
        public static bool UpdateInfoCustomer(KhachHangDTO kh)
        {
            CHDTEntities1 entities1 = new CHDTEntities1();
            var customer = (from ctm in entities1.KhachHangs
                         where ctm.MaKH == kh.MaKH
                         select ctm).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHangDTO, KhachHang>());
            var mapper = new Mapper(config);
            KhachHang khachHang = mapper.Map<KhachHang>(customer);
            khachHang.MaKH = kh.MaKH;
            khachHang.TenKH = kh.TenKH;
            khachHang.GioiTinh = kh.GioiTinh;
            khachHang.Email = kh.Email;
            khachHang.SĐT = kh.SĐT;
            khachHang.DiaChi = kh.DiaChi;
            khachHang.MaLoaiTVien = kh.MaLoaiTVien;
            khachHang.DiemTichLuy = kh.DiemTichLuy;
            khachHang.TrangThai = kh.TrangThai;
            return entities1.SaveChanges() > 0 ? true : false;
        }
        public static List<KhachHangDTO> LayTatCaKhachHang()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var customers = from kh in entities.KhachHangs
                            select kh;
            List<KhachHangDTO> khachHangDTOs = new List<KhachHangDTO>();
            foreach (KhachHang ctm in customers)
            {
                if (ctm.TrangThai == "1")
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangDTO>());
                    var mapper = new Mapper(config);
                    KhachHangDTO khachhang = mapper.Map<KhachHangDTO>(ctm);
                    khachHangDTOs.Add(khachhang);
                }
            }
            return khachHangDTOs;
        }
    }
}
