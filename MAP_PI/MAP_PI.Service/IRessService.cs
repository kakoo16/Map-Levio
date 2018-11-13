using MAP_PI.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Service
{
    public interface IRessService : IGestionService<Person>
    {
        List<Person> GetResByEtat();
        List<Person> GetAllRessources();
        //Person getResByName(String name);


    }
}
