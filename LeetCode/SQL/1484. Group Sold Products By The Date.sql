-- --sql server
-- Runtime: 2404 ms, faster than 15.30% of MS SQL Server online submissions for Group Sold Products By The Date.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Group Sold Products By The Date.
SELECT  sell_date, count(distinct product) as num_sold,   

STRING_AGG(product,',') as products                      
from(
select distinct sell_date,product 
from Activities 
) resultTable



 group by sell_date
 order by sell_date

