USE [SchedulingDatabase]
GO
/****** Object:  Table [dbo].[TimeDuration]    Script Date: 11/22/2016 09:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TimeDuration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Duration] [varchar](20) NULL,
 CONSTRAINT [PK_TimeDuration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Day]    Script Date: 11/22/2016 09:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Day](
	[DayID] [int] IDENTITY(1,1) NOT NULL,
	[DayName] [nchar](10) NULL,
 CONSTRAINT [PK_Day] PRIMARY KEY CLUSTERED 
(
	[DayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/22/2016 09:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[First name] [varchar](50) NULL,
	[Last name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Admin] [bit] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[deleteEmployee]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Remove an employee with ID.
-- =============================================
CREATE PROCEDURE [dbo].[deleteEmployee]
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Employee
	WHERE EmployeeID = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[createEmployee]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Create a new user
-- =============================================
CREATE PROCEDURE [dbo].[createEmployee] 
	-- Add the parameters for the stored procedure here
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
	VALUES (@pFirstName, @pLastName, @pEmail, @pPassword, @pAdmin)
END
GO
/****** Object:  Table [dbo].[Availability]    Script Date: 11/22/2016 09:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Availability](
	[AvailabilityID] [int] IDENTITY(1,1) NOT NULL,
	[DayID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[DurationID] [int] NULL,
	[DeleteFlag] [bit] NULL,
 CONSTRAINT [PK_Availability] PRIMARY KEY CLUSTERED 
(
	[AvailabilityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinalSchedule]    Script Date: 11/22/2016 09:13:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalSchedule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DayID] [int] NULL,
	[EmployeeID] [int] NULL,
	[DurationID] [int] NULL,
	[TimeStamp] [datetime] NULL,
 CONSTRAINT [PK_FinalSchedule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[addEmployee]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Create a new user
-- =============================================
CREATE PROCEDURE [dbo].[addEmployee] 
	-- Add the parameters for the stored procedure here
	@pFirstName varchar(50) = '',
	@pLastName varchar(50) = '',
	@pEmail varchar(50) = '',
	@pPassword varchar(50) = '',
	@pAdmin	bit = 0,
	@id int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Employee([First name], [Last name], Email, Password, Admin)
	VALUES (@pFirstName, @pLastName, @pEmail, @pPassword, @pAdmin)
	SET @id=SCOPE_IDENTITY()
	RETURN @id
END
GO
/****** Object:  StoredProcedure [dbo].[getEmail]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the employee email with ID
-- =============================================
CREATE PROCEDURE [dbo].[getEmail] 
	-- Add the parameters for the stored procedure here
	@pID int = 0 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Email
	FROM Employee
	WHERE EmployeeID = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[getEmployeeIDFromEmail]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getEmployeeIDFromEmail]
	-- Add the parameters for the stored procedure here
	@email varchar(50)
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
GO
/****** Object:  StoredProcedure [dbo].[setPassword]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Set the employee's password with ID.
-- =============================================
CREATE PROCEDURE [dbo].[setPassword]
	-- Add the parameters for the stored procedure here
	@pID int = 0,
	@pNewPassword varchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE EMPLOYEE
	SET Password = @pNewPassword
	WHERE EmployeeID = @pID;
END
GO
/****** Object:  StoredProcedure [dbo].[setLastName]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Set the employee's last name with ID.
-- =============================================
CREATE PROCEDURE [dbo].[setLastName]
	-- Add the parameters for the stored procedure here
	@pID int = 0,
	@pNewLastName varchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE EMPLOYEE
	SET [Last Name] = @pNewLastName
	WHERE EmployeeID = @pID;
END
GO
/****** Object:  StoredProcedure [dbo].[setFirstName]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Set employee first name with ID.
-- =============================================
CREATE PROCEDURE [dbo].[setFirstName]
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
/****** Object:  StoredProcedure [dbo].[setEmail]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Set the employee's email with ID.
-- =============================================
CREATE PROCEDURE [dbo].[setEmail]
	-- Add the parameters for the stored procedure here
	@pID int = 0,
	@pNewEmail varchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE EMPLOYEE
	SET Email = @pNewEmail
	WHERE EmployeeID = @pID;
END
GO
/****** Object:  StoredProcedure [dbo].[getPassword]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the employee password with ID
-- =============================================
CREATE PROCEDURE [dbo].[getPassword]
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
/****** Object:  StoredProcedure [dbo].[getLastName]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the employee last name via ID
-- =============================================
CREATE PROCEDURE [dbo].[getLastName] 
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Last Name]
	FROM Employee
	WHERE EmployeeID = @pID

END
GO
/****** Object:  StoredProcedure [dbo].[getFirstName]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Retrieves the admin status via ID.
-- =============================================
CREATE PROCEDURE [dbo].[getFirstName]
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [First name]
	FROM Employee
	WHERE EmployeeID = @PID
END
GO
/****** Object:  StoredProcedure [dbo].[getEndTime]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the End Time from Availability with ID.
-- =============================================
CREATE PROCEDURE [dbo].[getEndTime]
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EndTime
	FROM Availability
	WHERE AvailabilityID = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[getStartTime]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the Start Time from Availability with ID.
-- =============================================
CREATE PROCEDURE [dbo].[getStartTime]
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT StartTime
	FROM Availability
	WHERE AvailabilityID = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[getEmployeeID]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the EmployeeID from Availability with ID.
-- =============================================
CREATE PROCEDURE [dbo].[getEmployeeID]
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmployeeID
	FROM Availability
	WHERE AvailabilityID = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[getDayID]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Get the DayID from Availability with ID.
-- =============================================
CREATE PROCEDURE [dbo].[getDayID]
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DayID
	FROM Availability
	WHERE AvailabilityID = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[addAvailability]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mark and Daniel
-- Create date: 10-26-16
-- Description:	Create a new availability.
-- =============================================
CREATE PROCEDURE [dbo].[addAvailability]
	-- Add the parameters for the stored procedure here
	@pNewEmployeeID int,
	@pNewDayID int,
	@pDurationID int,
	@pDeleteFlag bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	-- Soft Delete previous enteries
	if @pDeleteFlag=0
	BEGIN
		UPDATE Availability SET DeleteFlag=1 WHERE EmployeeID=@pNewEmployeeID
	END
	if exists(Select 1 From Availability WHERE EmployeeID = @pNewEmployeeID AND DayID = @pNewDayID AND DurationID=@pDurationID)
      BEGIN
        UPDATE Availability SET DeleteFlag=0 WHERE EmployeeID = @pNewEmployeeID AND DayID = @pNewDayID AND DurationID=@pDurationID
       END
    ELSE
      BEGIN
            -- Insert statements for procedure here
	INSERT INTO Availability(EmployeeID, DayID, DurationID)
	VALUES(@pNewEmployeeID, @pNewDayID, @pDurationID)
       END
END
GO
/****** Object:  StoredProcedure [dbo].[addSchedule]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mark and Daniel
-- Create date: 10-26-16
-- Description:	Create a new availability.
-- =============================================
CREATE PROCEDURE [dbo].[addSchedule]
	-- Add the parameters for the stored procedure here
	@pNewEmployeeID int,
	@pNewDayID int,
	@pDurationID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    -- Insert statements for procedure here
	INSERT INTO FinalSchedule(EmployeeID, DayID, DurationID,TimeStamp)
	VALUES(@pNewEmployeeID, @pNewDayID, @pDurationID, GETDATE())
END
GO
/****** Object:  StoredProcedure [dbo].[deleteAvailability]    Script Date: 11/22/2016 09:13:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mason Hardy
-- Create date: 10-16-16
-- Description:	Delete availability with ID.
-- =============================================
CREATE PROCEDURE [dbo].[deleteAvailability]
	-- Add the parameters for the stored procedure here
	@pID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Availability
	WHERE AvailabilityID = @pID
END
GO
/****** Object:  Default [DF_Availability_DeleteFlag]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[Availability] ADD  CONSTRAINT [DF_Availability_DeleteFlag]  DEFAULT ((0)) FOR [DeleteFlag]
GO
/****** Object:  Default [DF__Employee__Admin__03317E3D]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0)) FOR [Admin]
GO
/****** Object:  ForeignKey [FK_Availability_Day]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[Availability]  WITH CHECK ADD  CONSTRAINT [FK_Availability_Day] FOREIGN KEY([DayID])
REFERENCES [dbo].[Day] ([DayID])
GO
ALTER TABLE [dbo].[Availability] CHECK CONSTRAINT [FK_Availability_Day]
GO
/****** Object:  ForeignKey [FK_Availability_Employee]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[Availability]  WITH CHECK ADD  CONSTRAINT [FK_Availability_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Availability] CHECK CONSTRAINT [FK_Availability_Employee]
GO
/****** Object:  ForeignKey [FK_Availability_TimeDuration]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[Availability]  WITH CHECK ADD  CONSTRAINT [FK_Availability_TimeDuration] FOREIGN KEY([DurationID])
REFERENCES [dbo].[TimeDuration] ([Id])
GO
ALTER TABLE [dbo].[Availability] CHECK CONSTRAINT [FK_Availability_TimeDuration]
GO
/****** Object:  ForeignKey [FK_FinalSchedule_Day]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[FinalSchedule]  WITH CHECK ADD  CONSTRAINT [FK_FinalSchedule_Day] FOREIGN KEY([DayID])
REFERENCES [dbo].[Day] ([DayID])
GO
ALTER TABLE [dbo].[FinalSchedule] CHECK CONSTRAINT [FK_FinalSchedule_Day]
GO
/****** Object:  ForeignKey [FK_FinalSchedule_Employee]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[FinalSchedule]  WITH CHECK ADD  CONSTRAINT [FK_FinalSchedule_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[FinalSchedule] CHECK CONSTRAINT [FK_FinalSchedule_Employee]
GO
/****** Object:  ForeignKey [FK_FinalSchedule_TimeDuration]    Script Date: 11/22/2016 09:13:08 ******/
ALTER TABLE [dbo].[FinalSchedule]  WITH CHECK ADD  CONSTRAINT [FK_FinalSchedule_TimeDuration] FOREIGN KEY([DurationID])
REFERENCES [dbo].[TimeDuration] ([Id])
GO
ALTER TABLE [dbo].[FinalSchedule] CHECK CONSTRAINT [FK_FinalSchedule_TimeDuration]
GO
