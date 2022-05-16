using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an_Winform.DTO
{
	public class HoaDonDTO
	{
		private string _MaHD;
		private DateTime _NgayTaoHD;
		private string _MaNV;
		private string _MaKH;

		public string MaHD
		{
			get { return _MaHD; }
			set { _MaHD = value; }
		}
		public DateTime NgayTaoHD
		{
			get { return _NgayTaoHD; }
			set { _NgayTaoHD = value; }
		}
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}
		public string MaKH
		{
			get { return _MaKH; }
			set { _MaKH = value; }
		}

		public HoaDonDTO(string MaHD_, DateTime NgayTaoHD_, string MaNV_, string MaKH_)
		{
			this.MaHD = MaHD_;
			this.NgayTaoHD = NgayTaoHD_;
			this.MaNV = MaNV_;
			this.MaKH = MaKH_;
		}
		public HoaDonDTO()
		{
			this.MaHD = "";
			this.NgayTaoHD = DateTime.Now;
			this.MaNV = "";
			this.MaKH = "";
		}
	}
}