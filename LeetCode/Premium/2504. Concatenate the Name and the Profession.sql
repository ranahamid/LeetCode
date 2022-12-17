select person_id ,name +'('+SUBSTRING(profession ,1,1)+')' as name     
from Person 
order by person_id  desc 