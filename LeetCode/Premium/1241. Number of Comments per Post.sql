select distinct sub_id  as post_id ,
(
    select count(distinct sub_id)
    from Submissions as s1
    where s1.parent_id  =s2.sub_id  
)as number_of_comments 
from Submissions as s2
where parent_id  is null
group by sub_id
order by post_id 

--mysql
--Runtime: 2840 ms, faster than 11.00% of MySQL online submissions for Number of Comments per Post.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Number of Comments per Post.


--sql server
--Runtime: 3222 ms, faster than 98.41% of MS SQL Server online submissions for Number of Comments per Post.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Number of Comments per Post.