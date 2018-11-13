using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace MAP_PI.Domain.Entities
{
    public class Person :IdentityUser  
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Person> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EtatResource { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Inbox> MyInbox { get; set; }
    }
}
