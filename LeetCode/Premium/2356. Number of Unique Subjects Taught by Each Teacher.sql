select distinct teacher_id ,count(distinct subject_id )cnt 
from teacher
group by teacher_id 


--mysql 
--Runtime: 629 ms, faster than 100.00% of MySQL online submissions for Number of Unique Subjects Taught by Each Teacher.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Number of Unique Subjects Taught by Each Teacher.


--sql server
--Runtime: 2454 ms, faster than 100.00% of MS SQL Server online submissions for Number of Unique Subjects Taught by Each Teacher.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Number of Unique Subjects Taught by Each Teacher.