CREATE DATABASE DKMH
USE DKMH
CREATE TABLE MonHoc(
MaMH VARCHAR(10) PRIMARY KEY NOT NULL,
TenMH NVARCHAR(10) NOT NULL,
SoTC INT CHECK(SoTC>0) NOT NULL
)
INSERT dbo.MonHoc
        ( MaMH, TenMH, SoTC )
VALUES  ( 'LTW1',N'Lập trình web', 3)
INSERT dbo.MonHoc
        ( MaMH, TenMH, SoTC )
VALUES  ( 'T1', N'Toán',2)
INSERT dbo.MonHoc
        ( MaMH, TenMH, SoTC )
VALUES  ( 'PTTK1',  N'Phân tích thiết kế', 3)
INSERT dbo.MonHoc
        ( MaMH, TenMH, SoTC )
VALUES  ( 'MMT1',N'Mạng máy tính',2)
INSERT dbo.MonHoc
        ( MaMH, TenMH, SoTC )
VALUES  ( 'HDH1',N'Hệ điều hành',3)
-----Lớp--------------
CREATE TABLE Lop(
MaLop VARCHAR(10) PRIMARY KEY NOT NULL,
TenLop NVARCHAR(40) NOT NULL,
NganhHoc NVARCHAR(40) NOT NULL
)
INSERT dbo.Lop
        ( MaLop, TenLop, NganhHoc )
VALUES  ( '57cntt1',N'57 Công nghệ thông tin 1',N'Công nghệ thông tin'),
		( '57cntt2',N'57 Công nghệ thông tin 2',N'Công nghệ thông tin'),
		( '58cntt1',N'58 Công nghệ thông tin 1',N'Công nghệ thông tin'),
		( '59cntt1',N'59 Công nghệ thông tin 1',N'Công nghệ thông tin'),
		( '57c.cntt',N'57 Cao đẳng  Công nghệ thông tin ',N'Công nghệ thông tin')
---Sinh Viên-------------
CREATE TABLE SinhVien(
MaSV VARCHAR(10) PRIMARY KEY NOT NULL,
HoSV NVARCHAR(10)  NOT NULL,
TenSV NVARCHAR(10) NOT NULL,
NgaySinh DATETIME NOT NULL,
GioiTinh BIT DEFAULT(1) NOT NULL,
MaLop VARCHAR(10) NOT NULL FOREIGN KEY REFERENCES dbo.Lop(MaLop)
)
INSERT dbo.SinhVien
        ( MaSV, HoSV ,TenSV ,NgaySinh ,GioiTinh ,MaLop)
VALUES  ( '57134567' , N'Lê' ,N'Lâm' ,'02/03/1997',1,'57cntt1' ),
        ( '57135788' , N'Huỳnh' ,N'Lập' ,'04/07/1997',1,'57cntt2' ),
		( '57132211' , N'Hàng' ,N'Lê' ,'01/02/1997',0,'58cntt1' ),
		( '57132456' , N'Hoàng' ,N'Lập' ,'05/06/1997',1,'59cntt1' ),
		( '57132568' , N'Lưu' ,N'Luân' ,'01/05/1997',1,'57c.cntt' )
---------DKMH-------
CREATE TABLE DKMH(
MaSV VARCHAR(10) NOT NULL,
MaMH VARCHAR(10) NOT NULL,
NgayDK DATETIME NOT NULL
CONSTRAINT KhoaChinh PRIMARY KEY (MaSV,MaMH),
CONSTRAINT dkmh_sv FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV),
CONSTRAINT dkmh_mh FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMH)
)
INSERT dbo.DKMH
        ( MaSV, MaMH, NgayDK )
VALUES  ( '57134567','LTW1','03/08/2018'),
( '57135788','LTW1','03/08/2018'),
( '57132211','LTW1','03/08/2018'),
( '57132456','T1','03/08/2018'),
( '57132568','PTTK1','03/08/2018')