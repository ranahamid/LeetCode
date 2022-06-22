using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1581_Customer_Who_Visited_but_Did_Not_Make_Any_Transactions
    {


        //		GO
        //		/****** Object:  Table [dbo].[Transactions]    Script Date: 06/21/2022 22:50:30 ******/
        //		SET ANSI_NULLS ON
        //GO
        //SET QUOTED_IDENTIFIER ON
        //GO
        //CREATE TABLE[dbo].[Transactions]
        //		(

        //   [transaction_id][int] NOT NULL,

        //   [visit_id] [int] NULL,
        //	[amount] [int] NULL,
        // CONSTRAINT[PK_Transactions] PRIMARY KEY CLUSTERED
        //(
        //   [transaction_id] ASC
        //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
        //) ON[PRIMARY]
        //GO
        ///****** Object:  Table [dbo].[Visits]    Script Date: 06/21/2022 22:50:30 ******/
        //SET ANSI_NULLS ON
        //GO
        //SET QUOTED_IDENTIFIER ON
        //GO
        //CREATE TABLE[dbo].[Visits]
        //		(

        //   [visit_id][int] IDENTITY(1,1) NOT NULL,

        //  [customer_id] [int] NOT NULL,
        //CONSTRAINT[PK_Visits] PRIMARY KEY CLUSTERED
        //(
        // [visit_id] ASC
        //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
        //) ON[PRIMARY]
        //GO
        //INSERT[dbo].[Transactions]
        //		([transaction_id], [visit_id], [amount]) VALUES(2, 5, 310)
        //GO
        //INSERT[dbo].[Transactions]
        //		([transaction_id], [visit_id], [amount]) VALUES(3, 5, 300)
        //GO
        //INSERT[dbo].[Transactions]
        //		([transaction_id], [visit_id], [amount]) VALUES(9, 5, 200)
        //GO
        //INSERT[dbo].[Transactions]
        //		([transaction_id], [visit_id], [amount]) VALUES(12, 1, 910)
        //GO
        //INSERT[dbo].[Transactions]
        //		([transaction_id], [visit_id], [amount]) VALUES(13, 2, 970)
        //GO
        //SET IDENTITY_INSERT[dbo].[Visits]
        //		ON
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(1, 23)
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(2, 9)
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(3, 0)
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(4, 30)
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(5, 54)
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(6, 96)
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(7, 54)
        //GO
        //INSERT[dbo].[Visits]
        //		([visit_id], [customer_id]) VALUES(8, 54)
        //GO
        //SET IDENTITY_INSERT[dbo].[Visits]
        //		OFF
        //GO




//      
//        Runtime: 1051 ms, faster than 87.22% of MySQL online submissions for Customer Who Visited but Did Not Make Any Transactions.
//Memory Usage: 0B, less than 100.00% of MySQL online submissions for Customer Who Visited but Did Not Make Any Transactions.


  //      SELECT distinct customer_id , count(vis.visit_id) as count_no_trans
  //FROM  Visits as  vis
  //left join Transactions as tr on tr.visit_id= vis.visit_id

        //where
        //transaction_id is null 
        //group by customer_id


    }
}
