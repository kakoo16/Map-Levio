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
    public class GestionUser : GestionService<Person>, IUserService
    {
        public static IDatabaseFactory dbFactory;
        public static IUnitOfWork myUnit;

        public GestionUser() : base(myUnit)
        {
            dbFactory = new DatabaseFactory();
            myUnit = new UnitOfWork(dbFactory);
        }

        public Person getUserByID(string UserID)
        {
            return myUnit.getRepository<Person>().GetById(UserID);
        }

        public Person getUserByRoleMember()
        {
            return myUnit.getRepository<Person>().Get(c => c.Role.Equals("Client"));
        }

        public Person getUserByRoleRessource()
        {
            return myUnit.getRepository<Person>().Get(c => c.Role.Equals("Ressource"));
        }

        public Person getUserByRoleVolunteer()
        {
            throw new NotImplementedException();
        }

        public void updateUser(Person u)
        {
            myUnit.getRepository<Person>().Update(u);
            myUnit.Commit();
        }
    }
}
