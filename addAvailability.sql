USE [SchedulingDatabase]
GO
/****** Object:  StoredProcedure addAvailability    Script Date: 10/26/2016 10:40:57 PM ******/
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
	@pNewEmployeeID int,
	@pNewDayID int,
	@pNewStartTime int,
	@pNewEndTime int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Availability(EmployeeID, DayID, StartTIme, EndTime)
	VALUES(@pNewEmployeeID, @pNewDayID, @pNewStartTime, @pNewEndTime)
END

