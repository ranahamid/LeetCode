using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1693_Daily_Leads_and_Partners
    {



        //        SET ANSI_NULLS ON
        //        GO
        //SET QUOTED_IDENTIFIER ON
        //GO
        //CREATE TABLE[dbo].[DailySales]
        //        (

        //   [Id][int] IDENTITY(1,1) NOT NULL,

        //  [date_id] [date] NULL,
        //	[make_name] [nchar] (10) NULL,
        //	[lead_id] [int] NULL,
        //	[partner_id] [int] NULL,
        // CONSTRAINT[PK_DailySales] PRIMARY KEY CLUSTERED
        //(
        //   [Id] ASC
        //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
        //) ON[PRIMARY]
        //GO
        //SET IDENTITY_INSERT[dbo].[DailySales]
        //        ON
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(1, CAST(N'2020-12-08' AS Date), N'toyota    ', 0, 1)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(2, CAST(N'2020-12-08' AS Date), N'toyota    ', 1, 0)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(3, CAST(N'2020-12-08' AS Date), N'toyota    ', 1, 2)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(4, CAST(N'2020-12-07' AS Date), N'toyota    ', 0, 2)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(5, CAST(N'2020-12-07' AS Date), N'toyota    ', 0, 1)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(6, CAST(N'2020-12-08' AS Date), N'honda     ', 1, 2)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(7, CAST(N'2020-12-08' AS Date), N'honda     ', 2, 1)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(8, CAST(N'2020-12-07' AS Date), N'honda     ', 0, 1)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(9, CAST(N'2020-12-07' AS Date), N'honda     ', 1, 2)
        //GO
        //INSERT[dbo].[DailySales] ([Id], [date_id], [make_name], [lead_id], [partner_id]) VALUES(10, CAST(N'2020-12-07' AS Date), N'honda     ', 2, 1)
        //GO
        //SET IDENTITY_INSERT[dbo].[DailySales]
        //        OFF
        //GO



        //        Runtime: 456 ms, faster than 90.60% of MySQL online submissions for Daily Leads and Partners.
        //Memory Usage: 0B, less than 100.00% of MySQL online submissions for Daily Leads and Partners.


        //      SELECT date_id, make_name, count( distinct lead_id) as unique_leads , count(distinct partner_id)as unique_partners
        //       FROM DailySales
        //       group by date_id, make_name
        //order by make_name desc
    }
}
