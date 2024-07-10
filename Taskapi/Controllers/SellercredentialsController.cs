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
    public class SellercredentialsController : ControllerBase
    {
        private readonly DbComand _context;
        public SellercredentialsController(DbComand context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<sellercredentials>> GetInfoRegister()
        {
            return _context.SellerCred.ToList();
        }
        [HttpPost]
        public ActionResult<sellercredentials> PostsellerInfo(sellercredentials model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            _context.SellerCred.Add(model);                                                                                               
            _context.SaveChanges();
            return CreatedAtAction(nameof(PostsellerInfo), new { id = model.Id }, model);
        }
        [HttpPut]
        public ActionResult<sellercredentials> UpdateSellerInfo(sellercredentials model)
        {

        }
    }
}
