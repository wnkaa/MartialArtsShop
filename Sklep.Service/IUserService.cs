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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        //Users
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Users")]
        List<UserDTO> getAll();
        //Users/id
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Users/{id}")]
        UserDTO get(string id);
        //Users/name
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Users/getByName/{name}")]
        UserDTO getByName(string name);
        //Users/Add
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "POST",
            UriTemplate = "Users/Add")]
        void add(UserDTO user);
        //Users/Update
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "PUT",
            UriTemplate = "Users/Update")]
        void update(UserDTO user);
        //Users/Delete
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "DELETE",
            UriTemplate = "Users/Delete")]
        void delete(UserDTO user);
    }
}
