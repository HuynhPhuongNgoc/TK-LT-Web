GO 
CREATE DATABASE Bai3_57131345
GO 
USE Bai3_57131345
GO 
CREATE TABLE LoaiDT
(
MaLDT VARCHAR(5) PRIMARY KEY NOT NULL,
TenLDT NVARCHAR(50) NOT NULL
)
GO 
CREATE TABLE DienThoai
(
MaDT VARCHAR(5) PRIMARY KEY NOT NULL,
TenDT NVARCHAR(50) NOT NULL,
AnhDT VARCHAR(50) NOT NULL,
PhuKien NVARCHAR(50) NOT NULL,
DonGia MONEY NOT NULL,
MaLDT VARCHAR(5) NOT NULL
CONSTRAINT DT_LoaiDT FOREIGN KEY(MaLDT) REFERENCES dbo.LoaiDT(MaLDT)
)
--
GO 
INSERT dbo.LoaiDT ( MaLDT, TenLDT )
VALUES  ( '01',N'Nokia')
GO 
INSERT dbo.LoaiDT ( MaLDT, TenLDT )
VALUES  ( '03',N'Oppo')
GO 
INSERT dbo.LoaiDT ( MaLDT, TenLDT )
VALUES  ( '02',N'SamSung')
--
GO 
INSERT dbo.DienThoai( MaDT ,TenDT , AnhDT ,PhuKien ,DonGia ,MaLDT)
VALUES  ( 'N001' , N'Nokia C5-06' ,'N001.gif' , N'Pin,sạc,cáp,tai nghe,hộp sách' ,286 ,'01')
GO 
INSERT dbo.DienThoai( MaDT ,TenDT , AnhDT ,PhuKien ,DonGia ,MaLDT)
VALUES  ( 'N002' , N'Nokia Asha 303' ,'N002.gif' , N'Pin,sạc,cáp,tai nghe,hộp sách' ,321 ,'01')
GO 
INSERT dbo.DienThoai( MaDT ,TenDT , AnhDT ,PhuKien ,DonGia ,MaLDT)
VALUES  ( 'S001' , N'SamSung Wave S7250D' ,'S001.gif' , N'Pin,sạc,cáp,tai nghe,thẻ nhớ 2GB' ,555,'02')
--- 
GO
CREATE PROC DienThoai_DS
AS
BEGIN
	SELECT* FROM dbo.DienThoai
END
---
GO
CREATE PROC DienThoai_Them
@MaDT VARCHAR(5) ,
@TenDT NVARCHAR(50),
@AnhDT VARCHAR(50) ,
@PhuKien NVARCHAR(50),
@DonGia MONEY ,
@MaLDT VARCHAR(5)
AS
BEGIN
	INSERT INTO dbo.DienThoai VALUES (@MaDT,@TenDT,@AnhDT,@PhuKien,@DonGia,@MaLDT)
END
---
GO
CREATE PROC DienThoai_Xoa
@MaDT VARCHAR(5)
AS
BEGIN
	DELETE FROM dbo.DienThoai WHERE MaDT=@MaDT
END
---
GO
CREATE PROC DienThoai_Sua
@MaDT VARCHAR(5) ,
@TenDT NVARCHAR(50),
@AnhDT VARCHAR(50) ,
@PhuKien NVARCHAR(50),
@DonGia MONEY ,
@MaLDT VARCHAR(5)
AS
BEGIN
	UPDATE dbo.DienThoai SET TenDT=@TenDT,AnhDT=@AnhDT,PhuKien=@PhuKien,DonGia=@DonGia,MaLDT=@MaLDT
	WHERE MaDT=@MaDT
END
---
GO
CREATE PROC LoaiDT_DS
AS
BEGIN
	SELECT*FROM dbo.LoaiDT
END

	 