 

--select player_id , device_id 
--from Activity 
--where (event_date , player_id ) IN 
--(
--    select min(event_date), player_id
--    from activity
--    group by player_id
--)

--MY SQL
--Runtime: 504 ms, faster than 84.23% of MySQL online submissions for Game Play Analysis II.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Game Play Analysis II...

 