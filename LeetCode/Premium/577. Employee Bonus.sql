select name,  bonus
from Employee as e
left join Bonus as b on e.empId       =b.empId       
where bonus  <1000  OR bonus is null

--sql server
--Runtime: 936 ms, faster than 99.27% of MS SQL Server online submissions for Employee Bonus.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Employee Bonus.



--mysql 
--Runtime: 1253 ms, faster than 31.34% of MySQL online submissions for Employee Bonus.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Employee Bonus.