select project_id , ROUND(AVG(experience_years ),2) as average_years 
from Project as p
inner join Employee as e on p.employee_id =e.employee_id 
group by project_id 

--mysql
--Runtime: 1262 ms, faster than 22.44% of MySQL online submissions for Project Employees I.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Project Employees I.




select project_id , ROUND(AVG(1.0*experience_years ),2) as average_years 
from Project as p
inner join Employee as e on p.employee_id =e.employee_id 
group by project_id 


--ms sql server
--Runtime: 4271 ms, faster than 69.56% of MS SQL Server online submissions for Project Employees I.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Project Employees I.