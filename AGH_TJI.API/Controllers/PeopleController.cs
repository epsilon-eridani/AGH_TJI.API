using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGH_TJI.API.Models;
using AGH_TJI.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AGH_TJI.API.Controllers
{
    
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private IPeopleInfoRepository _people;
        

        public PeopleController(IPeopleInfoRepository people)
        {
            _people = people;
        }

        // GET api/values
        [HttpGet, Authorize]
        public IActionResult GetPeople()
        {
            var peopleEntities = _people.GetPeople();
            return Ok(peopleEntities);
        }

        // GET api/values/5
        
        [HttpGet("{id}")]
        public IActionResult GetPerson(int id)
        {
            var person = _people.GetPerson(id);
            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        public void Post(People people)
        {
            if (ModelState.IsValid)
            {
                _people.AddPerson(people);
                
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
