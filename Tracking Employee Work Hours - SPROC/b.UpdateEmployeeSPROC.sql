-- =============================================
-- Author:		Thien
-- Create date: 21/05/2018
-- Description:	Update Employee
-- =============================================
CREATE PROCEDURE sp_Employees_UpdateEmployee
		@empID int,
		@firstName varchar(20),
		@lastName varchar(20),
		@email varchar(50),
		@dob date,
		@phone varchar(10)
AS
BEGIN
	UPDATE Employees
	SET FirstName = @firstName,
	LastName = @lastName,
	Email = @email,
	DOB = @dob,
	Phone = @phone
	WHERE EmpID = @empID
END