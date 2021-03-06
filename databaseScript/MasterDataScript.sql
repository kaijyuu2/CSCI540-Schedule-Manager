USE [SchedulingDatabase]
GO
/****** Object:  Table [dbo].[Day]    Script Date: 11/22/2016 09:14:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Day]') AND type in (N'U'))
DROP TABLE [dbo].[Day]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/22/2016 09:14:45 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__Employee__Admin__03317E3D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [DF__Employee__Admin__03317E3D]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[TimeDuration]    Script Date: 11/22/2016 09:14:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TimeDuration]') AND type in (N'U'))
DROP TABLE [dbo].[TimeDuration]
GO
/****** Object:  Table [dbo].[TimeDuration]    Script Date: 11/22/2016 09:14:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TimeDuration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TimeDuration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Duration] [varchar](20) NULL,
 CONSTRAINT [PK_TimeDuration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TimeDuration] ON
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (1, N'09:00 - 10:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (2, N'10:00 - 11:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (3, N'11:00 - 12:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (4, N'12:00 - 13:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (5, N'13:00 - 14:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (6, N'14:00 - 15:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (7, N'15:00 - 16:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (8, N'16:00 - 17:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (9, N'17:00 - 18:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (10, N'18:00 - 19:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (11, N'19:00 - 20:00')
INSERT [dbo].[TimeDuration] ([Id], [Duration]) VALUES (12, N'20:00 - 21:00')
SET IDENTITY_INSERT [dbo].[TimeDuration] OFF
/****** Object:  Table [dbo].[Employee]    Script Date: 11/22/2016 09:14:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[First name] [varchar](50) NULL,
	[Last name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Admin] [bit] NULL DEFAULT ((0)),
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([EmployeeID], [First name], [Last name], [Email], [Password], [Admin]) VALUES (1, N'Mark', N'Walters', N'a', N'abc', 1)
INSERT [dbo].[Employee] ([EmployeeID], [First name], [Last name], [Email], [Password], [Admin]) VALUES (2, N'John', N'Doe', N'b@b.com', N'abc', 0)
INSERT [dbo].[Employee] ([EmployeeID], [First name], [Last name], [Email], [Password], [Admin]) VALUES (3, N'paul', N'heyman', N'a@a.com', N'abc', 0)
INSERT [dbo].[Employee] ([EmployeeID], [First name], [Last name], [Email], [Password], [Admin]) VALUES (4, N'smith', N'steven', N'a@a.com', N'abc', 0)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  Table [dbo].[Day]    Script Date: 11/22/2016 09:14:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Day]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Day](
	[DayID] [int] IDENTITY(1,1) NOT NULL,
	[DayName] [nchar](10) NULL,
 CONSTRAINT [PK_Day] PRIMARY KEY CLUSTERED 
(
	[DayID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Day] ON
INSERT [dbo].[Day] ([DayID], [DayName]) VALUES (1, N'Sunday    ')
INSERT [dbo].[Day] ([DayID], [DayName]) VALUES (2, N'Monday    ')
INSERT [dbo].[Day] ([DayID], [DayName]) VALUES (3, N'Tuesday   ')
INSERT [dbo].[Day] ([DayID], [DayName]) VALUES (4, N'Wednesday ')
INSERT [dbo].[Day] ([DayID], [DayName]) VALUES (5, N'Thursday  ')
INSERT [dbo].[Day] ([DayID], [DayName]) VALUES (6, N'Friday    ')
INSERT [dbo].[Day] ([DayID], [DayName]) VALUES (7, N'Saturday  ')
SET IDENTITY_INSERT [dbo].[Day] OFF
