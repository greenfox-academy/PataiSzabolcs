using BusinessManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Repositories
{
    public class LoginRepository
    {
        private BusinessContext businessContext;

        public LoginRepository(BusinessContext businessContext)
        {
            this.businessContext = businessContext;
        }
    }
}
