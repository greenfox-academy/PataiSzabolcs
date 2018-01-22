using Microsoft.EntityFrameworkCore;
using RESTExercises.Entitites;
using RESTExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTExercises.Repository
{
    public class HomeRepository
    {
        public LogContext LogContext { get; set; }

        public HomeRepository(LogContext logContext)
        {
            LogContext = logContext;
        }

        public void LogNewEntry(string endpoint, string data)
        {
            LogContext.Add(new Log { CreatedAt = DateTime.Now, Endpoint = endpoint, Data = data });
            LogContext.SaveChanges();
        }
    }
}
