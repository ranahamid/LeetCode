
select distinct s.product_id , p.product_name 
from Sales as s
inner join Product as p on s.product_id = p.product_id 
where sale_date  >='2019-01-01' AND sale_date<= '2019-03-31'
AND s.product_id not in(

    select product_id
    from Sales 
    
    where sale_date  <'2019-01-01' or sale_date> '2019-03-31'
)

--sql server
--Runtime: 1096 ms, faster than 73.47% of MySQL online submissions for Sales Analysis III.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Sales Analysis III.