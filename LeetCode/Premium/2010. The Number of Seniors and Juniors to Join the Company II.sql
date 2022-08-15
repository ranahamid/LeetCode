--with a as 
--(
--    select *, SUM(salary) over(partition by experience order by salary) as budget
--    from Candidates 
--),

--b as 
--(
--    select employee_id ,budget from a where experience ='Senior' AND budget<=70000
--),
--c as 
--(
--       select employee_id  from a where budget<=70000 - (select ifnull(max(budget),0) from b)
--)

--select employee_id from b
--union

--select employee_id from c

--MY SQL
--Runtime: 461 ms, faster than 78.97% of MySQL online submissions for The Number of Seniors and Juniors to Join the Company II.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for The Number of Seniors and Juniors to Join the Company II.



with a as 
(
    select *, SUM(salary) over(partition by experience order by salary) as budget
    from Candidates 
),

b as 
(
    select employee_id ,budget from a where experience ='Senior' AND budget<=70000
),
c as 
(
       select employee_id  from a where budget<=70000 - (select isnull(max(budget),0) from b)
)

select employee_id from b
union

select employee_id from c


--MS SQL SERVER
--Runtime: 966 ms, faster than 69.81% of MS SQL Server online submissions for The Number of Seniors and Juniors to Join the Company II.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for The Number of Seniors and Juniors to Join the Company II.