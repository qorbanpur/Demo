using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DAL
{
    public class Subscription
    {
        public Subscription()
        {
            UserSubscriptions = new List<UserSubscription>();
        }

        [DataMember]
        public Guid SubscriptionId { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public decimal PriceIncVatAmount { get; set; }

        [DataMember]
        public int CallMinutes { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<UserSubscription> UserSubscriptions { get; set; }
    }
}