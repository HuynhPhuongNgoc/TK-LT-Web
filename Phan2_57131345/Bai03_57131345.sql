GO 
CREATE DATABASE QLBH
GO 
USE QLBH
--bp-nv--kh--ncc--lmh--mh--hdb--hdn
GO 
CREATE TABLE BoPhan(
MaBP NCHAR(2) PRIMARY KEY NOT NULL,
TenBP NVARCHAR(30) NOT NULL
)
GO 
CREATE TABLE NhanVien(
MaNV VARCHAR(10) PRIMARY KEY NOT NULL,
HoNV NVARCHAR(10) NOT NULL,
TenNV NVARCHAR(10) NOT NULL,
GioiTinh BIT DEFAULT(1) NOT NULL,
NgaySinh DATETIME NOT NULL,
DiaChi NVARCHAR(50) NOT NULL,
Luong TINYINT NOT NULL,
MaBP NCHAR(2) NOT NULL FOREIGN KEY REFERENCES dbo.BoPhan(MaBP)
)
GO 
CREATE TABLE KhachHang(
MaKH VARCHAR(10) PRIMARY KEY NOT NULL,
TenKH NVARCHAR(40) NOT NULL,
DiaChi NVARCHAR(50) NOT NULL,
DienThoai NCHAR(11) NOT NULL,
GhiChu NVARCHAR(50) NOT NULL
)
GO 
CREATE TABLE NhaCungCap(
MaNCC VARCHAR(10) PRIMARY KEY NOT NULL,
TenNCC NVARCHAR(50) NOT NULL,
DiaChi NVARCHAR(50) NOT NULL,
DienThoai NCHAR(11) NOT NULL,
GhiChu NVARCHAR(50) NOT NULL
)
GO 
CREATE TABLE LoaiMatHang(
MaLoaiMH VARCHAR(20) PRIMARY KEY NOT NULL,
TenLoaiMH NVARCHAR(40) NOT NULL
)
GO 
CREATE TABLE MatHang(
MaMH VARCHAR(10) PRIMARY KEY NOT NULL,
TenMH NVARCHAR(40) NOT NULL,
DVT NVARCHAR(10) NOT NULL,
DonGiaNhap MONEY NOT NULL,
DonGiaBan MONEY NOT NULL,
SoLuongTon TINYINT NOT NULL,
MaLoaiMH VARCHAR(20) FOREIGN KEY REFERENCES dbo.LoaiMatHang(MaLoaiMH)
)
GO 
CREATE TABLE HoaDonBan(
SoHDB NCHAR(10) PRIMARY KEY NOT NULL,
NgayBan DATETIME NOT NULL,
MaKH VARCHAR(10) NOT NULL,
MaNV VARCHAR(10) NOT NULL,
GhiChu NVARCHAR(50) NOT NULL,
CONSTRAINT hdb_kh FOREIGN KEY (MaKH) REFERENCES dbo.KhachHang(MaKH),
CONSTRAINT hdb_nv FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV)
)
GO 
CREATE TABLE HoaDonNhap(
SoHDN NCHAR(10) PRIMARY KEY NOT NULL,
NgayNhap DATETIME NOT NULL,
MaNCC VARCHAR(10) NOT NULL,
MaNV VARCHAR(10) NOT NULL,
GhiChu NVARCHAR(50) NOT NULL,
CONSTRAINT hdn_ncc FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
CONSTRAINT hdn_nv FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV)
)
GO 
CREATE TABLE CTHDB(
SoHDB NCHAR(10) NOT NULL,
MaMH VARCHAR(10) NOT NULL,
SoLuongBan TINYINT NOT NULL,
DonGiaBan MONEY NOT NULL
CONSTRAINT kc1 PRIMARY KEY(SoHDB,MaMH)
)
GO 
CREATE TABLE CTHDN(
SoHDN NCHAR(10) NOT NULL,
MaMH VARCHAR(10) NOT NULL,
SoLuongNhap TINYINT NOT NULL,
DonGiaNhap MONEY NOT NULL
CONSTRAINT kc2 PRIMARY KEY(SoHDN,MaMH)
)
--bộ phận
GO 
INSERT dbo.BoPhan( MaBP, TenBP )
VALUES  ( N'01',N'Phòng hành chính'),
		( N'02',N'Phòng nhân sự'),
		( N'03',N'Phòng kinh doanh'),
		( N'04',N'Phòng kế hoạch'),
		( N'05',N'Phòng chăm sóc khách hành')

