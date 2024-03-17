create database QuanLyNhaHang
Go

use QuanlyNhaHang
Go

--Loại đồ ăn
--Món ăn
--Bàn
--tài khoản
--Hóa đơn
--món ăn trong hóa đơn

create table TaiKhoan
(
	TenDangNhap nvarchar(100) primary key not null,
	MatKhau nvarchar(1000) not null,
	LoaiTaiKhoan int not null default 0--1 quản lý, 0 nhân viên
)
Go

create table NhanVien
(
	Ma int identity primary key not null,
	CCCD varchar(100) not null,
	Ten nvarchar(100) not null,
	NgaySinh date not null,
	GioiTinh nvarchar(100) not null,
	SDT varchar(100) not null,

)
go

create table DanhMuc
(
	Ma int identity primary key not null,
	Ten nvarchar(100) not null default N'Đặt tên',
)
Go

create table MonAn
(
	Ma int identity primary key not null,
	Ten nvarchar(100) not null default N'Đặt tên',
	MaDanhMuc int not null foreign key references DanhMuc(Ma),
	Gia money not null
)
Go

create table BanAn
(
	Ma int identity primary key not null,
	Ten nvarchar(100) not null default N'Đặt tên',
	TrangThai nvarchar(100) not null default N'Trống' --trống, đang phục vụ
)
Go

create table HoaDon
(
	Ma int identity primary key not null,
	MaBan int not null foreign key references BanAn(Ma),
	NgayVao date not null,
	NgayRa date,
	TrangThai int not null default 0 --1 đã thanh toán, 0 chưa thanh toán
)
Go

create table ThongTinHoaDon
(
	Ma int identity primary key not null,
	MaHoaDon int not null foreign key references HoaDon(Ma),
	MaMonAn int not null foreign key references MonAn(Ma),
	SoLuong int not null default 0,

)
Go

--insert into NhanVien( 

insert into TaiKhoan( tenDangNhap, matKhau, loaiTaiKhoan) values (N'quanly', N'1', 1)
insert into TaiKhoan( tenDangNhap, matKhau, loaiTaiKhoan) values (N'nhanvien', N'1', 0)

insert into NhanVien( CCCD, ten, ngaySinh, gioiTinh, SDT) values ( N'017204005254', N'Nguyễn Quang Thái', '2004/10/26', N'Nam', N'0989799062')


create proc TimNhanVien
@ten nvarchar(100)
as
begin
	select * from NhanVien where Ten = @ten
end
go

select * from TaiKhoan where TenDangNhap = N'quanly' and MatKhau = N'1' and LoaiTaiKhoan = 1
--Thêm bàn
insert into BanAn( Ten, TrangThai) values( N'Bàn 1', N'Đang phục vụ')
insert into BanAn( Ten, TrangThai) values( N'Bàn 2', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 3', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 4', N'Đang phục vụ')


--Thêm thông tin danh mục
insert into DanhMuc (Ten) values( N'Đồ ăn')
insert into DanhMuc( Ten) values( N'Đồ uống')

--Thêm thông tin món ăn
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Cơm lam', 1, 30000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Thịt trâu gác bếp', 1, 200000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Nậm pịa', 1, 120000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Rượu nếp', 2, 20000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'CocaCola', 2, 15000)

-- Thêm hóa đơn
insert into HoaDon( MaBan, NgayVao, NgayRa, TrangThai) values (1, 


select * from HoaDon
select * from ThongTinHoaDon
select * from MonAn
select * from DanhMuc

