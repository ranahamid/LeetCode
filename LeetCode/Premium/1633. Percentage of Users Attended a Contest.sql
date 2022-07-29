 
select contest_id, 
 
ROUND( cast ( count(DISTINCT user_id) as decimal)*100.0 / (select count(*) from Users),2)    as percentage 

    
from Register 
    group by contest_id
order by percentage desc, contest_id asc 

--my sql

--Runtime: 1168 ms, faster than 46.96% of MySQL online submissions for Percentage of Users Attended a Contest.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Percentage of Users Attended a Contest.


--sql server 
--TLE

