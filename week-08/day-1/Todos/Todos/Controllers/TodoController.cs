using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todos.Models;
using Todos.Repositories;

namespace Todos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        public TodoRepository TodoRepository { get; set; }

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [HttpGet("")]
        [Route("list")]
        public IActionResult List()
        {
            return View(TodoRepository.TodoContext.TodoList);
        }
    }
}
