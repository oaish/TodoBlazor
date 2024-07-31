using DataAccessLibrary.Data;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly ITaskData _sql;

    public TasksController(ITaskData sql)
    {
        _sql = sql;
    }

    [HttpGet("/All/{userId}")]
    public async Task<IActionResult> GetAllTasksByUserid(string userId)
    {
        if (userId is null) return BadRequest();
        var response = await _sql.GetAllTasks(userId);
        return response is null ? NotFound() : Ok(response);
    }

    [HttpGet("/Important/{userId}")]
    public async Task<IActionResult> GetImportantTasksByUserid(string userId)
    {
        if (userId is null) return BadRequest();
        var response = await _sql.GetImportantTasks(userId);
        return response is null ? NotFound() : Ok(response);
    }

    [HttpPost("Add")]
    public async Task<IActionResult> AddTask([FromBody] TaskModel task)
    {
        if (task is null) return BadRequest("Task is Null");
        await _sql.AddTask(task);
        return Ok();
    }

    [HttpPut("Update")]
    public async Task<IActionResult> UpdateTask([FromBody] TaskModel task)
    {
        if (task is null) return BadRequest();
        await _sql.UpdateTask(task);
        return Ok();
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteTaskById(int id)
    {
        await _sql.DeleteTask(id);
        return Ok();
    }
}
