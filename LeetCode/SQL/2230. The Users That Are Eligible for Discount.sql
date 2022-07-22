CREATE PROCEDURE getUserIDs(@startDate DATE, @endDate DATE, @minAmount INT) AS
BEGIN
    /* Write your T-SQL query statement below. */
      select distinct user_id
        from Purchases 
        where time_stamp >= @startDate AND 
            time_stamp<=  @endDate AND 
            amount >=  @minAmount
            
END

--SQL SERVER
--Runtime: 2442 ms, faster than 69.84% of MS SQL Server online submissions for The Users That Are Eligible for Discount.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for The Users That Are Eligible for Discount.


--CREATE PROCEDURE getUserIDs(startDate DATE, endDate DATE, minAmount INT)
--BEGIN
--	# Write your MySQL query statement below.
--	 select distinct user_id
--        from Purchases 
--        where time_stamp >= startDate AND 
--            time_stamp<=  endDate AND 
--            amount >=  minAmount
--            order by user_id;
--END

--mysql
--Runtime: 932 ms, faster than 28.89% of MySQL online submissions for The Users That Are Eligible for Discount.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for The Users That Are Eligible for Discount.