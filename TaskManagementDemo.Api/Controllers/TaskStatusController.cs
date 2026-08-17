using Microsoft.AspNetCore.Mvc;
using TaskManagementDemo.Application.Tasks.DTOs.TaskStatus;
using TaskManagementDemo.Application.Tasks.Services;

namespace TaskManagementDemo.Api.Controllers;

[ApiController]
[Route("api/task-status")]
public class TaskStatusController : ControllerBase
{
    private readonly ITaskStatusService _taskStatusService;

    public TaskStatusController(ITaskStatusService taskStatusService)
    {
        _taskStatusService = taskStatusService;
    }

    [HttpPost]
    [ProducesResponseType(typeof(TaskStatusResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<ActionResult<TaskStatusResponse>> Create(
        [FromBody] CreateTaskStatusRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var result = await _taskStatusService.CreateAsync(request, cancellationToken);
            return Created($"/api/task-status/{result.Id}", result);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(new { message = ex.Message });
        }
    }
}
