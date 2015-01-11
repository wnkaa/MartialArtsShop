using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sklep.Service.DTO;
using AutoMapper;
namespace Sklep.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CartItemService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CartItemService.svc or CartItemService.svc.cs at the Solution Explorer and start debugging.
    [AutoMapperServiceBehavior]
    public class CartItemService : ICartItemService, IDisposable
    {
        private readonly SklepDataBaseEntities1 ctx = new SklepDataBaseEntities1();
        public List<CartItemDTO> getAll()
        {
            List<CartItem> lista = ctx.CartItems.ToList();
            return Mapper.Map<List<CartItemDTO>>(lista);
        }

        public CartItemDTO getByID(string id)
        {
            int ID;
            if (int.TryParse(id, out ID))
            {
                CartItem cartitem = ctx.CartItems.FirstOrDefault(ci => ci.CartItemID == ID);
                if (cartitem != null)
                {
                    return Mapper.Map<CartItem, CartItemDTO>(cartitem);
                }
                return null;
            }
            return null;
        }

        public void add(CartItemDTO Cartit)
        {
            var cartitem = Mapper.Map<CartItem>(Cartit);
            ctx.CartItems.Add(cartitem);
            ctx.SaveChanges();
        }

        public void update(CartItemDTO Cartit)
        {
            //check does it work or not. if not find by id in context the object 
            //that u want update same with delete and check it in all classes
            var cartitem = Mapper.Map<CartItem>(Cartit);
            ctx.Entry(cartitem).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void delete(CartItemDTO Cartit)
        {
            var cartitem = Mapper.Map<CartItem>(Cartit);
            ctx.CartItems.Remove(cartitem);
            ctx.SaveChanges();

        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
