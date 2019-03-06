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
    public class SubscriptionHelper
    {
        readonly DBContext _dbContext;

        public SubscriptionHelper()
        {
            _dbContext = new DBContext();
        }

        public Subscription Add(Subscription entity)
        {
            try
            {
                entity.SubscriptionId = Guid.NewGuid();

                _dbContext.Subscriptions.Add(entity);

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

                _dbContext.Subscriptions.Remove(dbEntity);
                return _dbContext.SaveChanges() > 0;
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
                var convertedId = Guid.Parse(id);
                return _dbContext.Subscriptions.SingleOrDefault(x => x.SubscriptionId == convertedId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Subscription> Get()
        {
            try
            {
                return _dbContext.Subscriptions.ToList();
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
    }
}