/* Write your T-SQL query statement below */
 SELECT top 1 
    customer_number
     
FROM     
   Orders
GROUP BY 
    customer_number
ORDER BY 
    COUNT(customer_number)  DESC;


Runtime: 788 ms, faster than 88.57% of MS SQL Server online submissions for Customer Placing the Largest Number of Orders.
Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Customer Placing the Largest Number of Orders.



    USE [LEET]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 06/27/2022 21:10:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_number] [int] NOT NULL,
	[customer_number] [int] NULL,
 CONSTRAINT [PK_Orders_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (1, 3, 5)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (2, 5, 1)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (3, 6, 5)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (4, 7, 4)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (5, 8, 6)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (6, 9, 2)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (7, 10, 4)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (8, 11, 16)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (9, 12, 3)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (10, 13, 5)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (11, 14, 3)
GO
INSERT [dbo].[Orders] ([id], [order_number], [customer_number]) VALUES (12, 15, 16)
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
