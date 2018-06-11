GO 
CREATE DATABASE QuanLyDoanVien
GO 
USE QuanLyDoanVien
GO
CREATE TABLE ChiDoan(
MaChiDoan VARCHAR(10) PRIMARY KEY NOT NULL,
TenChiDoan NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE TinTuc(
MaTinTuc VARCHAR(10) PRIMARY KEY NOT NULL,
TenTinTuc NVARCHAR(100) NOT NULL,
NoiDungTT NVARCHAR(MAX) NOT NULL,
ThoiGianDang DATETIME NOT NULL,
NguoiDang NVARCHAR(50) NOT NULL
)
GO 
CREATE TABLE DoanVienTN(
MaDV VARCHAR(10) PRIMARY KEY NOT NULL,
HoTenDV NVARCHAR(100) NOT NULL,
NgaySinh DATE NOT NULL,
GioiTinh NVARCHAR(10) NOT NULL,
QueQuan NVARCHAR(100) NOT NULL,
Email NVARCHAR(50) NOT NULL,
SDT VARCHAR(15)NOT NULL,
DanToc NVARCHAR(50)NOT NULL,
TonGiao NVARCHAR(50) NOT NULL,
NgayVaoDoan DATE NOT NULL,
ChooHienNay NVARCHAR(100) NOT NULL,
HinhAnh NVARCHAR(200) NOT NULL,
MaChiDoan VARCHAR(10) NOT NULL,
CONSTRAINT dv_cd FOREIGN KEY(MaChiDoan) REFERENCES dbo.ChiDoan(MaChiDoan)
)
GO
CREATE TABLE HoatDongPT(
MaHDPT VARCHAR(10) PRIMARY KEY NOT NULL,
NgayBatDau DATE NOT NULL,
NgayKetThuc DATE NOT NULL,
NoiDungHD NVARCHAR(100) NOT NULL,
DiaDiem NVARCHAR(100) NOT NULL,
MaDV VARCHAR(10) NOT NULL,
CONSTRAINT ht_dv FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV)
)
GO 
CREATE TABLE DoanPhi(
MaDoanPhi VARCHAR(10) PRIMARY KEY NOT NULL,
Ngay DATE NOT NULL,
SoTien DECIMAL(15,0) NOT NULL,
NoiDungDP NVARCHAR(100) NOT NULL,
MaDV VARCHAR(10) NOT NULL,
CONSTRAINT dp_dv FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV)
)
GO
CREATE TABLE KyLuat(
MaKyLuat VARCHAR(10) PRIMARY KEY NOT NULL,
NgayKyLuat DATE NOT NULL,
NoiDungKL NVARCHAR(200) NOT NULL,
MaDV VARCHAR(10) NOT NULL,
CONSTRAINT kl_dv FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV)
)
GO
CREATE TABLE KhenThuong(
MaKhenThuong VARCHAR(10) PRIMARY KEY NOT NULL,
NgayKhenThuong DATE NOT NULL,
NoiDungKT NVARCHAR(200) NOT NULL,
MaDV VARCHAR(10) NOT NULL,
CONSTRAINT kt_dv FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV)
)
GO
CREATE TABLE ChucVu(
MaChucVu VARCHAR(10) PRIMARY KEY NOT NULL,
TenChucVu NVARCHAR(50) NOT NULL,
NgayNhamChuc DATE NOT NULL,
NgayHetNhiemKy DATE NOT NULL,
MaDV VARCHAR(10) NOT NULL,
CONSTRAINT cv_dv FOREIGN KEY(MaDV) REFERENCES dbo.DoanVienTN(MaDV)
)
GO 
INSERT dbo.ChiDoan
        ( MaChiDoan, TenChiDoan )
VALUES  ( '7TH1',N'57 Tin học 1'),
		( '8TTQL',N'58 Thông tin quản lý'),
		( '6HTTT',N'56 Hệ thống thông tin')
GO 
INSERT dbo.TinTuc
        ( MaTinTuc ,TenTinTuc ,NoiDungTT ,ThoiGianDang ,NguoiDang)
