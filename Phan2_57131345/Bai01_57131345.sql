GO
CREATE DATABASE QUANLYXE_57131345
GO 
USE QUANLYXE_57131345
GO 
CREATE TABLE LoaiXe(
MaLoai VARCHAR(10) PRIMARY KEY NOT NULL,
TenLoai NVARCHAR(20) NOT NULL,
DonGiaTheoNgay MONEY NOT NULL)
GO 
INSERT dbo.LoaiXe
        ( MaLoai, TenLoai, DonGiaTheoNgay )
VALUES  ( 'M1', N'Yamaha',15.00),
		( 'M2', N'Suzuki',17.00),
		( 'M3',N'Wave',18.00),
		( 'M4',N'Vision', 19.00),
		( 'M5', N'SH',20.05)
---------//xe----------
GO 
CREATE TABLE Xe(
SoXe VARCHAR(10) PRIMARY KEY NOT NULL,
TinhTrang BIT DEFAULT(1) NOT NULL,
MaLoai VARCHAR(10) NOT NULL,
CONSTRAINT fk_ml FOREIGN KEY(MaLoai) REFERENCES dbo.LoaiXe(MaLoai)
)

GO 
INSERT dbo.Xe
        ( SoXe, TinhTrang, MaLoai )
VALUES  ( 'N791',0,'M1'),
		( 'N792',1,'M2' ),
		( 'N793', 0,'M3'),
		( 'N794',1,'M4'),
		( 'N795',0,'M5')
----- Khách hàng-------------
GO 
CREATE TABLE KhachHang(
MaKhach VARCHAR(10) PRIMARY KEY NOT NULL,
HoTenKhach NVARCHAR(50) NOT NULL,
DiaChi NVARCHAR(50) NOT NULL,
DienThoai INT NOT NULL
)
GO 
INSERT dbo.KhachHang
        ( MaKhach,HoTenKhach,DiaChi ,DienThoai)
VALUES  ( 'KH1' , N'Lê Mai' , N'123 Xương Huân Nha Trang' ,0123445667),
		( 'KH2' , N'Lê Đào' ,N'14/345 Trần Phú Ninh Hòa' ,134689),
		( 'KH3' , N'Lê Mận' ,N'123-455 Lê Thánh Tôn Đak Lăk' ,3457889),
		( 'KH4' ,N'Lê Lựu' ,N'12-Bạch Đằng Cam Ranh' ,4657660),
		( 'KH5' , N'Lê Na' ,N'78 Đinh Tiên Hoàng-Quận 9' ,034579009)

		-----Nhật ký thuê----------
GO 
CREATE TABLE NhatKyThue(
SoXe VARCHAR(10) NOT NULL,
MaKhach VARCHAR(10) NOT NULL,
TuNgay DATETIME NOT NULL,
DenNgay DATETIME NOT NULL,
PRIMARY KEY(SoXe,MaKhach),
CONSTRAINT xe_nkthue FOREIGN KEY(SoXe) REFERENCES dbo.Xe(SoXe),
CONSTRAINT kh_nht FOREIGN KEY(MaKhach) REFERENCES dbo.KhachHang(MaKhach)
)

GO 
INSERT dbo.NhatKyThue
        ( SoXe, MaKhach, TuNgay, DenNgay )
VALUES  ( 'N791', 'KH1','02/03/2017','03/05/2017'),
		( 'N792','KH2','01/04/2017','01/08/2017'),
		( 'N793','KH3','09/02/2017','10/03/2017'),
		( 'N794','KH4','05/03/2017','05/09/2017'),
		( 'N795','KH5','08/03/2017','09/02/2017')