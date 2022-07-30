select ad_id, 
IFNULL(ROUND(AVG(
case when action='Clicked' then 1
    when action='Viewed' then 0
    else null end
)*100,2),0) as ctr
from ads
group by ad_id
order by ctr desc,ad_id

--mysql

select ad_id, 
IsNULL(ROUND(AVG(
case when action='Clicked' then 1.0
    when action='Viewed' then 0
    else null end
)*100.0,2),0) as ctr
from ads
group by ad_id
order by ctr desc,ad_id
--ms sql server
--Runtime: 1362 ms, faster than 47.87% of MS SQL Server online submissions for Ads Performance.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Ads Performance.