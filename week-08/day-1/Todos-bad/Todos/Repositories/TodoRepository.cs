using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todos.Entities;
using Todos.Models;

namespace Todos.Repositories
{
    public class TodoRepository
    {
        public TodoContext TodoContext { get; set; }

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public void CreateTodo(Todo todo)
        {
            TodoContext.TodoList.Add(todo);
            TodoContext.SaveChanges();
        }
    }
}
