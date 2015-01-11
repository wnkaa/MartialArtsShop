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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICartItemService" in both code and config file together.
    [ServiceContract]
    public interface ICartItemService
    {

        //CartItems
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "CartItems")]
        List<CartItemDTO> getAll();
        //CartItems/id
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "CartItems/{id}")]
        CartItemDTO getByID(string id);
        [OperationContract]
        //Items/Add
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "CartItems/Add")]
        void add(CartItemDTO Cartit);
        //Items/Update
        [WebInvoke(Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "CartItems/Update")]
        void update(CartItemDTO Cartit);
        //Items/delete
        [WebInvoke(Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
            UriTemplate = "CartItems/Delete")]
        void delete(CartItemDTO Cartit);
    }
}
