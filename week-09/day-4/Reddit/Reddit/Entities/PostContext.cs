using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> PostList { get; set; }
        public DbSet<User> UserList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(u => u.Posts)
                 .WithOne(p => p.Owner)
                 .HasPrincipalKey(u => u.Id);
        }
    }
}
