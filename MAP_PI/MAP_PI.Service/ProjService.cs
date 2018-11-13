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
    public class ProjService : GestionService<Project>, IProjService
    {
        public static IDatabaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public ProjService() : base(myUnit)
        {
            dbFactory = new DatabaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }

        public List<Project> GetAllProj()
        {
            return myUnit.getRepository<Project>().GetAll().ToList();
        }
    }
}
