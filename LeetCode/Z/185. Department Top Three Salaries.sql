select d.name  as Department ,e.name  as Employee , salary  as Salary 
from  Department  as d,Employee as e
WHERE d.id =e.departmentId AND 
(
    select count(distinct  salary)
    from Employee 
    where departmentId = d.id AND 
    salary > e.salary 
)<3
order by salary desc

--sql server
--Runtime: 774 ms, faster than 71.82% of MS SQL Server online submissions for Department Top Three Salaries.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Department Top Three Salaries.

--my sql
--Runtime: 1021 ms, faster than 55.12% of MySQL online submissions for Department Top Three Salaries.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Department Top Three Salaries.