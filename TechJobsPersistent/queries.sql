--Part 1
--Jobs table columns:
--Id (int AI PK)
--Name (longtext)
--EmployerId (int)

--Part 2
--SELECT Name
--FROM techJobs.Employers
--WHERE location = "St. Louis";

--Part 3
--SELECT Name, Description
--FROM techJobs.Skills
--INNER JOIN JobSkills ON SkillsId=JobSkills.SkillId
--ORDER BY Name ASC;