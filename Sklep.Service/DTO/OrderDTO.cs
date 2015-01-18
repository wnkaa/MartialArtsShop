using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Sklep.Service.DTO
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public CartDTO Cart { get; set; }
        [DataMember]
        public Nullable<int> CartID { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public UserDTO User { get; set; }
    }
    [DataContract]
    public class OrderCheck {
        [DataMember]
        public int CartID { get; set; }
        [DataMember]
        public int UserID { get; set; }
    }

}