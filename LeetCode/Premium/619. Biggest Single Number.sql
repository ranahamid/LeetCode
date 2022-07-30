select  max(num) as num  
from (

   select num
    from mynumbers
group by num
having count(num)=1
)as tables


--mysql
--Runtime: 897 ms, faster than 11.77% of MySQL online submissions for Biggest Single Number.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Biggest Single Number.


--sql server
--Runtime: 439 ms, faster than 98.35% of MS SQL Server online submissions for Biggest Single Number.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Biggest Single Number.