namespace TaskManagementDemo.Application.Tasks.Interfaces;
using TaskManagementDemo.Domain.Entities;

public interface ITaskStatusRepository
{
    Task AddAsync(TaskStatus taskStatus, CancellationToken cancellationToken = default);
}