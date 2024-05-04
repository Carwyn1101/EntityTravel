Use DoAnCuoiKy
Go
CREATE TABLE TaiKhoan
(
	IDNguoiDung INT PRIMARY KEY,
	TenDangNhap nvarchar(max) null,
	MatKhau nvarchar(max) null,
	LoaiNguoiDung nvarchar(max) null
);
Go
insert into TaiKhoan values
(1,'admin1','123','admin');
insert into TaiKhoan values
(2,'admin2','123','admin');
insert into TaiKhoan values
(3,'duong','123','user');
insert into TaiKhoan values
(4,'phuc','123','user');
Go
CREATE TABLE ThongTinKhachSan
(
	IDKhachSan INT PRIMARY KEY IDENTITY,
	TenKhachSan nvarchar(max) Null,
	DiaDiemKhachSan nvarchar(max)Null,
	Loai nvarchar(max)Null,
	MoTa nvarchar(max)Null,
	HinhAnh1 nvarchar(max)Null,
	HinhAnh2 nvarchar(max)Null,
	HinhAnh3 nvarchar(max)Null,
	HinhAnh4 nvarchar(max)Null,
	IDChuKhachSan INT Foreign key References TaiKhoan(IDNguoiDung)
);
Go
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('Royal Family','Nha Trang','Hotel',N'Giáp biển, khách sạn 5 sao','6.jpg','1.jpg','3.jpg','4.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('Bell YuNi','Nha Trang','Hotel',N'View biển, gần trung tâm thành phố','9.jpg','1.jpg','3.jpg','4.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('Flower Boutique',N'Huế','Hotel',N'Khách sạn 5 sao','10.jpg','1.jpg','3.jpg','4.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('Sea Hotel',N'Huế','Hotel',N'Giáp biển, khách sạn 5 sao','11.jpg','1.jpg','3.jpg','4.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('Golden Light',N'Đà Nẵng','Hotel',N'Giáp biển, khách sạn 5 sao','12.jpg','1.jpg','3.jpg','4.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('Heaven',N'Đà Nẵng','Hotel',N'View biển, gần trung tâm thành phố','13.jpg','1.jpg','3.jpg','4.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('LoTus',N'Huế','Homestay',N'View biển, gần trung tâm thành phố','14.jpg','1.jpg','3.jpg','4.jpg',2)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('SunSet',N'Nha Trang','Homestay',N'View biển, gần trung tâm thành phố','15.jpg','1.jpg','3.jpg','4.jpg',2)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('LuNa House',N'Đà Nẵng','Homestay',N'Giá rẻ','16.jpg','1.jpg','3.jpg','4.jpg',2)
Go
CREATE TABLE ThongTinPhongCuaKhachSan
(
	IDPhong INT PRIMARY KEY IDENTITY,
	TenPhong nvarchar(max) null,
	KichThuocPhong nvarchar(max) null,
	GiaPhong float,
	TienNghiPhongTam1 nvarchar (max) null,
	TienNghiPhongTam2 nvarchar (max) null,
	TienNghiPhongTam3 nvarchar (max) null,
	TienNghiPhongTam4 nvarchar (max) null,
	HuongTamNhin1 nvarchar (max) null,
	HuongTamNhin2 nvarchar (max) null,
	TienNghiPhong1 nvarchar (max) null,
	TienNghiPhong2 nvarchar (max) null,
	TienNghiPhong3 nvarchar (max) null,
	TienNghiPhong4 nvarchar (max) null,
	TienNghiPhong5 nvarchar (max) null,
	TienNghiPhong6 nvarchar (max) null,
	HutThuoc1 nvarchar (max) null,	
	HinhAnh1 nvarchar(max)Null,
	HinhAnh2 nvarchar(max)Null,
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan)
);
Go
--1
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','400000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','2.jpg','5.jpg',1)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','600000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','2.jpg','5.jpg',1)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','30','800000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','2.jpg','5.jpg',1)
--2
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','500000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','7.jpg','8.jpg',2)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','700000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','7.jpg','8.jpg',2)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','900000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','7.jpg','8.jpg',2)
--3
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','500000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','17.jpg','19.jpg',3)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','700000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','17.jpg','19.jpg',3)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','900000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','17.jpg','19.jpg',3)
--4
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','450000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','18.jpg','5.jpg',4)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','500000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','18.jpg','5.jpg',4)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','750000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','18.jpg','5.jpg',4)
--5
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','550000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','20.jpg','8.jpg',5)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','700000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','20.jpg','8.jpg',5)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','1000000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','20.jpg','8.jpg',5)
--6
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','550000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','24.jpg','22.jpg',6)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','700000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','24.jpg','22.jpg',6)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','1000000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','24.jpg','22.jpg',6)
--7
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','600000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','26.jpg','23.jpg',7)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','800000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','26.jpg','23.jpg',7)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','1100000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','26.jpg','23.jpg',7)
--8
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','550000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','25.jpg','18.jpg',8)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','700000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','25.jpg','18.jpg',8)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','950000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','25.jpg','18.jpg',8)
--9
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đơn','15','350000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','20.jpg','19.jpg',9)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng giường đôi','20','450000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','20.jpg','19.jpg',9)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1,  HinhAnh1, HinhAnh2,  IDKhachSan) values 
(N'Phòng vip','40','600000',N'Dép',N'Vòi sen',N'Bồn tắm',N'Máy sấy tóc',N'Nhìn ra biển',N'Nhìn ra thành phố',N'Minibar',N'Điện thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Được hút thuốc','20.jpg','19.jpg',9)
GO
CREATE TABLE MaGiamGia
(
	STTMa INT PRIMARY KEY IDENTITY,
	MaGiam nvarchar(30),
	GiaTri int,
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan),
);
CREATE TABLE DanhGia
(
	IDDanhGia INT PRIMARY KEY IDENTITY,
	TenKhachHang nvarchar(max),
	TraiNghiem nvarchar(max),
	DiemDanhGia int,
	DanhGiaNguoiDung nvarchar(max),
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan) 
);
Go
insert into DanhGia values 
(N'Sang',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',1)
insert into DanhGia values 
(N'Sơn',N'Tốt','8',N'View biển đẹp, trung tâm thành phố',2)
insert into DanhGia values 
(N'Phúc',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',3)
insert into DanhGia values 
(N'Dương',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',4)
insert into DanhGia values 
(N'Thao',N'Tuyệt Hảo','10',N'View biển đẹp, trung tâm thành phố',5)
insert into DanhGia values 
(N'Vũ',N'Tuyệt Hảo','10',N'View biển đẹp, trung tâm thành phố',6)
insert into DanhGia values 
(N'Hoàng',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',7)
insert into DanhGia values 
(N'Tiến',N'Tốt','8',N'View biển đẹp, trung tâm thành phố',8)
insert into DanhGia values 
(N'Huy',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',9)

insert into DanhGia values 
(N'Lựu',N'Tốt','8',N'Phòng sạch sẽ, thoải mái, view ban công đẹp',1)
insert into DanhGia values 
(N'Lê',N'Tốt','7',N'Đồ ăn ngon, nhân viên nhiệt tình',2)
insert into DanhGia values 
(N'Loan',N'Tuyệt Hảo','10',N'Khách sạn rất đẹp, bữa sáng ngon, địa điểm gần bãi biển',3)
insert into DanhGia values 
(N'Thư',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',4)
insert into DanhGia values 
(N'Tú',N'Tạm','6',N'Nhân viên thái độ làm việc không chuyên nghiệp',5)
insert into DanhGia values 
(N'Trang',N'Tạm','5',N'Phòng hơi bẩn',6)
insert into DanhGia values 
(N'Thi',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',7)
insert into DanhGia values 
(N'Thảo',N'Tốt','8',N'Phòng sạch sẽ, thoải mái, view ban công đẹp',8)
insert into DanhGia values 
(N'Thu',N'Tốt','7',N'Đồ ăn ngon, nhân viên nhiệt tình',9)

insert into DanhGia values 
(N'Thúy',N'Tốt','8',N'Phòng sạch sẽ, thoải mái, view ban công đẹp',1)
insert into DanhGia values 
(N'Thùy',N'Tốt','7',N'Đồ ăn ngon, nhân viên nhiệt tình',2)
insert into DanhGia values 
(N'Thủy',N'Tuyệt Hảo','10',N'Khách sạn rất đẹp, bữa sáng ngon, địa điểm gần bãi biển',3)
insert into DanhGia values 
(N'Yến',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',4)
insert into DanhGia values 
(N'Mai',N'Tạm','6',N'Nhân viên thái độ làm việc không chuyên nghiệp',5)
insert into DanhGia values 
(N'Đào',N'Tạm','5',N'Phòng hơi bẩn',6)
insert into DanhGia values 
(N'Hồng',N'Tuyệt Hảo','9',N'View biển đẹp, trung tâm thành phố',7)
insert into DanhGia values 
(N'Peter',N'Tốt','8',N'Phòng sạch sẽ, thoải mái, view ban công đẹp',8)
insert into DanhGia values 
(N'An',N'Tốt','7',N'Đồ ăn ngon, nhân viên nhiệt tình',9)
Go
CREATE TABLE ThongTinKhachHang
(
	SoThuTu INT PRIMARY KEY IDENTITY,
	IDKhachHang INT Foreign key References TaiKhoan(IDNguoiDung),
	TenKhachHang nvarchar(max),
	SDT nvarchar(max),
	CCCD nvarchar(max),
	Mail nvarchar(max),	
);
Go
insert into ThongTinKhachHang values 
(3,N'Trần Khánh Dương','0123456789','11111111','duong@gmail.com')
insert into ThongTinKhachHang values 
(4,N'Nguyễn Đinh Hồng Phúc','0123456789','11111111','phuc@gmail.com')
Go
CREATE TABLE DatPhong
(
	MaDatPhong INT PRIMARY KEY IDENTITY,		
	NgayNhanPhong date,
	NgayTraPhong date,
	TrangThai nvarchar(max),
	IDKhachHang INT Foreign key References TaiKhoan(IDNguoiDung),
	IDPhong INT Foreign key References ThongTinPhongCuaKhachSan(IDPhong),
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan) 
);
Go
insert into DatPhong values 
('2024-04-15','2024-04-17',N'Đã được thuê',3,4,2)
insert into DatPhong values 
('2024-04-15','2024-04-17',N'Đã được thuê',4,5,2)
Go
CREATE TABLE HoaDon
(
	MaHoaDon INT PRIMARY KEY IDENTITY,
	SoThuTuKhachHang INT Foreign key References ThongTinKhachHang(SoThuTu),
	TenKhachHang nvarchar(max),
	SDT nvarchar(max),
	CCCD nvarchar(max),
	Mail nvarchar(max),
	NgayDatPhong date default GetDate(),
	NgayNhanPhong date,
	NgayTraPhong date,
	TongTien nvarchar(max),
	IDPhong INT Foreign key References ThongTinPhongCuaKhachSan(IDPhong)
);
Go
insert into HoaDon values 
(1,N'Trần Khánh Dương','0123456789','11111111','duong@gmail.com','2024-04-15','2024-04-15','2024-04-17','1000000',4)
insert into HoaDon values 
(2,N'Nguyễn Đinh Hồng Phúc','0123456789','11111111','phuc@gmail.com','2024-04-15','2024-04-15','2024-04-17','1400000',5)

SELECT *FROM TaiKhoan
SELECT *FROM ThongTinKhachSan
SELECT *FROM ThongTinPhongCuaKhachSan
SELECT *FROM MaGiamGia
SELECT *FROM DanhGia
SELECT *FROM ThongTinKhachHang
SELECT *FROM DatPhong
SELECT *FROM HoaDon


DROP TABLE HoaDon
Go
DROP TABLE DatPhong
Go
DROP TABLE ThongTinKhachHang
Go
DROP TABLE DanhGia
Go
DROP TABLE MaGiamGia
Go
DROP TABLE ThongTinPhongCuaKhachSan
Go
DROP TABLE ThongTinKhachSan
Go
DROP TABLE TaiKhoan
