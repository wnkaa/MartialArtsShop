using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Sklep.Service.DTO
{
    [DataContract]
    public class ItemDTO
    {
        [DataMember]
        public int ItemID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public decimal Prize { get; set; }
        [DataMember]
        public int Quanity { get; set; }
    }
}