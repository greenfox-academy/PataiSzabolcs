using System.Collections.Generic;

namespace BusinessManager.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Case> Cases { get; set; }
        public List<User> ClientAdmins { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}