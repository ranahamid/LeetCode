select unique_id , name
from EmployeeUNI  as eu
right join Employees as e on eu.id= e.id

--Runtime: 1163 ms, faster than 57.94% of MySQL online submissions for Replace Employee ID With The Unique Identifier.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Replace Employee ID With The Unique Identifier.