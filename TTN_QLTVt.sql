USE [master]
GO
/****** Object:  Database [TTN_QLTV]    Script Date: 24/05/2017 3:32:06 AM ******/
CREATE DATABASE [TTN_QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTN_QLTV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTN_QLTV.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TTN_QLTV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTN_QLTV_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TTN_QLTV] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTN_QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTN_QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTN_QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTN_QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTN_QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TTN_QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTN_QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTN_QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTN_QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTN_QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTN_QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTN_QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTN_QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TTN_QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [TTN_QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTN_QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTN_QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTN_QLTV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TTN_QLTV]
GO
/****** Object:  StoredProcedure [dbo].[deleteDocGia]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[deleteDocGia](@ma varchar(20))
as
begin
	if(exists (select ma from DocGia where ma = @ma ))
	begin
		if(exists (select DocGiama  from PhieuMuon where ma = @ma ))
		begin 
			rollback tran 
		end
		else update DocGia set hoatdong = 0 where DocGia.ma = @ma
	end
end

GO
/****** Object:  StoredProcedure [dbo].[DSCHUATRA]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[DSCHUATRA]
  @docgiama varchar(20)
   as
		 begin
		  select ma,DocGiama,Sachma,ngaymuon,NhanVienma,ngaytra,hantra,phatquahan,phathong,phatmat from PhieuMuon where ngaytra=ngaymuon and DocGiama =@docgiama
		end
GO
/****** Object:  StoredProcedure [dbo].[DSMATHANG]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DSMATHANG]
  @ma varchar(20)
   as begin
      select *from Cart where ma=@ma
   end
GO
/****** Object:  StoredProcedure [dbo].[DSPhieuMuon]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DSPhieuMuon]
  @docgiama varchar(20)
   as
		 begin
		  if exists(select DocGiama from PhieuMuon where  docgiama= @docgiama)
			  begin
			  select ma,DocGiama,Sachma,ngaymuon,NhanVienma,ngaytra,hantra,phatquahan,phathong,phatmat from PhieuMuon where ngaytra=ngaymuon and DocGiama =@docgiama
			  end
		  else
			  begin
			   select null as ma, null as docgiama, null as sachma,null as ngaymuon, null as nhanvienma, null as ngaytra, null as hantra, null as phatquahan, null as phathong, null as phatmat
			  end
		end
GO
/****** Object:  StoredProcedure [dbo].[Nguoi_Muon]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Nguoi_Muon]
    @masv VARCHAR(20)

AS
  BEGIN  
      IF EXISTS(SELECT DBO.PhieuMuon.DocGiama
	            FROM   DBO.PhieuMuon 
				       INNER JOIN DBO.DocGia ON DBO.PhieuMuon.DocGiama = DBO.DocGia.ma
				WHERE DBO.PhieuMuon.DocGiama = @masv
	           )
		  BEGIN
		      SELECT  DG.ten,PM_S.ten,PM_S.[The loai],PM_S.noidungtomtat,PM_S.tinhtrang,PM_S.ngaymuon,PM_S.hantra
			  FROM DBO.DocGia DG
			       INNER JOIN ( SELECT PM.DocGiama,PM.ngaymuon,PM.hantra,S_TL.ten,S_TL.noidungtomtat,S_TL.[The loai],S_TL.tinhtrang,S_TL.gia
				                FROM    DBO.PhieuMuon PM
								        INNER JOIN ( SELECT S.noidungtomtat,S.ten,S.tinhtrang,S.gia,S.ma,TL.ten AS [The loai] 
										             FROM   DBO.Sach S
													        INNER JOIN DBO.TheLoai TL ON TL.ma = S.TheLoaima
													 GROUP BY TL.ten,S.ma,S.noidungtomtat,S.ten,S.tinhtrang,S.gia
										           )AS S_TL ON PM.Sachma = S_TL.ma
								GROUP BY  PM.DocGiama,PM.ngaymuon,PM.hantra,S_TL.ten,S_TL.noidungtomtat,S_TL.[The loai],S_TL.tinhtrang,S_TL.gia  
				              )AS PM_S ON DG.ma=PM_S.DocGiama
			WHERE DG.ma=@masv
		  END
	 ELSE
	      BEGIN
		    SELECT @masv as ma, null as ten, null as theloai, null as noidungtomtat, null as tinhtrang, null as ngaymuon, null as hantra
			return ;
		  END
  END

GO
/****** Object:  StoredProcedure [dbo].[procedure_deleteSach]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_deleteSach](@ma varchar(20))
as
begin
	if not exists (select sachma from PhieuMuon where PhieuMuon.Sachma = @ma AND (PhieuMuon.trangthai != 1)  ) 
	--= 0 chưa trả
	--= 1 đã trả
	--default lỗi
	begin 
		update sach set tinhtrang = 0 where sach.ma = @ma
	end
	
end

GO
/****** Object:  StoredProcedure [dbo].[procedure_insertDocGia]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_insertDocGia](@ten nvarchar(30),@ngaysinh date,@gioitinh bit,@diachi nvarchar(50),@ngaylamthe date,@ngayhethan date,@hoatdong bit)
as
begin
insert into DocGia(ma,ten,ngaysinh,gioitinh,diachi,ngaylamthe,ngayhethan,hoatdong)
values(dbo.auto_maDocGia(),@ten,@ngaysinh ,@gioitinh,@diachi,@ngaylamthe ,@ngayhethan,@hoatdong)
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertPhieuMuon]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertPhieuMuon](@docgiama varchar(20),@ngaymuon date,@sachma varchar(20),@nhanvienma varchar(20),@hantra date,@ngaytra date,@phathong bigint,@phatquahan bigint,@phatmat bigint)
as
begin
insert into PhieuMuon(ma,DocGiama,ngaymuon,Sachma,NhanVienma,hantra,ngaytra,phathong,phatquahan,phatmat)
values(dbo.auto_maPhieuMuon(),@docgiama,@ngaymuon,@sachma,@nhanvienma,@hantra,@ngaytra,@phathong,@phatquahan,@phatmat)
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertSach]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_insertSach](@ten nvarchar(30),@noidungtomtat nvarchar(200),@sotrang int,@gia bigint,@soluong int,@nhaxuatbanma varchar(20),@tacgiama varchar(20),@theloaima varchar(20),@tinhtrang bit)
as
begin
insert into Sach(ma,ten,noidungtomtat,sotrang,gia,soluong,ngaynhap,NXBma,TacGiama,TheLoaima,tinhtrang)
values(dbo.auto_maSach(),@ten,@noidungtomtat,@sotrang,@gia,@soluong,GETDATE(),@nhaxuatbanma,@tacgiama,@theloaima,@tinhtrang)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcPhieuTra]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcPhieuTra]
@docgiama varchar(20)
 as
   begin
    if exists(select *from PhieuMuon where DocGiama=@docgiama)
		begin
		 select *from PhieuMuon where  DocGiama=@docgiama 
		 end
	else
		begin
		  select null as ma, null as docgiama, null as ngaymuon, null as hantra, null as ngaytra
		end
   end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maDocGia]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[auto_maDocGia]() returns varchar(6)
as
begin
declare @ma varchar(6)
if(select count(ma) from DocGia)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from DocGia
set @ma=case
when 
@ma>=0 and @ma<9 then 'DG000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'DG00'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'DG0'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maPhieuMuon]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[auto_maPhieuMuon]() returns varchar(6)
as
begin
declare @ma varchar(6)
if(select count(ma) from PhieuMuon)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from PhieuMuon
set @ma=case
when 
@ma>=0 and @ma<9 then 'PM0000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'PM000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'PM00'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_maSach]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[auto_maSach]() returns varchar(6)
as
begin
declare @ma varchar(6)
if(select count(ma) from Sach)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from Sach
set @ma=case
when 
@ma>=0 and @ma<9 then 'S0000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'S000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'S00'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocGia](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[diachi] [nvarchar](50) NULL,
	[ngaylamthe] [date] NOT NULL,
	[ngayhethan] [date] NOT NULL,
	[hoatdong] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[dienthoai] [varchar](12) NOT NULL,
	[diachi] [nvarchar](50) NULL,
	[email] [varchar](30) NULL,
	[matkhau] [varchar](30) NOT NULL,
	[quyenhan] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](100) NULL,
	[dienthoai] [varchar](12) NULL,
	[website] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[ma] [varchar](20) NOT NULL,
	[DocGiama] [varchar](20) NOT NULL,
	[ngaymuon] [datetime] NOT NULL,
	[Sachma] [varchar](20) NOT NULL,
	[NhanVienma] [varchar](20) NOT NULL,
	[hantra] [datetime] NOT NULL,
	[ngaytra] [datetime] NULL,
	[phathong] [bigint] NULL,
	[phatquahan] [bigint] NULL,
	[phatmat] [bigint] NULL,
	[trangthai] [int] NULL,
 CONSTRAINT [PK__PhieuMuo__3213C8B7BBD81292] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
	[noidungtomtat] [nvarchar](200) NULL,
	[sotrang] [int] NOT NULL,
	[gia] [bigint] NOT NULL,
	[soluong] [int] NOT NULL,
	[ngaynhap] [date] NOT NULL,
	[NXBma] [varchar](20) NOT NULL,
	[TacGiama] [varchar](20) NOT NULL,
	[TheLoaima] [varchar](20) NOT NULL,
	[tinhtrang] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TacGia](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 24/05/2017 3:32:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheLoai](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
	[ghichu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK__PhieuMuon__DocGi__52593CB8] FOREIGN KEY([DocGiama])
REFERENCES [dbo].[DocGia] ([ma])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK__PhieuMuon__DocGi__52593CB8]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK__PhieuMuon__NhanV__5441852A] FOREIGN KEY([NhanVienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK__PhieuMuon__NhanV__5441852A]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK__PhieuMuon__Sachm__534D60F1] FOREIGN KEY([Sachma])
REFERENCES [dbo].[Sach] ([ma])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK__PhieuMuon__Sachm__534D60F1]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([NXBma])
REFERENCES [dbo].[NhaXuatBan] ([ma])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([TacGiama])
REFERENCES [dbo].[TacGia] ([ma])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([TheLoaima])
REFERENCES [dbo].[TheLoai] ([ma])
GO
USE [master]
GO
ALTER DATABASE [TTN_QLTV] SET  READ_WRITE 
GO
