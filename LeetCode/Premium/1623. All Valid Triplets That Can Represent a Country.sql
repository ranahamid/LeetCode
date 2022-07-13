select a.student_name as member_A , b.student_name as member_B, c.student_name as member_C
from SchoolA as a 
cross join SchoolB as b 
cross join SchoolC as c 
where  a.student_name<>  b.student_name AND
     a.student_name<> c.student_name AND
      b.student_name <> c.student_name AND
      
      a.student_id<>  b.student_id AND
     a.student_id<> c.student_id AND
      b.student_id <> c.student_id  

--SQL Server
--Runtime: 1672 ms, faster than 7.60% of MS SQL Server online submissions for All Valid Triplets That Can Represent a Country.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for All Valid Triplets That Can Represent a Country.      


--MY SQL
--Runtime: 1862 ms, faster than 94.05% of MySQL online submissions for All Valid Triplets That Can Represent a Country.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for All Valid Triplets That Can Represent a Country.