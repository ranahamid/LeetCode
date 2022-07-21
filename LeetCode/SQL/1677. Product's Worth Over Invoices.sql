/* Write your T-SQL query statement below */
select name,
sum(isnull(rest,0)) as rest,
sum(isnull(paid ,0)) as paid,
sum(isnull(canceled ,0)) as canceled ,
sum(isnull(refunded ,0)) as refunded 

from Product as p
left join Invoice as i on p.product_id =i.product_id 
group by name
order by name
--Runtime: 669 ms, faster than 80.28% of MS SQL Server online submissions for Product's Worth Over Invoices.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Product's Worth Over Invoices.




/* Write your T-SQL query statement below */
select name,
sum(ifnull(rest,0)) as rest,
sum(ifnull(paid ,0)) as paid,
sum(ifnull(canceled ,0)) as canceled ,
sum(ifnull(refunded ,0)) as refunded 

from Product as p
left join Invoice as i on p.product_id =i.product_id 
group by name
order by name
--MYSQL
--Runtime: 1612 ms, faster than 11.37% of MySQL online submissions for Product's Worth Over Invoices.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Product's Worth Over Invoices.