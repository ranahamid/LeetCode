  select id,
  CASE
    WHEN p_id is null THEN 'Root' 
    WHEN p_id is not  null and id in(
									select p_id 
									from tree
									) then 'Inner'
	ELSE 'Leaf'
END as type  

  from tree


--  sql server
--  Runtime: 1249 ms, faster than 10.72% of MS SQL Server online submissions for Tree Node.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Tree Node.



--mysql
--Runtime: 844 ms, faster than 16.19% of MySQL online submissions for Tree Node.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Tree Node.








 
GO
/****** Object:  Table [dbo].[Tree]    Script Date: 07/22/2022 15:21:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tree](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[p_id] [int] NULL,
 CONSTRAINT [PK_Tree] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tree] ON 
GO
INSERT [dbo].[Tree] ([id], [p_id]) VALUES (1, NULL)
GO
INSERT [dbo].[Tree] ([id], [p_id]) VALUES (2, 1)
GO
INSERT [dbo].[Tree] ([id], [p_id]) VALUES (3, 1)
GO
INSERT [dbo].[Tree] ([id], [p_id]) VALUES (4, 2)
GO
INSERT [dbo].[Tree] ([id], [p_id]) VALUES (5, 2)
GO
SET IDENTITY_INSERT [dbo].[Tree] OFF
GO
