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
    public class GestionMandats :GestionService<Mandate> , IGestionMandats
    {
        public static IDatabaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public GestionMandats() : base(myUnit)
        {
            dbFactory = new DatabaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }

        public void createMandat(Mandate m)
        {
            myUnit.getRepository<Mandate>().Add(m);
            myUnit.Commit();

        }

        public void deleteMandate(int idp, string idr)
        {
            Mandate d = myUnit.getRepository<Mandate>().GetMany(c => c.ProjectId == idp && c.Id.Equals(idr)).FirstOrDefault();
            myUnit.getRepository<Mandate>().Delete(d);
            myUnit.Commit();
        }

        public List<Mandate> GetAllMandats()
        {
            return myUnit.getRepository<Mandate>().GetAll().ToList();
        }
    }
}
