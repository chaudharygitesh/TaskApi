using shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task.Application.IServices
{
    public interface IServices
    {
        public void AddUser(RegistrationModel user);
        public RegistrationModel GetUserById(int id);
    }

}
