CREATE PROCEDURE [dbo].[spTasks_GetAllTasks]
	@UserId NVARCHAR(MAX)
AS
BEGIN
	SELECT * FROM Tasks WHERE UserId = @UserId;
END