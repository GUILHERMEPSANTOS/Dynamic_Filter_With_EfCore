USE [master]
GO
/****** Object:  Database [Dynamic_Filter_With_EfCore]    Script Date: 05/08/2023 12:31:53 ******/
CREATE DATABASE [Dynamic_Filter_With_EfCore]
GO

USE [Dynamic_Filter_With_EfCore]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 05/08/2023 12:31:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](125) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Active] [bit] NOT NULL,
	[RegistrationDate] [datetime2](7) NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230729170206_Customer', N'7.0.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230805002320_customer-values', N'7.0.9')
GO
INSERT [dbo].[Customers] ([Id], [Name], [Email], [Active], [RegistrationDate], [DateOfBirth]) VALUES (N'7f40737b-3b0c-4917-b04a-01a58fd37c92', N'Rafael', N'rafael.mtz@gmail.com', 1, CAST(N'2018-08-05T00:23:20.3141668' AS DateTime2), CAST(N'2003-08-05T00:23:20.3141670' AS DateTime2))
INSERT [dbo].[Customers] ([Id], [Name], [Email], [Active], [RegistrationDate], [DateOfBirth]) VALUES (N'2852c44e-2005-4145-87ad-02c4e6619129', N'Ana', N'ana123@gmail.com', 1, CAST(N'2021-08-05T00:23:20.3141651' AS DateTime2), CAST(N'2006-08-05T00:23:20.3141653' AS DateTime2))
INSERT [dbo].[Customers] ([Id], [Name], [Email], [Active], [RegistrationDate], [DateOfBirth]) VALUES (N'7f20e568-3c03-4c02-8afb-0dcc6a5a2eed', N'Carlos', N'carlos45@yahoo.com', 1, CAST(N'2019-08-05T00:23:20.3141657' AS DateTime2), CAST(N'2004-08-05T00:23:20.3141658' AS DateTime2))
INSERT [dbo].[Customers] ([Id], [Name], [Email], [Active], [RegistrationDate], [DateOfBirth]) VALUES (N'de186d50-d218-4c81-9dbc-9dff0ff39946', N'Guilherme', N'guilherme@hotmail.com', 1, CAST(N'2020-08-05T00:23:20.3141582' AS DateTime2), CAST(N'2005-08-05T00:23:20.3141599' AS DateTime2))
INSERT [dbo].[Customers] ([Id], [Name], [Email], [Active], [RegistrationDate], [DateOfBirth]) VALUES (N'f89acce8-8235-40c6-b515-c29e213b8e30', N'Maria', N'maria87@hotmail.com', 1, CAST(N'2022-08-05T00:23:20.3141663' AS DateTime2), CAST(N'2007-08-05T00:23:20.3141665' AS DateTime2))
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('2023-08-05T00:23:20.3140345Z') FOR [RegistrationDate]
GO
USE [master]
GO
ALTER DATABASE [Dynamic_Filter_With_EfCore] SET  READ_WRITE 
GO
