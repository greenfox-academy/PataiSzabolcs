using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.ViewModels
{
    public class GreetingViewModel
    {
        public List<Greeting> GreetingList { get; set; }

        public GreetingViewModel()
        {
            GreetingList = new List<Greeting>();
        }
    }
}
