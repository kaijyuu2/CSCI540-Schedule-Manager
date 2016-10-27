SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Create a new availability.
-- =============================================
CREATE PROCEDURE createAvailability
	-- Add the parameters for the stored procedure here
	@pID int = 0,
	@pNewEmployeeID int = 0,
	@pNewDayID int = 0,
	@pNewStartTime int = 0,
	@pNewEndTime int = 0

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Availability
	VALUES(@pID, @pNewEmployeeID, @pNewDayID, @pNewStartTime, @pNewEndTime)
END
GO