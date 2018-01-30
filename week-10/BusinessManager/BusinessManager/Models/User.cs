using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Client> AdministeredClients { get; set; }
        public IList<Case> AdministeredCases { get; set; }
        public IList<Case> WorkedCases { get; set; }
        public IList<Event> Events { get; set; }
    }
}
