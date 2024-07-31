CREATE PROCEDURE [dbo].[spTasks_GetImportantTasks]
	@UserId NVARCHAR(MAX)
AS
BEGIN
	SELECT * FROM Tasks WHERE UserId = @UserId AND IsImportant = 1;
END