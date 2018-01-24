using Microsoft.EntityFrameworkCore;
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
        public User User { get; set; }
        
        public ClientRepository(ClientContext clientContext, User user)
        {
            ClientContext = clientContext;
            User = user;
        }

        public bool SetUser(string username, string password)
        {
            if (ClientContext.UserList.FirstOrDefault(u => u.Username.Equals(username)) != null && ClientContext.UserList.FirstOrDefault(u => u.Username.Equals(username)).Password.Equals(password))
            {
                User.Username = username;
                User.Password = password;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsAdmin()
        {
            return (User.Username.Equals("Szabi") && User.Password.Equals("password"));
        }

        public List<Client> GetAll()
        {
            ClientContext.UserList.Load();
            ClientContext.ClientList.Load();
            if (IsAdmin())
            {
                return ClientContext.ClientList.OrderBy(c => c.Id).ToList();
            }
                return ClientContext.UserList.FirstOrDefault(u => u.Username.Equals(User.Username)).Clients.OrderBy(c => c.Id).ToList();
        }

        public List<User> GetAllUser()
        {
                ClientContext.ClientList.Load();
                return ClientContext.UserList.ToList();
        }

        public Client GetClient(int id)
        {
            return ClientContext.ClientList.FirstOrDefault(x => x.Id == id);
        }

        public void SetPayment (int id, bool isPaid)
        {
            var clientToModify = ClientContext.ClientList.Where(c => c.Id == id).ToList();
            clientToModify[0].IsPaid = isPaid;
            ClientContext.SaveChanges();
        }

        public void AddClient (string name, double billableHours, int hourlyRate, int billingDay, bool isPaid, int userId)
        {
            var addedClient = new Client() { Name = name, BillableHours = billableHours, HourlyRate = hourlyRate, BillingDay = billingDay, IsPaid = isPaid, UserId = userId, ServiceProvider = ClientContext.UserList.FirstOrDefault(u => u.Id == userId)};
            ClientContext.ClientList.Add(addedClient);
            ClientContext.UserList.FirstOrDefault(u => u.Id == userId).Clients.Add(addedClient);
            ClientContext.SaveChanges();
        }

        public void AddUser(string username, string password)
        {
                ClientContext.UserList.Add(new User() { Username = username, Password = password, Clients = new List<Client>() });
                ClientContext.SaveChanges();
        }

        public void EditClient(int id, string name, double billableHours, int hourlyRate, int billingDay, int userId)
        {
            ClientContext.UserList.Load();
            GetClient(id).Name = name;
            GetClient(id).BillableHours = billableHours;
            GetClient(id).HourlyRate = hourlyRate;
            GetClient(id).BillingDay = billingDay;
            GetClient(id).Id = id;
            GetClient(id).UserId = userId;
            GetClient(id).ServiceProvider = ClientContext.UserList.FirstOrDefault(u => u.Id == userId);
            ClientContext.SaveChanges();    
        }

        public void DeleteClient(int id)
        {
            var client = ClientContext.ClientList.FirstOrDefault(x => x.Id == id);
            ClientContext.ClientList.Remove(client);
            var user = ClientContext.UserList.FirstOrDefault(u => u.Clients.Contains(client));
            user.Clients.Remove(client);
            ClientContext.SaveChanges();
        }
    }
}
