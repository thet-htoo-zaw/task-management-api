using TaskManagementDemo.Application.Tasks.DTOs.TaskStatus;

namespace TaskManagementDemo.Application.Tasks.Services;

public interface ITaskStatusService
{
    Task<TaskStatusResponse> CreateAsync(
        CreateTaskStatusRequest request,
        CancellationToken cancellationToken = default);
}