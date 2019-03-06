using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfService.ServiceContracts;

namespace WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        UserHelper _entityHelper;

        public UserService()
        {
            _entityHelper = new UserHelper();
        }

        public User Add(User entity)
        {
            try
            {
                return _entityHelper.Add(entity);
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
                return _entityHelper.Delete(id);
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
                var user = _entityHelper.Get(id);
                user.Subscriptions = GetSubscriptions(user.UserId);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<DAL.User> Get()
        {
            try
            {
                var users = _entityHelper.Get();

                foreach (var user in users)
                    user.Subscriptions = GetSubscriptions(user.UserId);

                return users;
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
                return _entityHelper.Update(id, entity);
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
                return _entityHelper.AddSubscription(id, subscriptionId);
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
                return _entityHelper.GetSubscriptions(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}