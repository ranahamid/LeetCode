 MYSQL
  select p.product_id , ROUND( sum(units *price)/sum(units),2) as  average_price
  from Prices as p, UnitsSold  as u
 
  where  p.product_id = u.product_id AND purchase_date between start_date and end_date   
  group by p.product_id

