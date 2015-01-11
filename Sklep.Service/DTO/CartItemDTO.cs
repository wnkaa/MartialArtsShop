using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Sklep.Service.DTO
{
    [DataContract]
    public class CartItemDTO
    {
        [DataMember]
        public int CartItemID { get; set; }
        [DataMember]
        public int Quanity { get; set; }
        [DataMember]
        public ItemDTO Item { get; set; }
        [DataMember]
        public int ItemID { get; set; }
        [DataMember]
        public decimal Prize { get; set; }
    }
}
