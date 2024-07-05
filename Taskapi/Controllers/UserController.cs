using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shared.Model;
using Task.Application.IServices;

namespace Taskapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServices _UserService;
        public UserController (IServices UserService)
        {
            _UserService = UserService;
        }
        [HttpGet]
        [Route("/GetUser")]
        public RegistrationModel GetUserById(int Id)
        {
           return  _UserService.GetUserById(Id);
        }
    }
}
