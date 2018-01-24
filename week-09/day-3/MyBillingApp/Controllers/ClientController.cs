using Microsoft.AspNetCore.Mvc;
using MyBillingApp.Entities;
using MyBillingApp.Models;
using MyBillingApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBillingApp.Controllers
{
    [Route("")]
    public class ClientController : Controller
    {
        private ClientRepository clientRepository;
                
        public ClientController(ClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        [HttpGet("")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            bool IsActualUser = clientRepository.SetUser(username, password);
            
            if (IsActualUser)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("LoginPage");
            }
            //}
            //else
            //{
            //    return View("LoginPage");
            //}
        }

        [HttpGet("list")]
        public IActionResult Index()
        {
            return View(clientRepository.GetAll());
        }

        [HttpGet("alluser")]
        public IActionResult UserList()
        {
            if (clientRepository.IsAdmin())
            {
                return View(clientRepository.GetAllUser());
            }
            else
            {
                return RedirectToAction("Index");
            }            
        }

        [HttpPost("paid")]
        public IActionResult Payment(int id)
        {
            clientRepository.SetPayment(id, true);
            return RedirectToAction("Index");
        }

        [Route("add")]
        public IActionResult NewClient()
        {
            return View();
        }

        [HttpPost("addclient")]
        public IActionResult ClientAdded(string name, int hourlyRate, int billingDay, int userId)
        {
            clientRepository.AddClient(name, 0, hourlyRate, billingDay, false, userId);
            return RedirectToAction("Index");
        }

        [Route("edit")]
        public IActionResult EditClient(int id)
        {
            var client = clientRepository.GetClient(id);
            return View(client);
        }

        [HttpPost("editclient")]
        public IActionResult ClientEdited(int id, string name, double billableHours, int hourlyRate, int billingDay, int userId)
        {
            clientRepository.EditClient(id, name, billableHours, hourlyRate, billingDay, userId);
            return RedirectToAction("Index");
        }

        [Route("adduser")]
        public IActionResult AddUser()
        {
            if (clientRepository.IsAdmin())
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("addnewuser")]
        public IActionResult UserAdded(string username, string password)
        {
            clientRepository.AddUser(username, password);
            return RedirectToAction("Index");
        }
    }
}
