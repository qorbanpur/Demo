using DAL;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfService.ServiceContracts
{
    [ServiceContract(Namespace = "http://localhost:11012/services/subscription")]
    public interface ISubscriptionService// : IBaseServiceContract<Subscription>
    {

        [OperationContract]
        Subscription Add(Subscription entity);

        [OperationContract]
        bool Delete(string id);

        [OperationContract]
        Subscription Get(string id);

        [OperationContract(Name = "GetAll")]
        IEnumerable<DAL.Subscription> Get();

        [OperationContract]
        bool Update(string id, Subscription entity);
    }
}