 
select distinct buyer_id 
from Sales as s 
inner join Product as p on s.product_id = p.product_id 
where product_name ='S8' AND 
buyer_id NOT IN
(
    select buyer_id
    from Sales  as ss
    inner join Product as pp on ss.product_id = pp.product_id 
    where product_name ='iPhone'
)


--MY SQL
--Runtime: 1746 ms, faster than 19.18% of MySQL online submissions for Sales Analysis II.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Sales Analysis II.
--Next challenges:



--SQL SERVER
--Runtime: 4431 ms, faster than 82.61% of MS SQL Server online submissions for Sales Analysis II.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Sales Analysis II.