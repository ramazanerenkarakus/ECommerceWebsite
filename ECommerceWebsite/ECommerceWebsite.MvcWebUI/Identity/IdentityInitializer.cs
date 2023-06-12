using ECommerceWebsite.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Roller
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new ApplicationRole("admin", "yönetici rolü");
                
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new ApplicationRole("user", "kullanıcı rolü");
                
                manager.Create(role);
            }


            if (!context.Users.Any(i => i.Name == "erenkarakus"))
            {
                var store = new UserStore<IdentityUser>(context);
                var manager = new UserManager<IdentityUser>(store);
                var user = new ApplicationUser() { Name = "eren", Surname = "karakus", UserName = "erenkarakus", Email = "erenkarakus@gmail.com" };
                
                manager.Create(user,"1234567");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "kaankaim"))
            {
                var store = new UserStore<IdentityUser>(context);
                var manager = new UserManager<IdentityUser>(store);
                var user = new ApplicationUser() { Name = "kaan", Surname = "kaim", UserName = "kaankaim", Email = "kaankaim@gmail.com" };

                manager.Create(user, "616161");             
                manager.AddToRole(user.Id, "user");
            }


            base.Seed(context);
        }
    }
}