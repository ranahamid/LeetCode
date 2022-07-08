/* Write your T-SQL query statement below */
select distinct author_id as id
from Views
where author_id =viewer_id

-- 
--     Runtime: 2392 ms, faster than 23.16% of MS SQL Server online submissions for Article Views I.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Article Views I.