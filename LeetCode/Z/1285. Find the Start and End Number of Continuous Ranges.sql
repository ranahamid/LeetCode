 with cte as ( select log_id,
        row_number() over (order by log_id) as row_number
        from logs) 

select min(log_id) as         start_id   
, max(log_id) as end_id       
from cte
group by log_id-row_number 

--Runtime 484 ms Beats 71.43%