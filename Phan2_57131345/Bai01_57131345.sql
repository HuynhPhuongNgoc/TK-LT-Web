CREATE DATABASE QUANLYXE_57131345
USE QUANLYXE_57131345
CREATE TABLE LoaiXe(
MaLoai VARCHAR(10) NOT NULL,
TenLoai NVARCHAR(20) NOT NULL,
DonGiaTheoNgay MONEY NOT NULL)
INSERT dbo.LoaiXe
        ( MaLoai, TenLoai, DonGiaTheoNgay )
VALUES  ( 'M1', N'Yamaha',15.00)
INSERT dbo.LoaiXe
        ( MaLoai, TenLoai, DonGiaTheoNgay )
VALUES  ( 'M2', N'Suzuki',17.00)
INSERT dbo.LoaiXe
        ( MaLoai, TenLoai, DonGiaTheoNgay )
VALUES  ( 'M3',N'Wave',18.00)
INSERT dbo.LoaiXe
        ( MaLoai, TenLoai, DonGiaTheoNgay )
VALUES  ( 'M4',N'Vision', 19.00)
INSERT dbo.LoaiXe
        ( MaLoai, TenLoai, DonGiaTheoNgay )
VALUES  ( 'M5', N'SH',20.05)
---------//xe----------
CREATE TABLE Xe(
SoXe VARCHAR(10) PRIMARY KEY NOT NULL,
TinhTrang BIT DEFAULT(1) NOT NULL,
MaLoai VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.LoaiXe(MaLoai)
)
ALTER TABLE dbo.Xe ADD CONSTRAINT fk_ml FOREIGN KEY(MaLoai) REFERENCES dbo.LoaiXe(MaLoai)
INSERT dbo.Xe
        ( SoXe, TinhTrang, MaLoai )
VALUES  ( 'N791',0,'M1')
INSERT dbo.Xe
        ( SoXe, TinhTrang, MaLoai )
VALUES  ( 'N792',1,'M2' )
INSERT dbo.Xe
        ( SoXe, TinhTrang, MaLoai )
VALUES  ( 'N793', 0,'M3')
INSERT  dbo.Xe
        ( SoXe, TinhTrang, MaLoai )
VALUES  ( 'N794',1,'M4')
INSERT dbo.Xe
        ( SoXe, TinhTrang, MaLoai )
VALUES  ( 'N795',0,'M5')
----- Khách hàng-------------
CREATE TABLE KhachHang(
MaKhach VARCHAR(10) PRIMARY KEY NOT NULL,
HoTenKhach NVARCHAR(50) NOT NULL,
DiaChi NVARCHAR(50) NOT NULL,
DienThoai INT NOT NULL
)
INSERT dbo.KhachHang
        ( MaKhach,HoTenKhach,DiaChi ,DienThoai)
VALUES  ( 'KH1' , N'Lê Mai' , N'123 Xương Huân Nha Trang' ,0123445667)
INSERT dbo.KhachHang
        ( MaKhach,HoTenKhach,DiaChi,DienThoai)
VALUES  ( 'KH2' , N'Lê Đào' ,N'14/345 Trần Phú Ninh Hòa' ,134689)
INSERT dbo.KhachHang
        ( MaKhach ,HoTenKhach ,DiaChi ,DienThoai)
VALUES  ( 'KH3' , N'Lê Mận' ,N'123-455 Lê Thánh Tôn Đak Lăk' ,3457889)
INSERT dbo.KhachHang
        ( MaKhach ,HoTenKhach ,DiaChi ,DienThoai)
VALUES  ( 'KH4' ,N'Lê Lựu' ,N'12-Bạch Đằng Cam Ranh' ,4657660)
INSERT dbo.KhachHang
        ( MaKhach ,HoTenKhach ,DiaChi ,DienThoai)
VALUES  ( 'KH5' , N'Lê Na' ,N'78 Đinh Tiên Hoàng-Quận 9' ,034579009)
		-----Nhật ký thuê----------
CREATE TABLE NhatKyThue(
SoXe VARCHAR(10) NOT NULL,
MaKhach VARCHAR(10) NOT NULL,
TuNgay DATETIME NOT NULL,
DenNgay DATETIME NOT NULL,
PRIMARY KEY(SoXe,MaKhach),
CONSTRAINT xe_nkthue FOREIGN KEY(SoXe) REFERENCES dbo.Xe(SoXe),
CONSTRAINT kh_nht FOREIGN KEY(MaKhach) REFERENCES dbo.KhachHang(MaKhach)
)
ALTER TABLE dbo.LoaiXe ADD PRIMARY KEY(MaLoai)
INSERT dbo.NhatKyThue
        ( SoXe, MaKhach, TuNgay, DenNgay )
VALUES  ( 'N791', 'KH1','02/03/2017','03/05/2017')
INSERT dbo.NhatKyThue
        ( SoXe, MaKhach, TuNgay, DenNgay )
VALUES  ( 'N792','KH2','01/04/2017','01/08/2017')
INSERT dbo.NhatKyThue
        ( SoXe, MaKhach, TuNgay, DenNgay )
VALUES  ( 'N793','KH3','09/02/2017','10/03/2017')
INSERT dbo.NhatKyThue
        ( SoXe, MaKhach, TuNgay, DenNgay )
VALUES  ( 'N794','KH4','05/03/2017','05/09/2017')
INSERT dbo.NhatKyThue
        ( SoXe, MaKhach, TuNgay, DenNgay )
VALUES  ( 'N795','KH5','08/03/2017','09/02/2017')