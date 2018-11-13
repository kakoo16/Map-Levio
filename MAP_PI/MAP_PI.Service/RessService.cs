using MAP_PI.Data.Infrastructures;
using MAP_PI.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Service
{
    public class RessService : GestionService<Person>, IRessService
    {
        public static IDatabaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public RessService() : base(myUnit)
        {
            dbFactory = new DatabaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }
        
        public List<Person> GetAllRessources()
        {
            return myUnit.getRepository<Person>().GetAll().ToList();
        }
        

        public List<Person> GetResByEtat()
        {
            return GetMany(t => t.EtatResource.Equals("Disponible") && t.Role.Equals("ressource")).ToList();
        }

        //public Person getResByName(string name)
        //{
        //    return myUnit.getRepository<Ressource>().GetMany(t => t.).First();
        //}
    }
}
