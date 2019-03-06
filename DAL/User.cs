using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;

namespace DAL
{
    public class User
    {
        public User()
        {
            UserSubscriptions = new List<UserSubscription>();
            //Subscriptions = new List<Subscription>();
        }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public ICollection<UserSubscription> UserSubscriptions { get; set; }

        //[DataMember]
        //[NotMapped]
        //public ICollection<Subscription> Subscriptions
        //{
        //    get
        //    {
        //        var result = new List<Subscription>();

        //        if (this.UserId > 0)
        //        {
        //            var context = new DBContext();
        //            var userSubscriptions = context.UserSubscriptions.Where(us => us.UserId == this.UserId).ToList();

        //            if (userSubscriptions.Any())
        //                result = context.Subscriptions.Where(s => userSubscriptions.Select(us => us.SubscriptionId).Contains(s.SubscriptionId)).ToList();
        //        }

        //        return result;
        //    }

        //    set { }
        //}
    }
}
