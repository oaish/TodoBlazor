CREATE PROCEDURE [dbo].[spTasks_Delete]
	@Id INT
AS
BEGIN
	DELETE FROM Tasks
	WHERE Id = @Id;
END
