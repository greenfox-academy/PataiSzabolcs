using System.Collections.Generic;

namespace BusinessManager.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Case> Cases { get; set; }
        public List<User> ClientAdmins { get; set; }
        public BillingInfo BillingInfo { get; set; }
        public List<ContactPerson> ContactPeople { get; set; }
        public int GeneralPhone { get; set; }
        public string GeneralEmail { get; set; }
        public string Address { get; set; }
    }
}