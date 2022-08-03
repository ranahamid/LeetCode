-- select s.student_id , s.student_name , sub.subject_name,count(e.subject_name )as attended_exams 
--from Students as s
--join Subjects as sub
--left join Examinations as e on s.student_id =e.student_id 
--AND sub.subject_name = e.subject_name 

--group by  s.student_id , s.student_name , sub.subject_name 
--order by student_id , subject_name 




-- mysql 
--Runtime: 808 ms, faster than 63.55% of MySQL online submissions for Students and Examinations.
--Memory Usage: 0B, less than 100.00% of MySQL online submissions for Students and Examinations.