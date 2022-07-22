CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN 
    RETURN (
        /* Write your T-SQL query statement below. */

    select  distinct salary 
        from Employee
        order by salary desc 
        offset @N-1 rows 
        fetch next 1 rows only 

 
        
        
        
    );
END








/*
 

    select  distinct salary 
        from Employee
        order by salary desc 
        offset 2-1 rows 
        fetch next 1 rows only 

 
       
*/