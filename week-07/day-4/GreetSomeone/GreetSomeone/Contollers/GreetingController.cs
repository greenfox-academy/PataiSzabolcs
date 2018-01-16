using GreetSomeone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Contollers
{
    public class GreetingController : Controller
    {
        GreetingViewModel greetingViewModel;

        public GreetingController(GreetingViewModel greetingViewModel)
        {
            this.greetingViewModel = greetingViewModel;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult AddName(Greeting greeting)
        {
            greetingViewModel.GreetingList.Add(greeting);
            return View("greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View(greetingViewModel);
        }
    }
}
