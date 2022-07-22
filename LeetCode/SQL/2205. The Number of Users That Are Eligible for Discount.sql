--SQL SERVER
--Runtime: 2189 ms, faster than 78.18% of MS SQL Server online submissions for The Number of Users That Are Eligible for Discount.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for The Number of Users That Are Eligible for Discount.

CREATE FUNCTION getUserIDs(@startDate DATE, @endDate DATE, @minAmount INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        
        select count(distinct user_id  ) as user_cnt 
        from Purchases 
        where time_stamp >= @startDate AND 
            time_stamp<=  @endDate AND 
            amount >=  @minAmount
        
    );
END



--MYSQL 
--Runtime: 625 ms, faster than 66.51% of MySQL online submissions for The Number of Users That Are Eligible for Discount.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for The Number of Users That Are Eligible for Discount.


--CREATE FUNCTION getUserIDs(startDate DATE, endDate DATE, minAmount INT) RETURNS INT
--BEGIN
--  RETURN (
--      # Write your MySQL query statement below.
--         select count(distinct user_id  ) as user_cnt 
--        from Purchases 
--        where time_stamp >= startDate AND 
--            time_stamp<=  endDate AND 
--            amount >=  minAmount
--  );
--END