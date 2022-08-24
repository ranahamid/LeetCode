with cte as
(
    select id, p.name as personName,   c.name as   countryName 
    from Person as p
    inner join Country as c on c.country_code = left(p.phone_number,3)
), 
  scall as 
(
    select caller_id as caller, duration
from Calls 
 
UNION 
select callee_id  as caller, duration
from Calls  
)
, 
  sub as (
  
select avg(duration) as duration, countryName
from scall as s   
inner join cte as c on s.caller=c.id
group by countryName)

select countryName as country  
from sub
where sub.duration> ( select avg(duration ) as d
    from Calls )

--SQL Server
--Runtime: 2175 ms, faster than 70.97% of MS SQL Server online submissions for Countries You Can Safely Invest In.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Countries You Can Safely Invest In.


--my sql
--Runtime: 1888 ms, faster than 25.91% of MySQL online submissions for Countries You Can Safely Invest In.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Countries You Can Safely Invest In.