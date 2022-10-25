Create FUNCTION [dbo].[GetKyHoc](@id_ky_hoc int)
RETURNS TABLE 
AS
RETURN Select * from KYHOC WHERE id_ky_hoc = @id_ky_hoc