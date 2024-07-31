namespace DataAccessLibrary.Models;
public class TaskModel
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsImportant { get; set; }
    public bool IsCompleted { get; set; }
    public string? UserId { get; set; }
}
