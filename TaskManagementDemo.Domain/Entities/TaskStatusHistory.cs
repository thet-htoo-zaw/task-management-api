namespace TaskManagementDemo.Domain.Entities;

public class TaskStatusHistory
{
    public Guid Id { get; set; }
    
    public Guid TaskId { get; set; }

    public TaskItem TaskItem { get; set; } = null!;
    
    public Guid? FromStatusId {get; set; }
    
    public Guid ToStatusId { get; set; }
    
    public string? Remark  { get; set; }
}