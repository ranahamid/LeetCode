 with cte as
(
	select s.customer_id , c.salesperson_id , price 
    from Sales as s 
    inner join Customer as c on c.customer_id =s.customer_id 
)

select s.salesperson_id , s.name  , SUM(case when price is not null then price else 0 end) as total 
from Salesperson as s
left join cte as c on c.salesperson_id=s.salesperson_id
group by s.salesperson_id , s.name 

-- MS SQL Server

--Runtime: 1187 ms, faster than 10.00% of MS SQL Server online submissions for Calculate the Influence of Each Salesperson.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Calculate the Influence of Each Salesperson.

-- MY SQL
--Runtime: 1133 ms, faster than 51.65% of MySQL online submissions for Calculate the Influence of Each Salesperson.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Calculate the Influence of Each Salesperson.