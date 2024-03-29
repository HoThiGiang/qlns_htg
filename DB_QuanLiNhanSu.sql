USE [master]
GO
/****** Object:  Database [QuanLiNhanSu_BTL]    Script Date: 5/10/2019 8:38:50 AM ******/
CREATE DATABASE [QuanLiNhanSu_BTL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiNhanSu_BTL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLiNhanSu_BTL.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiNhanSu_BTL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLiNhanSu_BTL_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiNhanSu_BTL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLiNhanSu_BTL]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaNV] [char](50) NOT NULL,
	[Thang] [char](50) NULL,
	[Nam] [char](50) NULL,
	[SoNgayCong] [char](50) NULL,
	[SoNgayNghi] [char](50) NULL,
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucDanh]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucDanh](
	[MaCD] [char](50) NOT NULL,
	[TenCD] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucDanh] PRIMARY KEY CLUSTERED 
(
	[MaCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangNhap](
	[TenDN] [char](50) NULL,
	[MatKhau] [char](50) NULL,
	[MaLoaiNguoiDung] [int] NULL,
	[MaDN] [int] NOT NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[MaDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiNguoiDung]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNguoiDung](
	[MaLoaiNguoiDung] [int] NOT NULL,
	[TenLoaiNguoiDung] [nvarchar](200) NULL,
 CONSTRAINT [PK_LoaiNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Luong]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Luong](
	[MaLuong] [char](50) NOT NULL,
	[MaCD] [char](50) NOT NULL,
	[LCB] [decimal](28, 0) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](50) NOT NULL,
	[MaPB] [char](50) NOT NULL,
	[MaCD] [char](50) NOT NULL,
	[LoaiHD] [nvarchar](50) NULL,
	[NgayKi] [date] NULL,
	[NgayKT] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [char](50) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhonngBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TangLuong]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TangLuong](
	[MaNV] [char](50) NOT NULL,
	[LCBCu] [decimal](18, 0) NULL,
	[LCBMoi] [decimal](18, 0) NULL,
	[PCCu] [decimal](18, 0) NULL,
	[PCMoi] [decimal](18, 0) NULL,
	[NgayTang] [date] NOT NULL,
 CONSTRAINT [PK_TangLuong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[NgayTang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThaiSan]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThaiSan](
	[MaNV] [char](50) NOT NULL,
	[NgayNghiSinh] [date] NULL,
	[NgayLamTroLai] [date] NULL,
	[TroCap] [decimal](28, 0) NULL,
 CONSTRAINT [PK_ThaiSan] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TTCaNhan]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TTCaNhan](
	[MaNV] [char](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[TTHonNhan] [nvarchar](50) NULL,
	[NgayCap] [date] NULL,
	[NoiCap] [nvarchar](50) NULL,
	[SĐT] [decimal](20, 0) NULL,
	[DanToc] [nvarchar](50) NULL,
	[TonGiao] [nvarchar](50) NULL,
	[HocVan] [nvarchar](50) NULL,
	[HocHam] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[SoCMND] [nvarchar](200) NULL,
 CONSTRAINT [PK_TTCaNhan] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_ThongKeLuongNhanVien]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_ThongKeLuongNhanVien]
 as
select HoTen, dem.Lan as SoLan, LCBMoi as LCB, tl.NgayTang
from TTCaNhan as tt,NhanVien as nv,TangLuong as tl, (select count(tl.MaNV) as Lan,MaNV from TangLuong as tl group by MaNV) as dem
where tt.MaNV=nv.MaNV and
      tl.MaNV=nv.MaNV and
	  dem.MaNV=tl.MaNV
 
