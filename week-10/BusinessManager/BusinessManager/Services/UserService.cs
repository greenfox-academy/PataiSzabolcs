using BusinessManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessManager.Services
{
    public class UserService
    {
        private UserRepository userRepository;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void AddUser(string username, string password)
        {
            userRepository.AddUser(username, password);
        }

        public void AddClient(string name, string clientAdmin)
        {
            userRepository.AddClient(name, clientAdmin);
        }

        public void AddCase(int clientId, string caseAdmin)
        {
            userRepository.AddCase(clientId, caseAdmin);
        }

        public void AddFeeEarner(int caseId, string feeEarner)
        {
            userRepository.AddFeeEarner(caseId, feeEarner);
        }

        public void AddEvent(int caseId, string title, DateTime date)
        {
            userRepository.AddEvent(caseId, title, date);
        }

        public void AddDocument(string path, int caseId)
        {
            userRepository.AddDocument(path, caseId);
        }
    }
}
