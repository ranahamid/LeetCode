with cte as(
select account_id ,day, 
(
    case when type     ='Withdraw' then amount *-1 else amount end
)   as amount 
from Transactions 
    )

select account_id ,day, sum(amount ) over (partition by account_id order by day         ) as balance  
from cte
order by account_id,day
 
-- SQL Server
-- Runtime: 873 ms, faster than 70.97% of MS SQL Server online submissions for Account Balance.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Account Balance.

--MY SQL
--Runtime: 459 ms, faster than 81.59% of MySQL online submissions for Account Balance.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Account Balance.