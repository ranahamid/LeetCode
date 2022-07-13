select customer_id 
from Customers

where year=2021
group by customer_id

having sum(revenue) > 0


--  Runtime: 1285 ms, faster than 32.91% of MS SQL Server online submissions for Find Customers With Positive Revenue this Year.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Find Customers With Positive Revenue this Year.