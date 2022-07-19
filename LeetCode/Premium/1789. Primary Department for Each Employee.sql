select distinct employee_id , department_id 
from Employee 
where primary_flag ='Y'

UNION 

select distinct employee_id , department_id 
from Employee 
group by employee_id 
having count(employee_id)=1 

