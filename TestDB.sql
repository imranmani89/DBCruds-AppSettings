USE [TestDb]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 7/13/2024 1:28:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP DATABASE [TestDb]
GO
CREATE DATABASE [TestDb]
Go
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](250) NOT NULL,
	[LastName] [varchar](250) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Designition] [varchar](50) NOT NULL,
	[Address] [varchar](250) NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](50) NOT NULL,
	[CNIC] [varchar](20) NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [DOB], [Designition], [Address], [Phone], [Email], [CNIC], [isActive]) VALUES (1, N'Imran', N'Imtiaz', CAST(N'1989-07-06T00:00:00.000' AS DateTime), N'SS', N'XYZ', NULL, N'imran@imran.com', N'1234504561258', 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [DOB], [Designition], [Address], [Phone], [Email], [CNIC], [isActive]) VALUES (2, N'Asad', N'Ali', CAST(N'2002-09-02T00:00:00.000' AS DateTime), N'Internee', N'XYZ - xyx', N'0331-5245468', N'asad@ali.com', N'123455213435', 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [DOB], [Designition], [Address], [Phone], [Email], [CNIC], [isActive]) VALUES (3, N'Rana', N'Asif', CAST(N'2002-05-09T00:00:00.000' AS DateTime), N'PCO', N'XYZ - Lahore', N'0331-4535432', N'rana@asif.com', N'1234552464351', 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [DOB], [Designition], [Address], [Phone], [Email], [CNIC], [isActive]) VALUES (4, N'Shaikh', N'Atif', CAST(N'1982-06-19T00:00:00.000' AS DateTime), N'JS', N'XYZ - Pattoki', N'0331-4532435', N'atif@shaikh.com', N'3546552464351', 1)
GO
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [DOB], [Designition], [Address], [Phone], [Email], [CNIC], [isActive]) VALUES (5, N'Muhammad', N'Abdullah', CAST(N'1999-02-21T00:00:00.000' AS DateTime), N'JCO', N'XYZ - Lahore', N'0331-45324893', N'm@abdullah.com', N'3546123464351', 1)
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
