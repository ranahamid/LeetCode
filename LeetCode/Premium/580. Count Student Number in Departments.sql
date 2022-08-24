select dept_name , count(student_id ) as student_number
from Department as d
left join Student as s on d.dept_id =s.dept_id 
group by dept_name 
order by student_number desc, dept_name

--sql server
--Runtime: 699 ms, faster than 87.06% of MS SQL Server online submissions for Count Student Number in Departments.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Count Student Number in Departments.


--my sql
--Runtime: 665 ms, faster than 90.45% of MySQL online submissions for Count Student Number in Departments.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Count Student Number in Departments.