VALUES  ( 'TT01' ,N'Thanh niên học cảm tình Đoàn' ,N'Hơn 100 sinh viên của Khoa CNTT tham dự lớp cảm tình đoàn vào 3 ngày 24,25,26 tháng 3' ,'03/26/2018' ,N'Trần Văn A'),
		( 'TT02' ,N'Đoàn trường kiểm tra Đoàn khoa CNTT' ,N'Vào 9h sáng ngày 03/03/2018, Ban thường vụ Đoàn trường đã đến kiểm tra Đoàn khoa CNTT tại VP Đoàn khoa. ' ,'03/04/2018' ,N'Lê Thị B'),
		( 'TT03' ,N'Đoàn viên dọn vệ sinh giảng đường G6' ,N'Ngày 01/04 Hơn 50 Đoàn viên tham gia dọn vệ sinh giảng đường G6' ,'04/01/2018' ,N'Nguyễn C')
GO 
INSERT dbo.DoanVienTN
        ( MaDV ,HoTenDV ,NgaySinh ,GioiTinh ,QueQuan ,Email ,SDT ,DanToc ,TonGiao ,NgayVaoDoan ,ChooHienNay ,HinhAnh ,MaChiDoan)
VALUES  ( 'DV01' ,N'Nguyễn Minh Triết' ,'09/08/1997' , N'Nam' ,N'Nha Trang' ,N'triet@gmail.com' ,'0123456789' ,N'Kinh' , N'Không' ,'03/26/2015' ,N'Nha Trang' ,N'A1' ,'7TH1'),
		( 'DV02' ,N'Lê Thị Đào' ,'05/07/1996' , N'Nữ' ,N'Cam Ranh' , N'dao@gmail.com' ,'0987654321' ,N'Khơ me đỏ' , N'Phật giáo' ,'03/26/2014' ,N'Nha Trang' ,N'A2' ,'6HTTT'),
		( 'DV03' ,N'Đào Bá Lộc' ,'04/06/1995' , N'Nam' ,N'Vạn Ninh' ,N'loc@gmail.com' ,'015314316' ,N'Thái' , N'Thiên Chúa giáo' ,'05/19/2015' ,N'Nha Trang' ,N'A3' ,'8TTQL'),
		( 'DV04' ,N'Hiền Thục' ,'04/08/1998' , N'Nữ' ,N'Vạn Ninh' ,N'thuc@gmail.com' ,'01234756' ,N'Kinh' , N'Thiên Chúa giáo' ,'05/19/2015' ,N'Nha Trang' ,N'A4' ,'6HTTT'),
		( 'DV05' ,N'Đàm Vĩnh ' ,'09/06/1997' , N'Nam' ,N'Ninh Hòa' ,N'vinh@gmail.com' ,'0397452' ,N'Kinh' , N'Không' ,'05/19/2015' ,N'Nha Trang' ,N'A5' ,'8TTQL')
GO
INSERT dbo.HoatDongPT
        ( MaHDPT ,NgayBatDau ,NgayKetThuc ,NoiDungHD ,DiaDiem ,MaDV)
VALUES  ( 'HD01' ,'03/05/2018' ,'03/09/2018',N'Tham dự múa hát tập thể' ,N'Sân chào cờ' ,'DV01'),
		( 'HD02' ,'03/09/2018' ,'09/10/2018',N'Tham dự RCV' ,N'Sân chào cờ' ,'DV02'),
		( 'HD03' ,'03/01/2018' ,'03/01/2018',N'Tham dự văn nghệ' ,N'Hội trường 3' ,'DV03')
GO
INSERT dbo.DoanPhi
        ( MaDoanPhi ,Ngay ,SoTien ,NoiDungDP ,MaDV)
VALUES  ( 'DP01' ,'03/03/2018' ,'2360000' ,N'Nộp đoàn phí tháng 3' ,'DV01'),
		( 'DP02' ,'04/03/2018' ,'2160000' ,N'Nộp đoàn phí tháng 4' ,'DV02'),
		( 'DP03' ,'05/03/2018' ,'2260000' ,N'Nộp đoàn phí tháng 5' ,'DV03')
