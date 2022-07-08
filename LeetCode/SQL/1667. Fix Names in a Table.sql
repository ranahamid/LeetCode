/* Write your T-SQL query statement below */
select user_id, upper( substring( name,1,1))+  lower(substring( name,2,len(name)) ) as name
from users
order by user_id 

--Runtime: 2242 ms, faster than 35.78% of MS SQL Server online submissions for Fix Names in a Table.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Fix Names in a Table.