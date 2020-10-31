using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Doman;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServises _userServises;
        public UserController(IUserServises userServises)
        {
            _userServises = userServises;
        }
        // GET: api/User
        [HttpGet]
        public async Task<List<User>> Get()
        {
            return  await _userServises.GetAll() ;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<User> Get(int id)
        {
            return await _userServises.GetById(id);
        }

        // POST: api/User
        [HttpPost]
        public async Task<User> Post([FromBody] User user)
        {
            return await _userServises.Create(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public async Task<int> Put(  [FromBody] User user)
        {
            return await _userServises.Update(user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await _userServises.Delete(id);
        }
    }
}
