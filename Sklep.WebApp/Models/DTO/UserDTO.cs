using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.WebApp.Models.DTO
{

    public class UserDTO
    {

        public int UserID { get; set; }

        public string Name { get; set; }

        public string Pasword { get; set; }

        public string Roles { get; set; }

        public int AddressID { get; set; }

        public AddressDTO Address { get; set; }

    }
}