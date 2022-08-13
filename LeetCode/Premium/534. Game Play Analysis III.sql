select player_id , event_date , SUM(games_played ) OVER (PARTITION BY player_id order by  event_date ) as 'games_played_so_far'
from Activity 


--mysql
--Runtime: 753 ms, faster than 74.10% of MySQL online submissions for Game Play Analysis III.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Game Play Analysis III.


--sql server
--Runtime: 2715 ms, faster than 69.23% of MS SQL Server online submissions for Game Play Analysis III.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Game Play Analysis III.