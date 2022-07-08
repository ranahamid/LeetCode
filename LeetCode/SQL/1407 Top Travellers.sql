--  Runtime: 1101 ms, faster than 80.88% of MS SQL Server online submissions for Top Travellers.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Top Travellers.
  
  
  select   u.name , ISNULL( sum(r.distance), 0) as travelled_distance 
  from users as u
  left join rides as r  on u.id =r.user_id
  group by u.id, u.name
  order by travelled_distance desc 


  USE [LEET]
GO
/****** Object:  Table [dbo].[Rides]    Script Date: 06/24/2022 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rides](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[distance] [int] NULL,
 CONSTRAINT [PK_Rides] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 06/24/2022 14:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[pKey] [int] IDENTITY(1,1) NOT NULL,
	[id] [int] NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users1] PRIMARY KEY CLUSTERED 
(
	[pKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Rides] ON 
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (1, 1, 120)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (2, 2, 317)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (3, 3, 222)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (4, 7, 100)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (5, 13, 312)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (6, 19, 50)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (7, 7, 120)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (8, 19, 400)
GO
INSERT [dbo].[Rides] ([id], [user_id], [distance]) VALUES (9, 7, 230)
GO
SET IDENTITY_INSERT [dbo].[Rides] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([pKey], [id], [name]) VALUES (1, 1, N'Alice     ')
GO
INSERT [dbo].[Users] ([pKey], [id], [name]) VALUES (2, 2, N'Bob       ')
GO
INSERT [dbo].[Users] ([pKey], [id], [name]) VALUES (3, 3, N'Alex      ')
GO
INSERT [dbo].[Users] ([pKey], [id], [name]) VALUES (4, 4, N'Donald    ')
GO
INSERT [dbo].[Users] ([pKey], [id], [name]) VALUES (5, 7, N'Lee       ')
GO
INSERT [dbo].[Users] ([pKey], [id], [name]) VALUES (6, 13, N'Jonathan  ')
GO
INSERT [dbo].[Users] ([pKey], [id], [name]) VALUES (7, 19, N'Elvis     ')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
