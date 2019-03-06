using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DtoModels
{
    public class UserSubscriptionDto
    {
        public Guid UserSubscriptionId { get; set; }

        public int UserId { get; set; }

        public Guid SubscriptionId { get; set; }
    }
}
