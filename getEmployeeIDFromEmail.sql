CREATE PROCEDURE [dbo].[getEmployeeIDFromEmail]
	-- Add the parameters for the stored procedure here
	@email str = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmployeeID
	FROM Employee
	WHERE Email = @email
END