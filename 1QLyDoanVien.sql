GO 
CREATE DATABASE QuanLyDoanVien1
GO 
USE QuanLyDoanVien1
GO
CREATE TABLE ChiDoan(
MaChiDoan VARCHAR(10) PRIMARY KEY NOT NULL,
TenChiDoan NVARCHAR(50) NOT NULL
)
GO 
INSERT dbo.ChiDoan
        ( MaChiDoan, TenChiDoan )
VALUES  ( '7TH1',N'57 Tin học 1'),
		( '8TTQL',N'58 Thông tin quản lý'),
		( '6HTTT',N'56 Hệ thống thông tin')
GO 
CREATE TABLE DoanVienTN(
MaDV VARCHAR(10) PRIMARY KEY NOT NULL,
HoDV NVARCHAR (50) NOT NULL,
TenDV NVARCHAR(50) NOT NULL,
NgaySinh DATE NOT NULL,
GioiTinh BIT,
QueQuan NVARCHAR(100) NOT NULL,
Email VARCHAR(50) NOT NULL,
SDT VARCHAR(15)NOT NULL,
DanToc NVARCHAR(50)NOT NULL,
TonGiao NVARCHAR(50) NOT NULL,
NgayVaoDoan DATE NOT NULL,
ChooHienNay NVARCHAR(100) NOT NULL,
MaChiDoan VARCHAR(10) NOT NULL,
CONSTRAINT dv_cd FOREIGN KEY(MaChiDoan) REFERENCES dbo.ChiDoan(MaChiDoan)
)

		GO 
INSERT dbo.DoanVienTN
        ( MaDV ,HoDV,TenDV ,NgaySinh ,GioiTinh ,QueQuan ,Email ,SDT ,DanToc ,TonGiao ,NgayVaoDoan ,ChooHienNay  ,MaChiDoan)
VALUES  ( '57131121' ,N'Nguyễn Minh',N'Triết' ,'09/08/1997' , 1,N'Nha Trang-Khánh Hòa' ,N'triet@gmail.com' ,'0123456789' ,N'Kinh' , N'Không' ,'03/26/2015' ,N'Nha Trang-Khánh Hòa'  ,'7TH1'),
		( '56131122' ,N'Lê Thị' ,N'Đào' ,'05/07/1996' , 0 ,N'Cam Ranh-Khánh Hòa' , N'dao@gmail.com' ,'0987654321' ,N'Khơ me đỏ' , N'Phật giáo' ,'03/26/2014' ,N'Nha Trang-Khánh Hòa'  ,'6HTTT'),
		( '58131123' ,N'Đào Bá',N'Lộc' ,'04/06/1995' , 1 ,N'Vạn Ninh-Khánh Hòa' ,N'loc@gmail.com' ,'015314316' ,N'Thái' , N'Thiên Chúa giáo' ,'05/19/2015' ,N'Nha Trang-Khánh Hòa'  ,'8TTQL'),
		( '56131124' ,N'Nguyễn Hiền',N'Thục' ,'04/08/1998' , 0 ,N'Vạn Ninh-Khánh Hòa' ,N'thuc@gmail.com' ,'01234756' ,N'Kinh' , N'Thiên Chúa giáo' ,'05/19/2015' ,N'Nha Trang-Khánh Hòa'  ,'6HTTT'),
		( '58131125' ,N'Đàm Vĩnh' ,N'Hưng','09/06/1997' , 1 ,N'Ninh Hòa-Khánh Hòa' ,N'vinh@gmail.com' ,'0397452' ,N'Kinh' , N'Không' ,'05/19/2015' ,N'Nha Trang-Khánh Hòa'  ,'8TTQL')


GO
CREATE TABLE HoatDongPT(
MaHDPT VARCHAR(10) PRIMARY KEY NOT NULL,
NoiDungHD NVARCHAR(100) NOT NULL
)
GO
INSERT dbo.HoatDongPT
        ( MaHDPT ,NoiDungHD )
VALUES  ( 'HD01' ,N'Tham dự múa hát tập thể' ),
		( 'HD02' ,N'Tham dự RCV'),
		( 'HD03' ,N'Tham dự văn nghệ' )
