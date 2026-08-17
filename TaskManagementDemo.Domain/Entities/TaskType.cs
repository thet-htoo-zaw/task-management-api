namespace TaskManagementDemo.Domain.Entities;

public class TaskType
{
    public Guid Id { get; set; }
    
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; } = true;
    
    public ICollection<TaskTypeStatus> TaskTypeStatusCollection { get; set; } = new List<TaskTypeStatus>();
    
    public ICollection<TaskItem>  TaskItemCollection { get; set; } = new List<TaskItem>();

}