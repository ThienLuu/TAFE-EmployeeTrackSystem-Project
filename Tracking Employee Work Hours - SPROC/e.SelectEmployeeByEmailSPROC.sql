-- =============================================
-- Author:		Thien
-- Create date: 21/05/2018
-- Description:	Select Emplooyee by Email
-- =============================================
CREATE PROCEDURE sp_Employees_SelectEmployeeByEmail
		@email varchar(50)
AS
BEGIN
	SELECT *
	FROM Employees
	WHERE Email = @email
END
GO