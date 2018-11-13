using MAP_PI.Data;
using MAP_PI.Domain.Entities;
using MAP_PI.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MAP_PI.Web.Startup))]
namespace MAP_PI.Web
{
    public partial class Startup
    {
        MAP_PIContext db = new MAP_PIContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUsers();
            CreateRoles(); 
        }

        public void CreateUsers()
        {


            var userManager = new UserManager<Person>(new UserStore<Person>(db));
            var user = new Person();
            user.Email = "aminech@gmail.com";
            user.UserName = "amine";
            var check = userManager.Create(user, ("Azer1&"));
            if (check.Succeeded)
            {

                userManager.AddToRole(user.Id, "admin");
            }
        }
        public void CreateRoles()
        {

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            IdentityRole role;
            if (!roleManager.RoleExists("Admin"))
            {
                role = new IdentityRole();
                role.Name = "admin";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("client"))
            {
                role = new IdentityRole();
                role.Name = "client";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("condidat"))
            {
                role = new IdentityRole();
                role.Name = "condidat";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("ressource"))
            {
                role = new IdentityRole();
                role.Name = "ressource";
                roleManager.Create(role);
            }




        }

    }
}
