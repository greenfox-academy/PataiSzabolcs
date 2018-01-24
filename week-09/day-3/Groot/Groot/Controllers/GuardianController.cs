using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groot.Controllers
{
    [Route("")]
    public class GuardianController : Controller
    {
        [HttpGet("groot")]
        public IActionResult Groot([FromQuery]string message)
        {
            if (message != null)
            {
                return Json(new { received = message, translated = "I am Groot!" });
            }
            else
            {
                return StatusCode(400, new { error = "I am Groot!" });
            }
        }
    }
}
