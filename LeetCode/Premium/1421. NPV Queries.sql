 select q.id   , q.year , (case when  n.npv is null then 0 else  n.npv end) as npv
from Queries  as q
left join NPV as n on q .id= n .id and  q .year   = n .year     
--my sql
--Runtime: 1005 ms, faster than 52.32% of MySQL online submissions for NPV Queries.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for NPV Queries.


-- SQL Server
--Runtime: 1826 ms, faster than 48.60% of MS SQL Server online submissions for NPV Queries.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for NPV Queries.