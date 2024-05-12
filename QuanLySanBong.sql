create database QuanLySanBong
go
use QuanLySanBong
go
set dateformat dmy
go
/*###########################################*/
/*Sân Bóng*/
create table SanBong(
	maSanBong varchar(10),
	tenSanBong nvarchar(50),
	giaSanTheoPhut int,
	primary key(maSanBong)
)
go
insert into SanBong values
('SB01',N'Sân 1',1000),('SB02',N'Sân 2',1000),('SB03',N'Sân 3',1000),
('SB04',N'Sân 4',1000),('SB05',N'Sân 5',1000),('SB06',N'Sân 6',1000),
('SB07',N'Sân 7',1000),('SB08',N'Sân 8',1000),('SB09',N'Sân 9',1000),
('SB10',N'Sân 10',1000),('SB11',N'Sân 11',1000),('SB12',N'Sân 12',1000)
go
/*###########################################*/
/*Khách hàng*/
create table KhachHang(
	maKhachHang varchar(10),
	tenKhachHang nvarchar(50),
	soDienThoai varchar(10),
	email varchar(50),
	matKhau varchar(50),
	gioiTinh nvarchar(10),
	ngaySinh smalldatetime,
	diaChi nvarchar(50),
	soLanDatSan int,
	primary key(maKhachHang)
)
go
/*###########################################*/
/*Quản lý*/
create table QuanLy(
	maQuanLy varchar(5),
	tenQuanLy nvarchar(50),
	soDienThoai varchar(10),
	email varchar(50),
	matKhau varchar(50),
	toanQuyen bit
	primary key(maQuanLy)
)
go
/*###########################################*/
/*OTP*/
create table OTP(
	email varchar(50),
	otpCode int,
	primary key(email)
)
go
/*###########################################*/
/*PhieuDatSan*/
create table PhieuDatSan(
	maPhieuDatSan varchar(10),
	maKhachHang varchar(10),
	maQuanLy varchar(10),
	loaiSan int,
	ngayDatSan smalldatetime,
	thoiGianDa smalldatetime,
	thoiGianKetThuc smalldatetime,
	tongTien int,
	tinhTrangXacNhan nvarchar(255),
	tinhTrangThanhToan nvarchar(255),
	primary key (maPhieuDatSan),
	foreign key (maKhachHang) references KhachHang(maKhachHang),
	foreign key (maQuanLy) references QuanLy(maQuanLy)
)
go
/*###########################################*/
/*ChiTietPhieuDatSan*/
create table ChiTietPhieuDatSan(
	maPhieuDatSan varchar(10),
	maSanBong varchar(10),
	donGia int,
	primary key (maPhieuDatSan, maSanBong),
	foreign key (maPhieuDatSan) references PhieuDatSan(maPhieuDatSan),
	foreign key (maSanBong) references SanBong(maSanBong),
)
go
/*###########################################*/
/*Thêm 1 quản lý toàn quyền, 1 quản lý không toàn quyền*/
Insert into QuanLy values 
('AD001',N'Toàn quyền','0868063561','toanquyen@gmail.com','toanquyen',1),
('AD002',N'Không toàn quyền','0868063561','khongtoanquyen@gmail.com','khongtoanquyen',0)
