CREATE PROCEDURE [dbo].[spTasks_Update]
	@Id INT,
	@Description NVARCHAR(MAX),
	@DueDate DATE,
	@IsImportant BIT,
	@IsCompleted BIT,
	@UserId NVARCHAR(MAX)
AS
BEGIN
	UPDATE Tasks
	SET
		[Description] = @Description,
		[DueDate] = @DueDate,
		[IsImportant] = @IsImportant,
		[IsCompleted] = @IsCompleted
	WHERE UserId = @UserId AND Id = @Id;
END
