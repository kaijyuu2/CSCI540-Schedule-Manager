SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mark and Daniel
-- Create date: 10-26-16
-- Description:	Create a new availability.
-- =============================================
CREATE PROCEDURE addAvailability
	-- Add the parameters for the stored procedure here
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
	INSERT INTO Availability(EmployeeID, DayID, StartTIme, EndTime)
	VALUES(@pNewEmployeeID, @pNewDayID, @pNewStartTime, @pNewEndTime)
END
GO