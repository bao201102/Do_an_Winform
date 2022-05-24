using AutoMapper;
using Do_an_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DAL
{
    public class SanPhamDAL
    {
        public static List<SanPhamDTO> GetAllProduct()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var products = from pro in entities.SanPhams
                           where pro.TrangThai == "1"
                           select pro;
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham pro in products)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                sanPhamDTOs.Add(sanpham);
            }
            return sanPhamDTOs;
        }

        public static List<SanPhamDTO> GetAllProductWithConditions(string name)
        {
            if (name != "")
            {
                CHDTEntities1 entities = new CHDTEntities1();
                var products = from pro in entities.SanPhams
                               where pro.TenSP.Contains(name.ToLower().Trim()) && pro.TrangThai == "1"
                               select pro;
                List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
                foreach (SanPham pro in products)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                    var mapper = new Mapper(config);
                    SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                    sanPhamDTOs.Add(sanpham);
                }
                return sanPhamDTOs;
            }
            else
            {
                CHDTEntities1 entities = new CHDTEntities1();
                var products = from pro in entities.SanPhams
                               where pro.TrangThai == "1"
                               select pro;
                List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
                foreach (SanPham pro in products)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                    var mapper = new Mapper(config);
                    SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                    sanPhamDTOs.Add(sanpham);
                }
                return sanPhamDTOs;
            }
        }

        public static List<SanPhamDTO> GetProductByMaLoaiWithConditions(string name, string maloai)
        {
            if (name != "")
            {
                CHDTEntities1 entities = new CHDTEntities1();
                var products = from pro in entities.SanPhams
                               where pro.TenSP.Contains(name.Trim().ToLower()) && pro.MaLoaiSP == maloai && pro.TrangThai == "1"
                               select pro;
                List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
                foreach (SanPham pro in products)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                    var mapper = new Mapper(config);
                    SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                    sanPhamDTOs.Add(sanpham);
                }
                return sanPhamDTOs;
            }
            else
            {
                CHDTEntities1 entities = new CHDTEntities1();
                var products = from pro in entities.SanPhams
                               where pro.MaLoaiSP == maloai && pro.TrangThai == "1"
                               select pro;
                List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
                foreach (SanPham pro in products)
                {
                    var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                    var mapper = new Mapper(config);
                    SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                    sanPhamDTOs.Add(sanpham);
                }
                return sanPhamDTOs;
            }
        }

        public static List<object> GetProduct()
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       join lsp in entities.LoaiSanPhams
                       on sp.MaLoaiSP equals lsp.MaLoaiSP
                       where sp.TrangThai == "1"
                       select new
                       {
                           sp.MaSP,
                           sp.TenSP,
                           sp.SoLuong,
                           sp.DonGia,
                           lsp.TenLoaiSP,
                           nsx.TenNhaSX
                       };

            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in pros)
            {
                sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;

        }

        public static List<object> GetAllProductByName(string tensp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var pros = from sp in entities.SanPhams
                       join nsx in entities.NhaSanXuats
                       on sp.MaNhaSX equals nsx.MaNhaSX
                       join lsp in entities.LoaiSanPhams
                       on sp.MaLoaiSP equals lsp.MaLoaiSP
                       where sp.TenSP.Contains(tensp) && sp.TrangThai == "1"
                       select new
                       {
                           sp.MaSP,
                           sp.TenSP,
                           sp.SoLuong,
                           sp.DonGia,
                           lsp.TenLoaiSP,
                           nsx.TenNhaSX
                       };

            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in pros)
            {
                sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;
        }

        public static List<object> GetAllProductByCat(string maloaisp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var query = from sp in entities.SanPhams
                        join nsx in entities.NhaSanXuats
                        on sp.MaNhaSX equals nsx.MaNhaSX
                        join lsp in entities.LoaiSanPhams
                        on sp.MaLoaiSP equals lsp.MaLoaiSP
                        where sp.MaLoaiSP.Contains(maloaisp) && sp.TrangThai == "1"
                        select new
                        {
                            sp.MaSP,
                            sp.TenSP,
                            sp.SoLuong,
                            sp.DonGia,
                            lsp.TenLoaiSP,
                            nsx.TenNhaSX
                        };

            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in query)
            {
                sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;
        }

        public static List<object> GetProductByManufacId(string maNhaSX)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var query = from sp in entities.SanPhams
                        join nsx in entities.NhaSanXuats
                        on sp.MaNhaSX equals nsx.MaNhaSX
                        join lsp in entities.LoaiSanPhams
                        on sp.MaLoaiSP equals lsp.MaLoaiSP
                        where sp.MaNhaSX == maNhaSX && sp.TrangThai == "1"
                        select new
                        {
                            sp.TenSP,
                            sp.SoLuong,
                            sp.DonGia,
                            lsp.TenLoaiSP,
                            nsx.TenNhaSX
                        };

            List<object> sanPhamDTOs = new List<object>();
            foreach (var item in query)
            {
                sanPhamDTOs.Add(item);
            }
            return sanPhamDTOs;
        }

        public static List<SanPhamDTO> GetProByTxtNameChanged(string txtNameChanged)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var products = from pro in entities.SanPhams
                           where pro.TenSP.Contains(txtNameChanged) && pro.TrangThai == "1"
                           select pro;
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham pro in products)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                sanPhamDTOs.Add(sanpham);
            }
            return sanPhamDTOs;
        }

        public static SanPhamDTO GetProductById(string masp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            SanPham product = (from sp in entities.SanPhams
                               where sp.MaSP == masp && sp.TrangThai == "1"
                               select sp).SingleOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
            var mapper = new Mapper(config);
            SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(product);
            return sanPham;
        }

        public static SanPhamDTO GetProductByName(string ten)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var product = (from sp in entities.SanPhams
                           where sp.TenSP == ten && sp.TrangThai == "1"
                           select sp).FirstOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
            var mapper = new Mapper(config);
            SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(product);
            return sanPham;
        }

        public static SanPhamDTO GetProductEqualsName(string ten)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            SanPham product = (from sp in entities.SanPhams
                           where sp.TenSP.Equals(ten) && sp.TrangThai == "1"
                           select sp).FirstOrDefault();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
            var mapper = new Mapper(config);
            SanPhamDTO sanPham = mapper.Map<SanPhamDTO>(product);
            return sanPham;
        }

        public static List<object> GetProductByCondition(string manhasx, int minprice, int maxprice, string maloaisp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var query = from sp in entities.SanPhams
                        join nsx in entities.NhaSanXuats
                        on sp.MaNhaSX equals nsx.MaNhaSX
                        join lsp in entities.LoaiSanPhams
                        on sp.MaLoaiSP equals lsp.MaLoaiSP
                        where sp.TrangThai == "1"
                        select new
                        {
                            sp.TenSP,
                            sp.SoLuong,
                            sp.DonGia,
                            lsp.TenLoaiSP,
                            nsx.TenNhaSX
                        };
            if (manhasx != " " && manhasx != "Tất cả")
            {
                if (minprice != 0 && maxprice != 0)
                {
                    if (maloaisp != " " && maloaisp != "Tất cả")
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where sp.MaNhaSX == manhasx && minprice <= sp.DonGia && sp.DonGia <= maxprice
                                && sp.MaLoaiSP == maloaisp
                                && sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };

                    }
                    else
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where sp.MaNhaSX == manhasx && minprice <= sp.DonGia && sp.DonGia <= maxprice
                                && sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };
                    }
                }
                else
                {
                    if (maloaisp == " " || maloaisp == "Tất cả")
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where sp.MaNhaSX == manhasx
                                && sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };
                    }
                    else
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where sp.MaNhaSX == manhasx && sp.MaLoaiSP == maloaisp
                                && sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };
                    }
                }
            }
            else
            {
                if (minprice != 0 && maxprice != 0)
                {
                    if (maloaisp != " " && maloaisp != "Tất cả")
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where minprice <= sp.DonGia && sp.DonGia <= maxprice
                                && sp.MaLoaiSP == maloaisp
                                && sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };
                    }
                    else
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where minprice <= sp.DonGia && sp.DonGia <= maxprice
                                && sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };
                    }
                }
                else
                {
                    if (maloaisp != " " && maloaisp != "Tất cả")
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where sp.MaLoaiSP == maloaisp
                                && sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };
                    }
                    else
                    {
                        query = from sp in entities.SanPhams
                                join nsx in entities.NhaSanXuats
                                on sp.MaNhaSX equals nsx.MaNhaSX
                                join lsp in entities.LoaiSanPhams
                                on sp.MaLoaiSP equals lsp.MaLoaiSP
                                where sp.TrangThai == "1"
                                select new
                                {
                                    sp.TenSP,
                                    sp.SoLuong,
                                    sp.DonGia,
                                    lsp.TenLoaiSP,
                                    nsx.TenNhaSX
                                };
                    }
                }
            }
            try
            {
                List<object> sanPhamDTOs = new List<object>();
                foreach (var item in query)
                {
                    sanPhamDTOs.Add(item);
                }
                return sanPhamDTOs;
            }
            catch
            {
                return null;
            }
        }

        public static bool InsertProdut(SanPhamDTO product)
        {
            CHDTEntities1 entities = new CHDTEntities1();

            var query = (from x in entities.SanPhams
                         select x).Count();
            product.MaSP = "SP" + (query + 1).ToString("000");

            var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPhamDTO, SanPham>());
            var mapper = new Mapper(config);
            SanPham sp = mapper.Map<SanPham>(product);
            entities.SanPhams.Add(sp);

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

        public static bool UpdateQuantityProduct(ChiTietPhieuNhapDTO pn)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var sp = (from p in entities.SanPhams
                      where p.MaSP.Equals(pn.MaSP)
                      select p).SingleOrDefault();
            sp.SoLuong += pn.SoLuong;
            return entities.SaveChanges() > 0 ? true : false;
        }

        public static bool UpdateProduct(SanPhamDTO productDTO)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            SanPham sp = entities.SanPhams.Where(x => x.MaSP.Equals(productDTO.MaSP)).Single();

            sp.TenSP = productDTO.TenSP;
            sp.DonGia = productDTO.DonGia;
            sp.MaLoaiSP = productDTO.MaLoaiSP;
            sp.MaNhaSX = productDTO.MaNhaSX;

            try
            {
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                entities.SaveChanges();
                return false;
            }
        }

        public static bool DeleteProduct(string masp)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            SanPham sp = entities.SanPhams.Where(x => x.MaSP.Equals(masp)).Single();

            sp.TrangThai = "0";

            try
            {
                entities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                entities.SaveChanges();
                return false;
            }
        }

        public static List<SanPhamDTO> GetProductByProId(string maSP)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var products = from pro in entities.SanPhams
                           where pro.TrangThai == "1" && pro.MaSP == maSP
                           select pro;
            List<SanPhamDTO> sanPhamDTOs = new List<SanPhamDTO>();
            foreach (SanPham pro in products)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<SanPham, SanPhamDTO>());
                var mapper = new Mapper(config);
                SanPhamDTO sanpham = mapper.Map<SanPhamDTO>(pro);
                sanPhamDTOs.Add(sanpham);
            }
            return sanPhamDTOs;
        }

        public static Dictionary<string, double> GetTopProductName(DateTime time)
        {
            CHDTEntities1 entities = new CHDTEntities1();
            var query1 = from cthd in entities.ChiTietHoaDons
                         join hd in entities.HoaDons
                         on cthd.MaHD equals hd.MaHD
                         where hd.NgayTaoHD.Day.Equals(time.Day) || hd.NgayTaoHD.Month.Equals(time.Month) || hd.NgayTaoHD.Year.Equals(time.Year)
                         select new
                         {
                             cthd.MaSP,
                             cthd.TenSP,
                             cthd.SoLuong
                         };

            var query2 = from sp in entities.SanPhams
                         join cthd in query1
                         on sp.MaSP equals cthd.MaSP into X
                         from Y in X
                         group Y by sp.TenSP into Top
                         select new
                         {
                             Key = Top.Key,
                             Value = Top.Sum(t => t.SoLuong)
                         };


            Dictionary<string, double> list = new Dictionary<string, double>();
            foreach (var item in query2.Take(5))
            {
                list.Add(item.Key, item.Value);
            }
            return list;
        }
    }
}
