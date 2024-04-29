create database QuanLySanBong
use QuanLySanBong

set dateformat dmy

create table SanBong(
	maSan varchar(10),
	tenSan nvarchar(50),
	primary key(maSan)
)

create table KhachHang(
	maKhachHang varchar(10),
	tenKhachHang varchar(50),
	soDienThoai varchar(10),
	email varchar(50),
	matKhau varchar(50),
	gioiTinh varchar(10),
	ngaySinh smalldatetime,
	diaChi nvarchar(50),
	soLanDatSan int,
	primary key(maKhachHang)
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