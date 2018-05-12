GO 
CREATE DATABASE Bai2_57131345
GO 
USE Bai2_57131345
GO 
CREATE TABLE LoaiSach
(
MaLS VARCHAR(5) PRIMARY KEY NOT NULL,
TenLS NVARCHAR(50) NOT NULL
)
GO 
CREATE TABLE Sach
(
MaSach VARCHAR(10) PRIMARY KEY NOT NULL,
TenSach NVARCHAR(50) NOT NULL,
AnhSach VARCHAR(50) NOT NULL,
TacGia NVARCHAR(50) ,
NhaXB NVARCHAR(50) ,
MaLS VARCHAR(5) NOT NULL,
CONSTRAINT S_LS FOREIGN KEY(MaLS) REFERENCES dbo.LoaiSach(MaLS)
)
GO 
---tu cho insert la chua chay
INSERT dbo.LoaiSach( MaLS, TenLS )
VALUES  ( 'NN',N'Ngoại ngữ')
GO	
INSERT dbo.LoaiSach( MaLS, TenLS )
VALUES  ( 'TH',N'Tin học')
GO 
INSERT dbo.LoaiSach( MaLS, TenLS )
VALUES  ( 'CS',N'Cơ sở')
---
GO 
INSERT dbo.Sach( MaSach ,TenSach ,AnhSach ,TacGia ,NhaXB ,MaLS)
VALUES  ( 'NN0001' ,N'Gramma In Use' ,'NN0001.gif' ,N'' , N'' ,'NN')
GO 
INSERT dbo.Sach( MaSach ,TenSach ,AnhSach ,TacGia ,NhaXB ,MaLS)
VALUES  ( 'TH0001' ,N'Ngôn ngữ lập trình Pascal' ,'TH0001.gif' ,N'Quách Tuấn Ngọc ' , N'Nhà xuất bản Khoa học Kỹ thuật' ,'TH')
GO 
INSERT dbo.Sach( MaSach ,TenSach ,AnhSach ,TacGia ,NhaXB ,MaLS)
VALUES  ( 'TH0002' ,N'Bài giảng Hệ quản trị Cơ sở dữ liệu' ,'TH0002.gif' ,N'Chu THị Hường' , N'' ,'TH')
---- 
GO
CREATE PROC Sach_DS
AS
BEGIN
	SELECT*FROM dbo.Sach
END 
--------
GO
CREATE PROC Sach_Them
@MaSach VARCHAR(10) ,
@TenSach NVARCHAR(50) ,
@AnhSach VARCHAR(50) ,
@TacGia NVARCHAR(50) ,
@NhaXB NVARCHAR(50) ,
@MaLS VARCHAR(5) 
AS
BEGIN 
	INSERT INTO dbo.Sach VALUES(@MaSach,@TenSach,@AnhSach,@TacGia,@NhaXB,@MaLS)
END
-----------
GO
CREATE PROC Sach_Xoa
@Masach VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.Sach WHERE MaSach=@Masach
END
---
GO
CREATE PROC Sach_Sưa
@MaSach VARCHAR(10) ,
@TenSach NVARCHAR(50) ,
@AnhSach VARCHAR(50) ,
@TacGia NVARCHAR(50) ,
@NhaXB NVARCHAR(50) ,
@MaLS VARCHAR(5) 
AS
BEGIN 
	UPDATE dbo.Sach SET TenSach=@TenSach,AnhSach=@AnhSach,TacGia=@TacGia,NhaXB=@NhaXB,MaLS=@MaLS
	WHERE MaSach=@MaSach
END 	 

GO 
CREATE PROC LoaiSach_DS
AS
BEGIN 
	SELECT * FROM dbo.LoaiSach
END     