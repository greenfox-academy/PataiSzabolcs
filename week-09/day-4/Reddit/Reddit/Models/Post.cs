using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public int Score { get; set; } = 0;
        public User Owner { get; set; }
    }
}
