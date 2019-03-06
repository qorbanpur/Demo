using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubscriptionServiceReference;
using WebApplication.DtoModels;

namespace WebApplication.Controllers
{
    //[Route("[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly SubscriptionServiceClient _serviceReference;

        public SubscriptionsController()
        {
            //_serviceReference = new SubscriptionServiceClient(new BasicHttpBinding(), new EndpointAddress(Startup.Configuration["EndpointAddresses:SubscriptionServiceClient"]));
            _serviceReference = new SubscriptionServiceClient();
        }

        // GET: Subscriptions
        [HttpGet("/Subscriptions/Index")]
        public async Task<IActionResult> Index()
        {
            var result = await _serviceReference.GetAllAsync();

            return Ok(Mapper.Map<List<Subscription>, List<SubscriptionDto>>(result));
        }

        // GET: Subscriptions/5
        [HttpGet("/Subscriptions/GetSubscription/{id}")]
        public async Task<IActionResult> GetSubscription(string id)
        {
            var result = await _serviceReference.GetAsync(id);

            return Ok(Mapper.Map<Subscription, SubscriptionDto>(result));
        }

        // POST: Subscriptions
        [HttpPost("/PostSubscription")]
        public async Task<IActionResult> PostSubscription([FromBody] SubscriptionDto value)
        {
            return Ok(await _serviceReference.AddAsync(Mapper.Map<Subscription>(value)));
        }

        // PUT: Subscriptions/5
        [HttpPut("/PutSubscription/{id}")]
        public async Task<IActionResult> PutSubscription(string id, [FromBody] SubscriptionDto value)
        {
            return Ok(await _serviceReference.UpdateAsync(id, Mapper.Map<Subscription>(value)));
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("/DeleteSubscription/{id}")]
        public async Task<IActionResult> DeleteSubscription(string id)
        {
            return Ok(await _serviceReference.DeleteAsync(id));
        }
    }
}