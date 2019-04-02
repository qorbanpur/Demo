using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserServiceReference;
using WebApplication.DtoModels;

namespace WebApplication.Controllers
{
    //[Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _serviceReference;

        public UsersController(IUserService serviceReference)
        {
            //_serviceReference = new UserServiceClient(new BasicHttpBinding(), new EndpointAddress(Startup.Configuration["EndpointAddresses:UserServiceClient"]));
            _serviceReference = serviceReference;
        }

        // GET: Users
        [HttpGet("/Users/Index")]
        public async Task<IActionResult> Index()
        {
            var result = await _serviceReference.GetAllAsync();

            return Ok(Mapper.Map<List<User>, List<UserDto>>(result));
        }

        // GET: Users/5
        [HttpGet("/Users/GetUser/{id}")]
        public async Task<IActionResult> GetUser(string id)
        {
            var result = await _serviceReference.GetAsync(id);

            return Ok(Mapper.Map<User, UserDto>(result));
        }

        // POST: Users
        [HttpPost("/PostUser")]
        public async Task<IActionResult> PostUser([FromBody] UserDto value)
        {
            return Ok(await _serviceReference.AddAsync(Mapper.Map<User>(value)));
        }

        // PUT: Users/5
        [HttpPut("/PutUser/{id}")]
        public async Task<IActionResult> PutUser(string id, [FromBody] UserDto value)
        {
            return Ok(await _serviceReference.UpdateAsync(id, Mapper.Map<User>(value)));
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("/DeleteUser/{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            return Ok(await _serviceReference.DeleteAsync(id));
        }

        // PUT: Users/5/2712e86a-d519-48af-b50b-194e9a2102de
        [HttpPut("/AddSubscriptionToUser/{id}/{subscriptionId}")]
        public async Task<IActionResult> AddSubscriptionToUser(string id, string subscriptionId)
        {
            return Ok(await _serviceReference.AddSubscriptionAsync(id, subscriptionId));
        }
    }
}