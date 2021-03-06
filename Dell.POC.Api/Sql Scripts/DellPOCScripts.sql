USE [master]
GO
/****** Object:  Database [DellPOC]    Script Date: 04-01-2021 11:46:33 ******/
CREATE DATABASE [DellPOC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DellPOC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DellPOC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DellPOC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DellPOC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DellPOC] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DellPOC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DellPOC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DellPOC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DellPOC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DellPOC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DellPOC] SET ARITHABORT OFF 
GO
ALTER DATABASE [DellPOC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DellPOC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DellPOC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DellPOC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DellPOC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DellPOC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DellPOC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DellPOC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DellPOC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DellPOC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DellPOC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DellPOC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DellPOC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DellPOC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DellPOC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DellPOC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DellPOC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DellPOC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DellPOC] SET  MULTI_USER 
GO
ALTER DATABASE [DellPOC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DellPOC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DellPOC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DellPOC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DellPOC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DellPOC] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DellPOC] SET QUERY_STORE = OFF
GO
USE [DellPOC]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity](
	[Entity_Id] [int] IDENTITY(1,1) NOT NULL,
	[Entity_Name] [nvarchar](50) NOT NULL,
	[Entity_Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED 
(
	[Entity_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity_Attribute]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity_Attribute](
	[Entity_Attribute_Id] [int] IDENTITY(1,1) NOT NULL,
	[Entity_Id] [int] NOT NULL,
	[Attribute_Value] [nvarchar](50) NOT NULL,
	[Attribute_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Entity_Attribute] PRIMARY KEY CLUSTERED 
(
	[Entity_Attribute_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity_Item_Group]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity_Item_Group](
	[Entity_Item_Group_Id] [int] IDENTITY(1,1) NOT NULL,
	[Entity_Id] [int] NOT NULL,
	[Item_Group_Id] [int] NOT NULL,
 CONSTRAINT [PK_Entity_Item_Group] PRIMARY KEY CLUSTERED 
(
	[Entity_Item_Group_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Item_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Name] [nvarchar](50) NOT NULL,
	[Item_Description] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Attribute]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Attribute](
	[Attribute_Item_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Id] [int] NOT NULL,
	[Item_Attribute_Value] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Item_Attribute] PRIMARY KEY CLUSTERED 
(
	[Attribute_Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Group]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Group](
	[Item_Group_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Group_Name] [nvarchar](50) NOT NULL,
	[Item_Group_Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Item_Group] PRIMARY KEY CLUSTERED 
(
	[Item_Group_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Group_Attribute]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Group_Attribute](
	[Attribute_Item_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Group_Id] [int] NOT NULL,
	[Item_Group_Attribute] [nvarchar](50) NOT NULL,
	[Item_Group_Attribute_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Item_Group_Attribute] PRIMARY KEY CLUSTERED 
(
	[Attribute_Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Group_Item]    Script Date: 04-01-2021 11:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Group_Item](
	[Item_Group_Item_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Id] [int] NOT NULL,
	[Item_Group_Id] [int] NOT NULL,
 CONSTRAINT [PK_Item_Group_Item] PRIMARY KEY CLUSTERED 
(
	[Item_Group_Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Entity] ON 

INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (1, N'test entity name', N'test desc')
INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (2, N'Test Entity', N'Test Description')
INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (3, N'test', N'test')
INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (4, N'test', N'test')
INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (5, N'10', N'10')
INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (6, N'fdsffdsffdsfad', N'fafd')
INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (7, N'Test Entity', N'Test Desc')
INSERT [dbo].[Entity] ([Entity_Id], [Entity_Name], [Entity_Description]) VALUES (8, N'Test Entity Name 9', N'Test Entity Name 9')
SET IDENTITY_INSERT [dbo].[Entity] OFF
GO
SET IDENTITY_INSERT [dbo].[Entity_Attribute] ON 

INSERT [dbo].[Entity_Attribute] ([Entity_Attribute_Id], [Entity_Id], [Attribute_Value], [Attribute_Name]) VALUES (1, 1, N'Entity_1_Attribute_value', N'Entity_1_Attribute_Name')
INSERT [dbo].[Entity_Attribute] ([Entity_Attribute_Id], [Entity_Id], [Attribute_Value], [Attribute_Name]) VALUES (2, 1, N'Entity_2_Attribute_value', N'Entity_2_Attribute_Name')
INSERT [dbo].[Entity_Attribute] ([Entity_Attribute_Id], [Entity_Id], [Attribute_Value], [Attribute_Name]) VALUES (3, 1, N'Entity_3_Attribute_value', N'Entity_3_Attribute_Name')
SET IDENTITY_INSERT [dbo].[Entity_Attribute] OFF
GO
SET IDENTITY_INSERT [dbo].[Entity_Item_Group] ON 

INSERT [dbo].[Entity_Item_Group] ([Entity_Item_Group_Id], [Entity_Id], [Item_Group_Id]) VALUES (3, 1, 1)
INSERT [dbo].[Entity_Item_Group] ([Entity_Item_Group_Id], [Entity_Id], [Item_Group_Id]) VALUES (4, 1, 2)
SET IDENTITY_INSERT [dbo].[Entity_Item_Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([Item_Id], [Item_Name], [Item_Description]) VALUES (1, N'Test Item Name', N'Test Item Desc')
INSERT [dbo].[Item] ([Item_Id], [Item_Name], [Item_Description]) VALUES (2, N'Test Item Name', N'Test Item Desc')
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
SET IDENTITY_INSERT [dbo].[Item_Attribute] ON 

INSERT [dbo].[Item_Attribute] ([Attribute_Item_Id], [Item_Id], [Item_Attribute_Value]) VALUES (1, 1, N'value1')
SET IDENTITY_INSERT [dbo].[Item_Attribute] OFF
GO
SET IDENTITY_INSERT [dbo].[Item_Group] ON 

INSERT [dbo].[Item_Group] ([Item_Group_Id], [Item_Group_Name], [Item_Group_Description]) VALUES (1, N'groupname', N'group desc')
INSERT [dbo].[Item_Group] ([Item_Group_Id], [Item_Group_Name], [Item_Group_Description]) VALUES (2, N'Entity1_ItemGroupName', N'Entity1_GroupDesc')
SET IDENTITY_INSERT [dbo].[Item_Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Item_Group_Attribute] ON 

INSERT [dbo].[Item_Group_Attribute] ([Attribute_Item_Id], [Item_Group_Id], [Item_Group_Attribute], [Item_Group_Attribute_Name]) VALUES (1, 1, N'test Item group attribute', N'test_Item_Group_Attribute_Name')
SET IDENTITY_INSERT [dbo].[Item_Group_Attribute] OFF
GO
SET IDENTITY_INSERT [dbo].[Item_Group_Item] ON 

INSERT [dbo].[Item_Group_Item] ([Item_Group_Item_Id], [Item_Id], [Item_Group_Id]) VALUES (1, 1, 1)
INSERT [dbo].[Item_Group_Item] ([Item_Group_Item_Id], [Item_Id], [Item_Group_Id]) VALUES (2, 1, 2)
SET IDENTITY_INSERT [dbo].[Item_Group_Item] OFF
GO
ALTER TABLE [dbo].[Entity_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_Entity_Attribute_Entity] FOREIGN KEY([Entity_Id])
REFERENCES [dbo].[Entity] ([Entity_Id])
GO
ALTER TABLE [dbo].[Entity_Attribute] CHECK CONSTRAINT [FK_Entity_Attribute_Entity]
GO
ALTER TABLE [dbo].[Entity_Item_Group]  WITH CHECK ADD  CONSTRAINT [FK_Entity_Item_Group_Entity] FOREIGN KEY([Entity_Id])
REFERENCES [dbo].[Entity] ([Entity_Id])
GO
ALTER TABLE [dbo].[Entity_Item_Group] CHECK CONSTRAINT [FK_Entity_Item_Group_Entity]
GO
ALTER TABLE [dbo].[Entity_Item_Group]  WITH CHECK ADD  CONSTRAINT [FK_Entity_Item_Group_Item_Group] FOREIGN KEY([Item_Group_Id])
REFERENCES [dbo].[Item_Group] ([Item_Group_Id])
GO
ALTER TABLE [dbo].[Entity_Item_Group] CHECK CONSTRAINT [FK_Entity_Item_Group_Item_Group]
GO
ALTER TABLE [dbo].[Item_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_Item_Attribute_Item] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Item] ([Item_Id])
GO
ALTER TABLE [dbo].[Item_Attribute] CHECK CONSTRAINT [FK_Item_Attribute_Item]
GO
ALTER TABLE [dbo].[Item_Group_Attribute]  WITH CHECK ADD  CONSTRAINT [FK_Item_Group_Attribute_Item_Group] FOREIGN KEY([Item_Group_Id])
REFERENCES [dbo].[Item_Group] ([Item_Group_Id])
GO
ALTER TABLE [dbo].[Item_Group_Attribute] CHECK CONSTRAINT [FK_Item_Group_Attribute_Item_Group]
GO
ALTER TABLE [dbo].[Item_Group_Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Group_Item_Item] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Item] ([Item_Id])
GO
ALTER TABLE [dbo].[Item_Group_Item] CHECK CONSTRAINT [FK_Item_Group_Item_Item]
GO
ALTER TABLE [dbo].[Item_Group_Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Group_Item_Item_Group] FOREIGN KEY([Item_Group_Id])
REFERENCES [dbo].[Item_Group] ([Item_Group_Id])
GO
ALTER TABLE [dbo].[Item_Group_Item] CHECK CONSTRAINT [FK_Item_Group_Item_Item_Group]
GO
USE [master]
GO
ALTER DATABASE [DellPOC] SET  READ_WRITE 
GO
