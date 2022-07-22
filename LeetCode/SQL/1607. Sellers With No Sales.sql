select s.seller_name 
from Seller as s   
where s.seller_id   not in (
select distinct seller_id   
    from Orders as oo
    where oo.sale_date  >='2020-01-01' AND oo.sale_date  <='2020-12-31'
)
order by seller_name 

--SQL Server 
--Runtime: 721 ms, faster than 30.86% of MS SQL Server online submissions for Sellers With No Sales.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Sellers With No Sales.



select s.seller_name 
from Seller as s  
 
where s.seller_id   not in (
select distinct seller_id   
    from Orders as oo
    where oo.sale_date  >='2020-01-01' AND oo.sale_date  <='2020-12-31'
)
order by seller_name 