USE [QUANLYTUYENDUNG]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 5/9/2022 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[IdCongViec] [int] NOT NULL,
	[TenCV] [nchar](50) NULL,
	[IdPhongBan] [int] NOT NULL,
 CONSTRAINT [PK_CongViec] PRIMARY KEY CLUSTERED 
(
	[IdCongViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVienTuyenDung]    Script Date: 5/9/2022 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVienTuyenDung](
	[IdNhanVien] [int] NOT NULL,
	[TenNhanVien] [nchar](40) NULL,
	[IdPhongBan] [int] NOT NULL,
 CONSTRAINT [PK_NhanVienTuyenDung] PRIMARY KEY CLUSTERED 
(
	[IdNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 5/9/2022 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[IdPhongBan] [int] NOT NULL,
	[TenPhongBan] [nchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[IdPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UngVien]    Script Date: 5/9/2022 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UngVien](
	[IdUngVien] [int] NOT NULL,
	[Ten] [nchar](40) NULL,
	[Tuoi] [int] NULL,
	[GioiTinh] [bit] NULL,
	[HinhAnh] [varbinary](max) NULL,
	[KinhNghiem] [nchar](100) NULL,
	[HocVan] [nchar](50) NULL,
	[TiengAnh] [nchar](50) NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT] [nchar](15) NULL,
	[Email] [nchar](100) NULL,
	[CreatedAt] [datetime] NULL,
	[Duyet] [int] NULL,
 CONSTRAINT [PK_UngVien] PRIMARY KEY CLUSTERED 
(
	[IdUngVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UngVienDaChon]    Script Date: 5/9/2022 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UngVienDaChon](
	[IdCongViec] [int] NOT NULL,
	[IdNhanVien] [int] NOT NULL,
	[IdUngVien] [int] NOT NULL,
 CONSTRAINT [PK_UngVienDaChon] PRIMARY KEY CLUSTERED 
(
	[IdUngVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauCongViec]    Script Date: 5/9/2022 11:11:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauCongViec](
	[IdCongViec] [int] NOT NULL,
	[KinhNghiem] [nchar](100) NULL,
	[HocVan] [nchar](50) NULL,
	[TiengAnh] [nchar](50) NULL,
	[SoLuong] [int] NULL,
	[Luong] [money] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CongViec]  WITH CHECK ADD  CONSTRAINT [FK_CongViec_PhongBan] FOREIGN KEY([IdPhongBan])
REFERENCES [dbo].[PhongBan] ([IdPhongBan])
GO
ALTER TABLE [dbo].[CongViec] CHECK CONSTRAINT [FK_CongViec_PhongBan]
GO
ALTER TABLE [dbo].[NhanVienTuyenDung]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienTuyenDung_PhongBan] FOREIGN KEY([IdPhongBan])
REFERENCES [dbo].[PhongBan] ([IdPhongBan])
GO
ALTER TABLE [dbo].[NhanVienTuyenDung] CHECK CONSTRAINT [FK_NhanVienTuyenDung_PhongBan]
GO
ALTER TABLE [dbo].[UngVienDaChon]  WITH CHECK ADD  CONSTRAINT [FK_UngVienDaChon_CongViec] FOREIGN KEY([IdCongViec])
REFERENCES [dbo].[CongViec] ([IdCongViec])
GO
ALTER TABLE [dbo].[UngVienDaChon] CHECK CONSTRAINT [FK_UngVienDaChon_CongViec]
GO
ALTER TABLE [dbo].[UngVienDaChon]  WITH CHECK ADD  CONSTRAINT [FK_UngVienDaChon_NhanVienTuyenDung] FOREIGN KEY([IdNhanVien])
REFERENCES [dbo].[NhanVienTuyenDung] ([IdNhanVien])
GO
ALTER TABLE [dbo].[UngVienDaChon] CHECK CONSTRAINT [FK_UngVienDaChon_NhanVienTuyenDung]
GO
ALTER TABLE [dbo].[UngVienDaChon]  WITH CHECK ADD  CONSTRAINT [FK_UngVienDaChon_UngVien] FOREIGN KEY([IdUngVien])
REFERENCES [dbo].[UngVien] ([IdUngVien])
GO
ALTER TABLE [dbo].[UngVienDaChon] CHECK CONSTRAINT [FK_UngVienDaChon_UngVien]
GO
ALTER TABLE [dbo].[YeuCauCongViec]  WITH CHECK ADD  CONSTRAINT [FK_YeuCauCongViec_CongViec] FOREIGN KEY([IdCongViec])
REFERENCES [dbo].[CongViec] ([IdCongViec])
GO
ALTER TABLE [dbo].[YeuCauCongViec] CHECK CONSTRAINT [FK_YeuCauCongViec_CongViec]
GO
