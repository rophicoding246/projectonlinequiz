CREATE PROCEDURE prc_ListSubjectTeaching @CodeTeacher NVARCHAR(20)
AS
SELECT CodeMember, Fullname , Subjects.CodeSubject, Name, Description, tc.DateJoined  FROM dbo.Subjects, dbo.Members, dbo.TeachingSubject AS tc WHERE tc.CodeTeacher = @CodeTeacher AND Subjects.CodeSubject=tc.CodeSubject AND CodeMember=tc.CodeTeacher


EXEC dbo.prc_ListSubjectTeaching @CodeTeacher = 'GV00001'
DROP PROCEDURE dbo.prc_ListSubjectTeaching