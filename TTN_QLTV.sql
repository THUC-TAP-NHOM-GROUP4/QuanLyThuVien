USE [master]
GO
/****** Object:  Database [TTN_QLTV]    Script Date: 04/06/2017 2:45:26 PM ******/
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
/****** Object:  StoredProcedure [dbo].[DanhSachChiTietPhieuMuon]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DanhSachChiTietPhieuMuon]
@phieumuonma varchar(20)
 as
  begin
    select ten as [Tên sách], ABC.tennhaxuatban as [Nhà xuất bản], ABC.tentacgia as [Tác giả], ABC.tentheloai as [Thể loại] from Sach s
	                inner join (select tl.ten as tentheloai,AB.phieumuonma,AB.sachma,AB.tennhaxuatban,AB.tentacgia from TheLoai tl
					                             inner join (select ten as tentacgia, A.phieumuonma,A.sachma,A.tennhaxuatban,A.theloaima from TacGia tg
												                             inner join (select ten as tennhaxuatban,ctpm.phieumuonma,ctpm.sachma,ctpm.tacgiama,ctpm.theloaima from NhaXuatBan nxb
																			                             inner join Chitietphieumuon ctpm on nxb.ma = ctpm.nhaxuatbanma
																						 group by ten,ctpm.phieumuonma,ctpm.sachma,ctpm.tacgiama,ctpm.theloaima)as A 
									                                         on A.tacgiama= tg.ma
								                             group by  A.phieumuonma,A.sachma,A.tennhaxuatban,A.theloaima,tg.ten
															 )as AB
												 on AB.theloaima = tl.ma
								group by AB.phieumuonma,AB.sachma,AB.tennhaxuatban,AB.tentacgia,tl.ten
					           )as ABC
					on  s.ma = ABC.sachma
	where phieumuonma = @phieumuonma
												 
  end
GO
/****** Object:  StoredProcedure [dbo].[DanhSachPhieuMuon]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DanhSachPhieuMuon]
as
begin
  select pm.ma as [Mã phiếu],pm.DocGiama as [Mã độc giả], pm.ngaymuon as [Ngày mượn],
  pm.NhanVienma as [Mã nhân viên], pm.hantra as [Hạn trả]  from PhieuMuon pm where trangthai=0
end
GO
/****** Object:  StoredProcedure [dbo].[DanhSachTraSach]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DanhSachTraSach]
as
begin
  select pm.ma as [Mã phiếu],pm.DocGiama as [Mã độc giả], pm.ngaymuon as [Ngày mượn],
  pm.NhanVienma as [Mã nhân viên], pm.hantra as [Hạn trả]  from PhieuMuon pm where trangthai=1
end
GO
/****** Object:  StoredProcedure [dbo].[deleteDocGia]    Script Date: 04/06/2017 2:45:26 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procedure_deleteSach]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_deleteSach](@ma varchar(20))
as
begin
	if not exists (select sachma from phieumuon inner join Chitietphieumuon on Chitietphieumuon.phieumuonma  = PhieuMuon.ma 
	where Chitietphieumuon.Sachma = @ma AND (PhieuMuon.trangthai != 1)  ) 
	--= 0 chưa trả
	--= 1 đã trả
	--default lỗi
	begin 
		update sach set tinhtrang = 0 where sach.ma = @ma
	end
	
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertDocGia]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertDocGia](@ten nvarchar(30),@ngaysinh date,@gioitinh bit,@diachi nvarchar(50),@ngaylamthe date,@ngayhethan date,@hoatdong bit)
as
begin
insert into DocGia(ma,ten,ngaysinh,gioitinh,diachi,ngaylamthe,ngayhethan,hoatdong)
values(dbo.auto_maDocGia(),@ten,@ngaysinh ,@gioitinh,@diachi,@ngaylamthe ,@ngayhethan,@hoatdong)
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertSach]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procedure_insertSach](@ten nvarchar(30),@noidungtomtat nvarchar(200),@sotrang int,@gia bigint,@soluong int,@nhaxuatbanma varchar(20),@tacgiama varchar(20),@theloaima varchar(20),@tinhtrang bit)
as
begin
insert into Sach(ma,ten,noidungtomtat,sotrang,gia,soluong,ngaynhap,NXBma,TacGiama,TheLoaima,tinhtrang)
values(dbo.auto_maSach(),@ten,@noidungtomtat,@sotrang,@gia,@soluong,GETDATE(),@nhaxuatbanma,@tacgiama,@theloaima,@tinhtrang)
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_updateDocGia]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_updateDocGia](@ma varchar(20),@ten nvarchar(30),@ngaysinh date,@gioitinh bit,@diachi nvarchar(50),@ngaylamthe date,@ngayhethan date,@hoatdong bit)
as
begin
if(@ten like '') SET @ten = N'null' 
if(@gioitinh like 0) SET @gioitinh = 0
if(@diachi like '') SET @diachi = N'null'
if(@hoatdong like '') SET @hoatdong = N'null' 
update DocGia set ten = @ten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, ngaylamthe = @ngaylamthe , ngayhethan = @ngayhethan, hoatdong = @hoatdong
 where Ma = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_updateSach]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_updateSach](@ma varchar(20),@ten nvarchar(30) ,@noidungtomtat nvarchar(200) , @sotrang int , @gia bigint , @soluong int ,@nhaxuatban varchar(20) , @tacgiama varchar(20) , @tinhtrang bit)
as
begin
if(@ten like '') SET @ten = N'null' 
if(@noidungtomtat = '') set @noidungtomtat = N'null'
if(@sotrang like 0) SET @sotrang = 0
if(@gia like 0) SET @ten = 0
if(@soluong like 0) SET @soluong = 0 
if(@nhaxuatban like '') SET @nhaxuatban = N'null' 
if(@tacgiama like '') SET @tacgiama = N'null' 
if(@tinhtrang like '') SET @tinhtrang = N'null' 
update Sach set ten = @ten, noidungtomtat = @noidungtomtat , sotrang = @sotrang , gia = @gia , soluong = @soluong , NXBma = @nhaxuatban , tacgiama = @tacgiama , tinhtrang = @tinhtrang
 where Ma = @ma
end

GO
/****** Object:  StoredProcedure [dbo].[ThemVaoChiTietPhieuMuon]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemVaoChiTietPhieuMuon]
@sachma varchar(20),
@nhaxuatbanma varchar(20),
@theloaima varchar(20),
@tacgiama varchar(20)
as 
 begin 
	declare @phieumuonma varchar(20)
	select @phieumuonma = (select Max(ma) from PhieuMuon)
   insert into Chitietphieumuon(ma,sachma,phieumuonma,nhaxuatbanma,theloaima,tacgiama)
    values(dbo.auto_maChiTietPhieuMuon(),@sachma,@phieumuonma,@nhaxuatbanma,@theloaima,@tacgiama)
 end

GO
/****** Object:  StoredProcedure [dbo].[ThemVaoPhieuMuon]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemVaoPhieuMuon]
@docgiama varchar(20),
@ngaymuon date,
@nhanvienma varchar(20),
@hantra date
as
 begin
  insert into PhieuMuon(ma,DocGiama,ngaymuon,NhanVienma,hantra,ngaytra,phathong,phatmat,phatquahan,trangthai)
   values(dbo.auto_maPhieuMuon(),@docgiama,@ngaymuon,@nhanvienma,@hantra,@ngaymuon,0,0,0,0)
 end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maChiTietPhieuMuon]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_maChiTietPhieuMuon]() returns varchar(10)
as
begin
declare @ma varchar(10)
if(select count(ma) from Chitietphieumuon)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from Chitietphieumuon
set @ma=case
when 
@ma>=0 and @ma<9 then 'CTPM0000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'CTPM000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'CTPM00'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maDocGia]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_maDocGia]() returns varchar(6)
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
/****** Object:  UserDefinedFunction [dbo].[auto_maPhieuMuon]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_maPhieuMuon]() returns varchar(8)
as
begin
declare @ma varchar(8)
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
/****** Object:  UserDefinedFunction [dbo].[auto_maSach]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_maSach]() returns varchar(6)
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
/****** Object:  Table [dbo].[Chitietphieumuon]    Script Date: 04/06/2017 2:45:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chitietphieumuon](
	[ma] [varchar](20) NOT NULL,
	[sachma] [varchar](20) NULL,
	[phieumuonma] [varchar](20) NULL,
	[nhaxuatbanma] [varchar](20) NULL,
	[theloaima] [varchar](20) NULL,
	[tacgiama] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 04/06/2017 2:45:26 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/06/2017 2:45:26 PM ******/
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
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 04/06/2017 2:45:26 PM ******/
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
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 04/06/2017 2:45:26 PM ******/
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
	[NhanVienma] [varchar](20) NOT NULL,
	[hantra] [datetime] NOT NULL,
	[ngaytra] [datetime] NULL,
	[phathong] [bigint] NULL,
	[phatquahan] [bigint] NULL,
	[phatmat] [bigint] NULL,
	[trangthai] [bit] NULL,
 CONSTRAINT [PK__PhieuMuo__3213C8B7BBD81292] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 04/06/2017 2:45:26 PM ******/
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
/****** Object:  Table [dbo].[TacGia]    Script Date: 04/06/2017 2:45:26 PM ******/
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
/****** Object:  Table [dbo].[TheLoai]    Script Date: 04/06/2017 2:45:26 PM ******/
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
ALTER TABLE [dbo].[Chitietphieumuon]  WITH CHECK ADD FOREIGN KEY([phieumuonma])
REFERENCES [dbo].[PhieuMuon] ([ma])
GO
ALTER TABLE [dbo].[Chitietphieumuon]  WITH CHECK ADD FOREIGN KEY([sachma])
REFERENCES [dbo].[Sach] ([ma])
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
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([NXBma])
REFERENCES [dbo].[NhaXuatBan] ([ma])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([NXBma])
REFERENCES [dbo].[NhaXuatBan] ([ma])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([TacGiama])
REFERENCES [dbo].[TacGia] ([ma])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([TacGiama])
REFERENCES [dbo].[TacGia] ([ma])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([TheLoaima])
REFERENCES [dbo].[TheLoai] ([ma])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([TheLoaima])
REFERENCES [dbo].[TheLoai] ([ma])
GO
USE [master]
GO
ALTER DATABASE [TTN_QLTV] SET  READ_WRITE 
GO
