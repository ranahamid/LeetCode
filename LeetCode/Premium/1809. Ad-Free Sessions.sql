 
select  session_id 
 
from Playback 
 where session_id not in(
 
     select session_id
     from Playback as p
     left join Ads as a on p.customer_id =a. customer_id 
     Where a.timestamp between p.start_time  AND p.end_time 
 )
-- SQL
-- Runtime: 1851 ms, faster than 98.77% of MS SQL Server online submissions for Ad-Free Sessions.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Ad-Free Sessions.


 
select  session_id  
from Playback as p
left join ads as a on p.customer_id =a.customer_id 
    AND a.timestamp    between p.start_time AND p.end_time
 where timestamp is null

 -- SQL
-- Runtime: 2147 ms, faster than 79.01% of MS SQL Server online submissions for Ad-Free Sessions.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Ad-Free Sessions.