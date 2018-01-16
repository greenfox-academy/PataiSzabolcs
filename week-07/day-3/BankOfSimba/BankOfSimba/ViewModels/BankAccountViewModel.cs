using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;

namespace BankOfSimba.ViewModels
{
    public class BankAccountViewModel
    {
        public List<BankAccount> BankAccounts { get; set; }

        public BankAccountViewModel()
        {
            BankAccounts = new List<BankAccount>();
            BankAccounts.Add(new BankAccount("Timon", 5000, "Monguse?"));
            BankAccounts.Add(new BankAccount("Pumba", 6000, "PigOrWhateva\'"));
            BankAccounts.Add(new BankAccount("Simba's Woman", 3000, "Lion"));
            BankAccounts.Add(new BankAccount("Scar", 1500000, "Lion") { IsBad = true });
            BankAccounts.Add(new BankAccount("Simba", 15000000, "Lion") { IsKing = true });
        }
    }
}
