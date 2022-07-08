# Write your MySQL query statement below

SELECT  
       id, 
	   sum(CASE  WHEN month =  'Jan' THEN revenue   END) as Jan_Revenue,
	   sum(CASE  WHEN month =  'Feb' THEN revenue   END) as Feb_Revenue,
	   sum(CASE  WHEN month =  'Mar' THEN revenue   END) as Mar_Revenue,
	   sum(CASE  WHEN month =  'Apr' THEN revenue   END) as Apr_Revenue,

	   sum(CASE  WHEN month =  'May' THEN revenue   END) as May_Revenue,
	   sum(CASE  WHEN month =  'Jun' THEN revenue   END) as Jun_Revenue,
	   sum(CASE  WHEN month =  'Jul' THEN revenue   END) as Jul_Revenue,
	   sum(CASE  WHEN month =  'Aug' THEN revenue   END) as Aug_Revenue,

	   sum(CASE  WHEN month =  'Sep' THEN revenue   END) as Sep_Revenue,
	   sum(CASE  WHEN month =  'Oct' THEN revenue   END) as Oct_Revenue,
	   sum(CASE  WHEN month =  'Nov' THEN revenue   END) as Nov_Revenue,
	   sum(CASE  WHEN month =  'Dec' THEN revenue   END) as Dec_Revenue
       
     
  FROM  Department
  group by id



 
GO
/****** Object:  Table [dbo].[Department]    Script Date: 06/23/2022 15:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[idUNIQUE] [int] IDENTITY(1,1) NOT NULL,
	[id] [int] NULL,
	[revenue] [int] NULL,
	[month] [nvarchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[idUNIQUE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 
GO
INSERT [dbo].[Department] ([idUNIQUE], [id], [revenue], [month]) VALUES (1, 1, 8000, N'Jan   ')
GO
INSERT [dbo].[Department] ([idUNIQUE], [id], [revenue], [month]) VALUES (2, 2, 9000, N'Jan   ')
GO
INSERT [dbo].[Department] ([idUNIQUE], [id], [revenue], [month]) VALUES (3, 3, 10000, N'Feb')
GO
INSERT [dbo].[Department] ([idUNIQUE], [id], [revenue], [month]) VALUES (4, 1, 7000, N'Feb')
GO
INSERT [dbo].[Department] ([idUNIQUE], [id], [revenue], [month]) VALUES (5, 1, 6000, N'Mar')
GO
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
