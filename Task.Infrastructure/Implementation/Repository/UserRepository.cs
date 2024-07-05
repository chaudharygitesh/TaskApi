using shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.IRepository;

namespace Task.Infrastructure.Implementation.Repository
{
    public class UserRepository : IRepository
    {
        private readonly List<RegistrationModel> _users = new List<RegistrationModel>();
        public void AddUser(RegistrationModel user)
        {
            _users.Add(user);
        }
        public RegistrationModel GetuserById(int id)
        {
            RegistrationModel user = _users.Single(x => x.Id == id);
            return user;
        }

     
    }
}
