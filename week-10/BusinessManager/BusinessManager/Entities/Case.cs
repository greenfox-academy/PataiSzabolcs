using System.Collections.Generic;

namespace BusinessManager.Entities
{
    public class Case
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public List<User> CaseAdmins { get; set; }
        public Dictionary<User, double> HourlyRates { get; set; }
        public List<string> Documents { get; set; }
        public List<Event> Events { get; set; }
        public Dictionary<User, double> BillableHours { get; set; }
    }
}