GO 
CREATE TABLE ThamGiaHD(
MaDV VARCHAR(10) NOT NULL,
MaHDPT VARCHAR(10) NOT NULL,
NgayBatDau DATE NOT NULL,
NgayKetThuc DATE NOT NULL,
DiaDiem NVARCHAR(100) NOT NULL,
CONSTRAINT hd_dv PRIMARY KEY(MaDV,MaHDPT),
CONSTRAINT f1 FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV),
CONSTRAINT f2 FOREIGN KEY(MaHDPT) REFERENCES dbo.HoatDongPT(MaHDPT)

)
GO 
INSERT dbo.ThamGiaHD
        ( MaDV ,MaHDPT ,NgayBatDau ,NgayKetThuc ,DiaDiem)
VALUES  ( '57131121' ,'HD01' ,'03/05/2018' ,'03/09/2018' ,N'Sân chào cờ'),
		( '56131122' ,'HD02' ,'03/09/2018' ,'09/10/2018' ,N'Sân chào cờ'),
		( '58131123' ,'HD03' ,'03/01/2018' ,'03/01/2018' ,N'Hội trường 3')
GO
CREATE TABLE ChucVu(
MaChucVu VARCHAR(10) PRIMARY KEY NOT NULL,
TenChucVu NVARCHAR(50) NOT NULL,
)
GO
INSERT dbo.ChucVu
        ( MaChucVu ,TenChucVu  )
VALUES  ( 'BT01' , N'Bí thư' ),
		( 'PBT02' , N'Phó bí thư' ),
		( 'UV03' , N'Ủy viên' )
GO 
CREATE TABLE GiuCV(
MaDV VARCHAR(10) NOT NULL,
NgayNhamChuc DATE NOT NULL,
NgayHetNhiemKy DATE NOT NULL,
MaChucVu VARCHAR(10) NOT NULL,
CONSTRAINT cvpk PRIMARY KEY(MaDV,MaChucVu),
CONSTRAINT f3 FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV),
CONSTRAINT f4 FOREIGN KEY(MaChucVu) REFERENCES dbo.ChucVu(MaChucVu)
)
GO 
INSERT dbo.GiuCV
        ( MaDV ,NgayNhamChuc ,NgayHetNhiemKy ,MaChucVu)
VALUES  ( '56131124' ,'02/03/2016','06/30/2018','BT01'),
		( '58131125' ,'01/05/2016','06/11/2018','PBT02' ),
		( '58131123' , '02/03/2016','11/11/2018','UV03' )
GO 
CREATE TABLE DoanPhi(
MaDoanPhi VARCHAR(10) PRIMARY KEY NOT NULL,
Ngay DATE NOT NULL,
SoTien DECIMAL(15,0) NOT NULL,
NoiDungDP NVARCHAR(100) NOT NULL,
HoatDong BIT,
MaDV VARCHAR(10),
MaChucVu VARCHAR(10) NOT NULL,
CONSTRAINT dp_dv FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV),
CONSTRAINT dp_cv FOREIGN KEY(MaChucVu) REFERENCES dbo.ChucVu(MaChucVu)
)
GO
INSERT dbo.DoanPhi
        ( MaDoanPhi ,Ngay ,SoTien ,NoiDungDP ,HoatDong,MaDV,MaChucVu)
VALUES  ( 'DP01' ,'03/03/2018' ,2360000.0 ,N'Đoàn phí tháng 3' ,1,'57131121','BT01'),
		( 'DP02' ,'04/03/2018' ,2160000.0 ,N'Đoàn phí tháng 4' ,1,'56131122','UV03'),
		( 'DP03' ,'05/03/2018' ,2260000.0 ,N'Đoàn phí tháng 5' ,1,'58131123','PBT02'),
		( 'DP04' ,'03/10/2018' ,-750000.0 ,N'Công trình thanh niên' ,0,NULL,'BT01'),
		( 'DP05' ,'03/15/2018' ,-500000.0 ,N'Chuẩn bị 26/03' ,0,NULL,'PBT02')
GO
CREATE TABLE KyLuat(
MaKyLuat VARCHAR(10) PRIMARY KEY NOT NULL,
NoiDungKL NVARCHAR(200) NOT NULL
)
GO
INSERT dbo.KyLuat
        ( MaKyLuat ,NoiDungKL)
VALUES  ( 'KL01' ,N'Không đóng đoàn phí' ),
		( 'KL02' ,N'Không sinh hoạt Đoàn' )


