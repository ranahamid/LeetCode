select p.product_name, sum(unit)  as   unit  
from Products as p
inner join Orders as o on o.product_id  =p.product_id  
where order_date>='2020-02-01' AND order_date<='2020-02-29'
group by product_name
having sum(unit)>= 100
order by sum(unit) desc


--SQL SERVER
--Runtime: 844 ms, faster than 29.56% of MS SQL Server online submissions for List the Products Ordered in a Period.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for List the Products Ordered in a Period.


--MYSQL
--Runtime: 1079 ms, faster than 21.37% of MySQL online submissions for List the Products Ordered in a Period.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for List the Products Ordered in a Period.