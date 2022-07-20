select product_name , year, price
from Sales as s
inner join Product as p on s.product_id =p.product_id 

-- MYSQL
--Runtime: 1139 ms, faster than 89.84% of MySQL online submissions for Product Sales Analysis I.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Product Sales Analysis I




select product_name , [year], price
from Sales as s
inner join Product as p on s.product_id =p.product_id 
-- SQL Server
--Runtime: 4799 ms, faster than 100.00% of MS SQL Server online submissions for Product Sales Analysis I.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Product Sales Analysis I.