select name   as Customers 
from customers  

where id not in(select customerId 
               from orders
               )

--Runtime: 413 ms, faster than 89.53% of MySQL online submissions for Customers Who Never Order.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Customers Who Never Order.