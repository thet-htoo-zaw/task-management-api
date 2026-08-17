namespace TaskManagementDemo.Application.Tasks.DTOs.TaskStatus;

public sealed record CreateTaskStatusRequest
{
    public string Code { get; init; } = null!;

    public string Name { get; init; } = null!;
    
    public bool IsInitial { get; init; }
    
    public bool IsCompleted { get; init; }
};