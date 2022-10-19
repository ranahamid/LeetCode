with cte as(
select project_id  , count(employee_id ) as count
from Project 
group by project_id 

)

select top 1 with ties project_id
from cte
order by count desc 

--Runtime
--4496 ms
--Beats
--49.32%
--SQL SERVER