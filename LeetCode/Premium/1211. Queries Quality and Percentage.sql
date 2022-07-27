select query_name ,
ROUND ( AVG(rating /(position*1.0) ) ,2) as quality ,

ROUND ( AVG(case when rating<3 then 1.0 else 0.0 end )*100.0 ,2) as poor_query_percentage  
from Queries 
group by query_name
--ms sql server 
--Runtime: 2753 ms, faster than 94.89% of MS SQL Server online submissions for Queries Quality and Percentage.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Queries Quality and Percentage.


--select query_name ,
--ROUND ( AVG(rating /position ) ,2) as quality ,
--ROUND ( AVG(rating<3)*100 ,2) as poor_query_percentage  
--from Queries 
--group by query_name
--my sql
--Runtime: 644 ms, faster than 74.51% of MySQL online submissions for Queries Quality and Percentage.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Queries Quality and Percentage.