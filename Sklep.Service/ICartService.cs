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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICartService" in both code and config file together.
    [ServiceContract]
    public interface ICartService
    {
        // Carts
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
                UriTemplate = "Carts")]
        List<CartDTO> getAll();
        //Carts/id
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
                UriTemplate = "Carts/{id}")]
        CartDTO getByID(string id);
        //Carts/Add
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                Method = "POST",
                UriTemplate = "Carts/Add")]
        void add(CartDTO cart);
        //Carts/Update
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                Method = "POST",
                UriTemplate = "Carts/Update")]
        void update(CartDTO cart);
        //Carts/Delete
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                Method = "DELETE",
                UriTemplate = "Carts/Delete")]
        void delete(CartDTO cart);
    }
}
