using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

namespace Counter.Controllers
{
    public class VisitorCounterController : Controller
    {
        private VisitorCounter visitorCounter;

        public VisitorCounterController(VisitorCounter visitorCounter)
        {
            this.visitorCounter = visitorCounter;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(visitorCounter);
        }

        [HttpPost("")]
        public IActionResult IncrementCounter()
        {
            visitorCounter.Counter += 1;
            return RedirectToAction("Index");
        }
    }
}