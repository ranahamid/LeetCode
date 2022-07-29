select name as warehouse_name , 

   sum 
    (
       units*  Width *Length   *Height     
    )    as volume
from Warehouse as w
inner join Products as p on w.product_id   =p.product_id 
group by name


--ms sql 
--Runtime: 543 ms, faster than 93.41% of MS SQL Server online submissions for Warehouse Manager.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Warehouse Manager.