using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class KhachHangDTO
	{
		private string _MaKH;
		public string MaKH
		{
			get { return _MaKH; }
			set { _MaKH = value; }
		}

		private string _TenKH;
		public string TenKH
		{
			get { return _TenKH; }
			set { _TenKH = value; }
		}

		private string _GioiTinh;
		public string GioiTinh
		{
			get { return _GioiTinh; }
			set { _GioiTinh = value; }
		}

		private string _Email;
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		private string _SĐT;
		public string SĐT
		{
			get { return _SĐT; }
			set { _SĐT = value; }
		}

		private string _DiaChi;
		public string DiaChi
		{
			get { return _DiaChi; }
			set { _DiaChi = value; }
		}

		private string _MaLoaiTVien;
		public string MaLoaiTVien
		{
			get { return _MaLoaiTVien; }
			set { _MaLoaiTVien = value; }
		}

		private int _DiemTichLuy;
		public int DiemTichLuy
		{
			get { return _DiemTichLuy; }
			set { _DiemTichLuy = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		public KhachHangDTO()
        {
			this.MaKH = "";
			this.TenKH = "";
			this.GioiTinh = "";
			this.Email = "";
			this.SĐT = "";
			this.DiaChi = "";
			this.MaLoaiTVien = "";
			this.TrangThai = "";
			this.DiemTichLuy = 0;
        }
		public KhachHangDTO(string MaKH_, string TenKH_, string GioiTinh_, string Email_, string SĐT_, string DiaChi_, string MaLoaiTVien_, string TrangThai_, int DiemTichLuy_)
		{
			this.MaKH = MaKH_;
			this.TenKH = TenKH_;
			this.GioiTinh = GioiTinh_;
			this.Email = Email_;
			this.SĐT = SĐT_;
			this.DiaChi = DiaChi_;
			this.MaLoaiTVien = MaLoaiTVien_;
			this.TrangThai = TrangThai_;
			this.DiemTichLuy = DiemTichLuy_;
		}
	}
}
