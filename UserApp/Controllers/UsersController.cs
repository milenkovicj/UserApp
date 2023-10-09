using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserApp.Models;

namespace UserApp.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UserService userService;

        public UsersController()
        {
            userService = new UserService();
        }

        // GET: api/Users
        [HttpGet]
        public List<User> GetAll()
        {
            List<User> users = userService.GetAll();
            return users;
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public User GetById(int id)
        {
            User user = userService.GetById(id);
            return user;
        }

        // POST: api/Users
        [HttpPost]
        public void Post(User user)
        {
            userService.SaveUser(user);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
