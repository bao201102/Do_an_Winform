using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class NhanVienDTO
	{
		private string _MaNV;
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}

		private string _TenNV;
		public string TenNV
		{
			get { return _TenNV; }
			set { _TenNV = value; }
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

		private string _MaLoaiNV;
		public string MaLoaiNV
		{
			get { return _MaLoaiNV; }
			set { _MaLoaiNV = value; }
		}

		private string _MaNguoiDung;
		public string MaNguoiDung
		{
			get { return _MaNguoiDung; }
			set { _MaNguoiDung = value; }
		}

		private string _TrangThai;
		public string TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		public NhanVienDTO()
        {
			this.MaNV = "";
			this.TenNV = "";
			this.GioiTinh = "";
			this.Email = "";
			this.SĐT = "";
			this.DiaChi = "";
			this.MaLoaiNV = "";
			this.MaNguoiDung = "";
			this.TrangThai = "";
        }
		public NhanVienDTO(string MaNV_, string TenNV_, string GioiTinh_, string Email_, string SĐT_, string DiaChi_, string MaLoaiNV_, string MaNguoiDung_, string TrangThai_)
		{
			this.MaNV = MaNV_;
			this.TenNV = TenNV_;
			this.GioiTinh = GioiTinh_;
			this.Email = Email_;
			this.SĐT = SĐT_;
			this.DiaChi = DiaChi_;
			this.MaLoaiNV = MaLoaiNV_;
			this.MaNguoiDung = MaNguoiDung_;
			this.TrangThai = TrangThai_;
		}
	}
}
