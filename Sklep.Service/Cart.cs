//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklep.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public Cart()
        {
            this.CartItems = new HashSet<CartItem>();
            this.Orders = new HashSet<Order>();
        }
    
        public int CartID { get; set; }
        public decimal Prize { get; set; }
    
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
