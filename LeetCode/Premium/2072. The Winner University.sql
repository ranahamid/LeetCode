select
(
    CASE 
        WHEN (select count(*) from NewYork where score>=90) > (select count(*) from California  where score>=90 ) THEN 'New York University'
    
     WHEN (select count(*) from NewYork where score>=90) < (select count(*) from California  where score>=90 ) THEN 'California University'
    ELSE 'No Winner' END 
    
) AS winner   



--SQL Server
--Runtime: 1588 ms, faster than 54.54% of MS SQL Server online submissions for The Winner University.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for The Winner University.



--mysql
--Runtime: 1025 ms, faster than 38.54% of MySQL online submissions for The Winner University.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for The Winner University.