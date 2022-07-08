--Runtime: 1225 ms, faster than 61.35% of MS SQL Server online submissions for Calculate Special Bonus.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Calculate Special Bonus.


 
SELECT   [employee_id],  

(CASE WHEN employee_id %2=1 and [name] not like  'M%' THEN  salary  ELSE  0 end )
		as bonus
  FROM  [Employees]
    order by [employee_id]



	 
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 06/24/2022 22:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NULL,
	[name] [nvarchar](50) NULL,
	[salary] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([id], [employee_id], [name], [salary]) VALUES (1, 2, N'Meir    ', 3000)
GO
INSERT [dbo].[Employees] ([id], [employee_id], [name], [salary]) VALUES (2, 3, N'Michael ', 3800)
GO
INSERT [dbo].[Employees] ([id], [employee_id], [name], [salary]) VALUES (3, 7, N'Addilyn ', 7400)
GO
INSERT [dbo].[Employees] ([id], [employee_id], [name], [salary]) VALUES (4, 8, N'Juan    ', 6100)
GO
INSERT [dbo].[Employees] ([id], [employee_id], [name], [salary]) VALUES (5, 9, N'Kannon  ', 7700)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
