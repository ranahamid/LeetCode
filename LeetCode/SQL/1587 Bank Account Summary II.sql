


SELECT   distinct u.name, sum( t.amount ) as balance
  FROM  Users as u
	inner join Transactions as t on u.account= t.account
	
	group by t.account, u.name 
	having sum(t.amount) > 10000



SQL Table


USE [LEET]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 06/23/2022 10:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[trans_id] [int] IDENTITY(1,1) NOT NULL,
	[account] [int] NULL,
	[amount] [int] NULL,
	[transacted_on] [date] NULL,
 CONSTRAINT [PK_Transactions2] PRIMARY KEY CLUSTERED 
(
	[trans_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06/23/2022 10:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[account] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Transactions] ON 
GO
INSERT [dbo].[Transactions] ([trans_id], [account], [amount], [transacted_on]) VALUES (1, 900001, 7000, NULL)
GO
INSERT [dbo].[Transactions] ([trans_id], [account], [amount], [transacted_on]) VALUES (2, 900001, 7000, NULL)
GO
INSERT [dbo].[Transactions] ([trans_id], [account], [amount], [transacted_on]) VALUES (3, 900001, -3000, NULL)
GO
INSERT [dbo].[Transactions] ([trans_id], [account], [amount], [transacted_on]) VALUES (4, 900002, 1000, NULL)
GO
INSERT [dbo].[Transactions] ([trans_id], [account], [amount], [transacted_on]) VALUES (5, 900003, 6000, NULL)
GO
INSERT [dbo].[Transactions] ([trans_id], [account], [amount], [transacted_on]) VALUES (6, 900003, 6000, NULL)
GO
INSERT [dbo].[Transactions] ([trans_id], [account], [amount], [transacted_on]) VALUES (7, 900003, -4000, NULL)
GO
SET IDENTITY_INSERT [dbo].[Transactions] OFF
GO
INSERT [dbo].[Users] ([account], [name]) VALUES (900001, N'Alice        ')
GO
INSERT [dbo].[Users] ([account], [name]) VALUES (900002, N'Bob          ')
GO
INSERT [dbo].[Users] ([account], [name]) VALUES (900003, N'Charlie      ')
GO
