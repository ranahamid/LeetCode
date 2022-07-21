select patient_id ,patient_name ,conditions   
from Patients 
where conditions like '% DIAB1%' or  conditions like 'DIAB1%'

--my sql
--Runtime: 653 ms, faster than 15.63% of MySQL online submissions for Patients With a Condition.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Patients With a Condition.


---mssql server
--Runtime: 1147 ms, faster than 8.09% of MS SQL Server online submissions for Patients With a Condition.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Patients With a Condition.