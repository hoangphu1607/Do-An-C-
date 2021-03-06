USE [master]
GO
/****** Object:  Database [QLKho]    Script Date: 12/12/2020 12:56:10 PM ******/
CREATE DATABASE [QLKho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLKho.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLKho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLKho_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLKho] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKho] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKho] SET  MULTI_USER 
GO
ALTER DATABASE [QLKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKho] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLKho] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLKho]
GO
/****** Object:  Table [dbo].[CHI_TIET_NHAP]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHI_TIET_NHAP](
	[MaPhieu] [char](10) NOT NULL,
	[MaHang] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [numeric](18, 0) NULL,
 CONSTRAINT [KC_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHI_TIET_XUAT]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHI_TIET_XUAT](
	[MaPhieu] [char](10) NOT NULL,
	[MaHang] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [numeric](18, 0) NULL,
 CONSTRAINT [KC_chitiet] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DON_NHAP_KHO]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DON_NHAP_KHO](
	[MaDonNhapKho] [char](10) NOT NULL,
	[MaHang] [char](10) NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nvarchar](10) NULL,
 CONSTRAINT [KC_MaDonNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaDonNhapKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANG_HOA]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANG_HOA](
	[MaHang] [char](10) NOT NULL,
	[TenHang] [nvarchar](100) NULL,
	[DonViTinh] [nvarchar](10) NOT NULL,
	[MaNhomHang] [char](10) NOT NULL,
	[MaNhaCungCap] [char](10) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [numeric](18, 0) NULL,
 CONSTRAINT [KC_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[MaKhachHang] [char](10) NOT NULL,
	[TenKhach] [nvarchar](50) NULL,
	[Diachi] [nvarchar](100) NULL,
	[SDT] [char](10) NULL,
	[LoaiKH] [nvarchar](50) NULL,
 CONSTRAINT [KC_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaKhachMoiNhat]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaKhachMoiNhat](
	[MaKhachHang] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaMoiNhat]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaMoiNhat](
	[MaKhachHang] [char](10) NULL,
	[MaNhanVien] [char](10) NULL,
	[MaPhieuNhap] [char](10) NULL,
	[MaPhieuXuat] [char](10) NULL,
	[MaHang] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaNhanVienMoiNhat]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaNhanVienMoiNhat](
	[MaNhanVien] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaPhieuNhap_MoiNhat]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaPhieuNhap_MoiNhat](
	[MaPhieuNhap] [char](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHA_CUNG_CAP]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHA_CUNG_CAP](
	[MaNhaCungCap] [char](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[SDT] [char](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
 CONSTRAINT [KC_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MaNhanVien] [char](10) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [char](10) NULL,
 CONSTRAINT [KC_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOM_HANG]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOM_HANG](
	[MaNhom] [char](10) NOT NULL,
	[TenNhom] [nvarchar](100) NULL,
 CONSTRAINT [KC_MaNhom_Hang] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEU_NHAP]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEU_NHAP](
	[MaSoPhieuNhap] [char](10) NOT NULL,
	[NgayLapPhieu] [date] NULL,
	[MaNhanVien] [char](10) NULL,
 CONSTRAINT [KC_MaPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaSoPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEU_XUAT]    Script Date: 12/12/2020 12:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEU_XUAT](
	[MaSoPhieuXuat] [char](10) NOT NULL,
	[NgayLapPhieu] [date] NULL,
	[MaNhanVien] [char](10) NULL,
	[MaKhachHang] [char](10) NULL,
 CONSTRAINT [KC_MaPhieuNhapXuat] PRIMARY KEY CLUSTERED 
(
	[MaSoPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN11      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN11      ', N'TAP_HS_003', 2, CAST(5000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN12      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN12      ', N'TAP_HS_004', 1, CAST(15000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN13      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN14      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN15      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN15      ', N'TAP_HS_002', 1, CAST(10000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN15      ', N'TAP_HS_003', 2, CAST(5000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN16      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN17      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN17      ', N'TAP_HS_005', 205, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN18      ', N'TAP_HS_001', 5, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN18      ', N'TAP_HS_002', 20, CAST(10000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN22      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN22      ', N'TAP_HS_002', 1, CAST(10000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN23      ', N'TAP_HS_001', 1, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN23      ', N'TAP_HS_002', 69, CAST(10000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN24      ', N'0         ', 56, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN24      ', N'3         ', 100, CAST(5000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_NHAP] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PN25      ', N'TAP_HS_004', 50, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_XUAT] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'0         ', N'0         ', 6, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_XUAT] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PX4       ', N'0         ', 5, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_XUAT] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PX4       ', N'TAP_HS_001', 15, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[CHI_TIET_XUAT] ([MaPhieu], [MaHang], [SoLuong], [DonGia]) VALUES (N'PX4       ', N'TAP_HS_003', 100, CAST(5000 AS Numeric(18, 0)))
INSERT [dbo].[HANG_HOA] ([MaHang], [TenHang], [DonViTinh], [MaNhomHang], [MaNhaCungCap], [SoLuong], [DonGia]) VALUES (N'0         ', N'Viết Xanh ', N'Cây', N'TBHT000001', N'NCC02     ', 45, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[HANG_HOA] ([MaHang], [TenHang], [DonViTinh], [MaNhomHang], [MaNhaCungCap], [SoLuong], [DonGia]) VALUES (N'3         ', N'Khăn Giấy Vệ Sinh', N'Bịch', N'R01       ', N'NCC02     ', 100, CAST(5000 AS Numeric(18, 0)))
INSERT [dbo].[HANG_HOA] ([MaHang], [TenHang], [DonViTinh], [MaNhomHang], [MaNhaCungCap], [SoLuong], [DonGia]) VALUES (N'TAP_HS_001', N'Viết Tím', N'Cây', N'TBHT000001', N'NCC01     ', 90, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[HANG_HOA] ([MaHang], [TenHang], [DonViTinh], [MaNhomHang], [MaNhaCungCap], [SoLuong], [DonGia]) VALUES (N'TAP_HS_002', N'Viết Xám', N'Cây', N'TBHT000001', N'NCC01     ', 10, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[HANG_HOA] ([MaHang], [TenHang], [DonViTinh], [MaNhomHang], [MaNhaCungCap], [SoLuong], [DonGia]) VALUES (N'TAP_HS_003', N'Viết Hồng', N'Cây', N'TBHT000001', N'NCC01     ', 400, CAST(5000 AS Numeric(18, 0)))
INSERT [dbo].[HANG_HOA] ([MaHang], [TenHang], [DonViTinh], [MaNhomHang], [MaNhaCungCap], [SoLuong], [DonGia]) VALUES (N'TAP_HS_004', N'Viết Chì', N'Cây', N'TBHT000001', N'NCC01     ', 60, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[HANG_HOA] ([MaHang], [TenHang], [DonViTinh], [MaNhomHang], [MaNhaCungCap], [SoLuong], [DonGia]) VALUES (N'TAP_HS_005', N'Viết Xanh ', N'Cây', N'TBHT000002', N'NCC01     ', 10, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202001', N'Nguyễn Văn A', N'Vĩnh Long', N'079111511 ', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202002', N'Lê Văn Căn', N'Vinh Long', N'079955226 ', N'Khách Hàng Thân Thiết')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202003', N'Trịnh Văn D', N'Vĩnh Long', N'0790029911', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202008', N'Chánh Tâm', N'An Giang', N'0772875435', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202012', N'Long Rap godd', N'Vĩnh Long', N'0121363695', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202013', N'Võ Văn Còn', N'Vĩnh Long', N'0772875438', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202015', N'Ông Cao', N'Vĩnh Long', N'0236599554', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202017', N'Dũng Ct', N'Phú Thọ', N'0779552221', N'Khách Hàng Thân Thiết')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202018', N'Thành Khang', N'Vĩnh Long', N'0121603159', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[KHACH_HANG] ([MaKhachHang], [TenKhach], [Diachi], [SDT], [LoaiKH]) VALUES (N'KHTN202019', N'Long Võ', N'Vĩnh Long', N'0799517646', N'Khách Hàng Tiềm Năng')
INSERT [dbo].[MaKhachMoiNhat] ([MaKhachHang]) VALUES (N'NVTT202003')
INSERT [dbo].[MaMoiNhat] ([MaKhachHang], [MaNhanVien], [MaPhieuNhap], [MaPhieuXuat], [MaHang]) VALUES (N'KHTN202019', N'NNTT202012', N'PN25      ', N'PX4       ', N'3         ')
INSERT [dbo].[MaNhanVienMoiNhat] ([MaNhanVien]) VALUES (N'NNTT202009')
INSERT [dbo].[MaPhieuNhap_MoiNhat] ([MaPhieuNhap]) VALUES (N'PN24      ')
INSERT [dbo].[NHA_CUNG_CAP] ([MaNhaCungCap], [TenNhaCungCap], [SDT], [DiaChi]) VALUES (N'NCC01     ', N'Công Ty Thiên Long', N'0974133310', N'Vĩnh Long')
INSERT [dbo].[NHA_CUNG_CAP] ([MaNhaCungCap], [TenNhaCungCap], [SDT], [DiaChi]) VALUES (N'NCC02     ', N'Công Ty Bảo Nam', N'0975513610', N'Vĩnh Long')
INSERT [dbo].[NHA_CUNG_CAP] ([MaNhaCungCap], [TenNhaCungCap], [SDT], [DiaChi]) VALUES (N'NCC03     ', N'Công Ty Offic', N'0973306691', N'Vĩnh Long')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'NNTT202004', N'Võ Duy Long', N'Vĩnh Long', N'0728754367')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'NNTT202005', N'Võ Duy Nhuận', N'Vĩnh Long', N'0728754367')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'NNTT202010', N'Phú', N'An Giang', N'0799877897')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'NNTT202011', N'Test ter', N'An Giang', N'1234567890')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'NNTT202012', N'Trí Nguyên', N'Vĩnh Long', N'0125369631')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'NVTT202002', N'Lê Ngọc Duyen', N'Vĩnh Long', N'0121603991')
INSERT [dbo].[NHAN_VIEN] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'NVTT202003', N'Lê Vĩnh', N'Vĩnh Long', N'0121984300')
INSERT [dbo].[NHOM_HANG] ([MaNhom], [TenNhom]) VALUES (N'R01       ', N'Khăn Giấy')
INSERT [dbo].[NHOM_HANG] ([MaNhom], [TenNhom]) VALUES (N'R02       ', N'Keo Dán')
INSERT [dbo].[NHOM_HANG] ([MaNhom], [TenNhom]) VALUES (N'TAP_HS_001', N'Tập 96 trang')
INSERT [dbo].[NHOM_HANG] ([MaNhom], [TenNhom]) VALUES (N'TBHT000001', N'Tập')
INSERT [dbo].[NHOM_HANG] ([MaNhom], [TenNhom]) VALUES (N'TBHT000002', N'Viết')
INSERT [dbo].[NHOM_HANG] ([MaNhom], [TenNhom]) VALUES (N'TBHT000003', N'Thước')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'          ', CAST(N'2020-12-05' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN10      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN11      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN12      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN13      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN14      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN15      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN16      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN17      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN18      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN19      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN2       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN20      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN21      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN22      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN23      ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN24      ', CAST(N'2020-12-11' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN25      ', CAST(N'2020-12-11' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN3       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN4       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN5       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN6       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN7       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN8       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap], [NgayLapPhieu], [MaNhanVien]) VALUES (N'PN9       ', CAST(N'2020-11-28' AS Date), N'NNTT202004')
INSERT [dbo].[PHIEU_XUAT] ([MaSoPhieuXuat], [NgayLapPhieu], [MaNhanVien], [MaKhachHang]) VALUES (N'0         ', CAST(N'2020-12-11' AS Date), N'NNTT202004', N'KHTN202001')
INSERT [dbo].[PHIEU_XUAT] ([MaSoPhieuXuat], [NgayLapPhieu], [MaNhanVien], [MaKhachHang]) VALUES (N'PX2       ', CAST(N'2020-12-11' AS Date), N'NNTT202004', N'KHTN202001')
INSERT [dbo].[PHIEU_XUAT] ([MaSoPhieuXuat], [NgayLapPhieu], [MaNhanVien], [MaKhachHang]) VALUES (N'PX3       ', CAST(N'2020-12-11' AS Date), N'NNTT202010', N'KHTN202001')
INSERT [dbo].[PHIEU_XUAT] ([MaSoPhieuXuat], [NgayLapPhieu], [MaNhanVien], [MaKhachHang]) VALUES (N'PX4       ', CAST(N'2020-12-11' AS Date), N'NNTT202004', N'KHTN202017')
ALTER TABLE [dbo].[CHI_TIET_NHAP]  WITH CHECK ADD  CONSTRAINT [KP_HangHoa_Nhap] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANG_HOA] ([MaHang])
GO
ALTER TABLE [dbo].[CHI_TIET_NHAP] CHECK CONSTRAINT [KP_HangHoa_Nhap]
GO
ALTER TABLE [dbo].[CHI_TIET_NHAP]  WITH CHECK ADD  CONSTRAINT [PK_PhieuNhap] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEU_NHAP] ([MaSoPhieuNhap])
GO
ALTER TABLE [dbo].[CHI_TIET_NHAP] CHECK CONSTRAINT [PK_PhieuNhap]
GO
ALTER TABLE [dbo].[CHI_TIET_XUAT]  WITH CHECK ADD  CONSTRAINT [KP_HangHoa_NhapXuat] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANG_HOA] ([MaHang])
GO
ALTER TABLE [dbo].[CHI_TIET_XUAT] CHECK CONSTRAINT [KP_HangHoa_NhapXuat]
GO
ALTER TABLE [dbo].[CHI_TIET_XUAT]  WITH CHECK ADD  CONSTRAINT [PN_phieuxuat] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEU_XUAT] ([MaSoPhieuXuat])
GO
ALTER TABLE [dbo].[CHI_TIET_XUAT] CHECK CONSTRAINT [PN_phieuxuat]
GO
ALTER TABLE [dbo].[HANG_HOA]  WITH CHECK ADD  CONSTRAINT [KP_HangHoa] FOREIGN KEY([MaNhomHang])
REFERENCES [dbo].[NHOM_HANG] ([MaNhom])
GO
ALTER TABLE [dbo].[HANG_HOA] CHECK CONSTRAINT [KP_HangHoa]
GO
ALTER TABLE [dbo].[HANG_HOA]  WITH CHECK ADD  CONSTRAINT [KP_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHA_CUNG_CAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[HANG_HOA] CHECK CONSTRAINT [KP_NhaCungCap]
GO
ALTER TABLE [dbo].[PHIEU_NHAP]  WITH CHECK ADD  CONSTRAINT [KP_MaNhanVien2] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHAN_VIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEU_NHAP] CHECK CONSTRAINT [KP_MaNhanVien2]
GO
ALTER TABLE [dbo].[PHIEU_XUAT]  WITH CHECK ADD  CONSTRAINT [kn_kh] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACH_HANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEU_XUAT] CHECK CONSTRAINT [kn_kh]
GO
ALTER TABLE [dbo].[PHIEU_XUAT]  WITH CHECK ADD  CONSTRAINT [KP_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHAN_VIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEU_XUAT] CHECK CONSTRAINT [KP_MaNhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLKho] SET  READ_WRITE 
GO
