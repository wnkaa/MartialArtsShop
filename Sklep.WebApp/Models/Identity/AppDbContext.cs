using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Sklep.WebApp.Models.Login;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
namespace Sklep.WebApp.Models.Identity
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<AppDbContext>(new IdentityInit());
        }
    }
    public class IdentityInit : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            var user =new AppUser {Id="1",UserName="Admin",Email="admin@admin.pl" };

            var userStore = new UserStore<AppUser>(context);
            var userManager = new UserManager<AppUser>(userStore);
            userManager.Create(user, "Admin");
            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}