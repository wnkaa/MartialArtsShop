using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.WebApp.Models.DTO
{

    public class ItemDTO
    {

        public int ItemID { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Prize { get; set; }

        public int Quanity { get; set; }
    }
}