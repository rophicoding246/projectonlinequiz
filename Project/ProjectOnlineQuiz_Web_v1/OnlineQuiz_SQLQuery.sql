CREATE PROCEDURE SP_GetSubjectTeaching @CodeTeacher NVARCHAR(20)
AS
SELECT Subjects.CodeSubject, Name, Description, tc.DateJoined  FROM dbo.Subjects, dbo.TeachingSubject AS tc WHERE tc.CodeTeacher = @CodeTeacher AND Subjects.CodeSubject=tc.CodeSubject

EXEC dbo.SP_GetSubjectTeaching @CodeTeacher = 'GV00001'

DROP PROCEDURE dbo.SP_GetSubjectTeaching

ALTER PROCEDURE SP_GetQuestionFromSubject @CodeSubject NVARCHAR(20)
AS
SELECT 