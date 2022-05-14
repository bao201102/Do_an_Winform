using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class TaiKhoanDTO
	{
		private string _MaNguoiDung;
		public string MaNguoiDung
		{
			get { return _MaNguoiDung; }
			set { _MaNguoiDung = value; }
		}

		private string _TaiKhoan;
		public string TaiKhoan
		{
			get { return _TaiKhoan; }
			set { _TaiKhoan = value; }
		}

		private string _MatKhau;
		public string MatKhau
		{
			get { return _MatKhau; }
			set { _MatKhau = value; }
		}

		private string _MaLoaiNV;
		public string MaLoaiNV
		{
			get { return _MaLoaiNV; }
			set { _MaLoaiNV = value; }
		}

		public TaiKhoanDTO()
		{
			this.MaNguoiDung = "";
			this.TaiKhoan = "";
			this.MatKhau = "";
			this.MaLoaiNV = "";
		}
		public TaiKhoanDTO(string MaNguoiDung_, string TaiKhoan_, string MatKhau_, string MaLoaiNV_)
		{
			this.MaNguoiDung = MaNguoiDung_;
			this.TaiKhoan = TaiKhoan_;
			this.MatKhau = MatKhau_;
			this.MaLoaiNV = MaLoaiNV_;
		}
	}
}
