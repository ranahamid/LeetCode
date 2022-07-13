 ---MYSQL
  select p.product_id , ROUND( sum(units *price)/sum(units),2) as  average_price
  from Prices as p, UnitsSold  as u
 
  where  p.product_id = u.product_id AND purchase_date between start_date and end_date   
  group by p.product_id



   
GO
/****** Object:  Table [dbo].[Prices]    Script Date: 07/13/2022 17:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[start_date] [date] NULL,
	[end_date] [date] NULL,
	[price] [int] NULL,
 CONSTRAINT [PK_Prices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitsSold]    Script Date: 07/13/2022 17:05:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitsSold](
	[id] [int] NOT NULL,
	[product_id] [int] NULL,
	[purchase_date] [date] NULL,
	[units] [int] NULL,
 CONSTRAINT [PK_UnitsSold] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Prices] ON 
GO
INSERT [dbo].[Prices] ([id], [product_id], [start_date], [end_date], [price]) VALUES (1, 1, CAST(N'2019-02-17' AS Date), CAST(N'2019-02-28' AS Date), 5)
GO
INSERT [dbo].[Prices] ([id], [product_id], [start_date], [end_date], [price]) VALUES (2, 1, CAST(N'2019-03-01' AS Date), CAST(N'2019-03-22' AS Date), 20)
GO
INSERT [dbo].[Prices] ([id], [product_id], [start_date], [end_date], [price]) VALUES (3, 2, CAST(N'2019-02-01' AS Date), CAST(N'2019-02-20' AS Date), 15)
GO
INSERT [dbo].[Prices] ([id], [product_id], [start_date], [end_date], [price]) VALUES (4, 2, CAST(N'2019-02-21' AS Date), CAST(N'2019-03-31' AS Date), 30)
GO
SET IDENTITY_INSERT [dbo].[Prices] OFF
GO
INSERT [dbo].[UnitsSold] ([id], [product_id], [purchase_date], [units]) VALUES (1, 1, CAST(N'2019-02-25' AS Date), 100)
GO
INSERT [dbo].[UnitsSold] ([id], [product_id], [purchase_date], [units]) VALUES (2, 1, CAST(N'2019-03-01' AS Date), 15)
GO
INSERT [dbo].[UnitsSold] ([id], [product_id], [purchase_date], [units]) VALUES (3, 2, CAST(N'2019-02-10' AS Date), 200)
GO
INSERT [dbo].[UnitsSold] ([id], [product_id], [purchase_date], [units]) VALUES (4, 2, CAST(N'2019-03-22' AS Date), 30)
GO
