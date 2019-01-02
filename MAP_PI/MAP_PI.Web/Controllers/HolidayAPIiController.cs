using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAP_PI.Web.Controllers
{
    [RoutePrefix("api/Holiday")]
    public class HolidayAPIiController : ApiController
    {
        IGestionHoliday ms = null;
        public HolidayAPIiController()
        {

            ms = new GestionHoliday();

        }



        [HttpGet]
        [Route("GetHoliday")]
        public List<Holiday> GetMandats()
        {
            var mandat = ms.GetAllHoliday();

            List<Holiday> f = new List<Holiday>();
            foreach (var item in mandat)
            {

                f.Add(new Holiday
                {
                    HolidayId = item.HolidayId,
                    Description = item.Description,
                    stard_Date = item.stard_Date,
                    end_Date = item.end_Date

                });
            }

            return f;
        }


    }
}
