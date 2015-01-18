using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Sklep.Service.DTO
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Pasword { get; set; }
        [DataMember]
        public string Roles { get; set; }
        [DataMember]
        public int AddressID { get; set; }
        [DataMember]
        public AddressDTO Address { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}