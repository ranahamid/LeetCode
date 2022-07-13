/* Write your T-SQL query statement below */
select lower(trim(product_name) ) as product_name ,
 left(sale_date  ,7) as sale_date ,
count(*) as total 
from Sales 
group by lower(trim(product_name) ) , left(sale_date  ,7)
order by product_name asc, sale_date

--Runtime: 993 ms, faster than 66.67% of MS SQL Server online submissions for Fix Product Name Format.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Fix Product Name Format.