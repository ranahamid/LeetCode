select min(a.x-b.x) as shortest 
from point a, point b
where a.x>b.x
-- MY SQL
--Runtime: 245 ms, faster than 76.54% of MySQL online submissions for Shortest Distance in a Line.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Shortest Distance in a Line.


-- T-SQL
--Runtime: 789 ms, faster than 25.25% of MS SQL Server online submissions for Shortest Distance in a Line.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Shortest Distance in a Line.