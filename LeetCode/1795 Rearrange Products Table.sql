 

       SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[Products]
       (

  [product_id][int] NOT NULL,

  [store1] [int] NULL,
	[store2] [int] NULL,
	[store3] [int] NULL,
CONSTRAINT[PK_Products] PRIMARY KEY CLUSTERED
(
  [product_id] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY]
GO
INSERT[dbo].[Products]
       ([product_id], [store1], [store2], [store3]) VALUES(0, 95, 100, 105)
GO
INSERT[dbo].[Products]
       ([product_id], [store1], [store2], [store3]) VALUES(1, 70, NULL, 80)
GO



--SQL Server

select product_id, 'store1' as store ,[store1] as price from Products where[store1] is not null UNION
        select product_id, 'store2' as store ,[store2] as price from Products where[store2] is not null  UNION
        select product_id, 'store3' as store ,[store3] as price from Products where[store3] is not null 
 