--Nhân viên
GO 
INSERT dbo.NhanVien( MaNV ,HoNV ,TenNV ,GioiTinh ,NgaySinh ,DiaChi ,Luong ,MaBP)
VALUES  ( 'NV01' ,N'Huỳnh' , N'Ngọc' ,0, '04/19/1997',N'Nha Trang-Khánh Hòa' ,180 ,N'01'),
		( 'NV02' ,N'Hàng' , N'Bình' ,0, '05/17/1994',N'Nha Trang-Khánh Hòa' ,190 ,N'02'),
		( 'NV03' ,N'Lê' , N'A' ,0, '04/10/1990',N'Vạn Ninh-Khánh Hòa' ,170 ,N'03'),
		( 'NV04' ,N'Trần' , N'B' ,0, '03/11/1987',N'Ninh Hòa-Khánh Hòa' ,160 ,N'04'),
		( 'NV05' ,N'Nguyễn' , N'C' ,0, '02/03/1968',N'Cam Ranh-Khánh Hòa' ,150 ,N'05')

 --khách hàng
 GO 
 INSERT dbo.KhachHang( MaKH ,TenKH ,DiaChi ,DienThoai ,GhiChu )
 VALUES  ( 'KH01' ,N'Trang' ,N'Phương Sài-Nha Trang' ,N'0128384960' ,N'Ko có gì'),
		( 'KH02' ,N'Trân' ,N'Lương Định Của-Nha Trang' ,N'09462339' ,N'Thiếu hàng'),
		( 'KH03' ,N'Trinh' ,N'Trần Nhật Duật-Nha Trang' ,N'5555d9633' ,N'Khách VIP'),
		( 'KH04' ,N'Trà' ,N'Trần Phú-Nha Trang' ,N'098746313' ,N'Khách lẻ'),
		( 'KH05' ,N'Trâm' ,N'Lê Thánh Tôn-Nha Trang' ,N'997123366' ,N'Khách sỉ')

 ----- Nhà cung cấp--------------
 GO 
 INSERT dbo.NhaCungCap ( MaNCC ,TenNCC , DiaChi ,DienThoai , GhiChu)
 VALUES  ( 'CC01' ,N'Vinamilk' , N'Q2-TP.Hồ Chí Minh' ,N'026645412' ,N'Vận chuyển nhanh'),
		 ( 'CC02' ,N'Dutch lady' , N'Q10-TP.Hồ Chí Minh' ,N'09567392' ,N'Vận chuyển thường'),
		 ( 'CC03' ,N'Ông Thọ' , N'Q8-TP.Hồ Chí Minh' ,N'008272475' ,N'Số lượng lớn'),
		 ('CC04' ,'Yomost' , N'Q7-TP.Hồ Chí Minh' ,N'03958721' ,N'2 thùng'),
		 ( 'CC05' ,N'Firsti' , N'Q5-TP.Hồ Chí Minh' ,N'028475789' ,N'1 lô')

 -------- Loại mặt hàng-----------------
 GO 
 INSERT dbo.LoaiMatHang( MaLoaiMH, TenLoaiMH )
 VALUES  ( 'MH01',N'Sữa tươi'),
		 ( 'MH02',N'Sữa đặc'),
		 ( 'MH03',N'Sữa chua'),
		 ( 'MH04',N'Sữa bò'),
		 ( 'MH05',N'Sữa tiệt trùng')

 ---------Mặt hàng---------------------
 GO 
 INSERT dbo.MatHang( MaMH ,TenMH ,DVT ,DonGiaNhap ,DonGiaBan ,SoLuongTon ,MaLoaiMH)
 VALUES  ( 'H1' , N'sữa dâu' , N'hộp' ,5000 ,6000,2 ,'MH01'),
		 ( 'H2' , N'thạch nho' , N'viên' ,3000 ,5000,0 ,'MH02'),
		 ( 'H3' , N'sữa chua nha đam' , N'hủ' ,6000 ,8000,0 ,'MH03'),
		 ( 'H4' , N'sữa Mộc Châu' , N'hộp' ,5000 ,7000,1 ,'MH04'),
		 ( 'H5' , N'sữa socola' , N'hộp' ,6000 ,9000,2 ,'MH05')

 ---------------Hóa đơn bán-----------
 GO 
 INSERT dbo.HoaDonBan( SoHDB, NgayBan, MaKH, MaNV, GhiChu )
 VALUES		( N'HDB01','02/03/2017','KH01','NV02', N'Buổi sáng'),
			( N'HDB02','05/03/2017','KH04','NV01', N'Buổi sáng'),
			( N'HDB03','12/12/2017','KH03','NV04', N'Buổi sáng'),
			( N'HDB04','10/03/2017','KH05','NV05', N'Buổi chiều'),
			( N'HDB05','04/11/2017','KH02','NV03', N'Buổi chiều')
	
 -------------- Hóa đơn nhập---------------
 GO 
 INSERT dbo.HoaDonNhap( SoHDN, NgayNhap, MaNCC, MaNV, GhiChu )
 VALUES ( N'HDN01','02/01/2017','CC02','NV01',N'Nhập chiều'),
		( N'HDN02','04/11/2017','CC05','NV05',N'Nhập chiều'),
		( N'HDN03','11/11/2017','CC04','NV03',N'Nhập sáng'),
		( N'HDN04','09/01/2017','CC01','NV02',N'Nhập sáng'),
		( N'HDN05','02/10/2017','CC03','NV04',N'Nhập chiều')
 -------------- CTHDB---------------------
 GO 
 INSERT dbo.CTHDB( SoHDB, MaMH, SoLuongBan, DonGiaBan )
 VALUES		( N'SHD1','H2',10,5000),
			( N'SHD2','H1',20,6000),
			( N'SHD3','H5',5,9000),
			( N'SHD4','H3',18,8000),
			( N'SHD5','H4',19,7000)
 ----------------CTHDN---------------------
 GO 
 INSERT dbo.CTHDN( SoHDN ,MaMH ,SoLuongNhap ,DonGiaNhap)
 VALUES  ( N'SHDN1' ,'H5' ,22,6000),
		 ( N'SHDN2' ,'H3' ,25,6000),
		 ( N'SHDN3' ,'H1' ,30,5000),
		 ( N'SHDN4' ,'H4' ,50,5000),
		 ( N'SHDN5' ,'H2' ,100,3000)

 ---- **HIỂN THỊ DANH SÁCH CÁC DÒNG DỮ LIỆU--------