GO 
CREATE TABLE BiKL(
MaDV VARCHAR(10) NOT NULL,
MaKyLuat VARCHAR(10) NOT NULL,
NgayKyLuat DATE NOT NULL,
CONSTRAINT kl_dv PRIMARY KEY(MaDV,MaKyLuat),
CONSTRAINT f5 FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV),
CONSTRAINT f6 FOREIGN KEY(MaKyLuat) REFERENCES dbo.KyLuat(MaKyLuat)
)
GO 
INSERT dbo.BiKL
        ( MaDV, MaKyLuat, NgayKyLuat )
VALUES  ( '57131121', 'KL01','05/06/2018'),
         ( '56131122','KL02','07/06/2018')
GO
CREATE TABLE KhenThuong(
MaKhenThuong VARCHAR(10) PRIMARY KEY NOT NULL,
NoiDungKT NVARCHAR(200) NOT NULL

)
GO 
INSERT dbo.KhenThuong
        ( MaKhenThuong ,NoiDungKT )
VALUES  ( 'KT01' ,N'Tích cực tham gia hoạt động Đoàn'),
		( 'KT02' ,N'Hoàn thành xuất sắc nhiệm vụ'),
		( 'KT03' ,N'Lãnh đạo tốt')
GO
CREATE TABLE DuocKT(
MaDV VARCHAR(10) NOT NULL,
MaKhenThuong VARCHAR(10) NOT NULL,
NgayKhenThuong DATE NOT NULL,
CONSTRAINT kt_dv PRIMARY KEY(MaDV,MaKhenThuong),
CONSTRAINT f7 FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV),
CONSTRAINT f8 FOREIGN KEY(MaKhenThuong) REFERENCES dbo.KhenThuong(MaKhenThuong)
)
GO 
INSERT dbo.DuocKT
        ( MaDV , MaKhenThuong ,NgayKhenThuong)
VALUES  ( '57131121' , 'KT01' ,'03/26/2018'),
		( '56131122' , 'KT02' ,'03/26/2018' ),
		( '58131123' ,'KT03' ,'03/26/2018')
GO
CREATE TABLE SuKien(
MaSuKien VARCHAR(10) PRIMARY KEY NOT NULL,
CongViec NVARCHAR(MAX) NOT NULL,
ThoiGianSK DATE NOT NULL,
SoLuong DECIMAL(15,0) NOT NULL,
MaChucVu VARCHAR(10) NOT NULL,
CONSTRAINT sk_cv FOREIGN KEY (MaChucVu) REFERENCES dbo.ChucVu(MaChucVu)
)
GO 
INSERT dbo.SuKien
        ( MaSuKien ,CongViec ,ThoiGianSK ,SoLuong,MaChucVu)
VALUES  ( 'SK01' ,N'Vận động đoàn viên tham gia ngày hội học tốt' ,'04/20/2018' ,20,'UV03'),
		( 'SK02' ,N'Vận động đoàn viên tham gia olympic Tin học' ,'06/17/2018' ,200,'BT01'),
		( 'SK03' ,N'Vận động đoàn viên tham gia hội thao toàn trường' ,'04/04/2018' ,50,'PBT02')

GO
CREATE TABLE DangNhap(
TaiKhoan VARCHAR(100),
MatKhau VARCHAR(100),
Quyen   VARCHAR(20)
)
GO
INSERT dbo.DangNhap
        ( TaiKhoan, MatKhau, Quyen )
VALUES  ( 'admin','admin','admin'),
    ( 'huynhphuongngoc','12345678','member')

----chidoan
GO
CREATE PROC ChiDoan_DS
AS
BEGIN
	SELECT * FROM dbo.ChiDoan
END
----
GO
CREATE PROC ChiDoan_Them
@MaChiDoan VARCHAR(10) ,
@TenChiDoan NVARCHAR(50)
AS
BEGIN 
INSERT INTO dbo.ChiDoan VALUES (@MaChiDoan,@TenChiDoan)
END
GO
CREATE PROC ChiDoan_Xoa
@MaChiDoan VARCHAR(10)
AS
BEGIN
DELETE FROM dbo.ChiDoan WHERE MaChiDoan=@MaChiDoan
END
GO 
CREATE PROC ChiDoan_Sua
@MaChiDoan VARCHAR(10) ,
@TenChiDoan NVARCHAR(50)
AS
BEGIN
UPDATE dbo.ChiDoan SET TenChiDoan=@TenChiDoan WHERE MaChiDoan=@MaChiDoan
END      
---doanvien
GO
CREATE PROC DoanVienTN_DS
AS
BEGIN
	SELECT MaDV,HoDV,TenDV,NgaySinh,
	(CASE WHEN GioiTinh=1 THEN N'Nam'
	 WHEN GioiTinh=0 THEN N'Nữ'
	 END) AS GioiTinh,QueQuan,Email,SDT,DanToc,TonGiao,NgayVaoDoan,ChooHienNay,MaChiDoan
	 FROM dbo.DoanVienTN
