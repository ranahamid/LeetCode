--select distinct c.customer_id, c.name
--from Customers as c
--inner join Orders as o on o.customer_id =c.customer_id 
--inner join Product as p on p.product_id  =o.product_id  

--group by c.customer_id

--having 
--    sum(IF(Month(order_date)=6,quantity,0)*price)>=100
--    AND
--    sum(IF(Month(order_date)=7,quantity,0)*price)>=100




--mysql
--Runtime: 1361 ms, faster than 23.44% of MySQL online submissions for Customer Order Frequency.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Customer Order Frequency.


select distinct c.customer_id, c.name
from Customers as c
inner join Orders as o on o.customer_id =c.customer_id 
inner join Product as p on p.product_id  =o.product_id  

group by c.customer_id, c.name

having 
    sum(CASE WHEN Month(order_date)=6 THEN quantity ELSE 0 END *price)>=100
    AND
   sum(CASE WHEN Month(order_date)=7 THEN quantity ELSE 0 END *price)>=100

   --SQL SERVER
--   Runtime: 899 ms, faster than 25.32% of MS SQL Server online submissions for Customer Order Frequency.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Customer Order Frequency.