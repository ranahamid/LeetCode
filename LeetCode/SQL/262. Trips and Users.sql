--select request_at as Day        ,
--ROUND(
--     COUNT(IF(status !='completed',TRUE,NULL)) / count(*)
--    ,2
--) as 'Cancellation Rate'
--from Trips 
--where (request_at between '2013-10-01' AND '2013-10-03')

--AND client_id  in (Select users_id from  Users where banned='No')

--AND driver_id   in (Select users_id from  Users where banned='No')
--group by request_at


--My SQL 
--Runtime: 562 ms, faster than 60.67% of MySQL online submissions for Trips and Users.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Trips and Users.


--select request_at as Day        ,
--ROUND(
--     SUM(IF(status !='completed',1,0)) / count(*)
--    ,2
--) as 'Cancellation Rate'
--from Trips 
--where (request_at between '2013-10-01' AND '2013-10-03')

--AND client_id  in (Select users_id from  Users where banned='No')

--AND driver_id   in (Select users_id from  Users where banned='No')
--group by request_at


select request_at as Day,
ROUND(
     SUM
     (
     case when status !='completed' then 1.0 else 0.0 end
     ) / count(*)
    ,2
) as 'Cancellation Rate'
from Trips 
where (request_at between '2013-10-01' AND '2013-10-03')

AND client_id  in (Select users_id from  Users where banned='No')

AND driver_id   in (Select users_id from  Users where banned='No')
group by request_at


--MS SQL 
--Runtime: 517 ms, faster than 51.92% of MS SQL Server online submissions for Trips and Users.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Trips and Users.