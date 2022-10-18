 select m.employee_id ,m.name , count(e.employee_id)as reports_count, ROUND(avg(e.age )) as average_age
from Employees as m 
inner join Employees as e on m.employee_id = e.reports_to 
group by employee_id 
order by employee_id 

--MY SQL 
--Runtime 685 ms Beats 80.40%


select m.employee_id ,m.name , count(e.employee_id)as reports_count, Round(avg(e.age*1.0 ),0) as average_age
from Employees as m 
inner join Employees as e on m.employee_id = e.reports_to 
group by m.employee_id, m.name 
order by m.employee_id 

--SQL Server
--Runtime 1276 ms Beats 93.10%