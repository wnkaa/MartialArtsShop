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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IItemService" in both code and config file together.
    [ServiceContract]
    public interface IItemService
    {
        //Items
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "Items")]
        List<ItemDTO> getAll();
        //Items/id
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "Items/{id}")]
        ItemDTO getByID(string id);
        //Items/category
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "Items/getByCategory/{category}")]
        List<ItemDTO> getByCategory(string category);
        [OperationContract]
        //Items/Add
        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "Items/Add")]
        void add(ItemDTO it);
        //Items/Update
        [WebInvoke(Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "Items/Update")]
        void update(ItemDTO it);
        //Items/delete
        [WebInvoke(Method = "DELETE",
            ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
            UriTemplate = "Items/Delete")]
        void delete(ItemDTO it);
    }
}
