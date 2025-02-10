
select user_id         , email           
from Users 

where  Email LIKE '%@%' 
AND LEN(email) - LEN(REPLACE(email, '@', '')) = 1 -- Ensures exactly one @
AND Email LIKE '%.com' -- Ensures it ends with .com
 
 AND Email NOT LIKE '%[^a-zA-Z0-9_]@%'  -- Ensures only alphanumeric & underscore before @
    AND Email LIKE '%@[a-zA-Z]%.com' -- Ensures only letters in the domain before .com
AND Email NOT LIKE '%.%@%'  -- Ensures no dot before @

order by user_id 