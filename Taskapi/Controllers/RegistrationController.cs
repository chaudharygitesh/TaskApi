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
