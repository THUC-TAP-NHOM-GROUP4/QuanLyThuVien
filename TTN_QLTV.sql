create database TTN_QLTV

create table TacGia(
ma varchar(20) primary key not null,
ten nvarchar(30)
)
create table DocGia(
ma varchar(20) primary key not null,
ten nvarchar(30) not null,
ngaysinh date not null,
gioitinh bit not null,
diachi nvarchar(50),
ngaylamthe date not null,
ngayhethan date not null,
hoatdong bit
)
create table NhaXuatBan(
ma varchar(20) primary key not null,
ten nvarchar(50) not null,
diachi nvarchar(100),
dienthoai varchar(12),
website varchar(30)
)
create table TheLoai(
ma varchar(20) primary key not null,
ten nvarchar(30) not null,
ghichu nvarchar(100)
)
create table NhanVien
(
ma varchar(20) primary key not null,
ten nvarchar(30) not null,
gioitinh bit not null,
ngaysinh date not null,
dienthoai varchar(12) not null,
diachi nvarchar(50),
email varchar(30),
matkhau varchar(30) not null,
quyenhan bit not null
)
create table Sach
(
ma varchar(20) primary key not null,
ten nvarchar(30) not null,
noidungtomtat nvarchar(200),
sotrang int not null,
gia bigint not null,
soluong int not null,
ngaynhap date not null,
NXBma varchar(20) not null ,
foreign key(NXBma) references NhaXuatBan(ma),
TacGiama varchar(20) not null,
foreign key(TacGiama) references TacGia(ma),
TheLoaima varchar(20) not null,
foreign key (TheLoaima) references TheLoai(ma),
tinhtrang bit not null
)
create table PhieuMuon
(
ma varchar(20) primary key not null,
DocGiama varchar(20) not null,
foreign key(DocGiama) references DocGia(ma),
ngaymuon date not null,
Sachma varchar(20) not null,
foreign key(Sachma) references Sach(ma),
hantra date not null

)
create table PhieuTra(
ma varchar(20) primary key not null,
Sachma varchar(20) not null,
foreign key(Sachma) references Sach(ma),
NhanVienma varchar(20) not null,
foreign key(NhanVienma) references NhanVien(ma),
ngaytra date not null,
phathong bigint,
phatquahan bigint,
phatmat bigint
)


insert into NhaXuatBan values('NXB0001',N'Nhà xuất bản quân đội nhân dân',N'23 Lý Nam Đế,Hà Nội','8455766','nxbqdnd.com.vn')
insert into NhaXuatBan values('NXB0002',N'Nhà xuất bản Đại học Bách Khoa',N'Khán đài B,sân vận động Tạ Quang Bửu Đại học Bách Khoa,Hà Nội ','8684569','nxbbk.hust.edu.vn')
insert into NhaXuatBan values('NXB0003',N'Nhà xuất bản Đại học quốc gia Hà Nội',N'16 Hàng Chuối,Hà Nội','9714899','press.vnu.edu.vn')
insert into NhaXuatBan values('NXB0004',N'Nhà xuất bản Đại học Sư phạm',N'136 Xuân Thủy,Cầu Giấy,Hà Nội','7547735','nxbdhsp.edu.vn')
insert into NhaXuatBan values('NXB0005',N'Nhà xuất bản giáo dục',N'81 Trần Hưng Đạo,Hà Nội','8220647','www.nxbgd.vn')
insert into NhaXuatBan values('NXB0006',N'Nhà xuất bản Giao thông vận tải',N'80B Trần Hưng Đạo,Hà Nội','9423346','nxbgtvt.vn')
insert into NhaXuatBan values('NXB0007',N'Nhà xuất bản Khoa học và kỹ thuật',N'70 Trần Hưng Đạo,Hà Nội','9424786','nxbkhkt.vn')
insert into NhaXuatBan values('NXB0008',N'Nhà xuất bản Khoa học xã hội',N'61 Phan Chu Trinh,Hà Nội','8256174','nxbkhxh.vass.gov.vn')
insert into NhaXuatBan values('NXB0009',N'Nhà xuất bản Lý luận chính trị',N'56B Quốc Tử Giám,Hà Nội','7472541','nxbluluanchinhtri.hcma.vn')
insert into NhaXuatBan values('NXB0010',N'Nhà xuất bản Thống kê',N'96 Thụy Khê,Hà Nội','8457290','www.nxbthongke.com.vn')


