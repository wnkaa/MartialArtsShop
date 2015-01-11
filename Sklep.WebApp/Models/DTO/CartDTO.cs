using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization;
namespace Sklep.WebApp.Models.DTO
{

    public class CartDTO
    {

        public int CartID { get; set; }

        public decimal Prize { get; set; }

        public List<CartItemDTO> CartItems { get; set; }

        public CartDTO()
        {
            CartItems = new List<CartItemDTO>();

        }
        private void updatePrice()
        {
            this.Prize = CartItems.Sum(ci => ci.Prize);
        }

        public void addItem(ItemDTO item, int quanity)
        {
            if (item.Quanity >= quanity)
            {
                CartItemDTO line = CartItems.Where(i => i.Item.ItemID == item.ItemID).FirstOrDefault();
                if (line == null)
                {
                    CartItems.Add(new CartItemDTO { Item = item, Quanity = quanity });
                }
                else
                {
                    line.Quanity += quanity;
                }
                updatePrice();
            }
       }
        public void removeItem(ItemDTO item)
        {
            CartItems.RemoveAll(i => i.Item.ItemID == item.ItemID);
            updatePrice();
        }
        public void clear()
        {
            CartItems.Clear();
        }
        
      }
    
}