END 
GO
CREATE PROC DoanVienTN_Them
@MaDV VARCHAR(10),
@HoDV NVARCHAR(50),
@TenDV NVARCHAR(50),
@NgaySinh DATE,
@GioiTinh BIT,
@QueQuan NVARCHAR(100),
@Email VARCHAR(50),
@SDT VARCHAR(15),
@DanToc NVARCHAR(50),
@TonGiao NVARCHAR(50),
@NgayVaoDoan DATE,
@ChooHienNay NVARCHAR(100),

@MaChiDoan VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.DoanVienTN VALUES(@MaDV,@HoDV,@TenDV,@NgaySinh,@GioiTinh,@QueQuan,@Email,@SDT,@DanToc,@TonGiao,@NgayVaoDoan,@ChooHienNay,@MaChiDoan)
END 
GO
CREATE PROC DoanVienTN_Xoa
@MaDV VARCHAR(10)
AS
BEGIN 
	DELETE FROM dbo.DoanVienTN WHERE MaDV=@MaDV
END 
GO
CREATE PROC DoanVienTN_Sua
@MaDV VARCHAR(10),
@HoDV NVARCHAR(50),
@TenDV NVARCHAR(50),
@NgaySinh DATE,
@GioiTinh BIT,
@QueQuan NVARCHAR(100),
@Email VARCHAR(50),
@SDT VARCHAR(15),
@DanToc NVARCHAR(50),
@TonGiao NVARCHAR(50),
@NgayVaoDoan DATE,
@ChooHienNay NVARCHAR(100),
@MaChiDoan VARCHAR(10)   
AS
BEGIN
	UPDATE dbo.DoanVienTN SET HoDV=@HoDV,TenDV=@TenDV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,QueQuan=@QueQuan,Email=@Email,SDT=@SDT,DanToc=@DanToc,TonGiao=@TonGiao,NgayVaoDoan=@NgayVaoDoan,ChooHienNay=@ChooHienNay
	WHERE MaDV=@MaDV
END
---hdpt
GO
CREATE PROC HoatDongPT_DS
AS
BEGIN
	SELECT * FROM dbo.HoatDongPT
END
GO
CREATE PROC HoatDongPT_Them
@MaHDPT VARCHAR(10),
@NoiDungHD NVARCHAR(100)
AS
BEGIN 
	INSERT INTO dbo.HoatDongPT VALUES(@MaHDPT,@NoiDungHD )
END 
GO
CREATE PROC HoatDongPT_Xoa
@MaHDPT VARCHAR(10)
AS
BEGIN 
	DELETE FROM dbo.HoatDongPT WHERE MaHDPT=@MaHDPT
END 
GO
CREATE PROC HoatDongPT_Sua
@MaHDPT VARCHAR(10),
@NoiDungHD NVARCHAR(100)
AS
BEGIN 
	UPDATE dbo.HoatDongPT SET NoiDungHD=@NoiDungHD
	WHERE MaHDPT=@MaHDPT
END 
--chucvu
GO
CREATE PROC ChucVu_DS
AS
BEGIN
	SELECT*FROM dbo.ChucVu
END
GO
CREATE PROC ChucVu_Them
@MaChucVu VARCHAR(10),
@TenChucVu NVARCHAR(50)
AS
BEGIN 
	INSERT INTO dbo.ChucVu VALUES(@MaChucVu,@TenChucVu)
END
GO
CREATE PROC ChucVu_Xoa
@MaChucVu VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.ChucVu WHERE MaChucVu=@MaChucVu
END
GO
CREATE PROC ChucVu_Sua
@MaChucVu VARCHAR(10),
@TenChucVu NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.ChucVu SET TenChucVu=@TenChucVu
	WHERE MaChucVu=@MaChucVu
END 
--doanphi
GO
CREATE PROC DoanPhi_DS
AS
BEGIN 
	SELECT MaDoanPhi,Ngay,SoTien,NoiDungDP,(
	CASE WHEN HoatDong=1 THEN N'Thu'
	WHEN HoatDong=0 THEN N'Chi'
	END 
    ) AS HoatDong,MaDV,MaChucVu FROM dbo.DoanPhi