insert into TacGia values('TG0001',N'Lê Đức Trung')
insert into TacGia values('TG0002',N'Nguyễn Thị Minh Huyền')
insert into TacGia values('TG0003',N'Adam Khoo')
insert into TacGia values('TG0004',N'Tony Buzan')
insert into TacGia values('TG0005',N'Steve McConnell')
insert into TacGia values('TG0006',N'Steve Krug')
insert into TacGia values('TG0007',N'Tom Demarco')
insert into TacGia values('TG0008',N'Donald A.Norman')
insert into TacGia values('TG0009',N'Alan Cooper')
insert into TacGia values('TG0010',N'John Bentley')


insert into TheLoai values('TL0001',N'Công nghệ thông tin',N'Sách khoa học kỹ thuật')
insert into TheLoai values('TL0002',N'Cơ khí',N'Sách khoa học kỹ thuật')
insert into TheLoai values('TL0003',N'Xây dựng',N'Sách khoa học kỹ thuật')
insert into TheLoai values('TL0004',N'Tư tưởng-Lý luận chính trị',N'Sách lý luận chính trị,tư tưởng')
insert into TheLoai values('TL0005',N'Ngoại ngữ',N'Sách ngoại ngữ')
insert into TheLoai values('TL0006',N'Viễn thông',N'Sách khoa học kỹ thuật')
insert into TheLoai values('TL0007',N'Y sinh',N'Sách khoa học kỹ thuật')
insert into TheLoai values('TL0008',N'Văn học',N'Sách giải trí')
insert into TheLoai values('TL0009',N'Quân sự',N'Sách quân sự')
insert into TheLoai values('TL0010',N'Báo chí',N'Báo,tạp chí')


insert into DocGia values('DG0001',N'Vũ Thị Thu Hương','1996-6-6',0,N'lớp TH13A,khoa CNTT,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0002',N'Trần Thị Mai Hoa','1996-9-10',0,N'lớp TH13A,khoa CNTT,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0003',N'Nguyễn Thành Công','1996-4-1',1,N'lớp DTVT13A,HVKTQS','2014-9-9','2017-7-7',1)
insert into DocGia values('DG0004',N'Nguyễn Văn Nam','1995-3-9',1,N'lớp XD12A,HVKTQS','2013-9-9','2018-7-7',1)
insert into DocGia values('DG0005',N'Nguyễn Hữu Nghĩa','1994-5-6',1,N'lớp XD11A,HVKTQS','2012-9-9','2017-7-7',1)
insert into DocGia values('DG0006',N'Trần Văn Nam','1998-2-3',1,N'lớp HTTT15,HVKTQS','2016-9-9','2021-7-7',1)
insert into DocGia values('DG0007',N'Nguyễn Văn Hoàng','1997-2-3',1,N'lớp CNPM14,HVKTQS','2015-9-9','2020-7-7',1)
insert into DocGia values('DG0008',N'Đinh Thị Hòa','1996-6-21',0,N'lớp TH13B,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0009',N'Nguyễn Thị Hiền','1995-10-30',0,N'lớp TH13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0010',N'Ngô Thị Thúy Nga','1996-6-1',0,N'lớp TH13A,HVKTQS','2016-9-9','2019-7-7',1)
insert into DocGia values('DG0011',N'Trần Văn Cảnh','1996-8-8',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)

