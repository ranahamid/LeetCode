with cte as
(
    select *, row_number() over(partition by company  order by salary) as row_id,
    count(salary) over(partition by company) as salaryCount
    from Employee
)
select id, company, salary 
from cte 
where row_id between salaryCount/2.0 and salaryCount/2.0+1

--ms sql server
--Runtime: 1108 ms, faster than 73.78% of MS SQL Server online submissions for Median Employee Salary.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Median Employee Salary.


--mysql
--Runtime: 277 ms, faster than 92.20% of MySQL online submissions for Median Employee Salary.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Median Employee Salary.