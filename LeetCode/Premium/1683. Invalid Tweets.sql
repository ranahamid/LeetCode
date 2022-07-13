select tweet_id 
from Tweets
where LEN(content)>15
----SQL Server
--Runtime: 1360 ms, faster than 97.96% of MS SQL Server online submissions for Invalid Tweets.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Invalid Tweets.


select tweet_id 
from Tweets
where LENGTH(content)>15

-- MY SQL
--Runtime: 2701 ms, faster than 5.08% of MySQL online submissions for Invalid Tweets.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Invalid Tweets.