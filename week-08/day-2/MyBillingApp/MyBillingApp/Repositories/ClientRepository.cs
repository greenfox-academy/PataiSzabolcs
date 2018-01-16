using MyBillingApp.Entities;
using MyBillingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBillingApp.Repositories
{
    public class ClientRepository
    {
        public ClientContext ClientContext { get; set; }

        public ClientRepository(ClientContext clientContext)
        {
            ClientContext = clientContext;
        }

        public List<Client> GetAll()
        {
            return ClientContext.ClientList.ToList();
        }

        public void SetPayment (int id, bool isPaid)
        {
            var clientToModify = ClientContext.ClientList.Where(c => c.Id == id).ToList();
            clientToModify[0].IsPaid = isPaid;
            ClientContext.SaveChanges();
        }

        public void AddClient (string name, double billableHours, int hourlyRate, int billingDay, bool isPaid)
        {
            ClientContext.ClientList.Add(new Client() {Name = name, BillableHours = billableHours, HourlyRate = hourlyRate, BillingDay = billingDay, IsPaid = isPaid });
            ClientContext.SaveChanges();
        }
    }
}
