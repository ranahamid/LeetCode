select ROUND(a.imm/b.total*100,2) as immediate_percentage 
 
 from
    (select count(*) as imm
    from Delivery 
    where order_date =customer_pref_delivery_date) as a 
,

(select count(*) as total
    from Delivery)  
as  b 


--mysql


--==============
--Runtime: 368 ms, faster than 97.85% of MySQL online submissions for Immediate Food Delivery I.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Immediate Food Delivery I.
select round(avg(order_date=customer_pref_delivery_date )*100,2) as immediate_percentage 
from Delivery
--mysql