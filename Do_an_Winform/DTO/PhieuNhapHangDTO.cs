using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
    class PhieuNhapHangDTO
    {
        private string _MaPN;
        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }

        private DateTime _NgayTaoPN;
        public DateTime NgayTaoPN
        {
            get { return _NgayTaoPN; }
            set { _NgayTaoPN = value; }
        }

        private string _MaNV;
        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _MaNCC;
        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
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

        public PhieuNhapHangDTO()
        {
            this.MaPN = "";
            this.NgayTaoPN = DateTime.MinValue;
            this.MaNV = "";
            this.MaNCC = "";
            this.ThanhTien = 0;
            this.TrangThai = "";
        }

        public PhieuNhapHangDTO(string MaPN_, DateTime NgayTaoPN_, string MaNV_, string MaNCC_, int ThanhTien_,string TrangThai_)
        {
            this.MaPN = MaPN_;
            this.NgayTaoPN = NgayTaoPN_;
            this.MaNV = MaNV_;
            this.MaNCC = MaNCC_;
            this.ThanhTien = ThanhTien_;
            this.TrangThai = TrangThai_;
        }
    }
}
