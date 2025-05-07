using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Application.Interfaces;
using MyApp.Application.Models;

namespace MyApp.Application.Queries.GetTasks
{
    public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, List<TaskDto>>
    {
        private readonly ITaskRepository _repository;

        public GetTasksQueryHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TaskDto>> Handle(GetTasksQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _repository.GetAllAsync();
            return tasks.Select(t => new TaskDto(t.Id, t.Title, t.CreatedAt)).ToList();
        }
    }
}
