using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementDemo.Application.Tasks.Interfaces;
using TaskManagementDemo.Infrastructure.Persistence;
using TaskManagementDemo.Infrastructure.Repositories;

namespace TaskManagementDemo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36))));

        services.AddScoped<ITaskStatusRepository, TaskStatusRepository>();

        return services;
    }
}
