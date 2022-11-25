select e1. employee_id  as employee_id 
from Employees  as e1 ,  Employees  as e2,  Employees  as e3
where 
    e1.employee_id !=1 AND 
    e1.manager_id =e2.employee_id AND 
     e2.manager_id =e3.employee_id AND 
     e3.manager_id=1

     --Runtime 490 ms Beats 50.42%




select e1. employee_id  as employee_id 
from Employees  as e1 join   Employees  as e2 on    e1.manager_id =e2.employee_id
join    Employees  as e3 on  e2.manager_id =e3.employee_id
where 
    e1.employee_id !=1 AND 
     e3.manager_id=1