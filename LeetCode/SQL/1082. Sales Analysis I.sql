


--Runtime: 5704 ms, faster than 9.75% of MS SQL Server online submissions for Sales Analysis I.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Sales Analysis I.
select top 1 with ties seller_id 
from Sales 
group by seller_id
order by sum(price) desc