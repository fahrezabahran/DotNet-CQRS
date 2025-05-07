using MediatR;
using MyApp.Application.Models;

namespace MyApp.Application.Queries.GetTasks
{
    public record GetTasksQuery() : IRequest<List<TaskDto>>;
}
