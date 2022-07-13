--my sql
select problem_id 
from Problems 
where (likes/(likes+dislikes )*100)<60
order by problem_id


--SQL Server
--Runtime: 3245 ms, faster than 6.35% of MS SQL Server online submissions for Low-Quality Problems.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Low-Quality Problems.
select problem_id 
from Problems 
where (likes*100/(likes+dislikes ))<60
order by problem_id