using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Sklep.WebApp.Models.DTO
{

    public class CartItemDTO
    {
        public int CartItemID { get; set; }
        public int Quanity { get; set; }
        public ItemDTO Item { get; set; }
        public int ItemID { get; set; }
        public decimal Prize { get{return (Item.Prize * this.Quanity);}}
    }
}
