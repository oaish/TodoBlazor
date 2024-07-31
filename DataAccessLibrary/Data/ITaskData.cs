using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data;
public interface ITaskData
{
    Task AddTask(TaskModel taskModel);
    Task DeleteTask(int id);
    Task<IEnumerable<TaskModel>> GetAllTasks(string userId);
    Task<IEnumerable<TaskModel>> GetImportantTasks(string userId);
    Task UpdateTask(TaskModel taskModel);
}