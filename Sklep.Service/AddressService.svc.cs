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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AddressService" in code, svc and config file together.
    
    // NOTE: In order to launch WCF Test Client for testing this service, please select AddressService.svc or AddressService.svc.cs at the Solution Explorer and start debugging.
    [AutoMapperServiceBehavior]
    public class AddressService : IAddressService, IDisposable
    {
        private readonly SklepDataBaseEntities1 ctx = new SklepDataBaseEntities1();
        public List<AddressDTO> getAll()
        {
            var lista = ctx.Addresses.ToList();
            return Mapper.Map<List<AddressDTO>>(lista);
        }

        public DTO.AddressDTO get(string id)
        {
            int ID;
            if (int.TryParse(id, out ID))
            {
                var item = ctx.Addresses.FirstOrDefault(i => i.AddressID == ID);
                if (item != null)
                {
                    return Mapper.Map<Address, AddressDTO>(item);
                }
                return null;
            }
            return null;
        }

        public void add(DTO.AddressDTO address)
        {
            Address adr = Mapper.Map<Address>(address);
            ctx.Addresses.Add(adr);
            ctx.SaveChanges();
        }

        public void update(DTO.AddressDTO address)
        {
            Address adr = Mapper.Map<Address>(address);
            ctx.Entry(adr).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void delete(DTO.AddressDTO address)
        {
            Address adr = Mapper.Map<Address>(address);
            ctx.Addresses.Remove(adr);
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
