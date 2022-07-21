/* Write your T-SQL query statement below */
select activity_date as day , count(distinct user_id  ) as active_users 
from Activity 
where activity_date <= '2019-07-27' AND activity_date >= '2019-06-28'
group by activity_date

--sql server
--Runtime: 4217 ms, faster than 5.04% of MS SQL Server online submissions for User Activity for the Past 30 Days I.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for User Activity for the Past 30 Days I.


--mysql
--Runtime: 429 ms, faster than 79.18% of MySQL online submissions for User Activity for the Past 30 Days I.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for User Activity for the Past 30 Days I.