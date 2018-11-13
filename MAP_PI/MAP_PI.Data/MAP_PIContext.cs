using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MAP_PI.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MAP_PI.Data
{
    public class MAP_PIContext :IdentityDbContext<Person>
    {
        // Constructors
        public MAP_PIContext() : base("name=mapdb", throwIfV1Schema: false)
        {

        }
        public static MAP_PIContext Create()
        {
            return new MAP_PIContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<Ressource>().ToTable("Ressource");
            base.OnModelCreating(modelBuilder);
        }

        //Les Dbsets

        public DbSet<Mandate> Mandates { get; set; }
        public DbSet<Ressource> Resources { get; set; }
        //public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Organizational_Chart> Org_Charts { get; set; }
        public DbSet<Inbox> Inbox { get; set; }
        public DbSet<Message> Messages { get; set;  }
        public DbSet<Client> Clients { get; set;  }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Request> Requests { get; set;  }
        public DbSet<Job_Request> JobRequests { get; set; }
        public DbSet<Administrator> Administratorss { get; set; }



    }
}