GO
/****** Object:  View [dbo].[View_TinhLuongNhanVien]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_TinhLuongNhanVien]
as
select nv.MaNV, HoTen, TenCD, l.LCB, PCMoi , ((l.LCB+PCMoi)-SoNgayNghi*LCB/30) as N'Lương cứng' 
 from NhanVien as nv, TTCaNhan as ttcn, ChucDanh as cd, Luong as l, TangLuong as tl, ChamCong as cc 
 where ttcn.MaNV = nv.MaNV and nv.MaCD = cd.MaCD and cd.MaCD = l.MaCD and nv.MaCD = cd.MaCD and tl.MaNV= nv.MaNV and nv.MaNV=cc.MaNV 
GO
INSERT [dbo].[ChamCong] ([MaNV], [Thang], [Nam], [SoNgayCong], [SoNgayNghi]) VALUES (N'01                                                ', N'1                                                 ', N'2019                                              ', N'30                                                ', N'1                                                 ')
INSERT [dbo].[ChamCong] ([MaNV], [Thang], [Nam], [SoNgayCong], [SoNgayNghi]) VALUES (N'2                                                 ', N'1                                                 ', N'2019                                              ', N'31                                                ', N'0                                                 ')
INSERT [dbo].[ChamCong] ([MaNV], [Thang], [Nam], [SoNgayCong], [SoNgayNghi]) VALUES (N'3                                                 ', N'1                                                 ', N'2019                                              ', N'30                                                ', N'1                                                 ')
INSERT [dbo].[ChamCong] ([MaNV], [Thang], [Nam], [SoNgayCong], [SoNgayNghi]) VALUES (N'4                                                 ', N'1                                                 ', N'2019                                              ', N'28                                                ', N'3                                                 ')
INSERT [dbo].[ChamCong] ([MaNV], [Thang], [Nam], [SoNgayCong], [SoNgayNghi]) VALUES (N'5                                                 ', N'1                                                 ', N'2019                                              ', N'29                                                ', N'2                                                 ')
INSERT [dbo].[ChamCong] ([MaNV], [Thang], [Nam], [SoNgayCong], [SoNgayNghi]) VALUES (N'6                                                 ', N'1                                                 ', N'2019                                              ', N'30                                                ', N'1                                                 ')
INSERT [dbo].[ChucDanh] ([MaCD], [TenCD]) VALUES (N'1                                                 ', N'Chủ tịch')
INSERT [dbo].[ChucDanh] ([MaCD], [TenCD]) VALUES (N'2                                                 ', N'Giám đốc')
INSERT [dbo].[ChucDanh] ([MaCD], [TenCD]) VALUES (N'3                                                 ', N'Phó giám đốc')
INSERT [dbo].[ChucDanh] ([MaCD], [TenCD]) VALUES (N'4                                                 ', N'Trưởng phòng')
INSERT [dbo].[ChucDanh] ([MaCD], [TenCD]) VALUES (N'5                                                 ', N'Phó phòng')
INSERT [dbo].[ChucDanh] ([MaCD], [TenCD]) VALUES (N'6                                                 ', N'Nhân viên')
INSERT [dbo].[DangNhap] ([TenDN], [MatKhau], [MaLoaiNguoiDung], [MaDN]) VALUES (N'Giang                                             ', N'Giang                                             ', 1, 1)
INSERT [dbo].[DangNhap] ([TenDN], [MatKhau], [MaLoaiNguoiDung], [MaDN]) VALUES (N'linhgiang                                         ', N'linhgiang                                         ', 2, 2)
INSERT [dbo].[DangNhap] ([TenDN], [MatKhau], [MaLoaiNguoiDung], [MaDN]) VALUES (N'a                                                 ', N'a                                                 ', 1, 3)
INSERT [dbo].[DangNhap] ([TenDN], [MatKhau], [MaLoaiNguoiDung], [MaDN]) VALUES (N'b                                                 ', N'b                                                 ', 2, 4)
INSERT [dbo].[LoaiNguoiDung] ([MaLoaiNguoiDung], [TenLoaiNguoiDung]) VALUES (1, N'Bộ phận nhân sự')
INSERT [dbo].[LoaiNguoiDung] ([MaLoaiNguoiDung], [TenLoaiNguoiDung]) VALUES (2, N'Bộ phận tài chính')
INSERT [dbo].[Luong] ([MaLuong], [MaCD], [LCB], [GhiChu]) VALUES (N'1                                                 ', N'1                                                 ', CAST(40000000 AS Decimal(28, 0)), N'Chu tich')
INSERT [dbo].[Luong] ([MaLuong], [MaCD], [LCB], [GhiChu]) VALUES (N'2                                                 ', N'2                                                 ', CAST(25000000 AS Decimal(28, 0)), N'giám đốc')
INSERT [dbo].[Luong] ([MaLuong], [MaCD], [LCB], [GhiChu]) VALUES (N'3                                                 ', N'3                                                 ', CAST(20000000 AS Decimal(28, 0)), N'phó giám đốc')
INSERT [dbo].[Luong] ([MaLuong], [MaCD], [LCB], [GhiChu]) VALUES (N'4                                                 ', N'4                                                 ', CAST(15000000 AS Decimal(28, 0)), N'Trưởng phòng')
INSERT [dbo].[Luong] ([MaLuong], [MaCD], [LCB], [GhiChu]) VALUES (N'5                                                 ', N'5                                                 ', CAST(10000000 AS Decimal(28, 0)), N'Phó phòng')
INSERT [dbo].[Luong] ([MaLuong], [MaCD], [LCB], [GhiChu]) VALUES (N'6                                                 ', N'6                                                 ', CAST(100000000 AS Decimal(28, 0)), N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [MaPB], [MaCD], [LoaiHD], [NgayKi], [NgayKT]) VALUES (N'01                                                ', N'1                                                 ', N'1                                                 ', N'Dài hạn', CAST(N'2019-10-02' AS Date), CAST(N'2021-10-01' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [MaPB], [MaCD], [LoaiHD], [NgayKi], [NgayKT]) VALUES (N'2                                                 ', N'1                                                 ', N'2                                                 ', N'Dài hạn', CAST(N'2018-12-02' AS Date), CAST(N'2023-02-12' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [MaPB], [MaCD], [LoaiHD], [NgayKi], [NgayKT]) VALUES (N'3                                                 ', N'1                                                 ', N'3                                                 ', N'Dài hạn', CAST(N'2019-05-22' AS Date), CAST(N'2021-07-22' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [MaPB], [MaCD], [LoaiHD], [NgayKi], [NgayKT]) VALUES (N'4                                                 ', N'1                                                 ', N'4                                                 ', N'Ngắn ngày', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [MaPB], [MaCD], [LoaiHD], [NgayKi], [NgayKT]) VALUES (N'5                                                 ', N'1                                                 ', N'5                                                 ', N'Ngắn ngày', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [MaPB], [MaCD], [LoaiHD], [NgayKi], [NgayKT]) VALUES (N'6                                                 ', N'1                                                 ', N'6                                                 ', N'Ngắn ngày', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [MaPB], [MaCD], [LoaiHD], [NgayKi], [NgayKT]) VALUES (N'7                                                 ', N'3                                                 ', N'1                                                 ', N'Dài hạn', CAST(N'2019-05-22' AS Date), CAST(N'2021-07-22' AS Date))
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'1                                                 ', N'CNTT')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'2                                                 ', N'Mạng nội bộ')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'3                                                 ', N'Y tế')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'4                                                 ', N'Giáo dục')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'5                                                 ', N'Kế toán')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'6                                                 ', N'Quản lí nhân sự')
INSERT [dbo].[TangLuong] ([MaNV], [LCBCu], [LCBMoi], [PCCu], [PCMoi], [NgayTang]) VALUES (N'01                                                ', CAST(10000000 AS Decimal(18, 0)), CAST(15000000 AS Decimal(18, 0)), CAST(5000000 AS Decimal(18, 0)), CAST(8000000 AS Decimal(18, 0)), CAST(N'2018-10-02' AS Date))
INSERT [dbo].[TangLuong] ([MaNV], [LCBCu], [LCBMoi], [PCCu], [PCMoi], [NgayTang]) VALUES (N'01                                                ', CAST(20000000 AS Decimal(18, 0)), CAST(30000000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)), CAST(4000000 AS Decimal(18, 0)), CAST(N'2019-02-03' AS Date))
INSERT [dbo].[TangLuong] ([MaNV], [LCBCu], [LCBMoi], [PCCu], [PCMoi], [NgayTang]) VALUES (N'2                                                 ', CAST(8000000 AS Decimal(18, 0)), CAST(12000000 AS Decimal(18, 0)), CAST(5000000 AS Decimal(18, 0)), CAST(8000000 AS Decimal(18, 0)), CAST(N'2018-10-02' AS Date))
INSERT [dbo].[TangLuong] ([MaNV], [LCBCu], [LCBMoi], [PCCu], [PCMoi], [NgayTang]) VALUES (N'3                                                 ', CAST(6000000 AS Decimal(18, 0)), CAST(10000000 AS Decimal(18, 0)), CAST(4000000 AS Decimal(18, 0)), CAST(7000000 AS Decimal(18, 0)), CAST(N'2018-02-10' AS Date))
INSERT [dbo].[TangLuong] ([MaNV], [LCBCu], [LCBMoi], [PCCu], [PCMoi], [NgayTang]) VALUES (N'4                                                 ', CAST(7000000 AS Decimal(18, 0)), CAST(10000000 AS Decimal(18, 0)), CAST(7000000 AS Decimal(18, 0)), CAST(8000000 AS Decimal(18, 0)), CAST(N'2018-02-10' AS Date))
INSERT [dbo].[ThaiSan] ([MaNV], [NgayNghiSinh], [NgayLamTroLai], [TroCap]) VALUES (N'01                                                ', CAST(N'2019-04-16' AS Date), CAST(N'2019-04-25' AS Date), CAST(10000000 AS Decimal(28, 0)))
INSERT [dbo].[ThaiSan] ([MaNV], [NgayNghiSinh], [NgayLamTroLai], [TroCap]) VALUES (N'2                                                 ', CAST(N'2019-04-16' AS Date), CAST(N'2019-04-25' AS Date), CAST(200000 AS Decimal(28, 0)))
INSERT [dbo].[ThaiSan] ([MaNV], [NgayNghiSinh], [NgayLamTroLai], [TroCap]) VALUES (N'3                                                 ', CAST(N'2019-04-12' AS Date), CAST(N'2019-04-30' AS Date), CAST(200000 AS Decimal(28, 0)))
INSERT [dbo].[ThaiSan] ([MaNV], [NgayNghiSinh], [NgayLamTroLai], [TroCap]) VALUES (N'4                                                 ', CAST(N'2019-04-12' AS Date), CAST(N'2019-04-30' AS Date), CAST(200000 AS Decimal(28, 0)))
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'01                                                ', N'Mau Linh', CAST(N'1998-12-08' AS Date), N'Nu', N'Nghe An', N'DocThan', NULL, NULL, CAST(1215228163 AS Decimal(20, 0)), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'1                                                 ', N'Hồ Linh Giang', CAST(N'1998-07-12' AS Date), N'Nữ', N'Nghệ An', N'Độc thân', CAST(N'2015-06-11' AS Date), N'Nghệ An', CAST(123 AS Decimal(20, 0)), N'kinh', N'Không', N'Tiến sĩ', N'Giáo sư', N'Không', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'10                                                ', N'Hồ Kim Giang', CAST(N'1998-08-04' AS Date), N'', N'Nghệ An', N'độc thân', CAST(N'2019-04-02' AS Date), N'CA tỉnh nghệ an', NULL, N'', N'không', N'', N'', N'', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'11                                                ', N'Thầy Khánh', CAST(N'1981-07-30' AS Date), N'Nam', N'Nghệ An', N'độc thân', CAST(N'2019-04-08' AS Date), N'CA thành phố hà nội', CAST(3727414 AS Decimal(20, 0)), N'Kinh', N'không', N'Kĩ sư đại học', N'Phó giáo sư', N'Không', N'123                                                                                                                                                                                                     ')
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'12                                                ', N'Hồ Kim Giang', CAST(N'1998-08-04' AS Date), N'Nữ', N'Nghệ An', N'độc thân', CAST(N'2019-04-02' AS Date), N'CA tỉnh nghệ an', NULL, N'', N'không', N'Tiến sĩ', N'Giáo sư', N'Không', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'13                                                ', N'Nguyễn Quốc Khánh', CAST(N'1981-07-22' AS Date), N'Nam', N'Hà Nội', N'độc thân', CAST(N'2019-04-03' AS Date), N'CA thành phố hà nội', CAST(3372312 AS Decimal(20, 0)), N'Kinh', N'không', N'Kĩ sư đại học', N'Phó giáo sư', N'Không', N'1011372')
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'2                                                 ', N'Hồ thị Giang', CAST(N'2019-04-10' AS Date), N'Nữ', N'Nghệ an', N'độc thân', CAST(N'2019-04-10' AS Date), N'Nghệ an', CAST(7885 AS Decimal(20, 0)), N'Kinh', N'không', N'Đại học', N'Không', N'Không', N'1234567                                                                                                                                                                                                 ')
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'3                                                 ', N'Nguyễn thị linh', CAST(N'1997-03-16' AS Date), N'Nữ', N'Quảng Ninh', N'Độc thân', CAST(N'2015-01-02' AS Date), N'hn', NULL, N'Kinh', N'Không', N'Thạc sĩ', N'Giáo sư', N'Không', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'4                                                 ', N'Phạm tiến Minh', CAST(N'1997-01-02' AS Date), N'Nam', N'Nghệ an', N'Độc thân', CAST(N'1997-02-22' AS Date), N'Nghệ an', NULL, N'Kinh', N'không', N'Kĩ sư đại học', N'Giáo sư', N'Không', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'5                                                 ', N'Hồ Minh Tiến', CAST(N'1997-03-04' AS Date), N'', N'Hà Nội', N'Đã kết hôn', CAST(N'1996-03-10' AS Date), N'Hà Nội', NULL, N'', N'không', N'', N'', N'', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'6                                                 ', N'Hồ Văn Phương', CAST(N'1996-02-10' AS Date), N'Nam', N'Nghệ an', N'Độc thân', CAST(N'2010-02-10' AS Date), N'Nghệ an', NULL, N'Kinh', N'Không', N'Đại học', N'không', N'employee', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'7                                                 ', N'Hồ Thị Giang', CAST(N'1998-08-12' AS Date), N'', N'Nghệ An', N'độc thân', CAST(N'2019-04-11' AS Date), N'CA tỉnh nghệ an', NULL, N'', N'không', N'', N'', N'', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'8                                                 ', N'Hồ Thị Hoa', CAST(N'1990-11-01' AS Date), N'', N'Nghệ an', N'Độc thân', CAST(N'2009-10-28' AS Date), N'Nghệ an', NULL, N'', N'Không', N'', N'', N'', NULL)
INSERT [dbo].[TTCaNhan] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [QueQuan], [TTHonNhan], [NgayCap], [NoiCap], [SĐT], [DanToc], [TonGiao], [HocVan], [HocHam], [GhiChu], [SoCMND]) VALUES (N'9                                                 ', N'Hồ Thị Giang', CAST(N'1998-08-12' AS Date), N'', N'Nghệ an', N'Độc thân', CAST(N'2009-10-28' AS Date), N'Nghệ an', NULL, N'', N'Không', N'', N'', N'', NULL)
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_ChamCong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK_ChamCong_NhanVien]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_DangNhap_LoaiNguoiDung] FOREIGN KEY([MaLoaiNguoiDung])
REFERENCES [dbo].[LoaiNguoiDung] ([MaLoaiNguoiDung])
GO
ALTER TABLE [dbo].[DangNhap] CHECK CONSTRAINT [FK_DangNhap_LoaiNguoiDung]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_ChucDanh] FOREIGN KEY([MaCD])
REFERENCES [dbo].[ChucDanh] ([MaCD])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_ChucDanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucDanh] FOREIGN KEY([MaCD])
REFERENCES [dbo].[ChucDanh] ([MaCD])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucDanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TTCaNhan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TTCaNhan] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TTCaNhan]
GO
ALTER TABLE [dbo].[TangLuong]  WITH CHECK ADD  CONSTRAINT [FK_TangLuong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TangLuong] CHECK CONSTRAINT [FK_TangLuong_NhanVien]
GO
ALTER TABLE [dbo].[ThaiSan]  WITH CHECK ADD  CONSTRAINT [FK_ThaiSan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThaiSan] CHECK CONSTRAINT [FK_ThaiSan_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[THEMNHANVIEN_PC]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THEMNHANVIEN_PC](@MaNV char(50),
                                 @MaPB char(50),
								 @MaCD char(50),
								 @LoaiHD nvarchar(50),
								 @NgayKi datetime,
								 @NgayKT datetime
								 )
as
begin
       if(exists(select * from NhanVien where MaNV=@MaNV))
	      print N' đã tồn tại mã nhân viên có mã trên'
	   else  
		    insert into NhanVien
		    values(@MaNV, @MaPB,@MaCD,@LoaiHD, @NgayKi,@NgayKT)
		    
end
GO
/****** Object:  StoredProcedure [dbo].[THEMPB]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[THEMPB](@MaPB char(50),
                         @TenPB nvarchar(50)
						 )
as
begin
       if(exists(select * from PhongBan where MaPB=@MaPB))
	      print N' đã tồn tại Phòng Ban có mã trên'
	   else  
		    insert into PhongBan
		    values(@MaPB, @TenPB)
		    
end
GO
/****** Object:  StoredProcedure [dbo].[THEMTTCaNhan_PC]    Script Date: 5/10/2019 8:38:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THEMTTCaNhan_PC](@MaNV char(50),
                                 @HoTen nvarchar(50),
								 @NgaySinh datetime,
								 @GioiTinh nvarchar(50),
								 @QueQuan nvarchar(50),
								 @TTHonNhan nvarchar(50),
								 @SoCMND char(50),
								 @NgayCap datetime,
								 @NoiCap nvarchar(50),
								 @SĐT char(50),
								 @DanToc nvarchar(50),
								 @TonGiao nvarchar(50),
								 @HocVan nvarchar(50),
								 @HocHam nvarchar(50),
								 @GhiChu nvarchar(50)
								 )
as
begin
       if(exists(select * from TTCaNhan where MaNV=@MaNV))
	      print N' đã tồn tại mã nhân viên có mã trên'
	   else  
		    insert into TTCaNhan
		    values(@MaNV, @HoTen, @NgaySinh, @GioiTinh, @QueQuan, @TTHonNhan, @SoCMND, @NgayCap, @NoiCap, @SĐT, @DanToc,@TonGiao, @HocVan, @HocHam, @GhiChu)
		    
end
GO
USE [master]
GO
ALTER DATABASE [QuanLiNhanSu_BTL] SET  READ_WRITE 
GO
