CREATE PROCEDURE [dbo].[spTasks_Add]
	@Id INT,
	@Description NVARCHAR(MAX),
	@DueDate DATE,
	@IsImportant BIT,
	@IsCompleted BIT,
	@UserId NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO Tasks ([Description], DueDate, IsImportant, IsCompleted, UserId)
	VALUES (@Description, @DueDate, @IsImportant, @IsCompleted, @UserId);
END
