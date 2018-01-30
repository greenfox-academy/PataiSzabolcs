using System;
using System.Collections.Generic;

namespace BusinessManager.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<User> Participants { get; set; }
        public Case Case { get; set; }
        public string Description { get; set; }
    }
}