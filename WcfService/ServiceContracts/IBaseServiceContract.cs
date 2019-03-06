using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRepositoryService" in both code and config file together.
    [ServiceContract]
    public interface IBaseServiceContract<T>
    {
        [OperationContract]
        T Add(T entity);

        [OperationContract]
        bool Delete(string id);

        [OperationContract]
        T Get(string id);

        [OperationContract(Name = "GetAll")]
        IEnumerable<T> Get();

        [OperationContract]
        bool Update(string id, T entity);
    }
}