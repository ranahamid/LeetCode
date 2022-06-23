Runtime: 2844 ms, faster than 56.50% of MS SQL Server online submissions for Game Play Analysis I.
Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Game Play Analysis I.

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT player_id ,  min(event_date )as first_login 
  FROM  Activity
  group by player_id


  USE [LEET]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 06/23/2022 19:39:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[time_stamp] [datetime] NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Logins] ON 
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (1, 6, CAST(N'2020-06-30T15:06:07.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (2, 6, CAST(N'2021-04-21T14:06:06.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (3, 6, CAST(N'2019-03-07T00:18:15.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (4, 8, CAST(N'2020-02-01T05:10:53.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (5, 8, CAST(N'2020-12-30T00:46:50.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (6, 2, CAST(N'2020-01-16T02:49:50.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (7, 2, CAST(N'2019-08-25T07:59:08.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (8, 14, CAST(N'2019-07-14T09:00:00.000' AS DateTime))
GO
INSERT [dbo].[Logins] ([id], [user_id], [time_stamp]) VALUES (9, 14, CAST(N'2021-01-06T11:59:59.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Logins] OFF
GO
