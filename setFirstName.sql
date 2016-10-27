SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Set employee first name with ID.
-- =============================================
CREATE PROCEDURE setFirstName
	-- Add the parameters for the stored procedure here
	@pID int = 0,
	@pNewFirstName varchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE EMPLOYEE
	SET [First Name] = @pNewFirstName
	WHERE EmployeeID = @pID;
END
GO