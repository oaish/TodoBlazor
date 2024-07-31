CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [DueDate] DATE NULL, 
    [IsImportant] BIT NULL, 
    [IsCompleted] BIT NULL, 
    [UserId] NVARCHAR(MAX) NULL
)