insert into DocGia values('DG0012',N'Trần Văn Nghĩa','1996-9-8',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0013',N'Nguyễn Thành Đồng','1996-8-21',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0014',N'Doãn Vũ Kỳ','1996-10-8',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0015',N'Vũ Hoàng Anh','1996-11-8',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0016',N'Đỗ Văn Mạnh','1996-12-8',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0017',N'Nguyễn Văn Thắng','1996-8-1',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0018',N'Trần Mạnh Thắng','1996-8-2',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0019',N'Trần Văn Quảng','1996-8-3',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)
insert into DocGia values('DG0020',N'Bùi Tiến Đạt','1996-8-4',1,N'lớp CTM13A,HVKTQS','2014-9-9','2019-7-7',1)



select *from Sach
SELECT *FROM TheLoai

insert into Sach values('S00001',N'Code Complete',N'Sách về lập trình dành cho ngành CNTT',200,100000,300,'2014-1-1','NXB0001','TG0006','TL0001',1)
insert into Sach values('S00002',N'Cơ khí cơ bản',N'Sách ngành cơ khí',200,100000,300,'2017-10-1','NXB0002','TG0007','TL0002',1)
insert into Sach values('S00003',N'Xây dựng 1',N'Sách ngành xây dựng',200,90000,400,'2012-9-5','NXB0003','TG0003','TL0003',1)
insert into Sach values('S00004',N'Tư tưởng Hồ Chí Minh',N'Sách tư tưởng lý luận',100,30000,500,'2011-9-8','NXB0004','TG0004','TL0004',1)
insert into Sach values('S00005',N'Tiếng anh chuyên ngành',N'Sách ngoại ngữ',300,150000,500,'2011-9-9','NXB0005','TG0005','TL0005',1)
insert into Sach values('S00006',N'Mạng viễn thông',N'Sách ngành điện tử viễn thông',100,120000,400,'2016-9-9','NXB0006','TG0002','TL0006',1)
insert into Sach values('S00007',N'Điện tử y sinh',N'Sách ngành điện tử y sinh',200,100000,300,'2013-9-9','NXB0007','TG0007','TL0007',1)
insert into Sach values('S00008',N'Quân sự chung',N'Sách quân sự',200,20000,300,'2013-9-9','NXB0008','TG0008','TL0008',1)
insert into Sach values('S00009',N'Tạp chí',N'Tạp chí',20,10000,100,'2017-1-9','NXB0009','TG0009','TL0009',1)
insert into Sach values('S00010',N'Điện tử y sinh 2',N'Sách ngành điện tử y sinh',200,100000,300,'2013-9-9','NXB0010','TG0010','TL0010',1)


SELECT *FROM NhanVien
insert into NhanVien values('NV0001',N'Nguyễn Văn Nam',1,'1975-2-8','01233779898','Hà Nội','namnv@gmail.com','12345678',1)
insert into NhanVien values('NV0002',N'Nguyễn Vân Trà',0,'1975-9-8','01235779898','Hà Nội','tranv@gmail.com','12345678',1)
insert into NhanVien values('NV0003',N'Trần Văn Nam',1,'1975-2-7','01233679898','Hà Nội','namtv@gmail.com','12345678',1)
insert into NhanVien values('NV0004',N'Nguyễn Thị Hoa',0,'1979-2-8','01237779898','Hà Nội','hoant@gmail.com','12345678',1)
insert into NhanVien values('NV0005',N'Nguyễn Hữu Nghĩa',1,'1975-9-8','01233770898','Hà Nội','nghianh@gmail.com','12345678',0)
insert into NhanVien values('NV0006',N'Nguyễn Văn Hải',1,'1975-2-8','01233778898','Nam Định','hainv@gmail.com','12345678',0)
insert into NhanVien values('NV0007',N'Đinh Thị Hải',1,'1975-2-8','01233799898','Hà Nội','haidt@gmail.com','12345678',1)
insert into NhanVien values('NV0008',N'Đậu Đức Mạnh',1,'1975-10-8','01233779898','Hà Nội','manhdd@gmail.com','12345678',0)
insert into NhanVien values('NV0009',N'Nguyễn Phương Thảo',0,'1976-2-10','01233709898','Hải Dương','thaonp@gmail.com','12345678',1)
insert into NhanVien values('NV0010',N'Nguyễn Thị Gấm',0,'1979-2-11','01233769898','Hà Nội','gamnt@gmail.com','12345678',1)


select *from PhieuMuon

insert into PhieuMuon values('PM00001','DG0001','2016-8-20','S00001','2017-7-7')
insert into PhieuMuon values('PM00002','DG0002','2016-8-20','S00002','2017-7-7')
insert into PhieuMuon values('PM00003','DG0003','2016-8-20','S00003','2017-7-7')
insert into PhieuMuon values('PM00004','DG0004','2016-8-20','S00004','2017-7-7')
insert into PhieuMuon values('PM00005','DG0005','2016-8-20','S00005','2017-7-7')

SELECT *FROM PhieuTra
insert into PhieuTra(ma,Sachma,NhanVienma,ngaytra) values('PT0001','S00005','NV0001','2017-4-1')