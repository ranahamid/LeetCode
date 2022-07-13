select id, name 
from Students 
where department_id not in(
select id 
    from Departments 
)
--MYSQL
--Runtime: 788 ms, faster than 67.39% of MySQL online submissions for Students With Invalid Departments.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Students With Invalid Departments.


--SQL SERVER
--Runtime: 1328 ms, faster than 93.59% of MS SQL Server online submissions for Students With Invalid Departments.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Students With Invalid Departments.