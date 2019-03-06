using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserHelper
    {
        readonly DBContext _dbContext;

        public UserHelper()
        {
            _dbContext = new DBContext();
        }

        public User Add(User entity)
        {
            try
            {
                entity.UserId = _dbContext.Users.Count() + 1;

                _dbContext.Users.Add(entity);

                return (_dbContext.SaveChanges() > 0) ? entity : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                var dbEntity = Get(id);

                if (dbEntity == null)
                    return false;

                _dbContext.Users.Remove(dbEntity);

                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User Get(string id)
        {
            try
            {
                var convertedId = int.Parse(id);
                return _dbContext.Users.SingleOrDefault(x => x.UserId == convertedId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<User> Get()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(string id, User entity)
        {
            try
            {
                var dbEntity = Get(id);

                if (dbEntity == null)
                    return false;

                dbEntity = entity;
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddSubscription(string id, string subscriptionId)
        {
            try
            {
                var user = Get(id);

                if (user == null)
                    return false;

                var subscription = new SubscriptionHelper().Get(subscriptionId);

                if (subscription == null)
                    return false;

                var userSubscription = new UserSubscription(user, subscription) { UserSubscriptionId = Guid.NewGuid() };

                _dbContext.UserSubscriptions.Add(userSubscription);
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Subscription> GetSubscriptions(int id)
        {
            try
            {
                var result = new List<Subscription>();

                if (id > 0)
                {
                    var context = new DBContext();
                    var userSubscriptionIds = context.UserSubscriptions.Where(us => us.UserId == id).Select(us => us.SubscriptionId).ToList();

                    if (userSubscriptionIds.Any())
                        result = context.Subscriptions.Where(s => userSubscriptionIds.Contains(s.SubscriptionId)).ToList();
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}