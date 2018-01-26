using Microsoft.EntityFrameworkCore;
using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit
{
    public class PostRepository
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public DbSet<Post> GetAllPosts()
        {
            return postContext.PostList;
        }

        public Post AddPost(string username, Post json)
        {
            json.Owner = postContext.UserList.FirstOrDefault(u => u.Username.Equals(username));
            json.Owner.Posts.Add(json);
            postContext.UserList.Load();
            postContext.PostList.Add(json);
            postContext.SaveChanges();
            return json;
        }

        public Post UpvotePost(string username, int id)
        {
            var upvotePost = postContext.PostList.FirstOrDefault(p => p.Id == id);
            upvotePost.Score += 1;
            postContext.SaveChanges();
            return upvotePost;
        }

        public Post DownpvotePost(string username, int id)
        {
            var upvotePost = postContext.PostList.FirstOrDefault(p => p.Id == id);
            upvotePost.Score -= 1;
            postContext.SaveChanges();
            return upvotePost;
        }

        public Post DeletePost(string username, int id)
        {
            var postToDelete = postContext.PostList.FirstOrDefault(p => p.Id == id);
            postContext.PostList.Remove(postToDelete);
            postContext.SaveChanges();
            return postToDelete;
        }

        public Post UpdatePost(string username, int id, Post json)
        {
            var updatedPost = postContext.PostList.FirstOrDefault(p => p.Id == id);
            updatedPost.Title = json.Title;
            updatedPost.Url = json.Url;
            postContext.SaveChanges();
            return updatedPost;
        }
    }
}
