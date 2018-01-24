using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBillingApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BillableHours { get; set; }
        public int HourlyRate { get; set; }
        public double PayableAmount { get; set; }
        public int BillingDay { get; set; }
        public bool IsPaid { get; set; }

        public int UserId { get; set; }
        public User ServiceProvider { get; set; }

        public Client()
        {
        }
    }
}
