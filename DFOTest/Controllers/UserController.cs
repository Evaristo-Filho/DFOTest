using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using BusinessUser = DFOTest.Entities.User;
using WebApi.ViewModel;
using DFOTest.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IRepository<IUser> userRepository;
        public UserController(IRepository<IUser> userRepository)
        {
            this.userRepository = userRepository;
        }
        // GET: api/<UserController>
        [HttpGet]

        public ActionResult<string> Get()
        {
            return Ok(userRepository.GetAll());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var result= userRepository.Get(id);
            if(result== null)
                return NotFound("Not Found");
            return Ok(result);
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] ViewModel.User user)
        {

            if (this.userRepository.Insert(user) == -1)
                return Conflict("Id Alread Exists");
            return Created("", "Created with Success");

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ViewModel.User user)
        {
            if (userRepository.Update(user) == -1)
                return NotFound("Register Not Found");
            return Ok("Update with Success");
        }


    }
}
