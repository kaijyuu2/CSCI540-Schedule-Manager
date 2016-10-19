SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Retrieves the admin status via ID.
-- =============================================
ALTER PROCEDURE [dbo].[getFirstName] 
	-- Add the parameters for the stored procedure here
	@pID bit = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Admin
	FROM Employee
	WHERE EmployeeID = @PID
END