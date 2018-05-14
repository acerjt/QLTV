

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLTV]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLTV]
GO

USE [QLTV]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [int] NOT NULL,
	[tenloaidocgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblDocGia](
	[madocgia] [nvarchar](8) NOT NULL,
	[hovaten] [nvarchar](50) NOT NULL,
	[maloaidocgia] [int] NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylap] [datetime2](7) NOT NULL,
	[ngayhethan] [datetime2](7)Not NULL,
	
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblTheLoaiSach](
	[MaTheLoaiSach] [int] NOT NULL,
	[TenTheLoaiSach] [nvarchar](50) NOT NULL,
	
 CONSTRAINT [PK_tblTheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaTheLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblTacGia](
	[MaTacGia] [int] NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
	
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



USE [QLTV]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 3/28/2018 8:05:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* Note: */
/* [datetime2](7) = DateTime type in .NET */

CREATE TABLE [dbo].[tblSach](
	[MaSach] [nvarchar](8) NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[MaTheLoaiSach] [int] NOT NULL,
	[MaTacGia] [int] NOT NULL,
	[NamXuatBan] [nvarchar](4) NOT NULL,
	[NhaXuatBan] [nvarchar](50) NOT NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
	[TriGia] [money] NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



USE [QLTV]
GO



USE [QLTV]
GO

INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(1,N'X')
GO
INSERT INTO[dbo].[tblLoaiDocGia]([maloaidocgia],[tenloaidocgia]) VALUES(2,N'Y')
GO


USE [QLTV]
GO


INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(N'0000001',N'Phan Minh Toàn',2,convert(datetime,'10/02/1998 00:00:00'),N'Bắc Bình, Bình Thuận',N'16521261@gm.uit.edu.vn',convert(datetime,'11/05/2018 00:00:00',101),convert(datetime,'05/05/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(N'0000002',N'Nguyen Ngoc Dung',2,convert(datetime,'12/26/1997 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'11/05/2018 00:00:00',101),convert(datetime,'05/05/2019 00:00:00',101))
GO
INSERT INTO [dbo].[tblDocGia]([madocgia],[hovaten],[maloaidocgia],[ngaysinh], [diachi], [email], [ngaylap], [ngayhethan]) VALUES(N'0000004',N'Nguyen Ngoc Dung',1,convert(datetime,'12/26/1997 00:00:00'),N'Cẩm Mỹ, Đồng Nai',N'16521576@gm.uit.edu.vn',convert(datetime,'11/05/2018 00:00:00',101),convert(datetime,'05/05/2019 00:00:00',101))
GO
USE [QLTV]
GO


USE [QLTV]
GO

INSERT INTO[dbo].[tblTheLoaiSach]([MaTheLoaiSach],[TenTheLoaiSach]) VALUES(1,N'A')
GO
INSERT INTO[dbo].[tblTheLoaiSach]([MaTheLoaiSach],[TenTheLoaiSach]) VALUES(2,N'B')
GO
INSERT INTO[dbo].[tblTheLoaiSach]([MaTheLoaiSach],[TenTheLoaiSach]) VALUES(3,N'C')
GO

USE [QLTV]
GO

INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(1,N'Nguyen Nhat Anh')
GO
INSERT INTO[dbo].[tblTacGia]([MaTacGia],[TenTacGia]) VALUES(2,N'Nguyen Thi')
GO

INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia]) VALUES(1,N'Hôm Nay Tôi Buồn',2,1,N'2012',N'Kim Đồng',convert(datetime,'11/05/2018 00:00:00'),20000)
GO





USE [QLTV]
GO
CREATE TABLE [dbo].[tblquydinh](
	[id] [int] NOT NULL,
	[tuoitoithieu] [int] NOT NULL,
	[tuoitoida] [int] NOT NULL,
	[thoigiansudung] [int] NOT NULL,
CONSTRAINT [PK_tblquydinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO
USE QLTV
INSERT INTO [dbo].[tblQuyDinh]([id],[tuoitoithieu],[tuoitoida],[thoigiansudung]) VALUES (1, 18,55,6)
GO

