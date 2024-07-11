using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shared.Model;
using System;
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
        public IActionResult Update(sellercredentials person)
        {
            _context.Update(person);
            _context.SaveChanges();
            var patched = _context.SellerCred.FirstOrDefault(a => a.Id == person.Id);

            var model = new
            {
                sent = person,
                after = patched
            };
            return Ok(model);
        }
        [HttpDelete]
        [HttpDelete("Remove/{productid}")]
        public ActionResult<sellercredentials> DeleteProduct(int productid)
        {
            var products = _context.SellerCred.Find(productid);

            if (products == null) return NotFound();
            _context.SellerCred.Remove(products);

            _context.SaveChanges();
            return Ok();
        }
    }
}
