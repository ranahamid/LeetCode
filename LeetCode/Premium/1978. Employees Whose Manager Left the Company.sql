
select employee_id 
from Employees 
where salary <30000 and 
manager_id NOT IN(
select distinct employee_id 
from Employees)
order by employee_id

--mysql 
--Runtime: 279 ms, faster than 89.27% of MySQL online submissions for Employees Whose Manager Left the Company.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Employees Whose Manager Left the Company.


--ms sql server
--Runtime: 1012 ms, faster than 15.38% of MS SQL Server online submissions for Employees Whose Manager Left the Company.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Employees Whose Manager Left the Company.