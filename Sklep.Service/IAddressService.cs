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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAddressService" in both code and config file together.
    [ServiceContract]
    public interface IAddressService
    {
        //Addresses
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Addresses")]
        List<AddressDTO> getAll();
        //Addresses/id
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Addresses/{id}")]
        AddressDTO get(string id);
        //Addresses/Add
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "POST",
            UriTemplate = "Addresses/Add")]
        void add(AddressDTO address);
        //Addresses/Update
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "PUT",
            UriTemplate = "Addresses/Update")]
        void update(AddressDTO address);
        //Addresses/Delete
        [OperationContract]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            Method = "DELETE",
            UriTemplate = "Addresses/Delete")]
        void delete(AddressDTO address);
    }
    
}
