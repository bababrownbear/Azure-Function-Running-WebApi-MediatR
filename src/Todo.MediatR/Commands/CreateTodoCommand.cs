using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.MediatR.Commands
{
    public class CreateTodoCommand : IRequest<TodoDto>
    {
        public string Todo { get; set; }
    }

    public class Handler : IRequestHandler<CreateTodoCommand, TodoDto>
    {
        public async Task<TodoDto> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            return new TodoDto()
            {
                Id = Guid.NewGuid().ToString(),
                Todo = request.Todo
            };
        }
    }
}
