﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
