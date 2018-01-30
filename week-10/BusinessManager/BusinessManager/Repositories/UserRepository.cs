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

        public void AddUser(string username, string password)
        {
            businessContext.Users.Add(new User
            {
                Username = username,
                Password = password,
                AdministeredClients = new List<ClientAdmin>(),
                Billables = new List<Billable>(),
                Events = new List<Event>()
            });
        }

        public void AddClient(string name, string clientAdmin)
        {
            businessContext.Users.Load();
            businessContext.Clients.Add(new Client
            {
                Name = name,
                ClientAdmins = new List<ClientAdmin>()
                {
                    new ClientAdmin() { Admin = GetUser(clientAdmin) }
                },
                Cases = new List<Case>(),
                BillingInfo = new BillingInfo(),
                ContactPeople = new List<ContactPerson>()
            });
        }

        internal void AddDocument(string path, int caseId)
        {
            businessContext.Documents.Add(new Document
            {
                Path = path,
                Case = GetCase(caseId),
                Events = new List<DocumentEvent>()
            });
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
        }

        public void AddCase(int clientId, string caseAdmin)
        {
            businessContext.Users.Load();
            businessContext.Clients.Load();
            businessContext.Cases.Add(new Case
            {
                Client = GetClient(clientId),
                CaseAdmins = new List<CaseAdmin>()
                {
                    new CaseAdmin() { Admin = GetUser(caseAdmin) }
                },
                Billables = new List<Billable>(),
                Documents = new List<Document>(),
                Events = new List<Event>()
            });
        }

        public void AddFeeEarner(int caseId, string feeEarner)
        {
            businessContext.Users.Load();
            businessContext.Cases.Load();
            businessContext.Billables.Add(new Billable
            {
                Case = GetCase(caseId),
                FeeEarner = GetUser(feeEarner)
            });
        }

        private User GetUser(string username)
        {
            return businessContext.Users.FirstOrDefault(u => u.Username.Equals(username));
        }

        private Client GetClient(int id)
        {
            return businessContext.Clients.FirstOrDefault(c => c.Id == id);
        }

        private Case GetCase(int id)
        {
            return businessContext.Cases.FirstOrDefault(c => c.Id == id);
        }
    }
}
