using shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task.Application.IRepository
{
    public interface IRepository
    {
        public void AddUser(RegistrationModel user);
        public RegistrationModel GetUserById(int id);    
    }
}
