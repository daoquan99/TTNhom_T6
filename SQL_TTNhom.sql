USE [QuanLyNhanVien]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 3/4/2020 9:28:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Luong] [money] NULL,
	[MaPB] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 3/4/2020 9:28:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [int] IDENTITY(1,1) NOT NULL,
	[TenPB] [nvarchar](20) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/4/2020 9:28:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[TenTk] [nchar](20) NOT NULL,
	[MatKhau] [nchar](20) NULL,
	[QuocTich] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[TenTk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong], [MaPB]) VALUES (2, N'Đào Mạnh Quân', CAST(N'1999-05-01' AS Date), N'Nam', 10000000.0000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong], [MaPB]) VALUES (3, N'Trần Duy Hải ', CAST(N'1998-02-01' AS Date), N'Nam', 6000000.0000, 2)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong], [MaPB]) VALUES (4, N'Nguyễn Thị Hạnh', CAST(N'1999-10-20' AS Date), N'Nữ', 4000000.0000, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [Luong], [MaPB]) VALUES (1007, N'nguyễn văn a', CAST(N'2020-03-03' AS Date), N'Nam', 1000000.0000, 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (1, N'Giám Đốc')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (2, N'Phó Giám Đốc')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (3, N'Nhân Sự')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (4, N'IT')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (5, N'Bảo Vệ')
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
INSERT [dbo].[User] ([TenTk], [MatKhau], [QuocTich], [GioiTinh]) VALUES (N'Khiem               ', N'123456              ', N'Việt Nam', N'Nam')
INSERT [dbo].[User] ([TenTk], [MatKhau], [QuocTich], [GioiTinh]) VALUES (N'ManhQuan            ', N'123456              ', N'VietNam', N'Nam')
INSERT [dbo].[User] ([TenTk], [MatKhau], [QuocTich], [GioiTinh]) VALUES (N'Thanh               ', N'123456              ', N'Việt Nam', N'Nam')
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
