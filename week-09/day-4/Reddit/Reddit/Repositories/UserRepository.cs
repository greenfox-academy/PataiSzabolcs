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

        public User AddUser(User json)
        {
            postContext.UserList.Add(json);
            postContext.SaveChanges();
            return json;
        }

        public User GetUser(int id)
        {
            return postContext.UserList.FirstOrDefault(u => u.Id == id);
        }

        public int UserCount()
        {
            return postContext.UserList.Count();
        }
    }
}
