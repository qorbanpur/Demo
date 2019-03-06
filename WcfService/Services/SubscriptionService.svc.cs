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
    public class SubscriptionService : ISubscriptionService
    {
        SubscriptionHelper _entityHelper;

        public SubscriptionService()
        {
            _entityHelper = new SubscriptionHelper();
        }

        public Subscription Add(Subscription entity)
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

        public Subscription Get(string id)
        {
            try
            {
                return _entityHelper.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<DAL.Subscription> Get()
        {
            try
            {
                return _entityHelper.Get();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(string id, Subscription entity)
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
    }
}