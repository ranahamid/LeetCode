select 
sum(case WHEN DAYOFWEEK(submit_date ) in (1,7) then 1 else 0  end)as weekend_cnt,
sum(case WHEN DAYOFWEEK(submit_date ) in (2,3,4,5,6) then 1 else 0  end)as working_cnt 
from Tasks 

--my sql 
--Runtime: 337 ms, faster than 96.59% of MySQL online submissions for Tasks Count in the Weekend.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Tasks Count in the Weekend.





select 
sum(case WHEN DATEPART(dw,submit_date ) in (1,7) then 1 else 0  end)as weekend_cnt,
sum(case WHEN DATEPART(dw,submit_date ) in (2,3,4,5,6) then 1 else 0  end)as working_cnt 
from Tasks 

--MS SQL SERVER
--Runtime: 706 ms, faster than 80.00% of MS SQL Server online submissions for Tasks Count in the Weekend.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Tasks Count in the Weekend.