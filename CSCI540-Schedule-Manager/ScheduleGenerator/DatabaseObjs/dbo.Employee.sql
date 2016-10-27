CREATE TABLE [dbo].[Employee] (
    [EmployeeID] INT          IDENTITY (1, 1) NOT NULL,
    [First name] VARCHAR (50) NULL,
    [Last name]  VARCHAR (50) NULL,
    [Email]      VARCHAR (50) NULL,
    [Password]   VARCHAR (50) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);