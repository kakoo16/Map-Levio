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
   public  class GestionRecrutment : GestionService<Request>, IGestionRecrutment
    {
        public static IDatabaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public GestionRecrutment() : base(myUnit)
        {
            dbFactory = new DatabaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }

        public void createRequest(Request m)
        {
            myUnit.getRepository<Request>().Add(m);
            myUnit.Commit();

        }

        public List<Request> GetAllRequest()
        {
            return myUnit.getRepository<Request>().GetAll().ToList();
        }
    }
}
