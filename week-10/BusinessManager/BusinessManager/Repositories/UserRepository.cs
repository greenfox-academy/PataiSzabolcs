using BusinessManager.Entities;
using BusinessManager.Models;
using BusinessManager.Models.JointModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Repositories
{
    public class UserRepository
    {
        private BusinessContext businessContext;

        public UserRepository(BusinessContext businessContext)
        {
            this.businessContext = businessContext;
        }

        public void AddUser(string username, string password, string salt)
        {
            businessContext.Users.Add(new User
            {
                Username = username,
                Password = password,
                Salt = salt,
                AdministeredClients = new List<ClientAdmin>(),
                Billables = new List<Billable>(),
                Events = new List<Event>()
            });
            businessContext.SaveChanges();
        }

        public void AddClient(string name, int clientAdminId)
        {
            businessContext.Users.Load();
            businessContext.Clients.Add(new Client
            {
                Name = name,
                ClientAdmins = new List<ClientAdmin>()
                {
                    new ClientAdmin() { Admin = GetUser(clientAdminId) }
                },
                Cases = new List<Case>(),
                BillingInfo = new BillingInfo(),
                ContactPeople = new List<ContactPerson>()
            });
            businessContext.SaveChanges();
        }

        internal void AddDocument(string title, string path, int caseId)
        {
            businessContext.Documents.Add(new Document
            {
                Title = title,
                Path = path,
                Case = GetCase(caseId),
                Events = new List<DocumentEvent>()
            });
            businessContext.SaveChanges();
        }

        public void AddEvent(int caseId, string title, DateTime date)
        {
            businessContext.Events.Add(new Event
            {
                Case = GetCase(caseId),
                Title = title,
                Date = date,
                Participants = new List<UserEvent>(),
                Documents = new List<DocumentEvent>()
            });
            businessContext.SaveChanges();
        }

        public void AddCase(int clientId, string title, int caseAdminId)
        {
            businessContext.Users.Load();
            businessContext.Clients.Load();
            businessContext.Cases.Add(new Case
            {
                Client = GetClient(clientId),
                Title = title,
                CaseAdmins = new List<CaseAdmin>()
                {
                    new CaseAdmin() { Admin = GetUser(caseAdminId) }
                },
                Billables = new List<Billable>(),
                Documents = new List<Document>(),
                Events = new List<Event>()
            });
            businessContext.SaveChanges();
        }
        
        public void AddFeeEarner(int caseId, int feeEarnerId, double rate)
        {
            businessContext.Users.Load();
            businessContext.Cases.Load();
            businessContext.Billables.Add(new Billable
            {
                Case = GetCase(caseId),
                FeeEarner = GetUser(feeEarnerId),
                HourlyRate = rate
            });
            businessContext.SaveChanges();
        }

        private User GetUser(int userId)
        {
            return businessContext.Users.FirstOrDefault(u => u.Id == userId);
        }

        private Client GetClient(int id)
        {
            return businessContext.Clients.FirstOrDefault(c => c.Id == id);
        }

        private Case GetCase(int id)
        {
            return businessContext.Cases.FirstOrDefault(c => c.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return businessContext.Users.ToList();
        }

        public List<Client> GetAllClients()
        {
            return businessContext.Clients.ToList();
        }

        public List<Case> GetAllCases()
        {
            return businessContext.Cases.ToList();
        }
    }
}
