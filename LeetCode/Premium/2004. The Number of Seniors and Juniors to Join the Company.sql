with a as 
(
    select *, SUM(salary) over(partition by experience order by salary) as budget
    from Candidates 
),

b as 
(
    select  employee_id, budget , 'Senior' as type  from a where experience ='Senior' AND budget<=70000
),
c as 
(
       select  employee_id , 'Junior' as type from a where experience ='Junior' AND budget<=70000 - (select isnull(max(budget),0) from b)
),

d as(
select  type  as experience,  employee_id   from b 
union
select  type  as experience ,  employee_id  from c
UNION 
    select 'Senior' as experience , null as employee_id
 UNION 
    select 'Junior' as experience , null as employee_id    
)
 
select   experience , sum( 

    case when employee_id is null then 0 else 1 end
) as 'accepted_candidates'
from d
group by experience

--SQL Server
--Runtime: 744 ms, faster than 100.00% of MS SQL Server online submissions for The Number of Seniors and Juniors to Join the Company.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for The Number of Seniors and Juniors to Join the Company.


--with a as 
--(
--    select *, SUM(salary) over(partition by experience order by salary) as budget
--    from Candidates 
--),

--b as 
--(
--    select   employee_id, budget , 'Senior' as type  from a where experience ='Senior' AND budget<=70000
--),
--c as 
--(
--       select   employee_id , 'Junior' as type from a where experience ='Junior' AND budget<=70000 - (select ifnull(max(budget),0) from b)
--),

--d as(
--select   type  as experience,  employee_id   from b 
--union
--select   type  as experience ,  employee_id  from c
--UNION 
--    select 'Senior' as experience , null as employee_id
-- UNION 
--    select 'Junior' as experience , null as employee_id    
--)
 
--select   experience , sum( 

--    case when employee_id is null then 0 else 1 end
--) as 'accepted_candidates'
--from d
--group by experience

--my sql
--Runtime: 521 ms, faster than 63.50% of MySQL online submissions for The Number of Seniors and Juniors to Join the Company.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for The Number of Seniors and Juniors to Join the Company.