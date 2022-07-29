select distinct extra as report_reason , count(distinct post_id ) as report_count
from Actions 
where extra is not null

AND action_date ='2019-07-04'  
AND action='report'
group by extra
order by report_count 

--mysql
--Runtime: 684 ms, faster than 42.77% of MySQL online submissions for Reported Posts.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Reported Posts.


--sql server 
--Runtime: 3035 ms, faster than 62.61% of MS SQL Server online submissions for Reported Posts.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Reported Posts.