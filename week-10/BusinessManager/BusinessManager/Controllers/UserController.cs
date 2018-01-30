using BusinessManager.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        private UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("adduser")]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost("adduser")]
        public IActionResult UserAdded(string username, string password)
        {
            userService.AddUser(username, password);
            return RedirectToAction("Index");
        }

        [HttpGet("addnewclient")]
        public IActionResult AddNewClient()
        {
            return View();
        }

        [HttpPost("addnewclient")]
        public IActionResult NewClientAdded(string name, string clientAdmin)
        {
            userService.AddClient(name, clientAdmin);
            return RedirectToAction("Index");
        }

        [HttpGet("addcase")]
        public IActionResult AddCase()
        {
            return View();
        }

        [HttpPost("addcase")]
        public IActionResult CaseAdded(int clientId, string caseAdmin)
        {
            userService.AddCase(clientId, caseAdmin);
            return RedirectToAction("Index");
        }

        [HttpGet("addfeeearner")]
        public IActionResult AddFeeEarner()
        {
            return View();
        }

        [HttpPost("addfeeearner")]
        public IActionResult FeeEarnerAdded(int caseId, string feeEarner)
        {
            userService.AddFeeEarner(caseId, feeEarner);
            return RedirectToAction("Index");
        }

        [HttpGet("addevent")]
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost("addevent")]
        public IActionResult EventAdded(int caseId, string title, DateTime date)
        {
            userService.AddEvent(caseId, title, date);
            return RedirectToAction("Index");
        }

        [HttpGet("adddocument")]
        public IActionResult AddDocument()
        {
            return View();
        }

        [HttpPost("adddocument")]
        public IActionResult DocumentAdded(string path, int caseId)
        {
            userService.AddDocument(path, caseId);
            return RedirectToAction("Index");
        }
    }
}
