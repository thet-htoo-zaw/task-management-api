using TaskManagementDemo.Application.Tasks.DTOs.TaskStatus;
using TaskManagementDemo.Application.Tasks.Interfaces;
using TaskStatus = TaskManagementDemo.Domain.Entities.TaskStatus;

namespace TaskManagementDemo.Application.Tasks.Services.Impl;

public class TaskStatusService : ITaskStatusService
{
    private readonly ITaskStatusRepository _taskStatusRepository;

    public TaskStatusService(ITaskStatusRepository taskStatusRepository)
    {
        _taskStatusRepository = taskStatusRepository;
    }

    public async Task<TaskStatusResponse> CreateAsync(
        CreateTaskStatusRequest request,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(request.Code))
        {
            throw new ArgumentException("Code is required.");
        }

        if (string.IsNullOrWhiteSpace(request.Name))
        {
            throw new ArgumentException("Name is required.");
        }

        var code = request.Code.Trim();
        var name = request.Name.Trim();

        if (await _taskStatusRepository.ExistsByCodeAsync(code, cancellationToken))
        {
            throw new InvalidOperationException($"Task status with code '{code}' already exists.");
        }

        var now = DateTime.UtcNow;
        var taskStatus = new TaskStatus
        {
            Id = Guid.NewGuid(),
            Code = code,
            Name = name,
            IsActive = true,
            IsInitial = request.IsInitial,
            IsCompleted = request.IsCompleted,
            CreatedAt = now,
            UpdatedAt = now
        };

        await _taskStatusRepository.AddAsync(taskStatus, cancellationToken);
        await _taskStatusRepository.SaveChangesAsync(cancellationToken);

        return new TaskStatusResponse
        {
            Id = taskStatus.Id,
            Code = taskStatus.Code,
            Name = taskStatus.Name,
            IsActive = taskStatus.IsActive,
            IsInitial = taskStatus.IsInitial,
            IsCompleted = taskStatus.IsCompleted,
            CreatedAt = taskStatus.CreatedAt,
            UpdatedAt = taskStatus.UpdatedAt
        };
    }
}
