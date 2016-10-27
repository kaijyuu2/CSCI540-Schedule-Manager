SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT INTO [dbo].[Employee] ([EmployeeID], [First name], [Last name], [Email], [Password], [Admin]) VALUES (0, 'a', 'b', 'a.b.com', 'password', 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
