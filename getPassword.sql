SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the employee password with ID
-- =============================================
CREATE PROCEDURE getPassword
	-- Add the parameters for the stored procedure here
	@pID int = 0 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Password
	FROM Employee
	WHERE EmployeeID = @pID
END
GO