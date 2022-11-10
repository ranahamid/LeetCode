WITH TEMP AS(
select num,
    sum(frequency ) over(order by num) as low,
   
     sum(frequency ) over(order by num desc) as high,
    sum(frequency) over() as total
    from Numbers
)
select avg(num*1.0) as median 
from TEMP 
where 2*low>=total AND 2*high>=total

--sql server
--Runtime: 608 ms, faster than 85.44% of MS SQL Server online submissions for Find Median Given Frequency of Numbers.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Find Median Given Frequency of Numbers.

--mysql
--Runtime: 262 ms, faster than 66.31% of MySQL online submissions for Find Median Given Frequency of Numbers.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Find Median Given Frequency of Numbers.