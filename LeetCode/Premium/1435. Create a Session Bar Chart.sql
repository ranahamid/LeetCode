
select '[0-5>' as bin, count(session_id  ) as total        
from Sessions where duration/60 <5
UNION

select '[5-10>' as bin, count(session_id  ) as total        
from Sessions where duration/60 between 5 and 10

UNION

select '[10-15>' as bin, count(session_id  ) as total        
from Sessions where duration/60 between 10 and 15

UNION

select '15 or more' as bin, count(session_id  ) as total        
from Sessions where duration/60 >15


--mysql
--Runtime: 455 ms, faster than 56.93% of MySQL online submissions for Create a Session Bar Chart.
-- Memory Usage: 0B, less than 100.00% of MySQL online submissions for Create a Session Bar Chart.


/* Write your T-SQL query statement below */
select '[0-5>' as bin, count(session_id  ) as total        
from Sessions where duration/60.0 <5
UNION

select '[5-10>' as bin, count(session_id  ) as total        
from Sessions where duration/60.0 between 5 and 10

UNION

select '[10-15>' as bin, count(session_id  ) as total        
from Sessions where duration/60.0 between 10 and 15

UNION

select '15 or more' as bin, count(session_id  ) as total        
from Sessions where duration/60.0 >15

--sql server
-- Runtime: 515 ms, faster than 69.35% of MS SQL Server online submissions for Create a Session Bar Chart.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Create a Session Bar Chart.