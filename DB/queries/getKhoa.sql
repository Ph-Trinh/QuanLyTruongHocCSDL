create FUNCTION [dbo].[GetKhoa](@maKhoa int)
RETURNS TABLE 
AS
RETURN Select * from KHOA WHERE ma_khoa = @maKhoa
