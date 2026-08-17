using TaskStatus = TaskManagementDemo.Domain.Entities.TaskStatus;

namespace TaskManagementDemo.Application.Tasks.Interfaces;

public interface ITaskStatusRepository
{
    Task AddAsync(TaskStatus taskStatus, CancellationToken cancellationToken = default);

    Task<bool> ExistsByCodeAsync(string code, CancellationToken cancellationToken = default);

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
