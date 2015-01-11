using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Sklep.Service.DTO
{
    [DataContract]
    public class CartDTO
    {
        [DataMember]
        public int CartID { get; set; }
        [DataMember]
        public decimal Prize { get; set; }
        [DataMember]
        public List<CartItemDTO> CartItems { get; set; }

    }
}