----- Bộ phận-----
GO
CREATE PROC BoPhan_DS
AS
BEGIN 
	SELECT *
	FROM BoPhan 
END
-------Nhân viên------
GO
CREATE PROC NhanVien_DS
AS
BEGIN
	SELECT* FROM dbo.NhanVien
END
----------Khách Hàng------------
GO
CREATE PROC KhachHang_DS
AS
BEGIN 
	SELECT * FROM dbo.KhachHang
END
----- Nhà cung cấp--------------
 GO
CREATE PROC NhaCungCap_DS
AS
BEGIN 
	SELECT * FROM dbo.NhaCungCap
END
---------Loại mặt hàng-----------
 GO
CREATE PROC LoaiMatHang_DS
AS
BEGIN 
	SELECT * FROM dbo.LoaiMatHang
END
--------Mặt hàng----------------
 GO
CREATE PROC MatHang_DS
AS
BEGIN 
	SELECT * FROM dbo.MatHang
END
-------Hóa đơn nhập------------
 GO
CREATE PROC HoaDonNhap_DS
AS
BEGIN 
	SELECT * FROM dbo.HoaDonNhap
END
--------Hóa đơn bán-------------
 GO
CREATE PROC HoaDonBan_DS
AS
BEGIN 
	SELECT * FROM dbo.HoaDonBan
