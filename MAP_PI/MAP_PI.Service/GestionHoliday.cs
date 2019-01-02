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
    public class GestionHoliday : GestionService<Holiday>, IGestionHoliday
    {
        public static IDatabaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public GestionHoliday() : base(myUnit)
        {
            dbFactory = new DatabaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }

        public void createHoliday(Holiday m)
        {
            myUnit.getRepository<Holiday>().Add(m);
            myUnit.Commit();

        }

        public List<Holiday> GetAllHoliday()
        {
            return myUnit.getRepository<Holiday>().GetAll().ToList();
        }
    }
}
