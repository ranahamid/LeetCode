/* Write your T-SQL query statement below */
select count(distinct customer_id ) as rich_count 
from Store
where amount>500


--Runtime: 656 ms, faster than 100.00% of MS SQL Server online submissions for The Number of Rich Customers.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for The Number of Rich Customers.


--my sql
--Runtime: 350 ms, faster than 93.42% of MySQL online submissions for The Number of Rich Customers.
-- Memory Usage: 0B, less than 100.00% of MySQL online submissions for The Number of Rich Customers.
