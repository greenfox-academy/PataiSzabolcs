using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTExercises.Models;
using RESTExercises.Repository;

namespace RESTExercises.Controllers
{
    public class HomeController : Controller
    {
        private HomeRepository homeRepository;

        public HomeController(HomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        [Route("")]
        public IActionResult Index()
        {
            homeRepository.LogNewEntry(GetEndpoint(), GetReceivedData());

            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling(int? input)
        {
            homeRepository.LogNewEntry(GetEndpoint(), GetReceivedData());

            if (input != null)
            {
                return Json(new { received = input, result = input * 2 });
            }
            return Json(new { error = "Please provide an input!"});
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            homeRepository.LogNewEntry(GetEndpoint(), GetReceivedData());

            if (name != null && title != null)
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            return Json(new { error = "Please provide a title!" });
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppandA([FromRoute]string appendable)
        {
            homeRepository.LogNewEntry(GetEndpoint(), GetReceivedData());

            if (appendable != null)
            {
                return Json(new { appended = appendable + "a"});
            }
            return StatusCode(404);
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil([FromRoute]string what, int? until)
        {
            homeRepository.LogNewEntry(GetEndpoint(), GetReceivedData());

            if (until != null)
            {
                if (what.Equals("sum"))
                {
                    int sumOfNumbers = 0;
                    for (int i = 0; i < until; i++)
                    {
                        sumOfNumbers += i + 1;
                    }
                    return Json(new { result = sumOfNumbers});
                }

                if (what.Equals("factor"))
                {
                    int factorial = 1;
                    for (int i = 1; i < until + 1; i++)
                    {
                        factorial *= i;
                    }
                    return Json(new { result = factorial});
                }
            }
            return Json(new { error = "Please provide a number!" });
        }

        [HttpPost("/arrays")]
        public IActionResult Arrays(string what, int[] numbers)
        {
            homeRepository.LogNewEntry(GetEndpoint(), GetReceivedData());

            if (what != null && numbers != null && numbers.Length != 0)
            {
                if (what.Equals("sum"))
                {
                    int sumOfNumbers = numbers.Sum();
                    return Json(new { result = sumOfNumbers});
                }

                if (what.Equals("multiply"))
                {
                    int product = 1;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        product *= numbers[i];
                    }
                    return Json(new { result = product });
                }

                if (what.Equals("double"))
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] *= 2;
                    }
                    return Json(new { result = numbers});
                }
            }
            if (what == null)
            {
                return Json(new { error = "Please provide an operation!" });
            }
            return Json(new { error = "Please provide a number!" });
        }

        [HttpGet("/log")]
        public IActionResult Log(int input)
        {
            homeRepository.LogNewEntry(GetEndpoint(), GetReceivedData());

            return Json(new { entries = homeRepository.LogContext.LogEntries, entry_count = homeRepository.LogContext.LogEntries.Count()});
        }

        public string GetEndpoint()
        {
            return HttpContext.Request.Path.ToString();
        }

        public string GetReceivedData()
        {
            return HttpContext.Request.QueryString.ToString();
        }
    }
}