END
--------Chi tiết HD bán---------
 GO
CREATE PROC ChiTietHoaDonBan_DS
AS
BEGIN 
	SELECT * FROM dbo.CTHDB
END
------- Chi tiết HD Nhập---------
 GO
CREATE PROC ChiTietHoaDonNhap_DS
AS
BEGIN 
	SELECT * FROM dbo.CTHDN
END
--------- **XÓA MỘT BẢNG GHI TRONG BẢNG DỮ LIỆU TƯƠNG ỨNG-------
-----c1----------
GO
CREATE PROC LoaiMatHang_Xoa
@MaLoaiMH VARCHAR(20)
AS
BEGIN 
	DELETE FROM LoaiMatHang WHERE MaLoaiMH = @MaLoaiMH
END
-----c2------
GO
CREATE PROC BoPhan_Xoa
@MaBP NCHAR(2)
AS
BEGIN
	DELETE FROM dbo.BoPhan WHERE MaBP=@MaBP
END
---------c3--------
GO 
CREATE PROC NhanVien_Xoa
@MaNV VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.NhanVien WHERE MaNV=@MaNV
END
-----c4-----
GO 
CREATE PROC KhachHang_Xoa
@MaKH VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.KhachHang WHERE MaKH=@MaKH
END
----c5-----
GO 
CREATE PROC MatHang_Xoa
@MaMH VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.MatHang WHERE MaMH=@MaMH
END
----c6---------
GO 
CREATE PROC NhaCungCap_Xoa
@MaNCC VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.NhaCungCap WHERE MaNCC=@MaNCC
END
----c7----
GO 
CREATE PROC HoaDonBan_Xoa
@SoHDB NCHAR(10)
AS
BEGIN
	DELETE FROM dbo.HoaDonBan WHERE SoHDB=@SoHDB
END
----c8--------
GO 
CREATE PROC HoaDonNhap_Xoa
@SoHDN NCHAR(10)
AS
BEGIN
	DELETE FROM dbo.HoaDonNhap WHERE SoHDN=@SoHDN
END
-----c9--------
GO 
CREATE PROC CTHDB_Xoa
@SoHDB NCHAR(10),
@MaMH VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.CTHDB WHERE SoHDB=@SoHDB AND MaMH=@MaMH
END
----c10-------
GO 
CREATE PROC CTHDN_Xoa
@SoHDN NCHAR(10),
@MaMH VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.CTHDB WHERE SoHDB=@SoHDN AND MaMH=@MaMH
END
------------THÊM MỘT BẢN GHI--------
---d1---
-- MẶT HÀNG---
GO
CREATE PROC LoaiMatHang_Them
@MaLoaiMH	VARCHAR(20),
@TenLoaiMH	NVARCHAR(40)
AS
BEGIN 
	INSERT INTO dbo.LoaiMatHang VALUES(@MaLoaiMH,@TenLoaiMH)
END
 ---KHÁCH HÀNG---
GO
CREATE PROC KhachHang_Them
@MaKH VARCHAR(10),
@TenKH NVARCHAR(40),
@DiaChi NVARCHAR(50),
@DienThoai NCHAR(11),
@GhiChu NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.KhachHang VALUES(@MaKH,@TenKH,@DiaChi,@DienThoai,@GhiChu)
END
---NHÀ CUNG CẤP
GO
CREATE PROC NhaCungCap_Them
@MaNCC VARCHAR(10),
@TenNCC NVARCHAR(50),
@DiaChi NVARCHAR(50),
@DienThoai NCHAR(11),
@GhiChu NVARCHAR(50)
AS
BEGIN 
	INSERT INTO dbo.NhaCungCap VALUES(@MaNCC,@TenNCC,@DiaChi,@DienThoai,@GhiChu)
