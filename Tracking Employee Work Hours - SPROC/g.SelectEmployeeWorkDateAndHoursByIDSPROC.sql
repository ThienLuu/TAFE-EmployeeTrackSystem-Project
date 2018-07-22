-- =============================================
-- Author:		Thien
-- Create date: 21/05/2018
-- Description:	Select emplooyee work date and hours by ID
-- =============================================
CREATE PROCEDURE sp_EmpHours_SelectEmployeeWorkDateAndHoursByID
		@empID int
AS
BEGIN
	SELECT WorkDate, Hours
	FROM EmpHours
	WHERE EmpID = @empID
END
GO