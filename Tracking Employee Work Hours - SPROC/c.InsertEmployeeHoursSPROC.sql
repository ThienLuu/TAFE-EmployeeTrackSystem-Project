-- =============================================
-- Author:		Thien
-- Create date: 21/05/2018
-- Description:	Insert Employee Hours
-- =============================================
CREATE PROCEDURE sp_EmpHours_InsertEmployeeHours
		@empID int,
		@workDate date,
		@hours decimal
AS
BEGIN
	INSERT INTO EmpHours
	VALUES (@empID, @workDate, @hours)
END
GO