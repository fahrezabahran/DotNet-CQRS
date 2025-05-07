using MediatR;
using MyApp.Application.Interfaces;
using MyApp.Domain.Entities;

namespace MyApp.Application.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly ITaskRepository _repository;

        public CreateTaskCommandHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskItem
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                CreatedAt = DateTime.UtcNow
            };

            await _repository.AddAsync(task);
            return task.Id;
        }
    }
}
