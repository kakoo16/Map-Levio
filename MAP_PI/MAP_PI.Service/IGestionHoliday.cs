using MAP_PI.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_PI.Service
{
   public  interface IGestionHoliday : IGestionService<Holiday>
    {

        void createHoliday(Holiday m);
        List<Holiday> GetAllHoliday();

    }
}