END
----d2---THÊM MẶT HÀNG
GO
CREATE PROC MatHang_Them
@MaMH VARCHAR(10),
@TenMH NVARCHAR(40),
@DVT NVARCHAR(10) ,
@DonGiaNhap MONEY ,
@DonGiaBan MONEY ,
@SoLuongTon TINYINT ,
@MaLoaiMH VARCHAR(20) 
AS
BEGIN
	DECLARE @OKE INT
	IF NOT EXISTS (SELECT 1 FROM MatHang WHERE MaMH = @MaMH)
			AND EXISTS (SELECT 1 FROM LoaiMatHang WHERE MaLoaiMH = @MaLoaiMH)
		BEGIN
			SET @OKE = 1
			INSERT INTO dbo.MatHang VALUES(@MaMH,@TenMH,@DVT,@DonGiaNhap,@DonGiaBan,@SoLuongTon,@MaLoaiMH)
		END
	ELSE
		BEGIN 
			SET @OKE = 0
		END
	RETURN @OKE
END
----d3--THÊM NHÂN VIÊN
GO
CREATE PROC NhanVien_Them
@MaNV VARCHAR(10) ,
@HoNV NVARCHAR(10) ,
@TenNV NVARCHAR(10) ,
@GioiTinh BIT  ,
@NgaySinh DATETIME ,
@DiaChi NVARCHAR(50) ,
@Luong TINYINT ,
@MaBP NCHAR(2)
AS
BEGIN
	DECLARE @OKE INT
	IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @MaNV) 
			AND EXISTS (SELECT 1 FROM BoPhan WHERE MaBP = @MaBP)
		BEGIN
			SET @OKE = 1
			INSERT INTO NhanVien VALUES(@MaNV,@HoNV,@TenNV,@GioiTinh,@NgaySinh,@DiaChi,@Luong,@MaBP)
		END
	ELSE
		BEGIN
			SET @OKE = 0
		END
	RETURN @OKE
END
---d4--- THÊM BỘ PHẬN
GO
CREATE PROC BoPhan_Them
@TenBP NVARCHAR(30)
AS
BEGIN 
	IF NOT EXISTS (SELECT 1 FROM BoPhan WHERE TenBP = @TenBP)
	BEGIN
		DECLARE @SS VARCHAR(2)
		IF (SELECT COUNT(MaBP) FROM BoPhan) = 0
			SET @SS = '00'
		ELSE
			SELECT @SS = MAX(RIGHT(MaBP,2)) FROM BoPhan
			SELECT @SS = CASE
					WHEN @SS >= 0 AND @SS < 9 THEN 'BP0' + CONVERT(CHAR,CONVERT(INT,@SS) + 1)
					WHEN @SS >= 9 THEN 'BP' + CONVERT(CHAR,CONVERT(INT,@SS)+1)
						 END
		INSERT INTO BoPhan VALUES(@SS,@TenBP)
	END
END
--d7-- THÊM CHI TIẾT HÓA ĐƠN BÁN
GO
CREATE PROC CTHDB_Them
@SoHDB NCHAR(10),
@MaMH VARCHAR(10),
@SoLuongBan TINYINT,
@DonGiaBan MONEY
AS 
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.HoaDonBan WHERE SoHDB=@SoHDB)
		AND EXISTS (SELECT 1 FROM dbo.MatHang WHERE MaMH=@MaMH)
	BEGIN
			INSERT dbo.CTHDB VALUES(@SoHDB,@MaMH,@SoLuongBan,@DonGiaBan)
	END
END       
---d8--- THÊM CHI TIẾT HD NHẬP
GO
CREATE PROC CTHDN_Them
@SoHDN NCHAR(10),
@MaMH VARCHAR(10),
@SoLuongNhap TINYINT,
@DonGiaNhap MONEY
AS
BEGIN 
	IF EXISTS (SELECT 1 FROM dbo.HoaDonNhap WHERE SoHDN=@SoHDN)
		AND EXISTS (SELECT 1 FROM dbo.MatHang WHERE MaMH=@MaMH)
	BEGIN
		INSERT dbo.CTHDN VALUES (@SoHDN,@MaMH,@SoLuongNhap,@DonGiaNhap)
	END
END        