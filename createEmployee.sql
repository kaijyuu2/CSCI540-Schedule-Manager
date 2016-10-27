-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Create a new user
-- =============================================
CREATE PROCEDURE createEmployee 
	-- Add the parameters for the stored procedure here
	@pID int = 0, 
	@pFirstName varchar(50) = '',
	@pLastName varchar(50) = '',
	@pEmail varchar(50) = '',
	@pPassword varchar(50) = '',
	@pAdmin	bit = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Employee
	VALUES (@pID, @pFirstName, @pLastName, @pEmail, @pPassword, @pAdmin)
END
GO
