select i.item_category as Category, 
sum(case when DATENAME(WEEKDAY,o.order_date)='Monday' THEN quantity ELSE 0 end) as Monday    
,sum(case when DATENAME(WEEKDAY,o.order_date)='Tuesday' THEN quantity ELSE 0 end) as Tuesday  
,sum(case when DATENAME(WEEKDAY,o.order_date)='Wednesday' THEN quantity ELSE 0 end) as Wednesday  

,sum(case when DATENAME(WEEKDAY,o.order_date)='Thursday' THEN quantity ELSE 0 end) as Thursday    
,sum(case when DATENAME(WEEKDAY,o.order_date)='Friday' THEN quantity ELSE 0 end) as Friday  
,sum(case when DATENAME(WEEKDAY,o.order_date)='Saturday' THEN quantity ELSE 0 end) as Saturday  

,sum(case when DATENAME(WEEKDAY,o.order_date)='Sunday' THEN quantity ELSE 0 end) as Sunday  
from Items as i
left join Orders as o on i.item_id=o.item_id
group by i.item_category
order by i.item_category

--sql server
--Runtime: 435 ms, faster than 89.36% of MS SQL Server online submissions for Sales by Day of the Week.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Sales by Day of the Week.