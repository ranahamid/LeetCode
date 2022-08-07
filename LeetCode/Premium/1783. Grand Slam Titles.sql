--select player_id, player_name ,
--SUM(p.player_id =c.Wimbledon)+ SUM(p.player_id =c.Fr_open  )+SUM(p.player_id =c.US_open)+SUM(p.player_id =c.Au_open  ) as grand_slams_count 

--from Players as p
--inner join Championships as c 
--on p.player_id =c.Wimbledon  OR p.player_id =c.Fr_open OR p.player_id =c.US_open  OR p.player_id =c.Au_open 
--group by player_id,player_name


--MY SQL
--Runtime: 1198 ms, faster than 82.87% of MySQL online submissions for Grand Slam Titles.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Grand Slam Titles.



with cte as(
select Wimbledon as id from Championships 
UNION ALL
select Fr_open  as id from Championships 
UNION ALL
select US_open  as id from Championships 
UNION ALL
select Au_open as id from Championships 
)

 select player_id, player_name ,count(*) as grand_slams_count 
 from Players as p
 inner join cte as c 
 on p.player_id=c.id
 group by player_id,player_name

-- mysql 
-- Runtime: 1223 ms, faster than 79.80% of MySQL online submissions for Grand Slam Titles.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Grand Slam Titles.

-- SQL server
-- Runtime: 914 ms, faster than 98.81% of MS SQL Server online submissions for Grand Slam Titles.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Grand Slam Titles.