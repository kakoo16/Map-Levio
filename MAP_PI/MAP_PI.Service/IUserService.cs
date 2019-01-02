using MAP_PI.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Service
{
    public interface IUserService :IGestionService<Person>
    {
        Person getUserByID(string id);
        Person getUserByRoleVolunteer();
        Person getUserByRoleMember();
        void updateUser(Person u);
    

    }
}
