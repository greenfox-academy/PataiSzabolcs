using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todos.Models;

namespace Todos.Entities
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> TodoList { get; set; }

        public TodoContext(DbContextOptions options) : base(options)
        {
        }
    }
}
