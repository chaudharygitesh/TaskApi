using shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Application.IRepository;
using Task.Application.IServices;

namespace Task.Infrastructure.Implementation.Services
{
    public class UserServices : IServices
    {
        private readonly IRepository  _UserRepository;
        public UserServices(IRepository UserRepository) {
            _UserRepository = UserRepository;
        }
        public void AddUser(RegistrationModel user)
        {
            _UserRepository.AddUser(user);
        }

        public RegistrationModel GetUserById(int Id)
        {
            _UserRepository.GetUserById(Id);
        }
    }
}
