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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ItemService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ItemService.svc or ItemService.svc.cs at the Solution Explorer and start debugging.
    [AutoMapperServiceBehavior]
    public class ItemService : IItemService, IDisposable
    {
        private readonly SklepDataBaseEntities1 ctx = new SklepDataBaseEntities1();
        public List<ItemDTO> getAll()
        {
            List<Item> lista = ctx.Items.ToList();
            return Mapper.Map<List<Item>, List<ItemDTO>>(lista);
        }
        public ItemDTO getByID(string id)
        {
            int ID;
            if (int.TryParse(id, out ID))
            {
                var item = ctx.Items.FirstOrDefault(i => i.ItemID == ID);
                if (item != null)
                {
                    return Mapper.Map<Item, ItemDTO>(item);
                }
                return null;
            }
            return null;
        }

        public List<ItemDTO> getByCategory(string category)
        {
            List<Item> lista = ctx.Items.Where(i => i.Category == category).ToList();

            return Mapper.Map<List<ItemDTO>>(lista);
        }
        public void add(ItemDTO it)
        {
            Item item = Mapper.Map<ItemDTO, Item>(it);
            ctx.Items.Add(item);
            ctx.SaveChanges();
        }

        public void update(ItemDTO it)
        {
            Item item = Mapper.Map<ItemDTO, Item>(it);
            ctx.Entry(item).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void delete(ItemDTO it)
        {
            Item item = Mapper.Map<ItemDTO, Item>(it);
            ctx.Items.Remove(item);
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }


    }
}