GO
INSERT dbo.KyLuat
        ( MaKyLuat ,NgayKyLuat ,NoiDungKL ,MaDV)
VALUES  ( 'KL01' ,'05/06/2018' ,N'Không đóng đoàn phí' ,'DV04'),
		( 'KL02' ,'07/06/2018' ,N'Không sinh hoạt Đoàn' ,'DV05')
GO 
INSERT dbo.KhenThuong
        ( MaKhenThuong ,NgayKhenThuong ,NoiDungKT ,MaDV)
VALUES  ( 'KT01' ,'03/26/2018' ,N'Tích cực tham gia hoạt động Đoàn' ,'DV01'),
		( 'KT02' ,'03/26/2018' ,N'Hoàn thành xuất sắc nhiệm vụ' ,'DV02'),
		( 'KT03' ,'03/26/2018' ,N'Lãnh đạo tốt' ,'DV03')
GO
INSERT dbo.ChucVu
        ( MaChucVu ,TenChucVu ,NgayNhamChuc ,NgayHetNhiemKy ,MaDV)
VALUES  ( 'CV01' , N'Bí thư' ,'02/03/2016' ,'06/30/2018','DV01'),
		( 'CV02' , N'Phí bí thư' ,'01/05/2016' ,'06/11/2018','DV02'),
		( 'CV03' , N'Bí thư' ,'02/03/2016' ,'11/11/2018','DV03')
ALTER TABLE dbo.DoanVienTN DROP COLUMN HinhAnh
GO
CREATE PROC DoanVienTN_DS
AS
BEGIN
	SELECT * FROM dbo.DoanVienTN
END 
GO
CREATE PROC DoanVienTN_Them
@MaDV VARCHAR(10),
@HoTenDV NVARCHAR(100),
@NgaySinh DATE,
@GioiTinh NVARCHAR(10),
@QueQuan NVARCHAR(100),
@Email NVARCHAR(50),
@SDT VARCHAR(15),
@DanToc NVARCHAR(50),
@TonGiao NVARCHAR(50),
@NgayVaoDoan DATE,
@ChooHienNay NVARCHAR(100),

@MaChiDoan VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.DoanVienTN VALUES(@MaDV,@HoTenDV,@NgaySinh,@GioiTinh,@QueQuan,@Email,@SDT,@DanToc,@TonGiao,@NgayVaoDoan,@ChooHienNay,@MaChiDoan)
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
@HoTenDV NVARCHAR(100),
@NgaySinh DATE,
@GioiTinh NVARCHAR(10),
@QueQuan NVARCHAR(100),
@Email NVARCHAR(50),
@SDT VARCHAR(15),
@DanToc NVARCHAR(50),
@TonGiao NVARCHAR(50),
@NgayVaoDoan DATE,
@ChooHienNay NVARCHAR(100),

@MaChiDoan VARCHAR(10)   
AS
BEGIN
	UPDATE dbo.DoanVienTN SET HoTenDV=@HoTenDV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,QueQuan=@QueQuan,Email=@Email,SDT=@SDT,DanToc=@DanToc,TonGiao=@TonGiao,NgayVaoDoan=@NgayVaoDoan,ChooHienNay=@ChooHienNay
END
GO
CREATE PROC HoatDongPT_DS
AS
BEGIN
	SELECT MaHDPT, HoTenDV, NgayBatDau, NgayKetThuc ,NoiDungHD,DiaDiem FROM dbo.DoanVienTN JOIN dbo.HoatDongPT ON HoatDongPT.MaDV = DoanVienTN.MaDV
END
GO
CREATE PROC HoatDongPT_Them
@MaHDPT VARCHAR(10),
@HoTenDV NVARCHAR(50),
@NgayBatDau DATE,
@NgayKetThuc DATE,
@NoiDungHD NVARCHAR(100),
@DiaDiem NVARCHAR(100)
--@MaDV VARCHAR(10)
AS
BEGIN 
	INSERT INTO dbo.HoatDongPT VALUES(@MaHDPT,@HoTenDV,@NgayBatDau,@NgayKetThuc,@NoiDungHD,@DiaDiem )
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
--@HoTenDV NVARCHAR(50),
@NgayBatDau DATE,
@NgayKetThuc DATE,
@NoiDungHD NVARCHAR(100),
@DiaDiem NVARCHAR(100),
@MaDV VARCHAR(10)
AS
BEGIN 
	UPDATE dbo.HoatDongPT SET MaHDPT=@MaHDPT,NgayBatDau=@NgayBatDau,NgayKetThuc=@NgayKetThuc,NoiDungHD=@NoiDungHD,DiaDiem=@DiaDiem,MaDV=@MaDV
	WHERE MaHDPT=@MaHDPT
