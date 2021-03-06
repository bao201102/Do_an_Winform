CREATE DATABASE [CHDT]
GO
USE [CHDT]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaNhaSX] [nvarchar](10) NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[NgayTaoHD] [datetime] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NULL,
	[ThanhTien] [int] NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[SĐT] [char](10) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaLoaiTVien] [nvarchar](10) NOT NULL,
	[DiemTichLuy] [int] NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[MaLoaiNV] [nvarchar](10) NOT NULL,
	[TenLoaiNV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSP] [nvarchar](10) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThanhVien]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThanhVien](
	[MaLoaiTVien] [nvarchar](10) NOT NULL,
	[TenLoaiTVien] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[SDT] [char](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[SĐT] [char](10) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaLoaiNV] [nvarchar](10) NOT NULL,
	[MaNguoiDung] [nvarchar](10) NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNhaSX] [nvarchar](10) NOT NULL,
	[TenNhaSX] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNhaSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPN] [nvarchar](10) NOT NULL,
	[NgayTaoPN] [datetime] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaNCC] [nvarchar](10) NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaLoaiSP] [nvarchar](10) NOT NULL,
	[MaNhaSX] [nvarchar](10) NOT NULL,
	[TrangThai] [char](1) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 27/5/2022 4:41:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaNguoiDung] [nvarchar](10) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[MaLoaiNV] [nvarchar](10) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD001', N'SP010', N'Apple Watch Series 7', 3, 25800000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD002', N'SP003', N'HP Spectre', 2, 36000000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD003', N'SP004', N'Dell Vostro 3670MT J84NJ1', 2, 33000000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD004', N'SP006', N'Iphone 13 Pro Max 256GB', 1, 33000000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD004', N'SP017', N'Loa thanh Samsung HW', 1, 33990000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD004', N'SP021', N'Samsung Galaxy Tab S8', 1, 20990000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD005', N'SP009', N'Xiaomi Watch Life', 1, 1282500, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD005', N'SP011', N'SamSung 24 inch', 2, 9500000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD006', N'SP004', N'Dell Vostro 3670MT J84NJ1', 2, 31350000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD006', N'SP006', N'Iphone 13 Pro Max 256GB', 2, 62700000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD007', N'SP008', N'Oppo Reno 7 Series', 2, 19301600, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD007', N'SP014', N'Sony Smart TV 4K', 4, 47104000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD008', N'SP002', N'Macbook Air M1 2020', 1, 22325000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD008', N'SP010', N'Apple Watch Series 7', 2, 16340000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD009', N'SP004', N'Dell Vostro 3670MT J84NJ1', 2, 31350000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD009', N'SP010', N'Apple Watch Series 7', 1, 8170000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD010', N'SP002', N'Macbook Air M1 2020', 2, 44650000, N'1')
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [TenSP], [SoLuong], [ThanhTien], [TrangThai]) VALUES (N'HD010', N'SP022', N'Ipad Pro M1 12.9 inch', 3, 83476500, N'1')
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN001', N'SP014', N'Sony Smart TV 4K', 14, N'SX012', 161280000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN002', N'SP003', N'HP Spectre', 12, N'SX006', 194400000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN002', N'SP020', N'Bàn phím Akko 3098N', 5, N'SX015', 13455000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN003', N'SP007', N'SamSung Galaxy A51', 12, N'SX004', 81000000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN003', N'SP010', N'Apple Watch Series 7', 13, N'SX003', 100620000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN004', N'SP004', N'Dell Vostro 3670MT J84NJ1', 12, N'SX002', 178200000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN004', N'SP015', N'Tai nghe Sony WH-1000XM4', 3, N'SX012', 14823000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN005', N'SP011', N'SamSung 24 inch', 5, N'SX004', 22500000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN005', N'SP015', N'Tai nghe Sony WH-1000XM4', 9, N'SX012', 44469000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN006', N'SP009', N'Xiaomi Watch Life', 4, N'SX014', 4860000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN006', N'SP012', N'Dell S2721H 27 inch', 10, N'SX002', 56610000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN007', N'SP012', N'Dell S2721H 27 inch', 12, N'SX002', 67932000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN007', N'SP019', N'Bàn Phím Logitech G Pro KDA', 3, N'SX013', 88263000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN008', N'SP009', N'Xiaomi Watch Life', 10, N'SX014', 12150000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN008', N'SP011', N'SamSung 24 inch', 4, N'SX004', 18000000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN009', N'SP008', N'Oppo Reno 7 Series', 5, N'SX008', 47205000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN009', N'SP013', N'LG Smart TV NanoCell', 4, N'SX011', 64764000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN009', N'SP017', N'Loa thanh Samsung HW', 5, N'SX004', 152955000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN010', N'SP008', N'Oppo Reno 7 Series', 3, N'SX008', 28323000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN010', N'SP014', N'Sony Smart TV 4K', 2, N'SX012', 23040000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN010', N'SP019', N'Bàn Phím Logitech G Pro KDA', 4, N'SX013', 117684000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN011', N'SP013', N'LG Smart TV NanoCell', 4, N'SX011', 64764000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN011', N'SP017', N'Loa thanh Samsung HW', 2, N'SX004', 61182000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN012', N'SP004', N'Dell Vostro 3670MT J84NJ1', 5, N'SX002', 74250000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN012', N'SP013', N'LG Smart TV NanoCell', 4, N'SX011', 64764000, N'1')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [TenSP], [SoLuong], [MaNhaSX], [ThanhTien], [TrangThai]) VALUES (N'PN012', N'SP017', N'Loa thanh Samsung HW', 2, N'SX004', 61182000, N'1')
GO
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD001', CAST(N'2022-01-02T15:59:23.247' AS DateTime), N'NV001', NULL, 25800000, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD002', CAST(N'2022-01-17T15:59:23.247' AS DateTime), N'NV003', NULL, 36000000, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD003', CAST(N'2022-02-07T15:59:23.247' AS DateTime), N'NV001', NULL, 33000000, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD004', CAST(N'2022-02-17T15:59:23.247' AS DateTime), N'NV007', NULL, 87980000, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD005', CAST(N'2022-03-20T16:01:46.887' AS DateTime), N'NV006', N'KH001', 10782500, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD006', CAST(N'2022-03-27T16:02:44.947' AS DateTime), N'NV001', N'KH006', 94050000, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD007', CAST(N'2022-04-12T16:03:49.540' AS DateTime), N'NV008', N'KH002', 66405600, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD008', CAST(N'2022-04-18T16:07:27.800' AS DateTime), N'NV010', N'KH007', 38665000, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD009', CAST(N'2022-05-14T16:14:12.207' AS DateTime), N'NV009', N'KH009', 39520000, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTaoHD], [MaNV], [MaKH], [ThanhTien], [TrangThai]) VALUES (N'HD010', CAST(N'2022-05-27T16:15:58.637' AS DateTime), N'NV001', N'KH009', 128126500, N'1')
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH001', N'Văn Tuấn Kiệt', N'Nam', N'kietvan@gmail.com', N'0935112869', N'TPHCM', N'LTV002', 150, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH002', N'Nguyễn Hữu Lợi', N'Nam', N'loinguyen@gmail.com', N'0923445689', N'TPHCM', N'LTV002', 200, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH003', N'Trần Công Lộc', N'Nam', N'loctran@gmail.com', N'0922355486', N'TPHCM', N'LTV003', 200, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH004', N'Nguyễn Thị Thảo Ly', N'Nữ', N'lylynguyen@gmail.com', N'0925929772', N'TPHCM', N'LTV003', 220, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH005', N'Phạm Hoàng Tuấn', N'Nam', N'tuanpham@gmail.com', N'0941130732', N'TPHCM', N'LTV004', 400, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH006', N'Lồ Sìn Dậu', N'Nam', N'daulosin@gmail.com', N'0912345678', N'HCM', N'LTV001', 100, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH007', N'Nguyễn Ngọc Bảo', N'Nữ', N'bao@gmail.com', N'0946777827', N'TPHCM', N'LTV001', 100, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH008', N'Đoàn Trần Bá Đạt', N'Nam', N'badat123@gmail.com', N'0911223344', N'TPHCM', N'LTV001', 50, N'1')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiTVien], [DiemTichLuy], [TrangThai]) VALUES (N'KH009', N'Nguyễn Thị Bích Kiều', N'Nữ', N'kieu@gmail.com', N'0912312345', N'TPHCM', N'LTV002', 150, N'1')
GO
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV001', N'Nhân viên')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV002', N'Quản lí')
INSERT [dbo].[LoaiNhanVien] ([MaLoaiNV], [TenLoaiNV]) VALUES (N'LNV003', N'Thủ kho')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L001', N'Máy tính bàn')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L002', N'Laptop')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L003', N'Điện thoại')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L004', N'Đồng hồ thông minh')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L005', N'Màn hình')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L006', N'TV')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L007', N'Tai nghe')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L008', N'Loa')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L009', N'Bàn phím')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP]) VALUES (N'L010', N'Tablet')
GO
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV001', N'Đồng')
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV002', N'Bạc')
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV003', N'Vàng')
INSERT [dbo].[LoaiThanhVien] ([MaLoaiTVien], [TenLoaiTVien]) VALUES (N'LTV004', N'Kim cương')
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email], [DiaChi], [TrangThai]) VALUES (N'NCC001', N'Công Ty TNHH VIETHAS', N'0946712333', N'viethas@gmail.com', N'32 Lũy Bán Bích, Q. Tân Phú, HCM', N'1')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email], [DiaChi], [TrangThai]) VALUES (N'NCC002', N'Công Ty Cổ Phần Thiết Bị Hưng Phát ', N'0946777854', N'zendavn@gmail.com', N'Đống Đa, Hà Nội', N'1')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV001', N'Đỗ Thị Phương Anh', N'Nữ', N'anhthiphuongdo123@gmail.com', N'0983556448', N'TPHCM', N'LNV001', N'US009', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV002', N'Nguyễn Ngọc Bảo', N'Nam', N'baonguyenngoc@gmail.com', N'0946777827', N'Quảng Ngãi', N'LNV003', N'US005', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV003', N'Ngô Quốc Cường', N'Nam', N'cuongngoquoc@gmail.com', N'0982355479', N'TPHCM', N'LNV001', N'US010', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV004', N'Lồ Sin Dậu', N'Nam', N'daulosin@gmail.com', N'0898237581', N'TPHCM', N'LNV002', N'US002', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV005', N'Đoàn Trần Bá Đạt', N'Nam', N'badatdoan@gmail.com', N'0977420748', N'TPHCM', N'LNV002', N'US001', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV006', N'Nông Thảo Hiền', N'Nữ', N'hiennong@gmail.com', N'0935112869', N'TPHCM', N'LNV001', N'US011', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV007', N'Nguyễn Văn Vĩnh Hưng', N'Nam', N'hungnguyenvanvinh@gmail.com', N'0943555678', N'TPHCM', N'LNV001', N'US012', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV008', N'Đặng Duy Khánh', N'Nam', N'khanhdang@gmail.com', N'0933455899', N'TPHCM', N'LNV001', N'US013', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV009', N'Lê Tấn Khoa', N'Nam', N'khoaletan@gmail.com', N'0935113567', N'TPHCM', N'LNV001', N'US014', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV010', N'Nguyễn Văn Khôi', N'Nam', N'khoinguyen@gmail.com', N'0922355467', N'TPHCM', N'LNV001', N'US015', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV011', N'Nguyễn Thị Bích Kiều', N'Nữ', N'kieunguyen@gmail.com', N'0922115869', N'TPHCM', N'LNV002', N'US004', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV012', N'Lâm Minh Tuấn Kiện', N'Nam', N'kienlam@gmail.com', N'0955322867', N'TPHCM', N'LNV001', N'US016', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV013', N'Trần Hoàng Thanh Thy', N'Nữ', N'thygao@gmail.com', N'0922355918', N'TPHCM', N'LNV001', N'US017', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV014', N'Nguyễn Hoàn Thiện', N'Nam', N'thiennguyen@gmail.com', N'0935112448', N'TPHCM', N'LNV002', N'US003', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV015', N'Trần Tiến Phát', N'Nam', N'phattran@gmail.com', N'0982156878', N'TPHCM', N'LNV003', N'US006', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV016', N'Lê Thị Cẩm Hà', N'Nữ', N'hale@gmail.com', N'0981819175', N'TPHCM', N'LNV003', N'US007', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV017', N'Nguyễn Phương Duy', N'Nam', N'duynguyen@gmail.com', N'0983814358', N'TPHCM', N'LNV003', N'US018', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV018', N'Nguyễn Ngọc Nhã Thy', N'Nữ', N'thynguyen@gmail.com', N'0933525789', N'TPHCM', N'LNV003', N'US019', N'1')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [Email], [SĐT], [DiaChi], [MaLoaiNV], [MaNguoiDung], [TrangThai]) VALUES (N'NV019', N'Võ Ngọc Đan Thanh', N'Nữ', N'thanhvo@gmail.com', N'0943523479', N'TPHCM', N'LNV003', N'US008', N'1')
GO
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
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX014', N'Xiaomi')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX]) VALUES (N'SX015', N'Akko')
GO
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN001', CAST(N'2022-01-12T16:19:32.263' AS DateTime), N'NV015', N'NCC001', 161280000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN002', CAST(N'2022-01-20T16:20:04.000' AS DateTime), N'NV015', N'NCC001', 207855000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN003', CAST(N'2022-02-14T16:21:04.000' AS DateTime), N'NV002', N'NCC001', 181620000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN004', CAST(N'2022-02-24T16:21:38.000' AS DateTime), N'NV016', N'NCC002', 193023000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN005', CAST(N'2022-03-09T16:22:11.000' AS DateTime), N'NV017', N'NCC002', 66969000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN006', CAST(N'2022-03-25T16:22:51.000' AS DateTime), N'NV019', N'NCC001', 61470000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN007', CAST(N'2022-04-15T16:23:31.000' AS DateTime), N'NV002', N'NCC002', 156195000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN008', CAST(N'2022-04-30T16:23:57.000' AS DateTime), N'NV018', N'NCC002', 30150000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN009', CAST(N'2022-05-10T16:27:44.357' AS DateTime), N'NV002', N'NCC002', 264924000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN010', CAST(N'2022-05-19T16:28:42.000' AS DateTime), N'NV015', N'NCC001', 169047000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN011', CAST(N'2022-05-26T16:29:19.000' AS DateTime), N'NV019', N'NCC001', 264960000, N'1')
INSERT [dbo].[PhieuNhapHang] ([MaPN], [NgayTaoPN], [MaNV], [MaNCC], [ThanhTien], [TrangThai]) VALUES (N'PN012', CAST(N'2022-05-27T16:29:19.000' AS DateTime), N'NV017', N'NCC001', 200196000, N'1')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP001', N'Dell Inspiron 5515', 25, 19500000, N'L002', N'SX002', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP002', N'Macbook Air M1 2020', 22, 23500000, N'L002', N'SX003', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP003', N'HP Spectre', 18, 18000000, N'L002', N'SX006', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP004', N'Dell Vostro 3670MT J84NJ1', 23, 16500000, N'L001', N'SX002', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP005', N'Apple iMac 2017 MMQA2', 10, 41500000, N'L001', N'SX003', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP006', N'Iphone 13 Pro Max 256GB', 13, 33000000, N'L003', N'SX003', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP007', N'SamSung Galaxy A51', 35, 7500000, N'L003', N'SX004', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP008', N'Oppo Reno 7 Series', 24, 10490000, N'L003', N'SX008', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP009', N'Xiaomi Watch Life', 23, 1350000, N'L004', N'SX014', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP010', N'Apple Watch Series 7', 19, 8600000, N'L004', N'SX003', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP011', N'SamSung 24 inch', 17, 5000000, N'L005', N'SX004', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP012', N'Dell S2721H 27 inch', 29, 6290000, N'L005', N'SX002', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP013', N'LG Smart TV NanoCell', 25, 17990000, N'L006', N'SX011', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP014', N'Sony Smart TV 4K', 17, 12800000, N'L006', N'SX012', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP015', N'Tai nghe Sony WH-1000XM4', 19, 5490000, N'L007', N'SX012', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP016', N'Tai nghe Airpod 3 V/N', 18, 4490000, N'L007', N'SX003', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP017', N'Loa thanh Samsung HW', 19, 33990000, N'L008', N'SX004', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP018', N'Loa tháp Samsung MX', 15, 8290000, N'L008', N'SX004', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP019', N'Bàn Phím Logitech G Pro KDA', 25, 32690000, N'L009', N'SX013', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP020', N'Bàn phím Akko 3098N', 22, 2990000, N'L009', N'SX015', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP021', N'Samsung Galaxy Tab S8', 15, 20990000, N'L010', N'SX004', N'1')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [SoLuong], [DonGia], [MaLoaiSP], [MaNhaSX], [TrangThai]) VALUES (N'SP022', N'Ipad Pro M1 12.9 inch', 17, 29290000, N'L010', N'SX003', N'1')
GO
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US001', N'datdoan123', N'doantranbadat12345', N'LNV002')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US002', N'daulosin', N'dau123', N'LNV002')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US003', N'thiennguyen2455', N'thiennguyen231002', N'LNV002')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US004', N'bichkieu2002', N'bichkieu123', N'LNV002')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US005', N'bao201102', N'bao201102', N'LNV003')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US006', N'phattran123', N'trantienphat123456', N'LNV003')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US007', N'halethicam1604', N'camha160402', N'LNV003')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US008', N'danthanh2210', N'danthanh123', N'LNV003')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US009', N'anhthiphuongdo', N'anhdo12345', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US010', N'cuongngoquoc', N'cuongngo123', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US011', N'nongthaohien', N'hiennong120402', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US012', N'vinhhung123', N'vinhhung12345', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US013', N'khanhdang', N'dangduykhanh170102', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US014', N'khoaletan123', N'letankhoa1011002', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US015', N'vankhoi123', N'vankhoi12345', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US016', N'kienlamminhtuan', N'kiensinger123', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US017', N'thytranhoangthanh', N'thyg12345', N'LNV001')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US018', N'phuongduy', N'phuongduy123', N'LNV003')
INSERT [dbo].[TaiKhoan] ([MaNguoiDung], [UserName], [MatKhau], [MaLoaiNV]) VALUES (N'US019', N'thynha123', N'nhathy221102', N'LNV003')
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_NhaSanXuat] FOREIGN KEY([MaNhaSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNhaSX])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_NhaSanXuat]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhapHang] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhapHang] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhapHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK__KhachHang__MaLoa__3D5E1FD2] FOREIGN KEY([MaLoaiTVien])
REFERENCES [dbo].[LoaiThanhVien] ([MaLoaiTVien])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK__KhachHang__MaLoa__3D5E1FD2]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK__NhanVien__MaLoai__3E52440B] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK__NhanVien__MaLoai__3E52440B]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK__NhanVien__MaNguo__3F466844] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[TaiKhoan] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK__NhanVien__MaNguo__3F466844]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK__PhieuNhapH__MaNV__4316F928] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK__PhieuNhapH__MaNV__4316F928]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK__SanPham__MaLoaiS__47DBAE45] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK__SanPham__MaLoaiS__47DBAE45]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK__SanPham__MaNhaSX__48CFD27E] FOREIGN KEY([MaNhaSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNhaSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK__SanPham__MaNhaSX__48CFD27E]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK__DangNhap__MaLoai__398D8EEE] FOREIGN KEY([MaLoaiNV])
REFERENCES [dbo].[LoaiNhanVien] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK__DangNhap__MaLoai__398D8EEE]
GO
