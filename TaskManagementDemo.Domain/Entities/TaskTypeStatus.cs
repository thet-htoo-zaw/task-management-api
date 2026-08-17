namespace TaskManagementDemo.Domain.Entities;

public class TaskTypeStatus
{
    public Guid Id { get; set; }
    
    public Guid TaskTypeId { get; set; }
    
    public Guid TaskStatusId { get; set; }

    public virtual TaskType TaskType { get; set; } = null!;

    public virtual TaskStatus TaskStatus { get; set; } = null!;
    
    public int Sequence { get; set; }
    
    public bool IsActive { get; set; }
    
}