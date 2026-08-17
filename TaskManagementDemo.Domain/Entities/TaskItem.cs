namespace TaskManagementDemo.Domain.Entities;

public class TaskItem
{
    public Guid Id { get; set; }
    
    public Guid TaskTypeId { get; set; }
    
    public TaskType TaskType { get; set; } = null!;
    
    public Guid StatusId { get; set; }

    public TaskStatus Status { get; set; } = null!;

    public string Title { get; set; } = null!;
    
    public string? Description { get; set; }
    
    public DateTime? DueDate { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public ICollection<TaskStatusHistory> StatusHistories = new List<TaskStatusHistory>();
}