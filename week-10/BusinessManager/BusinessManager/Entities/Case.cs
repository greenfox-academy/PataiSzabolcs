using System.Collections.Generic;

namespace BusinessManager.Entities
{
    public class Case
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public List<User> CaseAdmins { get; set; }
        public Dictionary<int, double> FeeEarners { get; set; }
        public List<string> Documents { get; set; }
        public List<Event> Events { get; set; }
        public Dictionary<int, double> BillableHours { get; set; }
    }
}