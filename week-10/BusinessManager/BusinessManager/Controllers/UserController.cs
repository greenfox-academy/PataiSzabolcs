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

        [HttpGet("edituser")]
        public IActionResult EditUser()
        {
            return View();
        }

        [HttpGet("addclient")]
        public IActionResult AddClient()
        {
            return View(userService.GetAllUsers());
        }

        [HttpPost("addclient")]
        public IActionResult ClientAdded(string name, int clientAdminId)
        {
            userService.AddClient(name, clientAdminId);
            return RedirectToAction("Index");
        }

        [HttpGet("addcase")]
        public IActionResult AddCase()
        {
            return View(userService.GetAllClientsAndUsers());
        }

        [HttpPost("addcase")]
        public IActionResult CaseAdded(int clientId, string title, int caseAdminId)
        {
            userService.AddCase(clientId, title, caseAdminId);
            return RedirectToAction("Index");
        }

        [HttpGet("addfeeearner")]
        public IActionResult AddFeeEarner()
        {
            return View(userService.GetAllCaseAndUsers());
        }

        [HttpPost("addfeeearner")]
        public IActionResult FeeEarnerAdded(int caseId, int feeEarnerId, double rate)
        {
            userService.AddFeeEarner(caseId, feeEarnerId, rate);
            return RedirectToAction("Index");
        }

        [HttpGet("addevent")]
        public IActionResult AddEvent()
        {
            return View(userService.GetAllCases());
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
            return View(userService.GetAllCases());
        }

        [HttpPost("adddocument")]
        public IActionResult DocumentAdded(string title, string path, int caseId)
        {
            userService.AddDocument(title, path, caseId);
            return RedirectToAction("Index");
        }
    }
}
