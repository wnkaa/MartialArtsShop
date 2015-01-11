using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AutoMapper;
using Sklep.Service.DTO;
namespace Sklep.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderService.svc or OrderService.svc.cs at the Solution Explorer and start debugging.
    [AutoMapperServiceBehavior]
    public class OrderService : IOrderService, IDisposable
    {
        private readonly SklepDataBaseEntities1 ctx = new SklepDataBaseEntities1();
        public List<OrderDTO> getAll()
        {
            var lista = ctx.Orders.ToList();
            return Mapper.Map<List<OrderDTO>>(lista);
        }

        public OrderDTO get(string id)
        {
            int ID;
            if (int.TryParse(id, out ID))
            {
                var item = ctx.Orders.FirstOrDefault(i => i.OrderID == ID);
                if (item != null)
                {
                    return Mapper.Map<Order, OrderDTO>(item);
                }
                return null;
            }
            return null;
        }

        public void add(OrderDTO order)
        {
            Order ord = Mapper.Map<OrderDTO,Order>(order);
            ctx.Orders.Add(ord);
            ctx.SaveChanges();
        }

        public void update(OrderDTO order)
        {
            Order ord = Mapper.Map<Order>(order);
            ctx.Entry(ord).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void delete(DTO.OrderDTO order)
        {
            Order ord = Mapper.Map<Order>(order);
            ctx.Orders.Remove(ord);
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
