-- =============================================
-- Author:		Thien
-- Create date: 21/05/2018
-- Description:	Insert Employee
-- =============================================
CREATE PROCEDURE sp_Employees_InsertEmployee
		@firstName varchar(20),
		@lastName varchar(20),
		@email varchar(50),
		@dob date,
		@phone varchar(10)
AS
BEGIN
	INSERT INTO Employees
	VALUES (@firstName, @lastName, @email, @dob, @phone)
END
GO
