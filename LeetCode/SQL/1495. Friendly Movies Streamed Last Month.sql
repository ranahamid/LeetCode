select distinct title 
from content 
where Kids_content  ='Y' AND content_type  ='Movies'
AND content_id in (
select content_id
    from TVProgram 
    where program_date between '2020-06-01' AND '2020-06-30 ' 
)

--Runtime: 537 ms, faster than 91.67% of MS SQL Server online submissions for Friendly Movies Streamed Last Month.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Friendly Movies Streamed Last Month.