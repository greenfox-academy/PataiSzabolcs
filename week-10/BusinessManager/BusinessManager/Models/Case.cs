using BusinessManager.Models.JointModels;
using System.Collections.Generic;

namespace BusinessManager.Models
{
    public class Case
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public IList<User> CaseAdmins { get; set; }
        public IList<Billable> Billables { get; set; }
        public IList<Document> Documents { get; set; }
        public IList<Event> Events { get; set; }
    }
}