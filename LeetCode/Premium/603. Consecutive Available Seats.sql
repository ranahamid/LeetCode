
select distinct a.seat_id  
from cinema as a
inner join cinema as b 
on abs(a.seat_id-b.seat_id)=1
and a.free =1 and b.free=1 
order by a.seat_id  

--MY SQL 
--Runtime: 394 ms, faster than 67.37% of MySQL online submissions for Consecutive Available Seats.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Consecutive Available Seats.


--SQL Server
--Runtime: 561 ms, faster than 50.52% of MS SQL Server online submissions for Consecutive Available Seats.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Consecutive Available Seats.