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
        public DbSet<User> UserList { get; set; }

        public ClientContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(u => u.Clients)
                 .WithOne(c => c.ServiceProvider)
                 .HasPrincipalKey(u => u.Id);
        }
    }
}
