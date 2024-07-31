using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data;
public class TaskData : ITaskData
{
    private readonly ISqlDataAccess _sql;

    public TaskData(ISqlDataAccess sql)
    {
        _sql = sql;
    }

    public async Task AddTask(TaskModel taskModel)
    {
        await _sql.SaveDataAsync<TaskModel>("spTasks_Add", taskModel);
    }

    public async Task UpdateTask(TaskModel taskModel)
    {
        await _sql.SaveDataAsync<TaskModel>("spTasks_Update", taskModel);
    }

    public async Task DeleteTask(int id)
    {
        await _sql.SaveDataAsync<dynamic>("spTasks_Delete", new { Id = id });
    }

    public async Task<IEnumerable<TaskModel>> GetAllTasks(string userId)
    {
        return await _sql.FetchDataAsync<TaskModel, dynamic>("spTasks_GetAllTasks", new { UserId = userId });
    }

    public async Task<IEnumerable<TaskModel>> GetImportantTasks(string userId)
    {
        return await _sql.FetchDataAsync<TaskModel, dynamic>("spTasks_GetImportantTasks", new { UserId = userId });
    }
}
