select 
    (case when count ( distinct user_id   )>0 then

ROUND( count (distinct session_id ) /(count ( distinct user_id   )*1.0) ,2)
else 0 end) as average_sessions_per_user 
from Activity 
where activity_date between  '2019-06-28' AND '2019-07-27'

--Runtime: 2074 ms, faster than 46.84% of MS SQL Server online submissions for User Activity for the Past 30 Days II.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for User Activity for the Past 30 Days II.
-- MS SQL 



-- MY SQL