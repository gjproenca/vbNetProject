USE [master]
GO
/****** Object:  Database [DomoSys]    Script Date: 31-07-2018 16:46:35 ******/
CREATE DATABASE [DomoSys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DomoSys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DomoSys.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DomoSys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DomoSys_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DomoSys] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DomoSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DomoSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DomoSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DomoSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DomoSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DomoSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [DomoSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DomoSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DomoSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DomoSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DomoSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DomoSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DomoSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DomoSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DomoSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DomoSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DomoSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DomoSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DomoSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DomoSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DomoSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DomoSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DomoSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DomoSys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DomoSys] SET  MULTI_USER 
GO
ALTER DATABASE [DomoSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DomoSys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DomoSys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DomoSys] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DomoSys] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DomoSys]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 31-07-2018 16:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[IdPermission] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL CONSTRAINT [DF_Premissions_IdUser]  DEFAULT ((0)),
	[SoftwareStatus] [bit] NOT NULL CONSTRAINT [DF_Permissions_SoftwareStatus]  DEFAULT ((0)),
	[Alarm] [bit] NOT NULL CONSTRAINT [DF_Permissions_Alarm]  DEFAULT ((0)),
	[Fire] [bit] NOT NULL CONSTRAINT [DF_Permissions_Fire]  DEFAULT ((0)),
	[Message] [bit] NOT NULL CONSTRAINT [DF_Permissions_Message]  DEFAULT ((0)),
	[LightBedR1] [bit] NOT NULL CONSTRAINT [DF_Permissions_LightBedR1]  DEFAULT ((0)),
	[LightBedR2] [bit] NOT NULL CONSTRAINT [DF_Permissions_LightBedR2]  DEFAULT ((0)),
	[LightBedR3] [bit] NOT NULL CONSTRAINT [DF_Permissions_LightBedR3]  DEFAULT ((0)),
	[LightLiving] [bit] NOT NULL CONSTRAINT [DF_Permissions_LightLiving]  DEFAULT ((0)),
	[LightDining] [bit] NOT NULL CONSTRAINT [DF_Permissions_LightDining]  DEFAULT ((0)),
	[LightGarage] [bit] NOT NULL CONSTRAINT [DF_Permissions_LightGarage]  DEFAULT ((0)),
	[TimeStamp] [bit] NOT NULL CONSTRAINT [DF_Permissions_TimeStamp]  DEFAULT ((0)),
 CONSTRAINT [PK_Premissions] PRIMARY KEY CLUSTERED 
(
	[IdPermission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Status]    Script Date: 31-07-2018 16:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Status](
	[IdStatus] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[SoftwareStatus] [bit] NOT NULL,
	[Alarm] [bit] NOT NULL,
	[Fire] [bit] NOT NULL,
	[Message] [varchar](250) NULL,
	[LightBedR1] [bit] NOT NULL,
	[LightBedR2] [bit] NOT NULL,
	[LightBedR3] [bit] NOT NULL,
	[LightLiving] [bit] NOT NULL,
	[LightDining] [bit] NOT NULL,
	[LightGarage] [bit] NOT NULL,
	[TimeStamp] [datetime] NOT NULL CONSTRAINT [DF_tb_domosys_TimeStamp]  DEFAULT (getdate()),
 CONSTRAINT [PK_tb_domosys] PRIMARY KEY CLUSTERED 
(
	[IdStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 31-07-2018 16:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](168) NOT NULL,
	[Administrator] [bit] NOT NULL DEFAULT ((0)),
	[Active] [bit] NOT NULL DEFAULT ((1)),
	[TimeStamp] [datetime] NOT NULL DEFAULT (getdate()),
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 

INSERT [dbo].[Permissions] ([IdPermission], [IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (28, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Permissions] ([IdPermission], [IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (37, 33, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Permissions] ([IdPermission], [IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (38, 34, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Permissions] ([IdPermission], [IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (39, 35, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Permissions] OFF
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([IdStatus], [IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (1, 2, 1, 1, 1, N'', 0, 1, 1, 1, 1, 1, CAST(N'2018-07-27 17:36:45.507' AS DateTime))
INSERT [dbo].[Status] ([IdStatus], [IdUser], [SoftwareStatus], [Alarm], [Fire], [Message], [LightBedR1], [LightBedR2], [LightBedR3], [LightLiving], [LightDining], [LightGarage], [TimeStamp]) VALUES (51, 2, 1, 1, 1, N'mada', 0, 1, 1, 1, 1, 1, CAST(N'2018-07-31 16:43:45.360' AS DateTime))
SET IDENTITY_INSERT [dbo].[Status] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([IdUser], [UserName], [Password], [Administrator], [Active], [TimeStamp]) VALUES (2, N'administrator', N'2s+FAtxEEf2tEuZI6jBTYKIr8yCm/bCNb2YLuKGObwA=', 1, 1, CAST(N'2018-07-29 18:39:39.767' AS DateTime))
INSERT [dbo].[Users] ([IdUser], [UserName], [Password], [Administrator], [Active], [TimeStamp]) VALUES (33, N'administratorNotActive', N'2s+FAtxEEf2tEuZI6jBTYKIr8yCm/bCNHdNckKrC225V2EuzrLsjOYBT/PThXW9u', 1, 0, CAST(N'2018-07-31 16:41:35.473' AS DateTime))
INSERT [dbo].[Users] ([IdUser], [UserName], [Password], [Administrator], [Active], [TimeStamp]) VALUES (34, N'testuser1', N'H8ydov6j5W07nAV2HXmd+ZbcBUlfttT1', 0, 1, CAST(N'2018-07-31 16:39:12.400' AS DateTime))
INSERT [dbo].[Users] ([IdUser], [UserName], [Password], [Administrator], [Active], [TimeStamp]) VALUES (35, N'testuser1NotActive', N'H8ydov6j5W07nAV2HXmd+a6B7MWdjxzMkLCGSNW9BF5XpAB9Q+boAQ==', 0, 0, CAST(N'2018-07-31 16:40:06.603' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Permissions]  WITH CHECK ADD  CONSTRAINT [FK_Premissions_Users] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([IdUser])
GO
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_Premissions_Users]
GO
ALTER TABLE [dbo].[Status]  WITH CHECK ADD  CONSTRAINT [FK_Status_Users] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([IdUser])
GO
ALTER TABLE [dbo].[Status] CHECK CONSTRAINT [FK_Status_Users]
GO
USE [master]
GO
ALTER DATABASE [DomoSys] SET  READ_WRITE 
GO
