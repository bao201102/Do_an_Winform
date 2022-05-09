create database [CHDT]
go
USE [CHDT]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 5/9/2022 3:08:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[MaNguoiDung] [nvarchar](50) NOT NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[MaLoaiNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/9/2022 3:08:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](50) NOT NULL,
	[NgayLapHD] [datetime] NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/9/2022 3:08:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[SĐT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[MaLoaiTVien] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 5/9/2022 3:08:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[MaLoaiNV] [nvarchar](50) NOT NULL,
	[TenLoaiNV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 5/9/2022 3:08:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSP] [nvarchar](50) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThanhVien]    Script Date: 5/9/2022 3:08:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThanhVien](
	[MaLoaiTVien] [nvarchar](50) NOT NULL,
	[TenLoaiTVien] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/9/2022 3:08:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCC] [nvarchar](50) NOT NULL,
	[TenNhaCC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/9/2022 3:08:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SĐT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaLoaiNV] [nvarchar](50) NOT NULL,
	[MaNguoiDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 5/9/2022 3:08:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNhaSX] [nvarchar](50) NOT NULL,
	[TenNhaSX] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNhaSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 5/9/2022 3:08:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPN] [nvarchar](50) NOT NULL,
	[NgayTaoPN] [datetime] NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[MaLoaiSP] [nvarchar](50) NOT NULL,
	[MaNhaSX] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NULL,
	[MaNhaCC] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuatHang]    Script Date: 5/9/2022 3:08:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuatHang](
	[MaPX] [nvarchar](50) NOT NULL,
	[NgayTaoPX] [datetime] NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[MaLoaiSP] [nvarchar](50) NOT NULL,
	[MaNhaSX] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_PhieuXuatHang] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/9/2022 3:08:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaLoaiSP] [nvarchar](50) NOT NULL,
	[MaTrangThai] [nvarchar](50) NOT NULL,
	[MaNhaSX] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 5/9/2022 3:08:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[MaTrangThai] [nvarchar](50) NOT NULL,
	[TenTrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TrangThai] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US001', N'datdoan123', N'doantranbadat12345', N'LNV002')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US002', N'daulosin', N'dau123', N'LNV002')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US003', N'thiennguyen2455', N'thiennguyen231002', N'LNV002')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US004', N'bichkieu2002', N'bichkieu123', N'LNV002')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US005', N'baonguyenngoc', N'baobao2011002', N'LNV002')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US006', N'phattran123', N'trantienphat123456', N'LNV003')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US007', N'halethicam1604', N'camha160402', N'LNV003')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US008', N'danthanh2210', N'danthanh123', N'LNV003')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US009', N'anhthiphuongdo', N'anhdo12345', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US010', N'cuongngoquoc', N'cuongngo123', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US011', N'nongthaohien', N'hiennong120402', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US012', N'vinhhung123', N'vinhhung12345', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US013', N'khanhdang', N'dangduykhanh170102', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US014', N'khoaletan123', N'letankhoa1011002', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US015', N'vankhoi123', N'vankhoi12345', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US016', N'kienlamminhtuan', N'kiensinger123', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US017', N'thytranhoangthanh', N'thyg12345', N'LNV001')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US018', N'phuongduy', N'phuongduy123', N'LNV003')
