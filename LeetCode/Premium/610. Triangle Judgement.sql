select x,y,z, 
case when 
    x+y>z AND x+z>y AND y+z>x 
THEN 'Yes'
ELSE 'No' END AS triangle 
FROM Triangle 

--mysql 
--Runtime: 303 ms, faster than 48.80% of MySQL online submissions for Triangle Judgement.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Triangle Judgement.

--sql server 
--Runtime: 579 ms, faster than 43.71% of MS SQL Server online submissions for Triangle Judgement.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Triangle Judgement.