 
select distinct b.user_id
from Confirmations as a, Confirmations  as b
where 
a.user_id=b.user_id AND
a.time_stamp  != b.time_stamp          AND 
b.time_stamp  between a.time_stamp    and dateadd(HOUR, 24, a.time_stamp) 
order by b.user_id


--sql server
--Runtime: 1292 ms, faster than 92.45% of MS SQL Server online submissions for Users That Actively Request Confirmation Messages.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Users That Actively Request Confirmation Messages.






--select distinct b.user_id
--from Confirmations as a, Confirmations  as b
--where 
--a.user_id=b.user_id AND
--a.time_stamp  != b.time_stamp          AND 
--b.time_stamp  between a.time_stamp    and DATE_ADD(a.time_stamp,interval 24 hour)  
--order by b.user_id


--my sql 
--Runtime: 702 ms, faster than 67.66% of MySQL online submissions for Users That Actively Request Confirmation Messages.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Users That Actively Request Confirmation Messages.