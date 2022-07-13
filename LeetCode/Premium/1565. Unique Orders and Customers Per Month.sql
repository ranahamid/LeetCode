  --SQL Server
  --Runtime: 1614 ms, faster than 83.33% of MS SQL Server online submissions for Unique Orders and Customers Per Month.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Unique Orders and Customers Per Month.
  select  LEFT(order_date, 7) as month,
  count(order_id )as order_count ,
  count(distinct customer_id  )as customer_count  
  from orders 
  where invoice>20
  group by  LEFT(order_date, 7)


  --mysql
  --Runtime: 3072 ms, faster than 5.01% of MySQL online submissions for Unique Orders and Customers Per Month.
-- Memory Usage: 0B, less than 100.00% of MySQL online submissions for Unique Orders and Customers Per Month.


 
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 07/13/2022 17:19:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] NULL,
	[order_date] [date] NULL,
	[customer_id] [int] NULL,
	[invoice] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (1, CAST(N'2020-09-15' AS Date), 1, 30)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (2, CAST(N'2020-09-17' AS Date), 2, 90)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (3, CAST(N'2020-10-06' AS Date), 3, 20)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (4, CAST(N'2020-10-20' AS Date), 3, 21)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (5, CAST(N'2020-11-10' AS Date), 1, 10)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (6, CAST(N'2020-11-21' AS Date), 2, 15)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (7, CAST(N'2020-12-01' AS Date), 4, 55)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (8, CAST(N'2020-12-03' AS Date), 4, 77)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (9, CAST(N'2021-01-07' AS Date), 3, 31)
GO
INSERT [dbo].[Orders] ([order_id], [order_date], [customer_id], [invoice]) VALUES (10, CAST(N'2021-01-15' AS Date), 2, 20)
GO
