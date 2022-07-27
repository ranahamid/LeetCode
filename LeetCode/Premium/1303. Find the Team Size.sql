select  employee_id , (SELECT  COUNT(team_id) FROM Employee  WHERE E1. team_id =team_id ) AS team_size  
from Employee AS E1
group by employee_id 

-- my sql
--Runtime: 426 ms, faster than 27.65% of MySQL online submissions for Find the Team Size.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Find the Team Size.

 
select  employee_id , (SELECT  COUNT(*) FROM Employee  WHERE E1. team_id =team_id    ) AS team_size  
from Employee AS E1
group by employee_id   ,team_id
--sql server 
--Runtime: 426 ms, faster than 70.75% of MS SQL Server online submissions for Find the Team Size.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Find the Team Size.