END
GO
CREATE PROC DoanPhi_Them
@MaDoanPhi VARCHAR(10),
@Ngay DATE,
@SoTien DECIMAL(15,0),
@NoiDungDP NVARCHAR(100),
@HoatDong BIT,
@MaDV VARCHAR(10),
@MaChucVu VARCHAR(10)
As
BEGIN 
	INSERT INTO dbo.DoanPhi VALUES(@MaDoanPhi,@Ngay,@SoTien,@NoiDungDP,@HoatDong,@MaDV,@MaChucVu)
END 
GO
CREATE PROC DoanPhi_Xoa
@MaDoanPhi VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.DoanPhi WHERE MaDoanPhi=@MaDoanPhi
END
GO
CREATE PROC DoanPhi_Sua
@MaDoanPhi VARCHAR(10),
@Ngay DATE,
@SoTien DECIMAL(15,0),
@NoiDungDP NVARCHAR(100),
@HoatDong BIT,
@MaDV VARCHAR(10),
@MaChucVu VARCHAR(10)
AS
BEGIN
	UPDATE dbo.DoanPhi SET Ngay=@Ngay,SoTien=@SoTien,NoiDungDP=@NoiDungDP,HoatDong=@HoatDong,MaDV=@MaDV,MaChucVu=@MaChucVu
	WHERE MaDoanPhi=@MaDoanPhi
END

---ky luat
GO 
CREATE PROC KyLuat_DS
AS
BEGIN
	SELECT*FROM dbo.KyLuat
END 
GO 
CREATE PROC KyLuat_Them
@MaKyLuat VARCHAR(10),
@NoiDungKL NVARCHAR(200)
AS
BEGIN
	INSERT INTO dbo.KyLuat VALUES(@MaKyLuat,@NoiDungKL)
END 
GO
CREATE PROC KyLuat_Xoa
@MaKyLuat VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.KyLuat WHERE MaKyLuat=@MaKyLuat
END 
GO
CREATE PROC KyLuat_Sua
@MaKyLuat VARCHAR(10),
@NoiDungKL NVARCHAR(200)
AS
BEGIN
	UPDATE dbo.KyLuat SET NoiDungKL=@NoiDungKL
	WHERE MaKyLuat=@MaKyLuat
END 
---khenthuong
GO
CREATE PROC KhenThuong_DS
AS
BEGIN
	SELECT* FROM dbo.KhenThuong
END
GO
CREATE PROC KhenThuong_Them
@MaKhenThuong VARCHAR(10),
@NoiDungKT NVARCHAR(200)
AS
BEGIN
	INSERT INTO dbo.KhenThuong VALUES(@MaKhenThuong,@NoiDungKT)
END 
GO
CREATE PROC KhenThuong_Xoa
@MaKhenThuong VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.KhenThuong WHERE MaKhenThuong=@MaKhenThuong
END
GO
CREATE PROC KhenThuong_Sua
@MaKhenThuong VARCHAR(10),
@NoiDungKT NVARCHAR(200)
AS
BEGIN
	UPDATE dbo.KhenThuong SET  NoiDungKT=@NoiDungKT
	WHERE MaKhenThuong=@MaKhenThuong
END
--sukien
GO
CREATE PROC SuKien_DS
AS 
	BEGIN
	SELECT*FROM dbo.SuKien
END
GO
CREATE PROC SuKien_Them
@MaSuKien VARCHAR(10),
@CongViec NVARCHAR(MAX),
@ThoiGianSK DATE,
@SoLuong DECIMAL(15,0),
@MaChucVu VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.SuKien VALUES(@MaSuKien,@CongViec,@ThoiGianSK,@SoLuong,@MaChucVu)
END
GO
CREATE PROC SuKien_Xoa
@MaSuKien VARCHAR(10) 
AS
BEGIN
DELETE FROM dbo.SuKien WHERE MaSuKien=@MaSuKien
END
GO
CREATE PROC SuKien_Sua
@MaSuKien VARCHAR(10),
@CongViec NVARCHAR(MAX),
@ThoiGianSK DATE,
@SoLuong DECIMAL(15,0),
@MaChucVu VARCHAR(10)
AS
BEGIN
	UPDATE dbo.SuKien SET CongViec=@CongViec,ThoiGianSK=@ThoiGianSK,SoLuong=@SoLuong,MaChucVu=@MaChucVu
	WHERE MaSuKien=@MaSuKien
END

