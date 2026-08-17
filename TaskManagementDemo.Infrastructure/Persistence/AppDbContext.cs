using Microsoft.EntityFrameworkCore;
using TaskManagementDemo.Domain.Entities;
using TaskStatus = TaskManagementDemo.Domain.Entities.TaskStatus;

namespace TaskManagementDemo.Infrastructure.Persistence;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<TaskStatus> TaskStatuses => Set<TaskStatus>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TaskStatus>(entity =>
        {
            entity.ToTable("task_status");
            
            entity.HasKey(x => x.Id);
            
            entity.Property( x => x.Id).ValueGeneratedOnAdd();
            
            entity.Property(x => x.Code)
                .HasMaxLength(50)
                .IsRequired();

            entity.HasIndex(x => x.Code)
                .IsUnique();
            
            entity.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();
            
            entity.Property(x => x.IsActive).IsRequired();
            entity.Property(x => x.IsInitial).IsRequired();
            entity.Property(x => x.IsCompleted).IsRequired();
            
            entity.Property(x => x.CreatedAt).IsRequired();
            entity.Property(x => x.UpdatedAt).IsRequired();
        });
    }
}