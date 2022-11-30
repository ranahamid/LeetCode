select e1.symbol as metal , e2.symbol as nonmetal
from Elements as e1 ,  Elements as e2 
where e1.type='Metal' AND e2.type='Nonmetal' 



--select e1.symbol as metal , e2.symbol as nonmetal
--from Elements as e1 
--join by Elements as e2 
--where e1.type='Metal' AND e2.type='Nonmetal' 