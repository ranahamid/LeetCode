
/* Write your T-SQL query statement below */
select name
from Customer
where referee_id != 2 or referee_id is null


USE [LEET]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 06/27/2022 14:45:31 ******/
SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Customer](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [name] [varchar](50) NULL,
    [referee_id] [int] NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
    SET IDENTITY_INSERT [dbo].[Customer] ON
    GO
    INSERT [dbo].[Customer] ([id], [name], [referee_id]) VALUES (1, N'Will ', NULL)
    GO
    INSERT [dbo].[Customer] ([id], [name], [referee_id]) VALUES (2, N'Jane ', NULL)
    GO
    INSERT [dbo].[Customer] ([id], [name], [referee_id]) VALUES (3, N'Alex ', 2)
    GO
    INSERT [dbo].[Customer] ([id], [name], [referee_id]) VALUES (4, N'Bill ', NULL)
    GO
    INSERT [dbo].[Customer] ([id], [name], [referee_id]) VALUES (5, N'Zack ', 1)
    GO
    INSERT [dbo].[Customer] ([id], [name], [referee_id]) VALUES (6, N'Mark ', 2)
    GO
    SET IDENTITY_INSERT [dbo].[Customer] OFF
    GO
