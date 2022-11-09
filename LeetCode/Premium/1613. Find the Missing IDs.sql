--Runtime 392 ms Beats 89.10%
-- MY SQL 

--with recursive nums as (

--    select 1 as value 
--    UNION ALL 
--    select value+1 as value
--    from nums
--    where nums.value<(select max(customer_id) from customers)
--)

--select value as ids 
--from nums 
--where value   not in (select customer_id from customers)
--order by value


-- MS SQL Server
-- Runtime 691 ms Beats 67.3%

with  nums as (

    select 1 as value 
    UNION ALL 
    select value+1 as value
    from nums
    where nums.value<=100
) 

select value as ids 
from nums 
where  value< (select max(customer_id) from customers)
AND 
value not in (select customer_id from customers)
order by value