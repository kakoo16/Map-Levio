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
    public class GestionRessource : GestionService<Ressource> , IGestionRessource
    {
        public static IDatabaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public GestionRessource() : base(myUnit)
        {
            dbFactory = new DatabaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }

      

        public void createRessource(Ressource m)
        {
            myUnit.getRepository<Ressource>().Add(m);
            myUnit.Commit();

        }

        public List<Ressource> GetAllRessouce()
        {
         
            return myUnit.getRepository<Ressource>().GetAll().ToList();
        
        }
    }
}
