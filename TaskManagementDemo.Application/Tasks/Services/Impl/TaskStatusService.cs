using TaskManagementDemo.Application.Tasks.DTOs.TaskStatus;
using TaskManagementDemo.Application.Tasks.Interfaces;

namespace TaskManagementDemo.Application.Tasks.Services.Impl;

public class TaskStatusService : ITaskStatusService
{
   private readonly ITaskStatusRepository _taskStatusRepository;
   
   public TaskStatusService(ITaskStatusRepository taskStatusRepository)
   {
      _taskStatusRepository = taskStatusRepository;
   }

   public Task<TaskStatusResponse> CreateAsync(CreateTaskStatusRequest request, CancellationToken cancellationToken = default)
   {
      throw new NotImplementedException();
   }
}