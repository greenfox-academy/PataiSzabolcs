using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Controllers
{
    [Route("posts")]
    public class PostsController : Controller
    {
        private PostRepository postRepository;

        public PostsController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [HttpGet("")]
        public IActionResult AllPosts()
        {
            return StatusCode(200, new { posts = postRepository.GetAllPosts() });
        }

        [HttpPost("")]
        public IActionResult NewPost([FromHeader] string username, [FromBody] Post json)
        {
            Request.HttpContext.Response.Headers.Add("Username", username);
            var addedPost = postRepository.AddPost(username, json);
            return Json(new
            {
                id = addedPost.Id,
                title = addedPost.Title,
                url = addedPost.Url,
                timestamp = addedPost.TimeStamp,
                score = addedPost.Score,
            });
        }

        [HttpPut("{id}/upvote")]
        public IActionResult Upvote([FromHeader] string username, [FromRoute] int id)
        {
            Request.HttpContext.Response.Headers.Add("Username", username);
            var upvotedPost = postRepository.UpvotePost(username, id);
            return Json(new
            {
                id = upvotedPost.Id,
                title = upvotedPost.Title,
                url = upvotedPost.Url,
                timestamp = upvotedPost.TimeStamp,
                score = upvotedPost.Score
            });
        }

        [HttpPut("{id}/upvote")]
        public IActionResult Downvote([FromHeader] string username, [FromRoute] int id)
        {
            Request.HttpContext.Response.Headers.Add("Username", username);
            var upvotedPost = postRepository.UpvotePost(username, id);
            return Json(new
            {
                id = upvotedPost.Id,
                title = upvotedPost.Title,
                url = upvotedPost.Url,
                timestamp = upvotedPost.TimeStamp,
                score = upvotedPost.Score
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePost([FromHeader] string username, [FromRoute] int id, [FromBody] Post json)
        {
            Request.HttpContext.Response.Headers.Add("Username", username);
            var updatedPost = postRepository.UpdatePost(username, id, json);
            return Json(new
            {
                id = updatedPost.Id,
                title = updatedPost.Title,
                url = updatedPost.Url,
                timestamp = updatedPost.TimeStamp,
                score = updatedPost.Score
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost([FromHeader] string username, [FromRoute] int id)
        {
            Request.HttpContext.Response.Headers.Add("Username", username);
            var deletedPost = postRepository.DeletePost(username, id);
            return Json(new
            {
                id = deletedPost.Id,
                title = deletedPost.Title,
                url = deletedPost.Url,
                timestamp = deletedPost.TimeStamp,
                score = deletedPost.Score
            });
        }
    }
}
