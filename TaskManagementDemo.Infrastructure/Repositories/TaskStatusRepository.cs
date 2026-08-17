using Microsoft.EntityFrameworkCore;
using TaskManagementDemo.Application.Tasks.Interfaces;
using TaskManagementDemo.Infrastructure.Persistence;
using TaskStatus = TaskManagementDemo.Domain.Entities.TaskStatus;

namespace TaskManagementDemo.Infrastructure.Repositories;

public class TaskStatusRepository : ITaskStatusRepository
{
    private readonly AppDbContext _dbContext;

    public TaskStatusRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(TaskStatus taskStatus, CancellationToken cancellationToken = default)
    {
        await _dbContext.TaskStatuses.AddAsync(taskStatus, cancellationToken);
    }

    public Task<bool> ExistsByCodeAsync(string code, CancellationToken cancellationToken = default)
    {
        return _dbContext.TaskStatuses.AnyAsync(x => x.Code == code, cancellationToken);
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _dbContext.SaveChangesAsync(cancellationToken);
    }
}
