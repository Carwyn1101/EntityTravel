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
(1,'admin','admin','admin');
insert into TaiKhoan values
(2,'user','user','user');
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
('KSan 1','Nha Trang','Hotel','5 sao','6.jpg','6.jpg','6.jpg','6.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('KSan 2','Nha Trang','Hotel','5 sao','6.jpg','6.jpg','6.jpg','6.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('KSan 3',N'Huế','Hotel','5 sao','6.jpg','6.jpg','6.jpg','6.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('KSan 4',N'Huế','Hotel','5 sao','6.jpg','6.jpg','6.jpg','6.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('KSan 5',N'Đà Nẵng','Hotel','5 sao','6.jpg','6.jpg','6.jpg','6.jpg',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('KSan 6',N'Đà Nẵng','Hotel','5 sao','6.jpg','6.jpg','6.jpg','6.jpg',1)
Go
CREATE TABLE ThongTinPhongCuaKhachSan
(
	IDPhong INT PRIMARY KEY IDENTITY,
	TenPhong nvarchar(max) null,
	KichThuocPhong nvarchar(max) null,
	GiaPhong nvarchar (max) null,
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
	HutThuoc2 nvarchar (max) null,
	UuDai nvarchar (max) null,
	HinhAnh1 nvarchar(max)Null,
	HinhAnh2 nvarchar(max)Null,
	TrangThai nvarchar(max) null,
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan)
);
Go
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',1)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',1)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',2)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',2)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',3)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',3)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',4)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',4)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',5)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',5)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',6)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500,000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.jpg','2.jpg',N'Còn Trống',6)
Go
CREATE TABLE DanhGia
(
	IDDanhGia INT PRIMARY KEY IDENTITY,
	TenKhachHang nvarchar(max),
	TraiNghiem nvarchar(max),
	DiemDanhGia nvarchar(max),
	DanhGiaNguoiDung nvarchar(max),
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan) 
);
Go
insert into DanhGia values 
(N'A',N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',1)
insert into DanhGia values 
(N'B',N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',2)
insert into DanhGia values 
(N'C',N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',3)
insert into DanhGia values 
(N'D',N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',4)
insert into DanhGia values 
(N'E',N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',5)
insert into DanhGia values 
(N'F',N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',6)
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
CREATE TABLE DatPhong
(
	MaDatPhong INT PRIMARY KEY IDENTITY,		
	NgayNhanPhong date,
	NgayTraPhong date,
	IDKhachHang INT Foreign key References TaiKhoan(IDNguoiDung),
	IDPhong INT Foreign key References ThongTinPhongCuaKhachSan(IDPhong),
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan) 
);
Go
insert into DatPhong values 
('2024-04-20','2024-04-22',2,2,1)
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

SELECT *FROM TaiKhoan
SELECT *FROM ThongTinKhachSan
SELECT *FROM ThongTinPhongCuaKhachSan
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
DROP TABLE ThongTinPhongCuaKhachSan
Go
DROP TABLE ThongTinKhachSan
Go
DROP TABLE TaiKhoan
Go