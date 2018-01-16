using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

namespace BankOfSimba.Controllers
{
    public class BankAccountController : Controller
    {
        public static BankAccountViewModel BankAccountViewModel = new BankAccountViewModel();

        [Route("Simba")]
        public IActionResult Index()
        {
            var bankAccount = new BankAccount("Simba", 2000, "Lion");
            return View(bankAccount);
        }

        [HttpGet("Accounts")]
        public IActionResult Accounts()
        {          
             return View(BankAccountViewModel);
        }

        [HttpPost("raise")]
        public IActionResult GiveMoney(string name)
        {
            foreach (var account in BankAccountViewModel.BankAccounts)
            {
                if (account.Name == name)
                {
                    if (account.IsKing)
                    {
                        account.Balance += 100;
                    }
                    else
                    {
                        account.Balance += 10;
                    }
                }
            }
            return RedirectToAction("Accounts");
        }
    }
}