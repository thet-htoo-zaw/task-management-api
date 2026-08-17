namespace TaskManagementDemo.Domain.Entities;

public class TaskStatusTransition
{
    public Guid Id { get; set; }
    
    public Guid FromStatusId { get; set; }
    
    public Guid ToStatusId { get; set; }

    public TaskStatus FromStatus { get; set; } = null!;

    public TaskStatus ToStatus { get; set; } = null!;
    
}