--Part 1
--id(int, PK), employerId(int), name(varchar)
--Part 2
SELECT Name
From Employers
Where Location ="St. Louis City";

--Part 3

Select * 
From Skills
Join JobSkills
On Skills.Id = JobSkills.SkillId
Where JobSkills.JobId IS NOT NUll
Order By Name ASC;