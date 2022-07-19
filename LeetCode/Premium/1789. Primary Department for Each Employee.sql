select distinct employee_id , department_id 
from Employee 
where primary_flag ='Y'

UNION 

select distinct employee_id , department_id 
from Employee 
group by employee_id 
having count(employee_id)=1 

--MY SQL




/* Write your T-SQL query statement below */
select distinct employee_id , department_id 
from Employee 
where primary_flag ='Y'

UNION 

select distinct employee_id , department_id 
from Employee 
group by employee_id , department_id 
having count(employee_id)=1 
and employee_id not in 
(
select  employee_id
from Employee 
where primary_flag ='Y'
)



-- MS SQL
--Runtime: 662 ms, faster than 92.92% of MS SQL Server online submissions for Primary Department for Each Employee.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Primary Department for Each Employee.



 
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 07/19/2022 15:51:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [int] NULL,
	[department_id] [int] NULL,
	[primary_flag] [nchar](10) NULL,
 CONSTRAINT [PK_Employee1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([id], [employee_id], [department_id], [primary_flag]) VALUES (1, 1, 1, N'N         ')
GO
INSERT [dbo].[Employee] ([id], [employee_id], [department_id], [primary_flag]) VALUES (2, 2, 1, N'Y         ')
GO
INSERT [dbo].[Employee] ([id], [employee_id], [department_id], [primary_flag]) VALUES (3, 2, 2, N'N         ')
GO
INSERT [dbo].[Employee] ([id], [employee_id], [department_id], [primary_flag]) VALUES (4, 3, 3, N'N         ')
GO
INSERT [dbo].[Employee] ([id], [employee_id], [department_id], [primary_flag]) VALUES (5, 4, 2, N'N         ')
GO
INSERT [dbo].[Employee] ([id], [employee_id], [department_id], [primary_flag]) VALUES (6, 4, 3, N'Y         ')
GO
INSERT [dbo].[Employee] ([id], [employee_id], [department_id], [primary_flag]) VALUES (7, 4, 4, N'N         ')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
