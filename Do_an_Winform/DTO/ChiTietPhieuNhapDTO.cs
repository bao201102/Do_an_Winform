using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    public class ChiTietPhieuNhapDTO
    {
        private string _MaPN;
        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }

        private string _MaSP;
        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private string _TenSP;
        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private string _MaNhaSX;
        public string MaNhaSX
        {
            get { return _MaNhaSX; }
            set { _MaNhaSX = value; }
        }

        private int _ThanhTien;
        public int ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        private string _TrangThai;
        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public ChiTietPhieuNhapDTO()
        {
            this.MaPN = "";
            this.MaSP = "";
            this.TenSP = "";
            this.SoLuong = 0;
            this.MaNhaSX = "";
            this.ThanhTien = 0;
            this.TrangThai = "";

        }

        public ChiTietPhieuNhapDTO(string MaPN_, string MaSP_, string TenSP_, int SoLuong_, string MaNhaSX_, int ThanhTien_, string TrangThai_)
        {
            this.MaPN = MaPN_;
            this.MaSP = MaSP_;
            this.TenSP = TenSP_;
            this.SoLuong = SoLuong_;
            this.MaNhaSX = MaNhaSX_;
            this.ThanhTien = ThanhTien_;
            this.TrangThai = TrangThai_;
        }
    }
}
