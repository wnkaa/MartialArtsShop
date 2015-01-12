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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CartService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CartService.svc or CartService.svc.cs at the Solution Explorer and start debugging.
    [AutoMapperServiceBehavior]
    public class CartService : ICartService,IDisposable
    {
        private readonly SklepDataBaseEntities1 ctx = new SklepDataBaseEntities1();
        public List<CartDTO> getAll()
        {
            var lista = ctx.Carts.ToList();
            return Mapper.Map<List<CartDTO>>(lista);
        }

        public int getLastID()
        {
            var last =ctx.Carts.OrderByDescending(c => c.CartID).Take(1);
            return last.First().CartID;
        }
        public CartDTO getByID(string id)
        {
            int ID;
            if (int.TryParse(id, out ID))
            {
                var item = ctx.Carts.FirstOrDefault(i => i.CartID == ID);
                if (item != null)
                {
                    return Mapper.Map<Cart, CartDTO>(item);
                   
                }
                return null;
            }
            return null;
        }
        public void add(CartDTO cart)
        {
            Cart car = Mapper.Map<Cart>(cart);
            ctx.Carts.Add(car);
            ctx.SaveChanges();
        }

        public void update(CartDTO cart)
        {
            Cart car = Mapper.Map<Cart>(cart);
            ctx.Entry(car).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void delete(CartDTO cart)
        {
            Cart car = Mapper.Map<Cart>(cart);
            ctx.Carts.Remove(car);
            ctx.SaveChanges();
        }
        public void Dispose()
        {
            ctx.Dispose();
        }


    }
}
