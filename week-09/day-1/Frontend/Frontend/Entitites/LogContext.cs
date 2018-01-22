using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using RESTExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTExercises.Entitites
{
    public class LogContext : DbContext
    {
        public DbSet<Log> LogEntries { get; set; }

        public LogContext(DbContextOptions options) : base(options)
        {
        }
    }
}
