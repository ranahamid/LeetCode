using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1757_Recyclable_and_Low_Fat_Products
    {

        //GO
        //SET ANSI_NULLS ON
        //GO
        //SET QUOTED_IDENTIFIER ON
        //GO
        //CREATE TABLE[dbo].[Products]
        //        (

        //   [product_id][int] IDENTITY(1,1) NOT NULL,

        //  [low_fats] [nchar] (10) NULL,
        //	[recyclable] [nchar] (10) NULL,
        // CONSTRAINT[PK_Products] PRIMARY KEY CLUSTERED
        //(
        //   [product_id] ASC
        //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
        //) ON[PRIMARY]
        //GO
        //SET IDENTITY_INSERT[dbo].[Products]
        //        ON
        //GO
        //INSERT[dbo].[Products]
        //        ([product_id], [low_fats], [recyclable]) VALUES(1, N'Y         ', N'N         ')
        //GO
        //INSERT[dbo].[Products]
        //        ([product_id], [low_fats], [recyclable]) VALUES(2, N'Y         ', N'Y         ')
        //GO
        //INSERT[dbo].[Products]
        //        ([product_id], [low_fats], [recyclable]) VALUES(3, N'N         ', N'Y         ')
        //GO
        //INSERT[dbo].[Products]
        //        ([product_id], [low_fats], [recyclable]) VALUES(4, N'Y         ', N'Y         ')
        //GO
        //INSERT[dbo].[Products]
        //        ([product_id], [low_fats], [recyclable]) VALUES(5, N'N         ', N'N         ')
        //GO
        //SET IDENTITY_INSERT[dbo].[Products]
        //        OFF
        //GO



        //Runtime: 668 ms, faster than 93.17% of MS SQL Server online submissions for Recyclable and Low Fat Products.
        //Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Recyclable and Low Fat Products.

        //SELECT product_id  FROM Products WHERE low_fats = 'Y' AND recyclable = 'Y'
    }
}
