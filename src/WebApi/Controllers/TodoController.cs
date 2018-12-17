using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Todo.MediatR.Commands;
using Todo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator _mediator;

        [HttpGet]
        [Route("{todo}")]
        public async Task<JsonResult> Create(CreateTodoCommand query, CancellationToken cancellationtoken)
        {
            TodoDto todoDto = await _mediator.Send(query, cancellationtoken);

            return Json(todoDto);
        }
    }
}
