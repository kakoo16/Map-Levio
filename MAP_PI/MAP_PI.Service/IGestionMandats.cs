using MAP_PI.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Service
{
    public interface IGestionMandats :IGestionService<Mandate> 
    {
        void createMandat(Mandate m);
        List<Mandate> GetAllMandats();
        void deleteMandate(int idp, string idr);

    }
}
