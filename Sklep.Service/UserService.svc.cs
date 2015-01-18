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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    [AutoMapperServiceBehavior]
    public class UserService : IUserService, IDisposable
    {
        private readonly SklepDataBaseEntities1 ctx = new SklepDataBaseEntities1();
        public List<UserDTO> getAll()
        {
            var lista = ctx.Users.ToList();
            return Mapper.Map<List<UserDTO>>(lista);
        }

        public UserDTO get(string id)
        {
            int ID;
            if (int.TryParse(id, out ID))
            {
                var item = ctx.Users.FirstOrDefault(i => i.UserID == ID);
                if (item != null)
                {
                    return Mapper.Map<User, UserDTO>(item);
                }
                return null;
            }
            return null;
        }
        public UserDTO getByName(string name)
        {
            var item = ctx.Users.FirstOrDefault(u => u.Username == name);
            if (item != null)
                return Mapper.Map<UserDTO>(item);
            return null;
        }
        public void add(UserDTO user)
        {
           var adr= ctx.Addresses.OrderByDescending(a => a.AddressID).Take(1);
           
            User usr = Mapper.Map<User>(user);
            usr.Address = adr.First();
            usr.AddressID = adr.First().AddressID;

           
            
            ctx.Users.Add(usr);
            ctx.SaveChanges();
        }

        public void update(UserDTO user)
        {
            User usr = Mapper.Map<User>(user);
            ctx.Entry(usr).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void delete(DTO.UserDTO user)
        {
            User usr = Mapper.Map<User>(user);
            ctx.Users.Remove(usr);
            ctx.SaveChanges();
        }
        public void Dispose()
        {
            ctx.Dispose();
        }


       
    }
}
