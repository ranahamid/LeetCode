select user_id , sum(quantity *price) as spending 
from Sales as s
inner join Product as p on s.product_id =p.product_id 
group by user_id
order by spending desc, user_id 

--my sql
--Runtime: 691 ms, faster than 85.31% of MySQL online submissions for Product Sales Analysis V.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Product Sales Analysis V.



--sql server 
--Runtime: 1535 ms, faster than 58.33% of MS SQL Server online submissions for Product Sales Analysis V.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Product Sales Analysis V.