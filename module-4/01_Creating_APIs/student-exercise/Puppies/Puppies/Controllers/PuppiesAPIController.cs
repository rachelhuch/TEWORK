using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Puppies.DAL;
<<<<<<< HEAD
using Puppies.Models;
=======
>>>>>>> d91bd39055d92512d6751a12f03224931a9dd31d

namespace Puppies.Controllers
{
    [Route("api/puppies")]
    [ApiController]
    public class PuppiesAPIController : ControllerBase
    {
        private IPuppyDao puppyDao;
        public PuppiesAPIController(IPuppyDao puppyDao)
        {
            this.puppyDao = puppyDao;
        }

        [HttpGet("")]
        public IActionResult GetPuppies()
        {
            return new JsonResult(puppyDao.GetPuppies());
        }
<<<<<<< HEAD


        [HttpGet("{id}", Name = "GetPuppy")]
        [ProducesResponseType(404)]

        public IActionResult GetPuppy(int id)
        {
            Puppy puppy = puppyDao.GetPuppy(id);
            if (puppy == null)
            {
                return NotFound();
            }
            return new JsonResult(puppy);
        }


        [HttpPost("")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]

        public IActionResult AddPuppy([FromBody]Puppy puppy)
        {
            if (ModelState.IsValid)
            {
                int newId = puppyDao.AddPuppy(puppy);
                puppy = puppyDao.GetPuppy(newId);
                return CreatedAtRoute("GetPuppy", new { id = newId }, puppy);
            }
            else
            {
                return new BadRequestObjectResult(ModelState);
            }
        }



        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]

        public IActionResult UpdatePuppy(Puppy puppy)
        {
            if (ModelState.IsValid)
            {
                puppyDao.UpdatePuppy(puppy);
                return Ok(puppy);
            }
            else
            {
                return new BadRequestObjectResult(ModelState);
            }
        }
        //use postman to verify, do get post put delete



        [HttpDelete("{id}")]

        public IActionResult DeletePuppy(int id)
        {
            puppyDao.DeletePuppy(id);
            return Ok();
        }
=======
>>>>>>> d91bd39055d92512d6751a12f03224931a9dd31d
    }
}