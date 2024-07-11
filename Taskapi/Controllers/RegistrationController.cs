using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shared.Model;
using Task.Infrastructure.DbCont;

namespace Taskapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public class RegistrationController : ControllerBase
    {
        private readonly DbComand _context;
        public RegistrationController(DbComand context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<RegistrationModel>> GetInfoRegister()
        {
            return _context.Shopping.ToList();
        }
        //[HttpPost("register")]
        //public async Task<IActionResult> Register(RegisterDto registerDto)
        //{
        //    if (_context.GDUser.Any(u => u.Email == registerDto.Email))
        //    {
        //        return BadRequest(new { message = "Email already in use." });
        //    }

        //    // Hash the password using BCrypt
        //    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(registerDto.Password);

        //    var user = new GDUser
        //    {
        //        Name = registerDto.Name,
        //        Email = registerDto.Email,
        //        Phone = registerDto.Phone,
        //        Address = registerDto.Address,
        //        Password = hashedPassword,
        //        Role = registerDto.Role
        //    };

        //    _context.GDUser.Add(user);
        //    await _context.SaveChangesAsync();

        //    return Ok(new { message = "User registered successfully." });
        //}
        [HttpPost]
        public ActionResult<RegistrationModel> GetRegisterInfo(RegistrationModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            _context.Shopping.Add(model);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetInfoRegister), new { id = model.Id }, model);
        }
    }
}
