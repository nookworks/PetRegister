using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetRegister.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetRegisterController : ControllerBase
    {
        private readonly ApplicationDbContext _dbase;
        public PetRegisterController(ApplicationDbContext dbContext) => _dbase = dbContext;

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<PetOwner>> getItems()
        {
            return _dbase.PetOwnerList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        //public string Get(int id)
        public ActionResult<PetOwner> getItem(int id)
        {
            var value = _dbase.PetOwnerList.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            return value; 
        }

        // POST api/values
        [HttpPost]
        //public void Post([FromBody]string value)
        public ActionResult<PetOwner> PostItem(PetOwner petowner)
        {
            _dbase.PetOwnerList.Add(petowner);
            _dbase.SaveChanges();
            return CreatedAtAction("PostItem", petowner);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        public ActionResult<PetOwner> PutItem(string owner, PetOwner petowner)
        {
            if (owner != petowner.owner)
            {
                return BadRequest();
            }
            _dbase.Entry(petowner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbase.SaveChanges();
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        //public void Delete(int id)
        public ActionResult<PetOwner> DeleteItem(int id)
        {
            var value = _dbase.PetOwnerList.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            _dbase.PetOwnerList.Remove(value);
            _dbase.SaveChanges();
            return NoContent();
        }

    }
}
