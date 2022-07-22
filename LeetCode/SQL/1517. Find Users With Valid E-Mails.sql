/* Write your T-SQL query statement below */
select user_id, name , mail
from users
where lower(mail) like '[a-z]%@leetcode.com'
and left(mail, len(mail)-13) not like '%[^0-9a-zA-Z_.-]%'

-- MS SQL Server
--Runtime: 1843 ms, faster than 60.00% of MS SQL Server online submissions for Find Users With Valid E-Mails.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Find Users With Valid E-Mails.



/* Write your T-SQL query statement below */
select user_id, name , mail
from users
where mail like '[a-zA-Z]%@leetcode.com'
and left(mail, len(mail)-13) not like '%[^0-9a-zA-Z_.-]%'