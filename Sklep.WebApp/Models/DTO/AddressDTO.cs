using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Sklep.WebApp.Models.DTO
{

    public class AddressDTO
    {
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public int UserID { get; set; }
    }
}