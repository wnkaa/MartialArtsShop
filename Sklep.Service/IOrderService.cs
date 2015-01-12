using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using Sklep.Service.DTO;
namespace Sklep.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        //Orders
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Orders")]
        List<OrderDTO> getAll();

        //Orders/id
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Orders/{id}")]
        OrderDTO get(string id);
        //Orders/Add
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "Orders/Add")]
        void add(OrderDTO order);
        //Orders/Update
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "PUT",
            UriTemplate = "Orders/Update")]
        void update(OrderDTO order);
        //Orders/Delete
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "DELETE",
            UriTemplate = "Orders/Delete")]
        void delete(OrderDTO order);
    }
}
