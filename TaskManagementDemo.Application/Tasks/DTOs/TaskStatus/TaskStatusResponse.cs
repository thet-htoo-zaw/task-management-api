namespace TaskManagementDemo.Application.Tasks.DTOs.TaskStatus;

public sealed record TaskStatusResponse
{
    public Guid Id { get; init; }

    public string Code { get; init; } = null!;

    public string Name { get; init; } = null!;
    
    public bool IsActive { get; init; }
    
    public bool IsInitial { get; init; }
    
    public bool IsCompleted { get; init; }
    
    public DateTime CreatedAt { get; init; }
    
    public DateTime UpdatedAt { get; init; }
};