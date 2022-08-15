select t.* from Stadium as t
    left join Stadium as p1 on t.id-1=p1.id
    left join Stadium as p2 on t.id-2=p2.id
    left join Stadium as n1 on t.id+1=n1.id
    left join Stadium as n2 on t.id+2=n2.id
    
WHERE (t.people>=100 AND p1.people>=100 AND p2.people>=100 ) OR
(t.people>=100 AND n1.people>=100 AND n2.people>=100 )  OR
(t.people>=100 AND p1.people>=100 AND n1.people>=100 ) 
order by visit_date 

--sql server
--Runtime: 435 ms, faster than 85.88% of MS SQL Server online submissions for Human Traffic of Stadium.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Human Traffic of Stadium.

--my sql
--Runtime: 281 ms, faster than 94.78% of MySQL online submissions for Human Traffic of Stadium.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Human Traffic of Stadium.