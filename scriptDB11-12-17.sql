USE [QLNV_XiNghiep]
GO
/****** Object:  Table [dbo].[BANGCAP]    Script Date: 11/12/2017 7:45:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGCAP](
	[MABC] [int] IDENTITY(1,1) NOT NULL,
	[TENBC] [nvarchar](255) NULL,
	[HESO] [float] NULL,
 CONSTRAINT [PK_BANGCAP] PRIMARY KEY CLUSTERED 
(
	[MABC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHAMCONG]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHAMCONG](
	[MACC] [varchar](10) NOT NULL,
	[MANV] [varchar](10) NOT NULL,
	[THANG] [int] NULL,
	[NAM] [int] NULL,
	[SONGAY] [int] NULL,
	[D1] [varchar](5) NULL,
	[D2] [varchar](5) NULL,
	[D3] [varchar](5) NULL,
	[D4] [varchar](5) NULL,
	[D5] [varchar](5) NULL,
	[D6] [varchar](5) NULL,
	[D7] [varchar](5) NULL,
	[D8] [varchar](5) NULL,
	[D9] [varchar](5) NULL,
	[D10] [varchar](5) NULL,
	[D11] [varchar](5) NULL,
	[D12] [varchar](5) NULL,
	[D13] [varchar](5) NULL,
	[D14] [varchar](5) NULL,
	[D15] [varchar](5) NULL,
	[D16] [varchar](5) NULL,
	[D17] [varchar](5) NULL,
	[D18] [varchar](5) NULL,
	[D19] [varchar](5) NULL,
	[D20] [varchar](5) NULL,
	[D21] [varchar](5) NULL,
	[D22] [varchar](5) NULL,
	[D23] [varchar](5) NULL,
	[D24] [varchar](5) NULL,
	[D25] [varchar](5) NULL,
	[D26] [varchar](5) NULL,
	[D27] [varchar](5) NULL,
	[D28] [varchar](5) NULL,
	[D29] [varchar](5) NULL,
	[D30] [varchar](5) NULL,
	[D31] [varchar](5) NULL,
 CONSTRAINT [PK_CHAMCONG] PRIMARY KEY CLUSTERED 
(
	[MACC] ASC,
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MACV] [varchar](5) NOT NULL,
	[TENCV] [nvarchar](255) NULL,
 CONSTRAINT [PK_CHUCVU_1] PRIMARY KEY CLUSTERED 
(
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANTOC]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANTOC](
	[MADT] [varchar](5) NOT NULL,
	[TENDT] [nvarchar](255) NULL,
 CONSTRAINT [PK_DANTOC] PRIMARY KEY CLUSTERED 
(
	[MADT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HESOLUONG]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HESOLUONG](
	[MABACHSL] [int] NOT NULL,
	[MACV] [varchar](5) NOT NULL,
	[HESO] [float] NULL,
	[GHICHU] [nvarchar](255) NULL,
 CONSTRAINT [PK_HESOLUONG] PRIMARY KEY CLUSTERED 
(
	[MABACHSL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HESOLUONGND]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HESOLUONGND](
	[MABACND] [int] NOT NULL,
	[MACV] [varchar](5) NOT NULL,
	[HESO] [float] NULL,
 CONSTRAINT [PK_HESOLUONGND] PRIMARY KEY CLUSTERED 
(
	[MABACND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOPDONGLAODONG]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOPDONGLAODONG](
	[MAHDLD] [varchar](15) NOT NULL,
	[MANV] [varchar](10) NULL,
	[LOAIHD] [nvarchar](100) NULL,
	[TUNGAY] [datetime] NULL,
	[DENNGAY] [datetime] NULL,
	[DIADIEMLAM] [nvarchar](255) NULL,
	[CHUCVU] [varchar](5) NULL,
	[CONGVIEC] [nvarchar](255) NULL,
	[THOIGIANLAM] [float] NULL,
	[TRANGBILAODONG] [nvarchar](255) NULL,
	[HESOLUONG] [float] NULL,
	[PHUCAP] [float] NULL,
	[NGAYKY] [datetime] NULL,
 CONSTRAINT [PK_HOPDONGLAODONG] PRIMARY KEY CLUSTERED 
(
	[MAHDLD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOPDONGLAODONG_THOIVIEC]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOPDONGLAODONG_THOIVIEC](
	[MAHDLDTV] [varchar](15) NOT NULL,
	[MANV] [varchar](10) NULL,
	[SOQDINH] [varchar](50) NULL,
	[NGAYQDINH] [datetime] NULL,
	[LYDO] [nvarchar](255) NULL,
 CONSTRAINT [PK_HOPDONGLAODONG_THOIVIEC] PRIMARY KEY CLUSTERED 
(
	[MAHDLDTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KYHIEUCHAMCONG]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KYHIEUCHAMCONG](
	[KYHIEU] [varchar](5) NOT NULL,
	[DIENGIAI] [nvarchar](255) NULL,
 CONSTRAINT [PK_KYHIEUCHAMCONG] PRIMARY KEY CLUSTERED 
(
	[KYHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIND]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIND](
	[MALOAI] [varchar](5) NOT NULL,
	[TENLOAI] [nvarchar](255) NULL,
 CONSTRAINT [PK_LOAINGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MOIQUANHE]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOIQUANHE](
	[MAQH] [int] IDENTITY(1,1) NOT NULL,
	[TENMQH] [nvarchar](255) NULL,
 CONSTRAINT [PK_MOIQUANHE] PRIMARY KEY CLUSTERED 
(
	[MAQH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[TAIKHOAN] [varchar](255) NOT NULL,
	[MATKHAU] [varchar](255) NOT NULL,
	[LOAIND] [varchar](5) NULL,
	[MANV] [varchar](10) NULL,
	[TRANGTHAI] [bit] NOT NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [varchar](10) NOT NULL,
	[HO] [nvarchar](35) NULL,
	[TEN] [nvarchar](20) NULL,
	[NGAYSINH] [date] NULL,
	[DIACHI] [nvarchar](255) NULL,
	[CMND] [varchar](12) NULL,
	[GIOITINH] [bit] NULL,
	[NGUYENQUAN] [nvarchar](255) NULL,
	[TINHTHANH] [varchar](2) NULL,
	[QUANHUYEN] [varchar](2) NULL,
	[QUOCTICH] [varchar](5) NULL,
	[DANTOC] [varchar](5) NULL,
	[TONGIAO] [varchar](5) NULL,
	[NGAYBATDAU] [date] NULL,
	[PHONG] [varchar](5) NULL,
	[MABACND] [int] NULL,
	[MABACHSL] [int] NULL,
	[MACV] [varchar](5) NULL,
	[BANGCAP] [int] NULL,
	[TRANGTHAI] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHATKY]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHATKY](
	[MANK] [bigint] IDENTITY(1,1) NOT NULL,
	[TAIKHOAN] [varchar](255) NOT NULL,
	[THOIGIANDANGNHAP] [datetime] NULL,
	[THOIGIANDANGXUAT] [datetime] NULL,
 CONSTRAINT [PK_NHATKY_1] PRIMARY KEY CLUSTERED 
(
	[MANK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MAPB] [varchar](5) NOT NULL,
	[TENPB] [nvarchar](255) NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[MAPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUOCTICH]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUOCTICH](
	[MAQT] [varchar](5) NOT NULL,
	[TENQT] [nvarchar](255) NULL,
 CONSTRAINT [PK_QUOCTICH] PRIMARY KEY CLUSTERED 
(
	[MAQT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYDINHLUONG]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QUYDINHLUONG](
	[MAQD] [varchar](5) NOT NULL,
	[LUONGTOITHIEU] [decimal](18, 0) NULL,
	[GIOCONG] [float] NULL,
	[BHXH] [float] NULL,
	[BHYT] [float] NULL,
	[BHTN] [float] NULL,
 CONSTRAINT [PK_QUYDINHLUONG] PRIMARY KEY CLUSTERED 
(
	[MAQD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TINHQUANHUYEN]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TINHQUANHUYEN](
	[MATINH] [varchar](2) NOT NULL,
	[MAQH] [varchar](2) NOT NULL,
	[TENTINH] [nvarchar](255) NULL,
	[TENQH] [nvarchar](255) NULL,
 CONSTRAINT [PK_TINHQUANHUYEN] PRIMARY KEY CLUSTERED 
(
	[MATINH] ASC,
	[MAQH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TONGIAO]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TONGIAO](
	[MATG] [varchar](5) NOT NULL,
	[TENTG] [nvarchar](255) NULL,
 CONSTRAINT [PK_TONGIAO] PRIMARY KEY CLUSTERED 
(
	[MATG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THANNHAN]    Script Date: 11/12/2017 7:45:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THANNHAN](
	[MAQHGD] [int] IDENTITY(1,1) NOT NULL,
	[MANV] [varchar](10) NOT NULL,
	[HOTEN] [nvarchar](60) NULL,
	[MOIQH] [int] NULL,
	[NGAYSINH] [date] NULL,
	[NGHENGHIEP] [nvarchar](255) NULL,
 CONSTRAINT [PK_QUANHEGIADINH] PRIMARY KEY CLUSTERED 
(
	[MAQHGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[BANGCAP] ON 

INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (1, N'1/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (2, N'2/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (3, N'3/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (4, N'4/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (5, N'5/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (6, N'6/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (7, N'7/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (8, N'8/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (9, N'9/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (10, N'10/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (11, N'11/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (12, N'12/12', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (13, N'Trung Cấp', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (14, N'Cao Đẳng', NULL)
INSERT [dbo].[BANGCAP] ([MABC], [TENBC], [HESO]) VALUES (15, N'Đại Học', NULL)
SET IDENTITY_INSERT [dbo].[BANGCAP] OFF
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC1', N'NV100', 1, 2017, 31, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC1', N'NV80', 1, 2017, 31, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC1', N'NV83', 1, 2017, 31, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC1', N'NV86', 1, 2017, 31, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC1', N'NV87', 1, 2017, 31, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC2', N'NV95', 2, 2017, 28, N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', NULL, NULL, NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC3', N'NV100', 4, 2017, 30, N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC3', N'NV80', 4, 2017, 30, N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC3', N'NV83', 4, 2017, 30, N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC3', N'NV86', 4, 2017, 30, N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC3', N'NV87', 4, 2017, 30, N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC3', N'NV95', 4, 2017, 30, N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC4', N'NV100', 4, 2018, 30, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC4', N'NV80', 4, 2018, 30, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC4', N'NV83', 4, 2018, 30, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC4', N'NV86', 4, 2018, 30, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC4', N'NV87', 4, 2018, 30, N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV1', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV10', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV11', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV12', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV13', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV14', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV15', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV16', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV17', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV18', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV19', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV2', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV20', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV21', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV22', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV23', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV24', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV25', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV26', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV27', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV28', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV29', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV3', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV30', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV31', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV32', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV33', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV34', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV35', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV36', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV37', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV38', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV39', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV4', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV40', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV41', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV42', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV43', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV44', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV45', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV46', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV47', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV48', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV49', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV5', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV50', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV51', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV52', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV53', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV54', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV55', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV56', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV57', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV58', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV59', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV6', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV60', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV61', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV62', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV63', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV64', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV65', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV66', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV67', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV68', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV69', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV7', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV70', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV71', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV72', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV73', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV74', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV75', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV76', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV77', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV78', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV79', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV8', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV81', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV82', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV84', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV85', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV88', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
GO
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV89', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV9', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC5', N'NV90', 5, 2017, 31, N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8')
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC6', N'NV100', 2, 2017, 28, N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', NULL, NULL, NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC6', N'NV80', 2, 2017, 28, N'P', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', NULL, NULL, NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC6', N'NV83', 2, 2017, 28, N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', NULL, NULL, NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC6', N'NV86', 2, 2017, 28, N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', NULL, NULL, NULL)
INSERT [dbo].[CHAMCONG] ([MACC], [MANV], [THANG], [NAM], [SONGAY], [D1], [D2], [D3], [D4], [D5], [D6], [D7], [D8], [D9], [D10], [D11], [D12], [D13], [D14], [D15], [D16], [D17], [D18], [D19], [D20], [D21], [D22], [D23], [D24], [D25], [D26], [D27], [D28], [D29], [D30], [D31]) VALUES (N'CC6', N'NV87', 2, 2017, 28, N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', N'8', N'8', N'8', N'8', N'CN', N'8', N'8', NULL, NULL, NULL)
INSERT [dbo].[CHUCVU] ([MACV], [TENCV]) VALUES (N'CV1', N'Giám Đốc')
INSERT [dbo].[CHUCVU] ([MACV], [TENCV]) VALUES (N'CV2', N'Phó Giám Đốc')
INSERT [dbo].[CHUCVU] ([MACV], [TENCV]) VALUES (N'CV3', N'Kế Toán')
INSERT [dbo].[CHUCVU] ([MACV], [TENCV]) VALUES (N'CV4', N'Công Nhân May')
INSERT [dbo].[CHUCVU] ([MACV], [TENCV]) VALUES (N'CV5', N'Bảo Vệ')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT1', N'Kinh')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT10', N'Gia Rai')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT11', N'Ê Đê')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT12', N'Ba Na')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT13', N'Xơ Đăng')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT14', N'Sán Chay')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT15', N'Cơ Ho')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT16', N'Chăm')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT17', N'Sán Dìu')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT18', N'Hrê')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT19', N'Ra Glai')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT2', N'Tày')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT20', N'M''Nông')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT21', N'X''Tiêng')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT22', N'Bru-Vân Kiều')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT23', N'Thổ')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT24', N'Khơ Mú')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT25', N'Cơ Tu')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT26', N'Giáy')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT27', N'Giẻ Triêng')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT28', N'Tà Ôi')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT29', N'Mạ')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT3', N'Thái')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT30', N'Co')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT31', N'Chơ Ro')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT32', N'Xinh Mun')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT33', N'Hà Nhì')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT34', N'Chu Ru')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT35', N'Lào')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT36', N'Kháng')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT37', N'La Chí')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT38', N'Phù Lá')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT39', N'La Hủ')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT4', N'Mường')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT40', N'La Ha')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT41', N'Pà Thẻn')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT42', N'Chứt')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT43', N'Lự')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT44', N'Lô Lô')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT45', N'Mảng')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT46', N'Cờ Lao')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT47', N'Bố Y')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT48', N'Cống')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT49', N'Ngái')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT5', N'Khơ Me')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT50', N'	Si La')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT51', N'Pu Péo')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT52', N'Rơ măm')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT53', N'Brâu')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT54', N'Ơ Đu')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT6', N'H''Mông')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT7', N'Nùng')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT8', N'Hoa')
INSERT [dbo].[DANTOC] ([MADT], [TENDT]) VALUES (N'DT9', N'Dao')
INSERT [dbo].[HESOLUONGND] ([MABACND], [MACV], [HESO]) VALUES (1, N'CV1', 2.5)
INSERT [dbo].[KYHIEUCHAMCONG] ([KYHIEU], [DIENGIAI]) VALUES (N'8', N'Làm 8 giờ / ngày')
INSERT [dbo].[KYHIEUCHAMCONG] ([KYHIEU], [DIENGIAI]) VALUES (N'CN', N'Chủ nhật')
INSERT [dbo].[KYHIEUCHAMCONG] ([KYHIEU], [DIENGIAI]) VALUES (N'P', N'Nghỉ có phép')
INSERT [dbo].[LOAIND] ([MALOAI], [TENLOAI]) VALUES (N'L1', N'Administrator')
INSERT [dbo].[LOAIND] ([MALOAI], [TENLOAI]) VALUES (N'L2', N'Kế Toán')
INSERT [dbo].[LOAIND] ([MALOAI], [TENLOAI]) VALUES (N'L3', N'Tra Cứu')
SET IDENTITY_INSERT [dbo].[MOIQUANHE] ON 

INSERT [dbo].[MOIQUANHE] ([MAQH], [TENMQH]) VALUES (1, N'Vợ - Chồng')
INSERT [dbo].[MOIQUANHE] ([MAQH], [TENMQH]) VALUES (2, N'Cha - Con')
INSERT [dbo].[MOIQUANHE] ([MAQH], [TENMQH]) VALUES (3, N'Mẹ - Con')
INSERT [dbo].[MOIQUANHE] ([MAQH], [TENMQH]) VALUES (4, N'Anh - Em')
INSERT [dbo].[MOIQUANHE] ([MAQH], [TENMQH]) VALUES (5, N'Chị - Em')
SET IDENTITY_INSERT [dbo].[MOIQUANHE] OFF
INSERT [dbo].[NGUOIDUNG] ([TAIKHOAN], [MATKHAU], [LOAIND], [MANV], [TRANGTHAI]) VALUES (N'admin', N'123', N'L1', N'NV1', 1)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV1', N'Vũ Bích', N'My', CAST(0x5EE80A00 AS Date), N'828 Đông Du', N'324211720195', 0, N'758 Đặng Tất', N'02', N'21', N'QT1', N'DT24', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV10', N'Phạm Tín', N'Tự', CAST(0x24310B00 AS Date), N'336 Hàm Nghi', N'969164440131', 1, N'880 Đặng Tất', N'02', N'23', N'QT1', N'DT16', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV100', N'Lê Bá', N'Phương', CAST(0x19010B00 AS Date), N'850 Huỳnh Khương Ninh', N'640514027988', 1, N'494 Đặng Tất', N'02', N'21', N'QT1', N'DT8', N'TG2', CAST(0x693D0B00 AS Date), N'PB2', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV11', N'Đặng Phú', N'Thúy', CAST(0x590E0B00 AS Date), N'630 Hai Bà Trưng', N'178499981979', 0, N'637 Hàng Bún', N'02', N'16', N'QT1', N'DT29', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV12', N'Trần Hiếu', N'Ngạn', CAST(0x29330B00 AS Date), N'382 Đồng Khởi', N'647950071838', 0, N'463 Hàng Bún', N'02', N'01', N'QT1', N'DT42', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV13', N'Phạm Đức', N'Tôn', CAST(0x75EE0A00 AS Date), N'428 Huỳnh Khương Ninh', N'527529460230', 1, N'332 Quán Thánh', N'02', N'01', N'QT1', N'DT27', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV14', N'Hoàng Trung', N'An', CAST(0x14E40A00 AS Date), N'559 Cách Mạng Tháng Tám', N'018242299051', 0, N'561 Quốc Tử Giám', N'02', N'17', N'QT1', N'DT51', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV15', N'Nguyễn Tú', N'Thúy', CAST(0xD2EE0A00 AS Date), N'650 Hòa Mỹ', N'649905033986', 1, N'315 Phố Tràng Tiền', N'02', N'12', N'QT1', N'DT20', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV16', N'Võ Diệp', N'Quyết', CAST(0x2B0A0B00 AS Date), N'364 Cách Mạng Tháng Tám', N'236250931693', 1, N'315 Đặng Tất', N'02', N'20', N'QT1', N'DT44', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV17', N'Nguyễn Thục', N'Hoàn', CAST(0x72E90A00 AS Date), N'673 Huỳnh Thúc Kháng', N'173953957597', 0, N'665 Quốc Tử Giám', N'02', N'17', N'QT1', N'DT30', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV18', N'Dương Nghĩa', N'My', CAST(0x2C3D0B00 AS Date), N'491 Hoàng Sa', N'945420602100', 0, N'35 Bích Câu', N'02', N'13', N'QT1', N'DT21', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV19', N'Phan Cát', N'Nhung', CAST(0x5A250B00 AS Date), N'846 Huỳnh Thúc Kháng', N'504812094582', 0, N'128 Bích Câu', N'02', N'02', N'QT1', N'DT20', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV2', N'Đặng Trí', N'Khue', CAST(0x43090B00 AS Date), N'796 Đông Du', N'770294667198', 0, N'20 Đặng Tất', N'02', N'14', N'QT1', N'DT22', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV20', N'Nguyễn Kim', N'Hà', CAST(0x051A0B00 AS Date), N'729 Hồ Tùng Mậu', N'217003964821', 0, N'244 Khương Trung', N'02', N'03', N'QT1', N'DT44', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV21', N'Nguyễn Bảo', N'Hoàn', CAST(0xC2F60A00 AS Date), N'775 Hòa Mỹ', N'441109107234', 1, N'270 Khương Trung', N'02', N'15', N'QT1', N'DT41', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV22', N'Lê Tuệ', N'Trinh', CAST(0x58260B00 AS Date), N'403 Hàm Nghi', N'804449346320', 1, N'143 Khương Trung', N'02', N'03', N'QT1', N'DT16', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV23', N'Lý Trí', N'Giang', CAST(0x78320B00 AS Date), N'637 Đông Du', N'259813578346', 1, N'840 Quốc Tử Giám', N'02', N'13', N'QT1', N'DT32', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV24', N'Huỳnh Văn', N'Khue', CAST(0x27EA0A00 AS Date), N'174 Hồ Tùng Mậu', N'199547598220', 0, N'103 Phố Tràng Tiền', N'02', N'02', N'QT1', N'DT48', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV25', N'Ngô Cát', N'Khanh', CAST(0xBB3C0B00 AS Date), N'610 Hai Bà Trưng', N'952548512084', 0, N'537 Bà Huyện Thanh Quan', N'02', N'07', N'QT1', N'DT7', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV26', N'Đỗ Thục', N'Hân', CAST(0x110F0B00 AS Date), N'492 Hòa Mỹ', N'928366656735', 0, N'236 Bích Câu', N'02', N'12', N'QT1', N'DT18', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV27', N'Phi Khiêm', N'Bích', CAST(0xD2E70A00 AS Date), N'540 Hồ Tùng Mậu', N'989882293996', 0, N'766 Bà Huyện Thanh Quan', N'02', N'11', N'QT1', N'DT41', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV28', N'Trần Kim', N'Cấn', CAST(0xD3F70A00 AS Date), N'349 Hồ Tùng Mậu', N'102083400551', 0, N'765 Lê Duẩn', N'02', N'23', N'QT1', N'DT46', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV29', N'Ngô Tín', N'Bách', CAST(0x21240B00 AS Date), N'663 Hồ Tùng Mậu', N'912267311756', 1, N'636 Hoàng Hoa Thám', N'02', N'06', N'QT1', N'DT35', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV3', N'Đặng Phú', N'Khương', CAST(0xD9FE0A00 AS Date), N'231 Hai Bà Trưng', N'285985845577', 0, N'451 Hàng Bún', N'02', N'22', N'QT1', N'DT51', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV30', N'Nguyễn Tín', N'Giang', CAST(0x18300B00 AS Date), N'622 Hàm Nghi', N'862989093126', 0, N'761 Khương Trung', N'02', N'19', N'QT1', N'DT10', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV31', N'Nguyễn Kim', N'Khue', CAST(0x71260B00 AS Date), N'661 Ký Con', N'356322432886', 1, N'784 Khương Trung', N'02', N'06', N'QT1', N'DT53', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV32', N'Phan Diệp', N'Lan', CAST(0x15F20A00 AS Date), N'27 Hòa Mỹ', N'093667545521', 1, N'386 Hàng Bún', N'02', N'09', N'QT1', N'DT45', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV33', N'Dương Khiêm', N'Uyên', CAST(0x86180B00 AS Date), N'435 Đồng Khởi', N'052155879680', 0, N'36 Quốc Tử Giám', N'02', N'19', N'QT1', N'DT22', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV34', N'Vũ Nhân', N'Khue', CAST(0x1FFB0A00 AS Date), N'285 Ký Con', N'009821398598', 1, N'624 Đặng Tất', N'02', N'06', N'QT1', N'DT26', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV35', N'Đỗ Đức', N'Kỷ', CAST(0x920C0B00 AS Date), N'825 Huỳnh Khương Ninh', N'533567083526', 0, N'85 Bích Câu', N'02', N'10', N'QT1', N'DT44', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV36', N'Đỗ Cát', N'Khánh', CAST(0xAA190B00 AS Date), N'211 Hòa Mỹ', N'028700731265', 0, N'512 Lê Duẩn', N'02', N'02', N'QT1', N'DT7', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV37', N'Đỗ Tín', N'Diệp', CAST(0x22E50A00 AS Date), N'752 Huỳnh Khương Ninh', N'861312346361', 1, N'86 Lê Duẩn', N'02', N'12', N'QT1', N'DT26', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV38', N'Đặng Cát', N'Tịch', CAST(0xF3EC0A00 AS Date), N'491 Đông Du', N'121150757280', 0, N'889 Bà Huyện Thanh Quan', N'02', N'20', N'QT1', N'DT7', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV39', N'Trần Văn', N'Đạo', CAST(0x08E20A00 AS Date), N'838 Huỳnh Thúc Kháng', N'269785727870', 0, N'298 Quán Thánh', N'02', N'06', N'QT1', N'DT28', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV4', N'Phi Huyền', N'Dung', CAST(0xF1F00A00 AS Date), N'9 Huyền Quang', N'999022889705', 1, N'465 Phố Tràng Tiền', N'02', N'19', N'QT1', N'DT30', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV40', N'Dương Bảo', N'Châu', CAST(0x40330B00 AS Date), N'505 Đồng Khởi', N'666018066667', 1, N'445 Hàng Bún', N'02', N'01', N'QT1', N'DT9', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV41', N'Trần Khiêm', N'Nhi', CAST(0xF7030B00 AS Date), N'565 Bà Lê Chân', N'967150857115', 0, N'642 Quán Thánh', N'02', N'17', N'QT1', N'DT26', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV42', N'Nguyễn Nhã', N'Giang', CAST(0xB4F20A00 AS Date), N'385 Hàm Nghi', N'356163435159', 1, N'284 Bà Huyện Thanh Quan', N'02', N'02', N'QT1', N'DT8', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV43', N'Nguyễn Tuệ', N'Đan', CAST(0x41F00A00 AS Date), N'826 Ký Con', N'463821460181', 1, N'463 Đặng Tất', N'02', N'01', N'QT1', N'DT5', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV44', N'Đỗ Trung', N'Bá', CAST(0x31210B00 AS Date), N'454 Cách Mạng Tháng Tám', N'756601255066', 0, N'315 Khương Trung', N'02', N'16', N'QT1', N'DT32', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV45', N'Đặng Bích', N'Tịch', CAST(0x5D1D0B00 AS Date), N'515 Bà Lê Chân', N'290212271879', 0, N'106 Khương Trung', N'02', N'05', N'QT1', N'DT44', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV46', N'Trần Huyền', N'Quyết', CAST(0x8C170B00 AS Date), N'794 Hai Bà Trưng', N'793664527430', 0, N'341 Hoàng Hoa Thám', N'02', N'02', N'QT1', N'DT45', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV47', N'Nguyễn Ngọc', N'Hương', CAST(0x0D1A0B00 AS Date), N'265 Hai Bà Trưng', N'683389339763', 1, N'153 Hoàng Hoa Thám', N'02', N'07', N'QT1', N'DT1', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV48', N'Hồ Bảo', N'Vy', CAST(0xC4F60A00 AS Date), N'767 Huỳnh Thúc Kháng', N'114790088790', 0, N'694 Khương Trung', N'02', N'19', N'QT1', N'DT41', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV49', N'Phi Bích', N'An', CAST(0x52FD0A00 AS Date), N'418 Ký Con', N'868144975953', 0, N'158 Phố Tràng Tiền', N'02', N'18', N'QT1', N'DT7', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV5', N'Hồ Nghĩa', N'Hương', CAST(0x32330B00 AS Date), N'896 Ký Con', N'154613122592', 1, N'172 Lê Duẩn', N'02', N'08', N'QT1', N'DT36', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV50', N'Hoàng Thục', N'Nhung', CAST(0xC5180B00 AS Date), N'879 Hàm Nghi', N'988153902044', 0, N'542 Quốc Tử Giám', N'02', N'08', N'QT1', N'DT24', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV51', N'Phan Phú', N'Khue', CAST(0x56360B00 AS Date), N'796 Hai Bà Trưng', N'083644298252', 0, N'200 Quán Thánh', N'02', N'11', N'QT1', N'DT23', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV52', N'Vũ Bảo', N'Hân', CAST(0x01F70A00 AS Date), N'616 Ký Con', N'128579725070', 0, N'631 Hoàng Hoa Thám', N'02', N'10', N'QT1', N'DT13', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV53', N'Bùi Trí', N'Mai', CAST(0x83FF0A00 AS Date), N'72 Bà Lê Chân', N'183578881316', 1, N'528 Quốc Tử Giám', N'02', N'14', N'QT1', N'DT36', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV54', N'Bùi Tín', N'Hoa', CAST(0x4BE80A00 AS Date), N'600 Huỳnh Khương Ninh', N'132076472602', 0, N'892 Hoàng Hoa Thám', N'02', N'16', N'QT1', N'DT7', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV55', N'Hồ Phú', N'Đan', CAST(0xD8280B00 AS Date), N'61 Đông Du', N'442322890246', 0, N'107 Phố Tràng Tiền', N'02', N'12', N'QT1', N'DT20', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV56', N'Vũ Phương', N'Linh', CAST(0x70FF0A00 AS Date), N'547 Huỳnh Khương Ninh', N'061047071244', 0, N'18 Quán Thánh', N'02', N'19', N'QT1', N'DT9', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV57', N'Phi Phú', N'Mai', CAST(0x34140B00 AS Date), N'48 Hàm Nghi', N'665950758102', 1, N'88 Lê Duẩn', N'02', N'02', N'QT1', N'DT43', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV58', N'Hồ Trung', N'Khanh', CAST(0xC3F40A00 AS Date), N'724 Huyền Quang', N'545941588690', 0, N'863 Bích Câu', N'02', N'20', N'QT1', N'DT4', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV59', N'Trần Bảo', N'Khue', CAST(0xA0F10A00 AS Date), N'427 Hoàng Sa', N'443552110875', 1, N'258 Đặng Tất', N'02', N'13', N'QT1', N'DT23', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV6', N'Lê Bảo', N'My', CAST(0x38ED0A00 AS Date), N'341 Bà Lê Chân', N'584434929339', 0, N'157 Hàng Bún', N'02', N'05', N'QT1', N'DT19', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV60', N'Phi Phương', N'Giang', CAST(0x32040B00 AS Date), N'552 Hồ Tùng Mậu', N'693048896940', 1, N'809 Phố Tràng Tiền', N'02', N'20', N'QT1', N'DT18', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV61', N'Bùi Đức', N'Uyên', CAST(0x78E50A00 AS Date), N'691 Đông Du', N'112975596541', 1, N'561 Bích Câu', N'02', N'19', N'QT1', N'DT32', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV62', N'Đặng Thục', N'Vân', CAST(0x392E0B00 AS Date), N'250 Ký Con', N'720599276025', 0, N'151 Hàng Bún', N'02', N'19', N'QT1', N'DT3', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV63', N'Ngô Kiều', N'Uyên', CAST(0xC2020B00 AS Date), N'844 Ký Con', N'843080450344', 1, N'610 Bích Câu', N'02', N'03', N'QT1', N'DT6', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV64', N'Bùi Bích', N'Chi', CAST(0xAD150B00 AS Date), N'172 Hàm Nghi', N'014428814232', 1, N'165 Hàng Bún', N'02', N'14', N'QT1', N'DT32', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV65', N'Lý Dương', N'Quyết', CAST(0xC5EA0A00 AS Date), N'838 Hồ Tùng Mậu', N'729766318712', 0, N'506 Đặng Tất', N'02', N'17', N'QT1', N'DT16', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV66', N'Nguyễn Phú', N'Bách', CAST(0x56FC0A00 AS Date), N'665 Bà Lê Chân', N'150619048658', 0, N'833 Hoàng Hoa Thám', N'02', N'08', N'QT1', N'DT37', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV67', N'Lê Tú', N'Mai', CAST(0xB4FA0A00 AS Date), N'888 Cách Mạng Tháng Tám', N'485811051125', 0, N'242 Hoàng Hoa Thám', N'02', N'06', N'QT1', N'DT20', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV68', N'Đặng Thục', N'Ngạn', CAST(0xBF300B00 AS Date), N'351 Đồng Khởi', N'069392620227', 0, N'207 Quán Thánh', N'02', N'20', N'QT1', N'DT2', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV69', N'Ngô Trí', N'An', CAST(0xEB140B00 AS Date), N'300 Hồ Tùng Mậu', N'710519417128', 1, N'112 Phố Tràng Tiền', N'02', N'08', N'QT1', N'DT7', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV7', N'Hoàng Ngọc', N'Dung', CAST(0xA3E80A00 AS Date), N'731 Hòa Mỹ', N'563420958072', 1, N'228 Bà Huyện Thanh Quan', N'02', N'18', N'QT1', N'DT49', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV70', N'Huỳnh Bảo', N'Như', CAST(0x91120B00 AS Date), N'294 Ký Con', N'159775102464', 0, N'546 Khương Trung', N'02', N'10', N'QT1', N'DT14', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV71', N'Lê Nghĩa', N'Hương', CAST(0x1A050B00 AS Date), N'209 Hoàng Sa', N'064502815709', 0, N'242 Quán Thánh', N'02', N'09', N'QT1', N'DT18', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV72', N'Hồ Phú', N'Ngân', CAST(0xE8390B00 AS Date), N'58 Hàm Nghi', N'044160884124', 1, N'461 Lê Duẩn', N'02', N'21', N'QT1', N'DT24', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV73', N'Vũ Kim', N'Bích', CAST(0x353B0B00 AS Date), N'357 Cách Mạng Tháng Tám', N'295411435654', 0, N'599 Hoàng Hoa Thám', N'02', N'08', N'QT1', N'DT46', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV74', N'Phi Nghĩa', N'Vân', CAST(0x842F0B00 AS Date), N'243 Ký Con', N'591531234062', 1, N'404 Phố Tràng Tiền', N'02', N'01', N'QT1', N'DT11', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV75', N'Phan Dương', N'Liêu', CAST(0x20F60A00 AS Date), N'514 Cách Mạng Tháng Tám', N'193268084920', 1, N'575 Phố Tràng Tiền', N'02', N'11', N'QT1', N'DT18', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV76', N'Đỗ Thành', N'Trinh', CAST(0x1FE40A00 AS Date), N'434 Huỳnh Khương Ninh', N'730336449967', 0, N'368 Quốc Tử Giám', N'02', N'14', N'QT1', N'DT34', N'TG2', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV77', N'Ngô Cát', N'Bách', CAST(0x29160B00 AS Date), N'273 Hàm Nghi', N'825388922331', 0, N'761 Quán Thánh', N'02', N'03', N'QT1', N'DT12', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV78', N'Phạm Hiếu', N'Mai', CAST(0x59F10A00 AS Date), N'599 Huyền Quang', N'827766056089', 1, N'303 Bà Huyện Thanh Quan', N'02', N'21', N'QT1', N'DT1', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV79', N'Hoàng Cát', N'Trinh', CAST(0x340A0B00 AS Date), N'57 Huỳnh Khương Ninh', N'080861213533', 1, N'594 Đặng Tất', N'02', N'22', N'QT1', N'DT4', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV8', N'Huỳnh Nhã', N'Vân', CAST(0x79E90A00 AS Date), N'396 Đông Du', N'113245430644', 1, N'130 Phố Tràng Tiền', N'02', N'08', N'QT1', N'DT40', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV80', N'Ngô Thành', N'Hương', CAST(0x40050B00 AS Date), N'827 Đông Du', N'279509830850', 0, N'774 Hoàng Hoa Thám', N'02', N'06', N'QT1', N'DT15', N'TG4', CAST(0x693D0B00 AS Date), N'PB2', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV81', N'Ngô Huyền', N'Chi', CAST(0x6D320B00 AS Date), N'782 Đông Du', N'968390074620', 1, N'651 Hàng Bún', N'02', N'06', N'QT1', N'DT18', N'TG5', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV82', N'Lê Huyền', N'Vân', CAST(0x782E0B00 AS Date), N'794 Hòa Mỹ', N'816101828348', 0, N'858 Quán Thánh', N'02', N'16', N'QT1', N'DT1', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV83', N'Lê Diệp', N'Cấn', CAST(0xEA370B00 AS Date), N'399 Hồ Tùng Mậu', N'645724813989', 0, N'739 Hàng Bún', N'02', N'06', N'QT1', N'DT39', N'TG3', CAST(0x693D0B00 AS Date), N'PB2', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV84', N'Võ Nhân', N'Diệp', CAST(0x6DEB0A00 AS Date), N'707 Huỳnh Thúc Kháng', N'391245964978', 0, N'508 Hoàng Hoa Thám', N'02', N'23', N'QT1', N'DT11', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV85', N'Đỗ Kim', N'My', CAST(0x2C370B00 AS Date), N'24 Hòa Mỹ', N'363902262965', 0, N'146 Bích Câu', N'02', N'09', N'QT1', N'DT41', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV86', N'Bùi Kim', N'My', CAST(0x810F0B00 AS Date), N'343 Ký Con', N'534970783670', 0, N'827 Hoàng Hoa Thám', N'02', N'21', N'QT1', N'DT40', N'TG5', CAST(0x693D0B00 AS Date), N'PB2', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV87', N'Dương Cát', N'Vân', CAST(0xFB2F0B00 AS Date), N'266 Huyền Quang', N'957337466635', 1, N'565 Đặng Tất', N'02', N'19', N'QT1', N'DT10', N'TG1', CAST(0x693D0B00 AS Date), N'PB2', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV88', N'Đỗ Tú', N'Tịch', CAST(0x4D100B00 AS Date), N'315 Cách Mạng Tháng Tám', N'191071632671', 1, N'458 Phố Tràng Tiền', N'02', N'03', N'QT1', N'DT16', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV89', N'Đỗ Văn', N'Diệp', CAST(0xB10F0B00 AS Date), N'106 Ký Con', N'009328569294', 1, N'494 Phố Tràng Tiền', N'02', N'18', N'QT1', N'DT6', N'TG3', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV9', N'Phan Khiêm', N'Lan', CAST(0x5C080B00 AS Date), N'425 Hoàng Sa', N'734478572404', 1, N'333 Lê Duẩn', N'02', N'08', N'QT1', N'DT42', N'TG4', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV90', N'Lê Huyền', N'Ngân', CAST(0x34ED0A00 AS Date), N'463 Huỳnh Khương Ninh', N'583459880988', 0, N'667 Bà Huyện Thanh Quan', N'02', N'16', N'QT1', N'DT36', N'TG1', CAST(0x693D0B00 AS Date), N'PB4', NULL, NULL, N'CV4', NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV91', N'Võ Trí', N'Cấn', CAST(0x88E50A00 AS Date), N'575 Hai Bà Trưng', N'971194838623', 1, N'514 Hàng Bún', N'02', N'01', N'QT1', N'DT18', N'TG1', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV92', N'Nguyễn Diệp', N'Khải', CAST(0xC82D0B00 AS Date), N'799 Huỳnh Khương Ninh', N'804817689648', 1, N'773 Quán Thánh', N'02', N'16', N'QT1', N'DT23', N'TG2', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV93', N'Trần Nhã', N'My', CAST(0xBD380B00 AS Date), N'95 Ký Con', N'828278011044', 1, N'793 Quốc Tử Giám', N'02', N'08', N'QT1', N'DT37', N'TG2', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV94', N'Đặng Tú', N'Khánh', CAST(0x3F1B0B00 AS Date), N'639 Hồ Tùng Mậu', N'636445586955', 1, N'666 Hàng Bún', N'02', N'10', N'QT1', N'DT10', N'TG1', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV95', N'Nguyễn Bảo', N'Liêu', CAST(0xDA2D0B00 AS Date), N'413 Hoàng Sa', N'406320822337', 1, N'178 Bích Câu', N'02', N'07', N'QT1', N'DT31', N'TG3', CAST(0x693D0B00 AS Date), N'PB3', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV96', N'Đặng Tú', N'Hương', CAST(0x27130B00 AS Date), N'199 Hồ Tùng Mậu', N'556050175018', 1, N'202 Quán Thánh', N'02', N'23', N'QT1', N'DT24', N'TG2', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV97', N'Đặng Trí', N'Vân', CAST(0x5C2D0B00 AS Date), N'586 Đông Du', N'014416186386', 1, N'825 Bích Câu', N'02', N'24', N'QT1', N'DT2', N'TG5', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV98', N'Đặng Văn', N'Châu', CAST(0xFD170B00 AS Date), N'889 Bà Lê Chân', N'279122230999', 0, N'794 Phố Tràng Tiền', N'02', N'11', N'QT1', N'DT26', N'TG2', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [HO], [TEN], [NGAYSINH], [DIACHI], [CMND], [GIOITINH], [NGUYENQUAN], [TINHTHANH], [QUANHUYEN], [QUOCTICH], [DANTOC], [TONGIAO], [NGAYBATDAU], [PHONG], [MABACND], [MABACHSL], [MACV], [BANGCAP], [TRANGTHAI]) VALUES (N'NV99', N'Hồ Ngọc', N'Thúy', CAST(0x7E160B00 AS Date), N'725 Hồ Tùng Mậu', N'952578949720', 1, N'791 Khương Trung', N'02', N'24', N'QT1', N'DT16', N'TG1', CAST(0x693D0B00 AS Date), N'PB1', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[PHONGBAN] ([MAPB], [TENPB]) VALUES (N'PB1', N'Phòng Nhân Sự')
INSERT [dbo].[PHONGBAN] ([MAPB], [TENPB]) VALUES (N'PB2', N'Phòng cắt vải')
INSERT [dbo].[PHONGBAN] ([MAPB], [TENPB]) VALUES (N'PB3', N'Phòng Giám Đốc')
INSERT [dbo].[PHONGBAN] ([MAPB], [TENPB]) VALUES (N'PB4', N'Xưởng may')
INSERT [dbo].[QUOCTICH] ([MAQT], [TENQT]) VALUES (N'QT1', N'Việt Nam')
INSERT [dbo].[QUOCTICH] ([MAQT], [TENQT]) VALUES (N'QT2', N'Mỹ')
INSERT [dbo].[QUOCTICH] ([MAQT], [TENQT]) VALUES (N'QT3', N'Anh')
INSERT [dbo].[QUYDINHLUONG] ([MAQD], [LUONGTOITHIEU], [GIOCONG], [BHXH], [BHYT], [BHTN]) VALUES (N'QD1', CAST(3750000 AS Decimal(18, 0)), 8, 0.08, 0.015, 0.01)
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'01', N'TP.HCM', N'Quận 1')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'02', N'TP.HCM', N'Quận 2')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'03', N'TP.HCM', N'Quận 3')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'04', N'TP.HCM', N'Quận 4')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'05', N'TP.HCM', N'Quận 5')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'06', N'TP.HCM', N'Quận 6')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'07', N'TP.HCM', N'Quận 7')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'08', N'TP.HCM', N'Quận 8')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'09', N'TP.HCM', N'Quận 9')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'10', N'TP.HCM', N'Quận 10')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'11', N'TP.HCM', N'Quận 11')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'12', N'TP.HCM', N'Quận 12')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'13', N'TP.HCM', N'Quận Gò Vấp')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'14', N'TP.HCM', N'Quận Tân Bình')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'15', N'TP.HCM', N'Quận Tân Phú')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'16', N'TP.HCM', N'Quận Bình Thạnh')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'17', N'TP.HCM', N'Quận Phú Nhuận')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'18', N'TP.HCM', N'Quận Thủ Đức')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'19', N'TP.HCM', N'Quận Bình Tân')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'20', N'TP.HCM', N'Huyện Bình Chánh')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'21', N'TP.HCM', N'Huyện Củ Chi')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'22', N'TP.HCM', N'Huyên Hóc Môn')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'23', N'TP.HCM', N'Huyện Nhà Bè')
INSERT [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH], [TENTINH], [TENQH]) VALUES (N'02', N'24', N'TP.HCM', N'Huyện Cần Giờ')
INSERT [dbo].[TONGIAO] ([MATG], [TENTG]) VALUES (N'TG1', N'Phật Giáo')
INSERT [dbo].[TONGIAO] ([MATG], [TENTG]) VALUES (N'TG2', N'Công Giáo')
INSERT [dbo].[TONGIAO] ([MATG], [TENTG]) VALUES (N'TG3', N'Cao Đài')
INSERT [dbo].[TONGIAO] ([MATG], [TENTG]) VALUES (N'TG4', N'Hòa Hảo')
INSERT [dbo].[TONGIAO] ([MATG], [TENTG]) VALUES (N'TG5', N'Tin Lành')
INSERT [dbo].[TONGIAO] ([MATG], [TENTG]) VALUES (N'TG6', N'Hồi Giáo')
SET IDENTITY_INSERT [dbo].[THANNHAN] ON 

INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (1, N'NV1', N'Đỗ Nghĩa Ngân', 2, CAST(0xCDFE0A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (2, N'NV2', N'Bùi Huyền Kỷ', 1, CAST(0x13040B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (3, N'NV3', N'Đỗ Diệp An', 3, CAST(0xB1E40A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (4, N'NV4', N'Hồ Thục Loan', 1, CAST(0xE2180B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (5, N'NV5', N'Lý Huyền Nhi', 2, CAST(0xF10F0B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (6, N'NV6', N'Dương Nhân Đạo', 3, CAST(0x8A050B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (7, N'NV7', N'Ngô Huyền Khanh', 4, CAST(0x39130B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (8, N'NV8', N'Hoàng Văn Thúy', 5, CAST(0x611A0B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (9, N'NV9', N'Hồ Tín Ngạn', 5, CAST(0xF01A0B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (10, N'NV10', N'Bùi Bích Dung', 1, CAST(0xD3F80A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (11, N'NV11', N'Ngô Phú Hân', 3, CAST(0xEAFC0A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (12, N'NV12', N'Phạm Trí Khương', 4, CAST(0x10270B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (13, N'NV13', N'Nguyễn Thục Trinh', 2, CAST(0xEB310B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (14, N'NV14', N'Hoàng Phú Khánh', 1, CAST(0x84EB0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (15, N'NV15', N'Ngô Dương Đan', 3, CAST(0x5FF10A00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (16, N'NV16', N'Phạm Kiều Phi', 2, CAST(0x39FB0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (17, N'NV17', N'Phan Thành Anh', 4, CAST(0x38200B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (18, N'NV18', N'Ngô Đức Linh', 3, CAST(0x630D0B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (19, N'NV19', N'Bùi Tín Châu', 2, CAST(0x13350B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (20, N'NV20', N'Vũ Nhã Bích', 1, CAST(0xB6F80A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (21, N'NV21', N'Bùi Khiêm Ngân', 1, CAST(0x6FE90A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (22, N'NV22', N'Phan Kiều Như', 2, CAST(0xC0120B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (23, N'NV23', N'Trần Nghĩa Bích', 2, CAST(0x98E20A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (24, N'NV24', N'Phạm Nghĩa Ngân', 2, CAST(0xA4F90A00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (25, N'NV25', N'Võ Huyền Liêu', 3, CAST(0xD72A0B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (26, N'NV26', N'Nguyễn Trí Diệp', 1, CAST(0x1CED0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (27, N'NV27', N'Phi Huyền Như', 5, CAST(0xD6050B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (28, N'NV28', N'Vũ Hiếu Hân', 4, CAST(0x1E2E0B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (29, N'NV29', N'Đỗ Đức Hạnh', 4, CAST(0x0AE70A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (30, N'NV30', N'Nguyễn Cát An', 3, CAST(0xEAF90A00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (31, N'NV31', N'Ngô Thục Vy', 3, CAST(0x18F10A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (32, N'NV32', N'Phạm Huyền Hạnh', 3, CAST(0xBF130B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (33, N'NV33', N'Hồ Bảo Hà', 1, CAST(0x4D260B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (34, N'NV34', N'Bùi Nghĩa Phi', 2, CAST(0xF30B0B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (35, N'NV35', N'Phan Khiêm Tự', 4, CAST(0x2B3D0B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (36, N'NV36', N'Hồ Nhân Loan', 1, CAST(0xA7240B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (37, N'NV37', N'Phi Tú Phi', 2, CAST(0x6FE50A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (38, N'NV38', N'Đỗ Huyền Tự', 2, CAST(0x89E70A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (39, N'NV39', N'Nguyễn Phú Bích', 3, CAST(0xFCFE0A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (40, N'NV40', N'Huỳnh Phú Châu', 1, CAST(0x3C170B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (41, N'NV41', N'Phan Phương Trinh', 3, CAST(0x07F90A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (42, N'NV42', N'Lý Diệp Hạnh', 5, CAST(0x6AFC0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (43, N'NV43', N'Bùi Văn Liêu', 4, CAST(0xCD1E0B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (44, N'NV44', N'Lê Thục Anh', 1, CAST(0x6FE50A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (45, N'NV45', N'Lê Tú Dung', 5, CAST(0xB32D0B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (46, N'NV46', N'Phan Diệp Dung', 5, CAST(0x6A030B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (47, N'NV47', N'Ngô Trung Diệp', 5, CAST(0xBC0E0B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (48, N'NV48', N'Phi Ngọc Tự', 5, CAST(0x51F10A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (49, N'NV49', N'Vũ Nhân Khue', 3, CAST(0x7E0E0B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (50, N'NV50', N'Trần Bích Khue', 3, CAST(0xB7160B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (51, N'NV51', N'Nguyễn Bảo Ngạn', 3, CAST(0x50F50A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (52, N'NV52', N'Dương Kim Lan', 2, CAST(0x60E00A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (53, N'NV53', N'Đỗ Tuệ Khánh', 2, CAST(0x54FC0A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (54, N'NV54', N'Hồ Kiều Đạo', 2, CAST(0x66FC0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (55, N'NV55', N'Nguyễn Nhã Bá', 1, CAST(0x88180B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (56, N'NV56', N'Đặng Văn Hoàn', 2, CAST(0x78290B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (57, N'NV57', N'Lý Trí Đạo', 3, CAST(0x8E010B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (58, N'NV58', N'Vũ Tú Bích', 5, CAST(0x79280B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (59, N'NV59', N'Ngô Nhân My', 4, CAST(0x772B0B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (60, N'NV60', N'Nguyễn Phương Khải', 1, CAST(0xE9020B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (61, N'NV61', N'Phi Bảo Ngân', 2, CAST(0x203D0B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (62, N'NV62', N'Hồ Phú Chi', 3, CAST(0x87220B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (63, N'NV63', N'Lý Khiêm Chi', 5, CAST(0x6B130B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (64, N'NV64', N'Phi Nhã Như', 1, CAST(0x19010B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (65, N'NV65', N'Phạm Huyền Hà', 2, CAST(0xCEE70A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (66, N'NV66', N'Võ Bảo Liêu', 5, CAST(0x96260B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (67, N'NV67', N'Đặng Thành Hương', 2, CAST(0xD7E00A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (68, N'NV68', N'Đặng Đức An', 5, CAST(0x0C060B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (69, N'NV69', N'Vũ Đức Châu', 4, CAST(0xC4EB0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (70, N'NV70', N'Dương Thành Mai', 1, CAST(0x240A0B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (71, N'NV71', N'Hồ Phú Vân', 3, CAST(0xDEF50A00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (72, N'NV72', N'Võ Nghĩa Nhi', 2, CAST(0xC2180B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (73, N'NV73', N'Phan Bích Cấn', 1, CAST(0x7BEE0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (74, N'NV74', N'Lê Nhã Trinh', 2, CAST(0xEAFD0A00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (75, N'NV75', N'Hoàng Kiều Tự', 3, CAST(0x1B3D0B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (76, N'NV76', N'Vũ Tín Hương', 2, CAST(0x702A0B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (77, N'NV77', N'Hồ Trung Tôn', 1, CAST(0x5E310B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (78, N'NV78', N'Đặng Khiêm Trinh', 1, CAST(0x943A0B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (79, N'NV79', N'Lý Đức Thúy', 1, CAST(0x5C090B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (80, N'NV80', N'Phi Bảo Thúy', 3, CAST(0x80070B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (81, N'NV81', N'Bùi Bảo Hạnh', 5, CAST(0xCB1B0B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (82, N'NV82', N'Bùi Khiêm Thúy', 4, CAST(0x99F40A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (83, N'NV83', N'Ngô Phú Hân', 1, CAST(0xB3FF0A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (84, N'NV84', N'Đặng Tuệ Khanh', 1, CAST(0xBF0D0B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (85, N'NV85', N'Phạm Hiếu Hoàn', 1, CAST(0xAEE40A00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (86, N'NV86', N'Võ Diệp Hoàn', 1, CAST(0xCBF00A00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (87, N'NV87', N'Lê Thành Nhung', 2, CAST(0x7FF70A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (88, N'NV88', N'Phan Phú Hân', 3, CAST(0xFB090B00 AS Date), N'Quản lý nhân sự')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (89, N'NV89', N'Đỗ Phú Nhung', 5, CAST(0xD6300B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (90, N'NV90', N'Lý Cát Bích', 2, CAST(0xC6F30A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (91, N'NV91', N'Võ Ngọc Khue', 1, CAST(0x2C030B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (92, N'NV92', N'Ngô Cát Lan', 5, CAST(0x61FA0A00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (93, N'NV93', N'Phan Nghĩa Thúy', 4, CAST(0x7EF90A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (94, N'NV94', N'Nguyễn Đức Vy', 2, CAST(0x7F390B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (95, N'NV95', N'Đặng Đức Như', 5, CAST(0x88170B00 AS Date), N'Tiếp viên hàng')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (96, N'NV96', N'Hoàng Nhân Đan', 2, CAST(0xEB130B00 AS Date), N'Phi công')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (97, N'NV97', N'Vũ Tú Thúy', 1, CAST(0x6B260B00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (98, N'NV98', N'Nguyễn Diệp Vọng', 3, CAST(0xC8FD0A00 AS Date), N'Lập trình viên CNTT')
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (99, N'NV99', N'Huỳnh Huyền Bá', 5, CAST(0x0C3B0B00 AS Date), N'Tiếp viên hàng')
GO
INSERT [dbo].[THANNHAN] ([MAQHGD], [MANV], [HOTEN], [MOIQH], [NGAYSINH], [NGHENGHIEP]) VALUES (100, N'NV100', N'Nguyễn Cát An', 1, CAST(0x30E70A00 AS Date), N'Tiếp viên hàng')
SET IDENTITY_INSERT [dbo].[THANNHAN] OFF
ALTER TABLE [dbo].[CHAMCONG]  WITH CHECK ADD  CONSTRAINT [FK_CHAMCONG_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[CHAMCONG] CHECK CONSTRAINT [FK_CHAMCONG_NHANVIEN]
GO
ALTER TABLE [dbo].[HESOLUONG]  WITH CHECK ADD  CONSTRAINT [FK_HESOLUONG_CHUCVU1] FOREIGN KEY([MACV])
REFERENCES [dbo].[CHUCVU] ([MACV])
GO
ALTER TABLE [dbo].[HESOLUONG] CHECK CONSTRAINT [FK_HESOLUONG_CHUCVU1]
GO
ALTER TABLE [dbo].[HESOLUONGND]  WITH CHECK ADD  CONSTRAINT [FK_HESOLUONGND_CHUCVU] FOREIGN KEY([MACV])
REFERENCES [dbo].[CHUCVU] ([MACV])
GO
ALTER TABLE [dbo].[HESOLUONGND] CHECK CONSTRAINT [FK_HESOLUONGND_CHUCVU]
GO
ALTER TABLE [dbo].[HOPDONGLAODONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONGLAODONG_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOPDONGLAODONG] CHECK CONSTRAINT [FK_HOPDONGLAODONG_NHANVIEN]
GO
ALTER TABLE [dbo].[HOPDONGLAODONG_THOIVIEC]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONGLAODONG_THOIVIEC_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOPDONGLAODONG_THOIVIEC] CHECK CONSTRAINT [FK_HOPDONGLAODONG_THOIVIEC_NHANVIEN]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_LOAIND] FOREIGN KEY([LOAIND])
REFERENCES [dbo].[LOAIND] ([MALOAI])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_LOAIND]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_NHANVIEN1] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_NHANVIEN1]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BANGCAP1] FOREIGN KEY([BANGCAP])
REFERENCES [dbo].[BANGCAP] ([MABC])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BANGCAP1]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MACV])
REFERENCES [dbo].[CHUCVU] ([MACV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_DANTOC] FOREIGN KEY([DANTOC])
REFERENCES [dbo].[DANTOC] ([MADT])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_DANTOC]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHONGBAN] FOREIGN KEY([PHONG])
REFERENCES [dbo].[PHONGBAN] ([MAPB])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_PHONGBAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_QUOCTICH] FOREIGN KEY([QUOCTICH])
REFERENCES [dbo].[QUOCTICH] ([MAQT])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_QUOCTICH]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TINHQUANHUYEN1] FOREIGN KEY([TINHTHANH], [QUANHUYEN])
REFERENCES [dbo].[TINHQUANHUYEN] ([MATINH], [MAQH])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_TINHQUANHUYEN1]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TONGIAO] FOREIGN KEY([TONGIAO])
REFERENCES [dbo].[TONGIAO] ([MATG])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_TONGIAO]
GO
ALTER TABLE [dbo].[NHATKY]  WITH CHECK ADD  CONSTRAINT [FK_NHATKY_NGUOIDUNG1] FOREIGN KEY([TAIKHOAN])
REFERENCES [dbo].[NGUOIDUNG] ([TAIKHOAN])
GO
ALTER TABLE [dbo].[NHATKY] CHECK CONSTRAINT [FK_NHATKY_NGUOIDUNG1]
GO
ALTER TABLE [dbo].[THANNHAN]  WITH CHECK ADD  CONSTRAINT [FK_QUANHEGIADINH_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[THANNHAN] CHECK CONSTRAINT [FK_QUANHEGIADINH_NHANVIEN]
GO
ALTER TABLE [dbo].[THANNHAN]  WITH CHECK ADD  CONSTRAINT [FK_THANNHAN_MOIQUANHE] FOREIGN KEY([MOIQH])
REFERENCES [dbo].[MOIQUANHE] ([MAQH])
GO
ALTER TABLE [dbo].[THANNHAN] CHECK CONSTRAINT [FK_THANNHAN_MOIQUANHE]
GO
