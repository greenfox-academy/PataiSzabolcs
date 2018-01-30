using System;
using System.Collections.Generic;

namespace BusinessManager.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public IList<User> Participants { get; set; }
        public Case Case { get; set; }
        public string Description { get; set; }
        public IList<Document> Documents { get; set; }
    }
}