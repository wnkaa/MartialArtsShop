using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Sklep.Service.DTO
{
    [DataContract]
    public class AddressDTO
    {
        [DataMember]
        public int AddressID { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public int UserID { get; set; }
    }
}