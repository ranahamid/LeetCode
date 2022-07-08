-- Runtime: 629 ms, faster than 67.23% of MS SQL Server online submissions for Employees With Missing Information.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Employees With Missing Information.
--     
    
select e.employee_id
from Employees  as e
         left join Salaries as s  on e.employee_id =s.employee_id
where  salary    is null

UNION

select s.employee_id
from   Salaries as s
           left join  Employees as e  on e.employee_id =s.employee_id
where name is null
order by employee_id
