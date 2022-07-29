
select sale_date,
(sum(case when fruit='apples' then sold_num else -sold_num   end)) as diff         
from Sales 
group by Sale_date

--ms sql server
--Runtime: 463 ms, faster than 75.81% of MS SQL Server online submissions for Apples & Oranges.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Apples & Oranges.