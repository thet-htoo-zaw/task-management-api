namespace TaskManagementDemo.Domain.Entities;

public class TaskStatus
{
    public Guid Id { get; set; }
    
    
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; } = true;
    
    public bool IsInitial { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public ICollection<TaskTypeStatus> TaskTypeStatusCollection { get; set; } = new List<TaskTypeStatus>();
    
    public ICollection<TaskStatusTransition> FromTransition  { get; set; } = new List<TaskStatusTransition>();
    
    public ICollection<TaskStatusTransition> ToTransition { get; set; } = new List<TaskStatusTransition>();

    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    

}