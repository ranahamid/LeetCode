/* Write your T-SQL query statement below */
select w1.id from Weather as w1
, Weather w2 where w1.temperature > w2.temperature 
and datediff(DAY, w2.recordDate    ,w1.recordDate    )=1






 
/****** Object:  Table [dbo].[Weather]    Script Date: 06/23/2022 15:43:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weather](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[recordDate] [date] NULL,
	[temperature] [int] NULL,
 CONSTRAINT [PK_Weather] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Weather] ON 
GO
INSERT [dbo].[Weather] ([id], [recordDate], [temperature]) VALUES (1, CAST(N'2015-01-01' AS Date), 10)
GO
INSERT [dbo].[Weather] ([id], [recordDate], [temperature]) VALUES (2, CAST(N'2015-01-02' AS Date), 25)
GO
INSERT [dbo].[Weather] ([id], [recordDate], [temperature]) VALUES (3, CAST(N'2015-01-03' AS Date), 20)
GO
INSERT [dbo].[Weather] ([id], [recordDate], [temperature]) VALUES (4, CAST(N'2015-01-04' AS Date), 30)
GO
SET IDENTITY_INSERT [dbo].[Weather] OFF
GO
