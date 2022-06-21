using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1741_Find_Total_Time_Spent_by_Each_Employee
    {


        //		SET ANSI_NULLS ON
        //		GO
        //SET QUOTED_IDENTIFIER ON
        //GO
        //CREATE TABLE[dbo].[Employees]
        //		(

        //   [Id][int] IDENTITY(1,1) NOT NULL,

        //  [emp_id] [int] NULL,
        //	[event_day] [date] NULL,
        //	[in_time] [int] NULL,
        //	[out_time] [int] NULL,
        // CONSTRAINT[PK_Employees] PRIMARY KEY CLUSTERED
        //(
        //   [Id] ASC
        //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
        //) ON[PRIMARY]
        //GO
        //SET IDENTITY_INSERT[dbo].[Employees]
        //		ON
        //GO
        //INSERT[dbo].[Employees] ([Id], [emp_id], [event_day], [in_time], [out_time]) VALUES(1, 1, CAST(N'2020-11-28' AS Date), 4, 32)
        //GO
        //INSERT[dbo].[Employees] ([Id], [emp_id], [event_day], [in_time], [out_time]) VALUES(2, 1, CAST(N'2020-11-28' AS Date), 55, 200)
        //GO
        //INSERT[dbo].[Employees] ([Id], [emp_id], [event_day], [in_time], [out_time]) VALUES(3, 1, CAST(N'2020-12-03' AS Date), 1, 42)
        //GO
        //INSERT[dbo].[Employees] ([Id], [emp_id], [event_day], [in_time], [out_time]) VALUES(4, 2, CAST(N'2020-11-28' AS Date), 3, 33)
        //GO
        //INSERT[dbo].[Employees] ([Id], [emp_id], [event_day], [in_time], [out_time]) VALUES(5, 2, CAST(N'2020-12-09' AS Date), 47, 74)
        //GO
        //SET IDENTITY_INSERT[dbo].[Employees]
        //		OFF
        //GO


        //        Runtime: 1020 ms, faster than 18.12% of MS SQL Server online submissions for Find Total Time Spent by Each Employee.
        //Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Find Total Time Spent by Each Employee.



        //SELECT[event_day] as day,[emp_id] , SUM(out_time-in_time) as total_time
        //FROM[Employees]
        //  GROUP by emp_id,event_day
        //  order by event_day

    }
}
