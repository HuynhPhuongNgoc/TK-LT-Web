﻿GO 
CREATE DATABASE Bai4_57131345
GO
USE Bai4_57131345
GO
CREATE TABLE LoaiTT
(
MaLTT VARCHAR(5) PRIMARY KEY NOT NULL,
TenLTT NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE TinTuc
(
MaTT VARCHAR(10) PRIMARY KEY NOT NULL,
TieuDe NVARCHAR(50) NOT NULL,
NgayDang DATETIME NOT NULL,
AnhMH VARCHAR(50) NOT NULL,
MaLTT VARCHAR(5) NOT NULL
CONSTRAINT TT_LTT FOREIGN KEY(MaLTT) REFERENCES dbo.LoaiTT(MaLTT)
)
GO
INSERT dbo.LoaiTT( MaLTT, TenLTT )
VALUES  ( 'GD', N'Giáo dục' )
GO
INSERT dbo.LoaiTT( MaLTT, TenLTT )
VALUES  ( 'CT', N'Chính trị' )
GO
INSERT dbo.LoaiTT( MaLTT, TenLTT )
VALUES  ( 'TT', N'Thể Thao' )
GO
INSERT dbo.TinTuc( MaTT, TieuDe, NgayDang, AnhMH, MaLTT )
VALUES  ( 'GD0001', N'Tổng bí thư đánh trống khai giảng ở trường cũ', '04/09/14 12:00:00 AM', 'GD0001.gif','GD')
GO
INSERT dbo.TinTuc( MaTT, TieuDe, NgayDang, AnhMH, MaLTT )
VALUES  ( 'GD0002', N'PGS Văn Như Cương nhắn nhủ trò bảo về biển đảo quê hương', '05/09/14 12:00:00 AM', 'GD0002.gif','GD')
GO
INSERT dbo.TinTuc( MaTT, TieuDe, NgayDang, AnhMH, MaLTT )
VALUES  ( 'TT0001', N'Những VĐV gốc Việt tỏa sáng nơi đất khách', '08/09/14 12:00:00 AM', 'TT0001.gif','TT')
GO
CREATE PROC TinTuc_DS
AS
BEGIN
	SELECT*FROM dbo.TinTuc
END
---
GO
CREATE PROC TinTuc_Them
@MaTT VARCHAR(10) ,
@TieuDe NVARCHAR(50),
@NgayDang DATETIME,
@AnhMH NVARCHAR(200) ,
@MaLTT VARCHAR(5)
AS
BEGIN
	INSERT INTO dbo.TinTuc VALUES(@MaTT,@TieuDe,@NgayDang,@AnhMH,@MaLTT)
END
---
GO
CREATE PROC TinTuc_Xoa
@MaTT VARCHAR(10)
AS
BEGIN
	DELETE FROM dbo.TinTuc WHERE MaTT=@MaTT
END
--
GO
CREATE PROC TinTuc_Sua
@MaTT VARCHAR(10),
@TieuDe NVARCHAR(50),
@NgayDang DATETIME,
@AnhMH NVARCHAR(200),
@MaLTT VARCHAR(5)
AS
BEGIN
	UPDATE dbo.TinTuc SET TieuDe=@TieuDe,NgayDang=@NgayDang,AnhMH=@AnhMH,MaLTT=@MaLTT
	WHERE MaTT=@MaTT
END 
---
GO
CREATE PROC LoaiTT_DS
AS
BEGIN
	SELECT*FROM dbo.LoaiTT
END 
ALTER TABLE dbo.TinTuc ALTER COLUMN TieuDe NVARCHAR(100)
ALTER TABLE dbo.TinTuc ALTER COLUMN AnhMH NVARCHAR(200)