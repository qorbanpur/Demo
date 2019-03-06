using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DAL
{
    public class UserSubscription
    {
        public UserSubscription(User user, Subscription subscription)
        {
            SubscriptionId = subscription.SubscriptionId;
            UserId = user.UserId;
        }

        public UserSubscription()
        {
            SubscriptionId = Guid.Empty;
            UserId = 0;
        }

        [DataMember]
        public Guid UserSubscriptionId { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public Guid SubscriptionId { get; set; }

        //[ForeignKey("UserId")]
        //[DataMember]
        //public virtual User User { get; set; }

        //[ForeignKey("SubscriptionId")]
        //[DataMember]
        //public virtual Subscription Subscription { get; set; }
    }
}
