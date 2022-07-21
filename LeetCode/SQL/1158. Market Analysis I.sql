select  u.user_id as buyer_id  , join_date,
count(item_id) as orders_in_2019 

from Users  as u 
left join Orders as o on u.user_id =o.buyer_id 
and YEAR(order_date)=2019
group by u.user_id

--MY SQL
--Runtime: 1209 ms, faster than 58.85% of MySQL online submissions for Market Analysis I.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Market Analysis I.











select  u.user_id as buyer_id , join_date,
count(item_id) as orders_in_2019 

from Users  as u 
left join Orders as o on u.user_id =o.buyer_id 
and YEAR(order_date)=2019
group by u.user_id,join_date


--MS SQL Server
--Runtime: 2472 ms, faster than 78.06% of MS SQL Server online submissions for Market Analysis I.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Market Analysis I.