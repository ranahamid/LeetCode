# Write your MySQL query statement below
select actor_id    ,director_id 
from ActorDirector
group by  actor_id    ,director_id 
having count(*)>=3
order by actor_id


--Runtime: 1387 ms, faster than 69.77% of MS SQL Server online submissions for Actors and Directors Who Cooperated At Least Three Times.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Actors and Directors Who Cooperated At Least Three Times.