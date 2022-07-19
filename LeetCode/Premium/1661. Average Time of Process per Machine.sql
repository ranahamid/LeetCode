--select machine_id,
--ROUND( sum(case when activity_type = 'end' THEN timestamp else -timestamp end)
--/ count(distinct process_id), 3) as processing_time 
--from Activity
--group by machine_id




--my sql
--Runtime: 190 ms, faster than 91.46% of MySQL online submissions for Average Time of Process per Machine.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Average Time of Process per Machine.



--select machine_id,
--ROUND( sum(case when activity_type = 'end' THEN timestamp else -timestamp end)
--/ count(distinct process_id), 3) as processing_time 
--from Activity
--group by machine_id


-- SQL Server
--Runtime: 524 ms, faster than 29.79% of MS SQL Server online submissions for Average Time of Process per Machine.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Average Time of Process per Machine.