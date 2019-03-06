using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DtoModels
{
    public class SubscriptionDto
    {
        public string SubscriptionId { get; set; }

        public decimal Price { get; set; }

        public decimal PriceIncVatAmount { get; set; }

        public int CallMinutes { get; set; }

        public string Name { get; set; }
    }
}