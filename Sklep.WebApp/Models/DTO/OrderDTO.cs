using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Sklep.WebApp.Models.DTO
{

    public class OrderDTO
    {

        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }
        public Nullable<int> CartID { get; set; }
        public CartDTO Cart { get; set; }

        public int UserID { get; set; }

        public UserDTO User { get; set; }
    }
    public class OrderCheck {
    public int CartID { get; set; }
    public int UserID { get; set; }
    }
}