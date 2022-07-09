select stock_name    , sum(
    if(operation ='Sell',1,-1)* price
) as capital_gain_loss 

from stocks
group by stock_name
order by capital_gain_loss desc


--mysql 

select stock_name    , sum(
    case when operation='Buy' then  -1* price else price end
) as capital_gain_loss 

from stocks
group by stock_name
order by capital_gain_loss desc

--sql server

--Runtime: 1523 ms, faster than 75.15% of MS SQL Server online submissions for Capital Gain/Loss.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Capital Gain/Loss.