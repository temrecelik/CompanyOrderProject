USE [ApiDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30.05.2024 11:10:46 ******/
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
/****** Object:  Table [dbo].[Companies]    Script Date: 30.05.2024 11:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
	[ApprovalStatus] [bit] NOT NULL,
	[OrderPermissionStart] [datetime2](7) NOT NULL,
	[OrderPermissionEnd] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 30.05.2024 11:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderingPerson] [nvarchar](max) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 30.05.2024 11:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[ProductStock] [int] NOT NULL,
	[ProductPrice] [real] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240529151924_mig1', N'6.0.0')
GO
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([CompanyId], [CompanyName], [ApprovalStatus], [OrderPermissionStart], [OrderPermissionEnd]) VALUES (1, N'A Market', 1, CAST(N'2024-05-30T07:00:00.4180000' AS DateTime2), CAST(N'2024-05-30T20:00:00.4180000' AS DateTime2))
INSERT [dbo].[Companies] ([CompanyId], [CompanyName], [ApprovalStatus], [OrderPermissionStart], [OrderPermissionEnd]) VALUES (2, N'Pet Shop', 1, CAST(N'2024-05-30T12:00:00.4180000' AS DateTime2), CAST(N'2024-05-30T18:00:00.4180000' AS DateTime2))
INSERT [dbo].[Companies] ([CompanyId], [CompanyName], [ApprovalStatus], [OrderPermissionStart], [OrderPermissionEnd]) VALUES (3, N'B Restaurant', 1, CAST(N'2024-05-30T10:00:00.4180000' AS DateTime2), CAST(N'2024-05-30T23:00:00.4180000' AS DateTime2))
INSERT [dbo].[Companies] ([CompanyId], [CompanyName], [ApprovalStatus], [OrderPermissionStart], [OrderPermissionEnd]) VALUES (4, N'Clothing Market', 1, CAST(N'2024-05-30T09:00:00.4180000' AS DateTime2), CAST(N'2024-05-30T17:00:00.4180000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Companies] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (1, N'Tomato', 200, 10, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (2, N'Apple', 300, 12.3, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (3, N'Milk', 230, 20, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (4, N'detergent', 230, 23, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (5, N'Chocolate', 350, 9, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (6, N'Cat food', 400, 30, 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (7, N'cage', 500, 44.7, 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (8, N'birdseed', 200, 25, 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (9, N'pasta', 400, 14, 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (10, N'chicken', 250, 44, 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (11, N'soup', 250, 12, 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (12, N'meat dish', 300, 55, 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (13, N'sweater', 300, 70, 4)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (14, N't-shirt', 400, 60, 4)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (15, N'trousers', 700, 90, 4)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductStock], [ProductPrice], [CompanyId]) VALUES (16, N'coat', 600, 85, 4)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products_ProductId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Companies_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([CompanyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Companies_CompanyId]
GO
