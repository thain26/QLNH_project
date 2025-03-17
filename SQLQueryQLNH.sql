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

insert into TaiKhoan values('quanly', '1', 1)
insert into TaiKhoan values('nhanvien', '1', 0)


select * from TaiKhoan

create table NhanVien
(
	Ma varchar(10) identity primary key not null,
	CCCD varchar(100) not null,
	Ten nvarchar(100) not null,
	NgaySinh date not null,
	GioiTinh nvarchar(100) not null,
	SDT varchar(100) not null,
	--Luong money not null

)
go

create table DanhMucMonAn
(
	Ma int identity primary key not null,
	Ten nvarchar(100) not null,
)
Go

create table MonAn
(
	Ma int identity primary key not null,
	Ten nvarchar(100) not null default N'Đặt tên',
	MaDanhMuc int not null foreign key references DanhMucMonAn(Ma),
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
	TrangThai int not null default 0, --1 đã thanh toán, 0 chưa thanh toán
	TongTien money,
	PhuongThucThanhToan nvarchar(50)
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

create table CaLam
(
	Ca varchar(10) not null,
	constraint CaLam_PK primary key (Ca)
)

create table LichLam
(
	Ngay date not null primary key,
	Ca varchar(10) not null foreign key references CaLam(Ca),
	MaNV varchar(10) not null foreign key references NhanVien(Ma),
)

--insert into NhanVien( 

create proc TimNhanVien
@ten nvarchar(100)
as
begin
	select * from NhanVien where Ten = @ten
end
go

--Thêm bàn
insert into BanAn( Ten, TrangThai) values( N'Bàn 1', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 2', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 3', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 4', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 5', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 6', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 7', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 8', N'Trống')
insert into BanAn( Ten, TrangThai) values( N'Bàn 9', N'Trống')


--Thêm thông tin danh mục
insert into DanhMucMonAn(Ten) values( N'Đồ ăn')
insert into DanhMucMonAn( Ten) values( N'Đồ uống')



--Thêm thông tin món ăn
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Cơm lam', 1, 30000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Thịt trâu gác bếp', 1, 200000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Nậm pịa', 1, 120000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'Rượu nếp', 2, 20000)
insert into MonAn( Ten, MaDanhMuc, Gia) values( N'CocaCola', 2, 15000)



create proc ThemHoaDon
@MaBan int
as
begin
	insert into HoaDon( MaBan, NgayVao, NgayRa, TrangThai) values (@MaBan, GETDATE(), null , 0)
end
go


create proc ThemThongTinHoaDon
@mahoadon int, @mamonan int, @soluongthem int
as
begin
	declare @check int
	declare @soluongcu int = 1

	select @check = Ma, @soluongcu = Soluong from ThongTinHoaDon where MaHoaDon = @mahoadon and MaMonAn = @mamonan

	if (@check > 0)
		begin
			declare @soluongmoi int = @soluongcu + @soluongthem
			if (@soluongmoi > 0)
				update ThongTinHoaDon set SoLuong = @soluongcu + @soluongthem where MaHoaDon = @mahoadon and MaMonAn = @mamonan
			else delete ThongTinHoaDon where MaMonAn = @mamonan and MaHoaDon = @mahoadon 
		end
	else if (@soluongthem > 0)
	begin
		insert into ThongTinHoaDon( MaHoaDon, MaMonAn, SoLuong) values (@mahoadon, @mamonan, @soluongthem)
	end
end
go

create trigger updateThongTinHoaDon on ThongTinHoaDon for update, insert
as 
begin
	declare @idHoaDon int	
	select @idHoaDon = MaHoaDon from inserted
	declare @idBan int 
	select @idBan = MaBan from HoaDon where Ma = @idHoaDon and TrangThai = 0
	update BanAn set TrangThai = N'Đang phục vụ' where Ma = @idBan
end
go

create trigger updateHoaDon on HoaDon for update
as 
begin
	declare @idHoaDon int	
	select @idHoaDon = Ma from inserted

	declare @idBan int 
	select @idBan = MaBan from HoaDon where Ma = @idHoaDon

	declare @check int = 0
	select @check = count(*) from HoaDon where MaBan = @idBan and TrangThai = 0

	if ( @check = 0)
		update BanAn set TrangThai = N'Trống' where BanAn.Ma = @idBan
end
go


insert into HoaDon(Ma, MaBan, NgayVao, NgayRa, TrangThai,TongTien) values(1, 2, '2023-01-11', '2023-01-11', 1, 100000)
insert into HoaDon(Ma, MaBan, NgayVao, NgayRa, TrangThai,TongTien) values(2, 2, '2024-01-16', '2024-01-11', 1, 200000)

 