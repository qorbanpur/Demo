using DAL;
using System.Collections.Generic;
using System.ServiceModel;

namespace WcfService.ServiceContracts
{
    [ServiceContract(Namespace = "http://localhost:11012/services/user")]
    public interface IUserService// : IBaseServiceContract<User>
    {
        [OperationContract]
        User Add(User entity);

        [OperationContract]
        bool AddSubscription(string id, string subscriptionId);

        [OperationContract]
        bool Delete(string id);

        [OperationContract]
        User Get(string id);

        [OperationContract(Name = "GetAll")]
        IEnumerable<DAL.User> Get();

        [OperationContract]
        bool Update(string id, User entity);

        [OperationContract]
        List<Subscription> GetSubscriptions(int id);
    }
}