END 
GO
CREATE PROC DoanPhi_DS
AS
BEGIN 
	SELECT* FROM dbo.DoanPhi
END
GO
CREATE PROC DoanPhi_Them
@MaDoanPhi VARCHAR(10),
@Ngay DATE,
@SoTien DECIMAL(15,0),
@NoiDungDP NVARCHAR(100),
@MaDV VARCHAR(10)
AS
BEGIN 
	INSERT INTO dbo.DoanPhi VALUES(@MaDoanPhi,@Ngay,@SoTien,@NoiDungDP,@MaDV)
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
@MaDV VARCHAR(10)
AS
BEGIN
	UPDATE dbo.DoanPhi SET Ngay=@Ngay,SoTien=@SoTien,NoiDungDP=@NoiDungDP,MaDV=@MaDV
	WHERE MaDoanPhi=@MaDoanPhi
END
GO 
CREATE PROC KyLuat_DS
AS
BEGIN
	SELECT*FROM dbo.KyLuat
END 
GO 
CREATE PROC KyLuat_Them
@MaKyLuat VARCHAR(10),
@NgayKyLuat DATE,
@NoiDungKL NVARCHAR(200),
@MaDV VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.KyLuat VALUES(@MaKyLuat,@NgayKyLuat,@NoiDungKL,@MaDV)
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
@NgayKyLuat DATE,
@NoiDungKL NVARCHAR(200),
@MaDV VARCHAR(10)
AS
BEGIN
	UPDATE dbo.KyLuat SET NgayKyLuat=@NgayKyLuat,NoiDungKL=@NoiDungKL,MaDV=@MaDV
	WHERE MaKyLuat=@MaKyLuat
END 
GO
CREATE PROC KhenThuong_DS
AS
BEGIN
	SELECT* FROM dbo.KhenThuong
END
GO
CREATE PROC KhenThuong_Them
@MaKhenThuong VARCHAR(10),
@NgayKhenThuong DATE,
@NoiDungKT NVARCHAR(200),
@MaDV VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.KhenThuong VALUES(@MaKhenThuong,@NgayKhenThuong,@NoiDungKT,@MaDV)
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
@NgayKhenThuong DATE,
@NoiDungKT NVARCHAR(200),
@MaDV VARCHAR(10)
AS
BEGIN
	UPDATE dbo.KhenThuong SET NgayKhenThuong=@NgayKhenThuong, NoiDungKT=@NoiDungKT,MaDV=@MaDV
	WHERE MaKhenThuong=@MaKhenThuong
END
GO
CREATE PROC ChucVu_DS
AS
BEGIN
	SELECT*FROM dbo.ChucVu
END
GO
CREATE PROC ChucVu_Them
@MaChucVu VARCHAR(10),
@TenChucVu NVARCHAR(50),
@NgayNhamChuc DATE,
@NgayHetNhiemKy DATE,
@MaDV VARCHAR(10)
AS
BEGIN 
	INSERT INTO dbo.ChucVu VALUES(@MaChucVu,@TenChucVu,@NgayNhamChuc,@NgayHetNhiemKy,@MaDV)
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
@TenChucVu NVARCHAR(50),
@NgayNhamChuc DATE,
@NgayHetNhiemKy DATE,
@MaDV VARCHAR(10)
AS
BEGIN
	UPDATE dbo.ChucVu SET TenChucVu=@TenChucVu,NgayNhamChuc=@NgayNhamChuc,NgayHetNhiemKy=@NgayHetNhiemKy
	WHERE MaChucVu=@MaChucVu
END 