INSERT [dbo].[DangNhap] ([MaNguoiDung], [TaiKhoan], [MatKhau], [MaLoaiNV]) VALUES (N'US019', N'thynha123', N'nhathy221102', N'LNV003')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien]) VALUES (N'KH001', N'Văn Tuấn Kiệt', N'Nam', N'kietvan@gmail.com', N'0935112869', N'TPHCM', N'LTV001')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien]) VALUES (N'KH002', N'Nguyễn Hữu Lợi', N'Nam', N'loinguyen@gmail.com', N'0923445689', N'TPHCM', N'LTV002')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien]) VALUES (N'KH003', N'Trần Công Lộc', N'Nam', N'loctran@gmail.com', N'0922355486', N'TPHCM', N'LTV003')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien]) VALUES (N'KH004', N'Nguyễn Thị Thảo Ly', N'Nữ', N'lylynguyen@gmail.com', N'0925929772', N'TPHCM', N'LTV003')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien]) VALUES (N'KH005', N'Phạm Hoàng Tuấn', N'Nam', N'tuanpham@gmail.com', N'0941130732', N'TPHCM', N'LTV004')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV001', N'Nhân viên')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV002', N'Quản lí')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV003', N'Thủ kho')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L001', N'Máy tính bàn')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L002', N'Laptop')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L003', N'Điện thoại')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L004', N'Tablet')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L005', N'Đồng hồ thông minh')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L006', N'Màn hình')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L007', N'TV')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L008', N'Tai nghe')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L009', N'Loa')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L010', N'Bàn phím')
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV001', N'Đồng')
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV002', N'Bạc')
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV003', N'Vàng')
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV004', N'Kim cương')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV001', N'Đỗ Thị Phương Anh', N'Nữ', N'anhthiphuongdo123@gmail.com', N'0983556448', N'TPHCM', N'LNV001', N'US009')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV002', N'Nguyễn Ngọc Bảo', N'Nam', N'baonguyenngoc@gmail.com', N'0946777827', N'TPHCM', N'LNV002', N'US005')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV003', N'Ngô Quốc Cường', N'Nam', N'cuongngoquoc@gmail.com', N'0982355479', N'TPHCM', N'LNV001', N'US010')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV004', N'Lồ Sin Dậu', N'Nam', N'daulosin@gmail.com', N'0898237581', N'TPHCM', N'LNV002', N'US002')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV005', N'Đoàn Trần Bá Đạt', N'Nam', N'badatdoan@gmail.com', N'0977420748', N'TPHCM', N'LNV002', N'US001')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV006', N'Nông Thảo Hiền', N'Nữ', N'hiennong@gmail.com', N'0935112869', N'TPHCM', N'LNV001', N'US011')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV007', N'Nguyễn Văn Vĩnh Hưng', N'Nam', N'hungnguyenvanvinh@gmail.com', N'0943555678', N'TPHCM', N'LNV001', N'US012')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV008', N'Đặng Duy Khánh', N'Nam', N'khanhdang@gmail.com', N'0933455899', N'TPHCM', N'LNV001', N'US013')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV009', N'Lê Tấn Khoa', N'Nam', N'khoaletan@gmail.com', N'0935113567', N'TPHCM', N'LNV001', N'US014')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV010', N'Nguyễn Văn Khôi', N'Nam', N'khoinguyen@gmail.com', N'0922355467', N'TPHCM', N'LNV001', N'US015')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV011', N'Nguyễn Thị Bích Kiều', N'Nữ', N'kieunguyen@gmail.com', N'0922115869', N'TPHCM', N'LNV002', N'US004')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV012', N'Lâm Minh Tuấn Kiện', N'Nam', N'kienlam@gmail.com', N'0955322867', N'TPHCM', N'LNV001', N'US016')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV013', N'Trần Hoàng Thanh Thy', N'Nữ', N'thygao@gmail.com', N'0922355918', N'TPHCM', N'LNV001', N'US017')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV014', N'Nguyễn Hoàn Thiện', N'Nam', N'thiennguyen@gmail.com', N'0935112448', N'TPHCM', N'LNV002', N'US003')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV015', N'Trần Tiến Phát', N'Nam', N'phattran@gmail.com', N'0982156878', N'TPHCM', N'LNV003', N'US006')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV016', N'Lê Thị Cẩm Hà', N'Nữ', N'hale@gmail.com', N'0981819175', N'TPHCM', N'LNV003', N'US007')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV017', N'Nguyễn Phương Duy', N'Nam', N'duynguyen@gmail.com', N'0983814358', N'TPHCM', N'LNV003', N'US018')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV018', N'Nguyễn Ngọc Nhã Thy', N'Nữ', N'thynguyen@gmail.com', N'0933525789', N'TPHCM', N'LNV003', N'US019')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung]) VALUES (N'NV019', N'Võ Ngọc Đan Thanh', N'Nữ', N'thanhvo@gmail.com', N'0943523479', N'TPHCM', N'LNV003', N'US008')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX001', N'Asus')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX002', N'Dell')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX003', N'Apple')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX004', N'Samsung')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX005', N'Lenovo')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX006', N'HP')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX007', N'Microsoft')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX008', N'Oppo')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX009', N'Huawei')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX010', N'Realme')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX011', N'LG')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX012', N'Sony')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX013', N'Logitech')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP001', N'Asus Vivobook Pro 14 Oled', 23500000, N'L002', N'TT001', N'SX001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP002', N'Dell Inspiron 5515', 19500000, N'L002', N'TT001', N'SX002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP003', N'Macbook Air M1 2020', 23500000, N'L002', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP004', N'HP Spectre', 18000000, N'L002', N'TT001', N'SX006')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP005', N'Dell Vostro 3670MT J84NJ1', 16500000, N'L001', N'TT001', N'SX002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP006', N'HP ProDesk 400 G5 MT 4ST33PA', 17200000, N'L001', N'TT001', N'SX006')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP007', N'Apple iMac 2017 MMQA2', 41500000, N'L001', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP008', N'Microsoft Surface Laptop 4', 22500000, N'L002', N'TT001', N'SX007')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP009', N'Macbook Pro M1 2020', 32500000, N'L002', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP010', N'Dell XPS 13', 22500000, N'L002', N'TT001', N'SX002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP011', N'Dell Inspiron 7501', 31500000, N'L002', N'TT001', N'SX002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP012', N'Dell Vostro 3400', 17500000, N'L002', N'TT001', N'SX002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP013', N'Asus Vivobook F512J', 19500000, N'L002', N'TT001', N'SX001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP014', N'Asus Zenbook Q408UG', 18500000, N'L002', N'TT001', N'SX001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP015', N'MacBook Pro 16 inch Intel', 35800000, N'L002', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP016', N'MacBook Pro 16 inch M1 Pro', 75200000, N'L002', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP017', N'Lenovo Yoga Slim 7 i7', 24500000, N'L002', N'TT001', N'SX005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP018', N'HP Envy 13', 18500000, N'L002', N'TT001', N'SX006')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP019', N'HP ProBook 445 G7', 20500000, N'L002', N'TT001', N'SX006')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP020', N'Lenovo ThinkPad X1 Carbon (Gen 9)', 22500000, N'L002', N'TT001', N'SX005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP021', N'Lenovo Legion 5 Pro', 23500000, N'L002', N'TT001', N'SX005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP022', N'Huawei Matebook Pro 14 2021', 20500000, N'L002', N'TT001', N'SX009')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP023', N'Macbook Air M2 2022', 27500000, N'L002', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP024', N'HP ProDesk 400 G5 MT 4ST33PA', 19500000, N'L001', N'TT001', N'SX006')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP025', N'Dell Vostro 3470ST STI31508', 18000000, N'L001', N'TT001', N'SX002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP026', N'OPPO A76', 6500000, N'L003', N'TT001', N'SX008')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP027', N'OPPO Reno7', 8990000, N'L003', N'TT001', N'SX008')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP028', N'OPPO Reno7 Pro 5G', 7990000, N'L003', N'TT001', N'SX008')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP029', N'OPPO Find X5 Pro 5G', 7800000, N'L003', N'TT001', N'SX008')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP030', N'Galaxy S22 Ultra', 31500000, N'L003', N'TT001', N'SX004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP031', N'Galaxy Z Fold 3', 24500000, N'L003', N'TT001', N'SX004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP032', N'Galaxy A53 5G', 8950000, N'L003', N'TT001', N'SX004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP033', N'Realme X3 SuperZoom', 4990000, N'L003', N'TT001', N'SX010')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP034', N'Realme 6 Pro', 5990000, N'L003', N'TT001', N'SX010')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP035', N'IPhone 11 64GB', 8500000, N'L003', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP036', N'iPhone 12 Pro Max', 32500000, N'L003', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP037', N'Asus Zenfone 5', 9500000, N'L003', N'TT001', N'SX001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP038', N'Asus Rog Phone 2', 13500000, N'L003', N'TT001', N'SX001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP039', N'LG V60 ThinQ.', 6990000, N'L003', N'TT001', N'SX011')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP040', N'LG G8 ThinQ.', 79900000, N'L003', N'TT001', N'SX011')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP041', N'TV LG Smart OLED G1 65 inch 4K OLED65G1PTA', 52500000, N'L007', N'TT001', N'SX011')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP042', N'Smart Tivi LG 4K 70 inch 70UP7750PTB', 20500000, N'L007', N'TT001', N'SX011')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP043', N'Smart Tivi OLED LG 4K 48 inch 48A1PTA', 23500000, N'L007', N'TT001', N'SX011')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP044', N'Tivi Sony 4K 43 inch KD-43X8500H', 24500000, N'L007', N'TT001', N'SX012')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP045', N'Tivi Sony 4K 49 inch KD-49X8050H', 34500000, N'L007', N'TT001', N'SX012')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP046', N'Apple Watch Series 7 41mm', 13500000, N'L005', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP047', N'Huawei Watch GT3', 14500000, N'L005', N'TT001', N'SX009')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP048', N'Samsung Galaxy Watch 4 40mm', 12350000, N'L005', N'TT001', N'SX004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP049', N'Apple Watch Series 5', 6500000, N'L005', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP050', N'Samsung Galaxy Tab S6 Lite 64GB Xanh', 13500000, N'L004', N'TT001', N'SX004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP051', N'Samsung Galaxy Tab S7 FE 64GB Đen', 15990000, N'L004', N'TT001', N'SX004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP052', N'Lenovo Tab M8', 9500000, N'L004', N'TT001', N'SX005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP053', N'iPad 10.2 inch Wifi 32GB', 9800000, N'L004', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP054', N'iPad Pro M1 2021', 40990000, N'L004', N'TT001', N'SX003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP055', N'Asus VP279QGL Gaming Monitor', 9500000, N'L006', N'TT001', N'SX001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP056', N'Samsung LS32R750UEEXXV 32 inch 4K', 12500000, N'L006', N'TT001', N'SX004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP057', N'LG 24MP59G-P 24 inch Full HD', 4500000, N'L006', N'TT001', N'SX011')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP058', N'Tai Nghe Nhét Tai Sony XBA-N1AP Hi-Res', 1250000, N'L008', N'TT001', N'SX012')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP059', N'Sony XBA-N1AP Hi-Res', 1300000, N'L008', N'TT001', N'SX012')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP060', N'Loa Bluetooth LG XBOOM GO PN1', 4990000, N'L009', N'TT001', N'SX011')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP061', N'Loa Bluetooth Sony SRS XB12', 4500000, N'L009', N'TT001', N'SX012')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP062', N'Bàn phím Logitech K380', 550000, N'L010', N'TT001', N'SX013')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP063', N'Bàn phím Logitech G Pro X', 670000, N'L010', N'TT001', N'SX013')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP064', N'Bàn phím Logitech G613', 850000, N'L010', N'TT001', N'SX013')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia], [MaLoaiSP], [MaTrangThai], [MaNhaSX]) VALUES (N'SP065', N'Bàn phím Logitech K270', 720000, N'L010', N'TT001', N'SX013')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai]) VALUES (N'TT001', N'Còn hàng')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai]) VALUES (N'TT002', N'Hết hàng')
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD FOREIGN KEY([MaLoaiTVien])
REFERENCES [dbo].[LoaiThanhVien] ([MaLoaiTVien])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[DangNhap] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNhaSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNhaSX])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD FOREIGN KEY([MaNhaSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNhaSX])
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[PhieuXuatHang]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaNhaSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNhaSX])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaTrangThai])
REFERENCES [dbo].[TrangThai] ([MaTrangThai])
GO
