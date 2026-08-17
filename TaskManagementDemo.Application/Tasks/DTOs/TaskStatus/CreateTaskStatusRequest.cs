using System.ComponentModel.DataAnnotations;

namespace TaskManagementDemo.Application.Tasks.DTOs.TaskStatus;

public sealed record CreateTaskStatusRequest
{
    [Required]
    [MaxLength(50)]
    public string Code { get; init; } = null!;

    [Required]
    [MaxLength(100)]
    public string Name { get; init; } = null!;

    public bool IsInitial { get; init; }

    public bool IsCompleted { get; init; }
}