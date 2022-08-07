 select order_id , customer_id ,order_type 
 from orders 
 where order_type=0
 UNION
 
  select order_id , customer_id ,order_type 
   from orders 
 where order_type =1 AND customer_id not in
 (
    select customer_id
    from orders as s1
     where  order_type=0
 )
 
 

--MY SQL
-- Runtime: 374 ms, faster than 89.48% of MySQL online submissions for Drop Type 1 Orders for Customers With Type 0 Orders.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Drop Type 1 Orders for Customers With Type 0 Orders.

--sql server
--Runtime: 745 ms, faster than 67.11% of MS SQL Server online submissions for Drop Type 1 Orders for Customers With Type 0 Orders.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Drop Type 1 Orders for Customers With Type 0 Orders.