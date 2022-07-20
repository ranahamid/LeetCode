 
select product_id , year as first_year , quantity , price 
from Sales 

where (product_id,year) in (

    select product_id, min(year) as year
    from sales
    group by product_id 
)



--my sql
--Runtime: 4150 ms, faster than 5.08% of MySQL online submissions for Product Sales Analysis III.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Product Sales Analysis III.

 
select s1.product_id , s1.year as first_year ,s1. quantity ,s1. price 
    from Sales as s1
inner Join(
    select product_id, min(year) min_yr 
     from sales
    group by product_id 
) as s2
on s1.product_id= s2.product_id and s1.[year]=s2.min_yr


--SQL Server
--Runtime: 5122 ms, faster than 87.50% of MS SQL Server online submissions for Product Sales Analysis III.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Product Sales Analysis III