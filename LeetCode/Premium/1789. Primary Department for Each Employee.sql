select distinct employee_id , department_id 
from Employee 
where primary_flag ='Y'

UNION 

select distinct employee_id , department_id 
from Employee 
group by employee_id 
having count(employee_id)=1 

--MY SQL




/* Write your T-SQL query statement below */
select distinct employee_id , department_id 
from Employee 
where primary_flag ='Y'

UNION 

select distinct employee_id , department_id 
from Employee 
group by employee_id , department_id 
having count(employee_id)=1 
and employee_id not in 
(
select  employee_id
from Employee 
where primary_flag ='Y'
)



-- MS SQL
--Runtime: 662 ms, faster than 92.92% of MS SQL Server online submissions for Primary Department for Each Employee.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Primary Department for Each Employee.