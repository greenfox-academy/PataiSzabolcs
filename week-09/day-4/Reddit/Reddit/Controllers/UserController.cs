using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        private UserRepository userRepository;

        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser([FromRoute] int id)
        {
            var user = userRepository.GetUser(id);
            return Json(new
            {
                id = user.Id,
                username = user.Username,
                postcount = user.Posts.Count()
            });
        }

        [HttpPost("add")]
        public IActionResult AddUser([FromBody]User newUser)
        {
            var addedUser = userRepository.AddUser(newUser);
            return Json(new
            {
                addedUser
            });
        }
    }
}
