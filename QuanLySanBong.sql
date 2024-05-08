create database QuanLySanBong
use QuanLySanBong

set dateformat dmy

create table SanBong(
	maSanBong varchar(10),
	tenSanBong nvarchar(50),
	primary key(maSanBong)
)

insert into SanBong values
('SB01',N'Sân 1'),('SB02',N'Sân 2'),('SB03',N'Sân 3'),
('SB04',N'Sân 4'),('SB05',N'Sân 5'),('SB06',N'Sân 6'),
('SB07',N'Sân 7'),('SB08',N'Sân 8'),('SB09',N'Sân 9'),
('SB10',N'Sân 10'),('SB11',N'Sân 11'),('SB12',N'Sân 12')

create table KhachHang(
	maKhachHang varchar(10),
	tenKhachHang nvarchar(50),
	soDienThoai varchar(10),
	email varchar(50),
	matKhau varchar(50),
	gioiTinh varchar(10),
	ngaySinh smalldatetime,
	diaChi nvarchar(50),
	soLanDatSan int,
	primary key(maKhachHang)
)

create table OTP(
	email varchar(50),
	otpCode int,
	primary key(email)
)

create table PhieuDatSan(
	maPhieuDatSan varchar(10),
	maKhachHang varchar(10),
	maQuanLy varchar(10),
	loaiSan int,
	ngayDatSan smalldatetime,
	ngayDa smalldatetime,
	phutDa int,
	tongTien int,
	tinhTrangXacNhan nvarchar(255),
	tinhTrangThanhToan nvarchar(255),
	primary key (maPhieuDatSan),
	foreign key (maKhachHang) references KhachHang(maKhachHang),
	foreign key (maQuanLy) references QuanLy(maQuanLy)
)

create table ChiTietPhieuDatSan(
	maPhieuDatSan varchar(10),
	maSanBong varchar(10),
	donGia int,
	primary key (maPhieuDatSan, maSanBong),
	foreign key (maPhieuDatSan) references PhieuDatSan(maPhieuDatSan),
	foreign key (maSanBong) references SanBong(maSanBong),
)

/*Ma khach hang phat sinh tu dong, KHXXYYYYYY,
KH la viet tat cua KH
XX la hai so cuoi dien thoai
YYYYYY la so thu tu tang dan
*/
insert into KhachHang values (
	'KH69000001',
	'Dinh Phat Phat',
	'0868063569',
	'dinhphatphat@gmail.com',
	'dinhphatphat123',
	'Nam',
	'24/11/2004',
	'Dong Thap',
	0
)

insert into KhachHang values (
	'KH66000002',
	'Le Cong Tuan',
	'0868063566',
	'lecongtuan@gmail.com',
	'lecongtuan123',
	'Nam',
	'24/11/2004',
	'Dong Thap',
	0
)

use QuanLySanBong

create table QuanLy(
	maQuanLy varchar(5),
	tenQuanLy varchar(50),
	soDienThoai varchar(10),
	email varchar(50),
	matKhau varchar(50),
	toanQuyen bit
	primary key(maQuanLy)
)

insert into QuanLy values (
	'',
	'',
	'',
	'',
	'',
	0
)
insert into QuanLy values (
	'AD001',
	'Le Cong Tuan',
	'0123456789',
	'lecongtuan@gmail.com',
	'lecongtuanadmin',
	1
)

select * from KhachHang
delete from KhachHang where (email='dinhtainang@gmail.com')
print datetime
delete from PhieuDatSan where 1=1
delete from ChiTietPhieuDatSan where 1=1
select * from PhieuDatSan
select * from  ChiTietPhieuDatSan