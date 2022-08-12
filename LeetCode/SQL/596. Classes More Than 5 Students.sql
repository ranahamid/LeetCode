select class
from courses
group by class
having count(student)>=5

--MY SQL
--Runtime: 436 ms, faster than 34.07% of MySQL online submissions for Classes More Than 5 Students.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Classes More Than 5 Students.



--SQL Server
--Runtime: 1183 ms, faster than 64.27% of MS SQL Server online submissions for Classes More Than 5 Students.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Classes More Than 5 Students.