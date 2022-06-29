-- 
-- Runtime: 1017 ms, faster than 25.19% of MS SQL Server online submissions for Duplicate Emails.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Duplicate Emails.


select email
from person
group by email
having count(email)>1

