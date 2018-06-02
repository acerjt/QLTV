

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
	[TinhTrang] [nvarchar](20),

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

INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(1,N'Hôm Nay Tôi Buồn',2,1,N'2012',N'Kim Đồng',convert(datetime,'11/05/2018 00:00:00'),20000,'')

USE [QLTV]
GO
INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(2,N'Nữ Thần Báo Tử',3,2,N'2012',N'Trẻ',convert(datetime,'05/23/2018 00:00:00'),70000,' ')


INSERT INTO[dbo].[tblSach]([MaSach],[TenSach],[MaTheLoaiSach],[MaTacGia],[NamXuatBan],[NhaXuatBan],[NgayNhap],[TriGia],[Tinhtrang]) VALUES(3,N'Fire',1,2,N'2014',N'Phương Đông',convert(datetime,'11/06/2018 00:00:00'),50000,' ')
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


USE [QLTV]
GO
CREATE TABLE [dbo].[tblPhieuMuonSach](
	[maphieumuonsach] [nvarchar](8) NOT NULL,
	[madocgia] [nvarchar](8) NOT NULL,
	[ngaymuon] [datetime2](7) NOT NULL,
	[ngaydukientra] [datetime2](7) NOT NULL,
CONSTRAINT [PK_tblPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]
GO
USE QLTV
--INSERT INTO [dbo].[tblPhieuMuonSach]([maphieumuonsach],[madocgia],[ngaymuon],[ngaydukientra]) VALUES (N'1', N'2',convert(datetime,'05/11/2018'),convert(datetime,'05/15/2018'))
--GO


USE [QLTV]
GO
CREATE TABLE [dbo].[tblChiTietPhieuMuonSach](
	[maphieumuonsach] [nvarchar](8) NOT NULL,
	[masach] [int],
	[TinhTrang] [nvarchar](20),
CONSTRAINT [PK_tblChiTietPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach], [masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

USE [QLTV]
go
CREATE TABLE [dbo].[tblPhieuTraSach](
	[maphieutrasach] [nvarchar](8) NOT NULL,
	[madocgia] [nvarchar](8) NOT NULL,
	[ngaytra] [datetime2](7) NOT NULL,
CONSTRAINT [PK_tblPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieutrasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

go

CREATE TABLE [dbo].[tblChiTietPhieuTraSach](
	[maphieutrasach] [nvarchar](8) NOT NULL,
	[masach] [int] NOT NULL,
	[TinhTrang] [nvarchar](20),
	[MaPhieuMuonSach] [int] Not null,
CONSTRAINT [PK_tblChiTietPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieutrasach], [masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

USE [QLTV]
go
CREATE TABLE [dbo].[tblBaoCaoThongKeMuonSachTheoTheLoai](
	[MaBaoCaoThongKeMuonSachTheoTheLoai] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[TongSoLuotMuon] [int] NOT NULL,
CONSTRAINT [PK_tblBaoCaoThongKeMuonSachTheoTheLoai] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoThongKeMuonSachTheoTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

go


CREATE TABLE [dbo].[tblChiTietBaoCaoThongKeMuonSachTheoTheLoai](
	[MaBaoCaoThongKeMuonSachTheoTheLoai] [int] NOT NULL,
	[MaTheLoaiSach] [int] NOT NULL,
	[SoLuotMuon] [int] NOT NULL,
	[TyLe] [float] NOT NULL,
CONSTRAINT [PK_tblChiTietBaoCaoThongKeMuonSachTheoTheLoai] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoThongKeMuonSachTheoTheLoai], [MaTheLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]





select [TenTheLoaiSach],count([TenTheLoaiSach]) as [SoLuotMuon], count([TenTheLoaiSach])*1.0 / (select count([masach]) from [tblChiTietPhieuMuonSach])*100 as [TyLe], (select count([masach]) from [tblChiTietPhieuMuonSach]) as [TongSoLuotMuon]
from [tblChiTietPhieuMuonSach],[tblSach],[tblTheLoaiSach],[tblPhieuMuonSach]
 where [tblChiTietPhieuMuonSach].[masach] = [tblSach].[MaSach]
And [tblSach].[MaTheLoaiSach]=[tblTheLoaiSach].[MaTheLoaiSach]
And [tblChiTietPhieuMuonSach].[maphieumuonsach]=[tblPhieuMuonSach].[maphieumuonsach]
--And [tblsach].[MaTheLoaiSach] =2
And MONTH([ngaymuon])=5
--And year([ngaymuon]) =2018
group by [TenTheLoaiSach]
select [tensach],[ngaymuon],DATEDIFF ( day , [ngaydukientra] , [ngaytra] ) as Songaytratre
from [tblChiTietPhieuTraSach],[tblPhieuTraSach],[tblSach],[tblPhieuMuonSach]
where [tblChiTietPhieuTraSach].[maphieutrasach]=[tblPhieuTraSach].[maphieutrasach]
and [tblSach].[MaSach]=[tblChiTietPhieuTraSach].[masach]
and [tblChiTietPhieuTraSach].[MaPhieuMuonSach]=[tblPhieuMuonSach].[maphieumuonsach]


