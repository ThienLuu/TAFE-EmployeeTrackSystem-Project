-- =============================================
-- Author:		Thien
-- Create date: 21/05/2018
-- Description:	Select Emplooyee by ID
-- =============================================
CREATE PROCEDURE sp_Employees_SelectEmployeeByID
		@empID int
AS
BEGIN
	SELECT *
	FROM Employees
	WHERE EmpID = @empID
END
GO