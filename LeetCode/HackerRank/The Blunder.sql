select   


    CEILING(
    avg( CAST( salary  AS DECIMAL(10,2)))
    
    -
    avg(CAST(REPLACE(CAST(salary AS varchar), '0', '') AS DECIMAL(10,2)) )
    
        )
 
from EMPLOYEES 