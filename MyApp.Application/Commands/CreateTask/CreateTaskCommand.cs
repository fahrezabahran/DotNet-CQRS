using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MyApp.Application.Commands.CreateTask
{
    public record CreateTaskCommand(string Title) : IRequest<Guid>;

}
