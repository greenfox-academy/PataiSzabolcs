using Microsoft.EntityFrameworkCore;
using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class UserRepository
    {
        private PostContext postContext;

        public UserRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public User AddUser(User newUser)
        {
            postContext.UserList.Add(newUser);
            postContext.SaveChanges();
            return newUser;
        }

        public User GetUser(int id)
        {
            postContext.PostList.Load();
            return postContext.UserList.FirstOrDefault(u => u.Id == id);
        }

        public int UserCount()
        {
            return postContext.UserList.Count();
        }
    }
}
