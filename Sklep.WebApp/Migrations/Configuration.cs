namespace Sklep.WebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Sklep.WebApp.Models.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    internal sealed class Configuration : DbMigrationsConfiguration<Sklep.WebApp.Models.Identity.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Sklep.WebApp.Models.Identity.AppDbContext context)
        {
            var storeRole = new RoleStore<AppUserRole>(context);
            var managerRole = new RoleManager<AppUserRole>(storeRole);

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var role = new AppUserRole() { Name = "Admin" };
                managerRole.Create(role);
            }
            if (!context.Roles.Any(r => r.Name == "User"))
            {
                var role = new AppUserRole() { Name = "User" };
                managerRole.Create(role);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
