
-- 
--     Runtime: 1197 ms, faster than 23.48% of MS SQL Server online submissions for Employees Earning More Than Their Managers.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Employees Earning More Than Their Managers.

select a.name  as Employee
from Employee as a
         inner join Employee as b on a.managerId=b.id
where a.salary>b.salary



--     Runtime: 866 ms, faster than 63.35% of MS SQL Server online submissions for Employees Earning More Than Their Managers.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Employees Earning More Than Their Managers.
select a.name  as Employee
from Employee as a

where a.salary>
      (
          SELECT b.salary from
              Employee as b
          where a.managerId=b.id
      )
      
      

    USE [LEET]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 06/30/2022 22:02:03 ******/
SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Employee](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [name] [nchar](100) NULL,
    [salary] [int] NULL,
    [managerId] [int] NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO
    SET IDENTITY_INSERT [dbo].[Employee] ON
    GO
    INSERT [dbo].[Employee] ([id], [name], [salary], [managerId]) VALUES (1, N'Joe                                                                                                 ', 70000, 3)
    GO
    INSERT [dbo].[Employee] ([id], [name], [salary], [managerId]) VALUES (2, N'Henry                                                                                               ', 80000, 4)
    GO
    INSERT [dbo].[Employee] ([id], [name], [salary], [managerId]) VALUES (3, N'Sam                                                                                                 ', 60000, NULL)
    GO
    INSERT [dbo].[Employee] ([id], [name], [salary], [managerId]) VALUES (4, N'Max                                                                                                 ', 90000, NULL)
    GO
    SET IDENTITY_INSERT [dbo].[Employee] OFF
    GO
