CREATE DATABASE Bai1_57131345
USE Bai1_57131345
CREATE TABLE DT
(
MaDT VARCHAR(5) PRIMARY KEY NOT NULL,
TenDT VARCHAR(40) NOT NULL,
Dongia MONEY NOT NULL,
Phukienkemtheo NVARCHAR(50) NOT NULL,
Loaidienthoai NVARCHAR(20) NOT NULL
)
INSERT dbo.DT( MaDT , TenDT ,Dongia ,Phukienkemtheo ,Loaidienthoai)
VALUES  ( 'N001' ,'Nokia C5-06' ,28000000 , N'Pin, sạc, cáp, tai nghe, hộp sách' ,N'Nokia')
INSERT dbo.DT( MaDT , TenDT ,Dongia ,Phukienkemtheo ,Loaidienthoai)
VALUES  ( 'N002' ,'Nokia Asha 303' ,3210000, N'Pin, sạc, cáp, tai nghe, hộp sách' ,N'Nokia')
INSERT dbo.DT( MaDT , TenDT ,Dongia ,Phukienkemtheo ,Loaidienthoai)
VALUES  ( 'S001' ,'Samsung Wave S7250D' ,55500000, N'Pin, sạc, cáp, tai nghe, hộp sách' ,N'SamSung')
--------
GO
CREATE PROC DienThoai_DS
AS
BEGIN
	SELECT*
	FROM dbo.DT
END 
------
GO
CREATE PROC DienThoai_Them
@MaDT VARCHAR(5) ,
@TenDT VARCHAR(40),
@Dongia MONEY ,
@Phukienkemtheo NVARCHAR(50) ,
@Loaidienthoai NVARCHAR(20)
AS
BEGIN
	INSERT INTO dbo.DT VALUES(@MaDT,@TenDT,@Dongia,@Phukienkemtheo,@Loaidienthoai)
END
------ 
GO
CREATE PROC DienThoai_Xoa
@MaDT VARCHAR(5) 
AS
BEGIN
	DELETE FROM dbo.DT WHERE MaDT=@MaDT
END 
------
GO
CREATE PROC DienThoai_Sua
@MaDT VARCHAR(5) ,
@TenDT VARCHAR(40) ,
@Dongia MONEY ,
@Phukienkemtheo NVARCHAR(50),
@Loaidienthoai NVARCHAR(20) 
AS
BEGIN
	UPDATE dbo.DT SET TenDT=@TenDT, DonGia=@DonGia, Phukienkemtheo=@Phukienkemtheo, Loaidienthoai=@Loaidienthoai
	WHERE MaDT=@MaDT 
END
