using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBillingApp.Models;

namespace MyBillingApp.Entities
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> ClientList { get; set; }

        public ClientContext(DbContextOptions options) : base(options)
        {
        }
    }
}
