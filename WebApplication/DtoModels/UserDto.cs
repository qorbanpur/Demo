using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DtoModels
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public decimal TotalPriceIncVatAmount
        {
            get
            {
                return this.Subscriptions.Sum(s => s.PriceIncVatAmount);
            }
        }

        public int TotalCallMinutes
        {
            get
            {
                return this.Subscriptions.Sum(s => s.CallMinutes);
            }
        }

        public ICollection<SubscriptionDto> Subscriptions
        {
            get
            {
                var result = new UserServiceReference.UserServiceClient().GetSubscriptionsAsync(this.UserId).GetAwaiter().GetResult();

                return AutoMapper.Mapper.Map<List<UserServiceReference.Subscription>, List<SubscriptionDto>>(result);
            }

            set { }
        }
    }
}