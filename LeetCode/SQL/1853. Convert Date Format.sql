select CONCAT(

 DATEName(DW, day),


',',' ', concat(DATENAME(month,day),' ', day(day)),',',' ',YEAR(day)) as day                     
from days
--sql server

 

 SELECT DATE_FORMAT(day, "%W, %M %e, %Y") AS day
FROM Days
--mysql
--Runtime: 545 ms, faster than 63.59% of MySQL online submissions for Convert Date Format.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Convert Date Format.