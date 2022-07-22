/* Write your T-SQL query statement below */

select c.country_name ,
case when avg(weather_state*1.0)<=15.0 then 'Cold' 
 when avg(weather_state*1.0)>=25.0 then 'Hot' 
    ELSE 'Warm'
    End as weather_type 
    
from Countries as c
inner join Weather as w on w.country_id =c.country_id 
 
where day>='2019-11-01' AND day<='2019-11-30'
group by c.country_name
order by c.country_name



-- SQL Server
--Runtime: 818 ms, faster than 99.13% of MS SQL Server online submissions for Weather Type in Each Country.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Weather Type in Each Country.


-- MY SQL
--Runtime: 470 ms, faster than 92.63% of MySQL online submissions for Weather Type in Each Country.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Weather Type in Each Country.