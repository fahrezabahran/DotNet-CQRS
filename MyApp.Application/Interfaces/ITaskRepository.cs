using MyApp.Domain.Entities;

namespace MyApp.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task AddAsync(TaskItem task);
        Task<List<TaskItem>> GetAllAsync();
    }
}
