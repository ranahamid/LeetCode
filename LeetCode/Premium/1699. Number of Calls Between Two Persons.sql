with cte as(
select LEAST(from_id ,to_id ) as from_id ,GREATEST(from_id ,to_id ) as to_id  , duration 
    from Calls 

)    

select from_id as person1 , to_id as person2  , count( duration) as call_count   , sum( duration) as total_duration 
from cte  
group by from_id, to_id


--MY SQL