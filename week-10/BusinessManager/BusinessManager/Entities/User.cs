using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Client> AdministeredClients { get; set; }
        public List<Case> AdministeredCases { get; set; }
        public List<Case> WorkedCases { get; set; }
        public List<Event> Events { get; set; }
    }
}
