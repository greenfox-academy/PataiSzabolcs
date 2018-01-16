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
        public IActionResult Index()
        {
            return View(clientRepository.GetAll());
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
        public IActionResult ClientAdded(string name, int hourlyRate, int billingDay)
        {
            clientRepository.AddClient(name, 0, hourlyRate, billingDay, false);
            return RedirectToAction("Index");
        }
    }
}
