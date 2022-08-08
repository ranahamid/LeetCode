select gender, day, sum(score_points ) over (partition by gender order by day) as total 
from Scores  


--mysql 
--Runtime: 1602 ms, faster than 81.60% of MS SQL Server online submissions for Running Total for Different Genders.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Running Total for Different Genders.

--SQL Server.
--Runtime: 3137 ms, faster than 12.00% of MS SQL Server online submissions for Running Total for Different Genders.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Running Total for Different Genders.

select gender, day, (select sum(score_points ) 
from Scores  s1
where s1.gender=s2.gender AND s1.day<=s2.day) as total from Scores as s2
group by gender , day
order by gender ,day 

--Runtime: 1850 ms, faster than 64.00% of MS SQL Server online submissions for Running Total for Different Genders.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Running Total for Different Genders.