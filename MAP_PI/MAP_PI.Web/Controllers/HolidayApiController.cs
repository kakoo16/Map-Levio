using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace MAP_PI.Web.Controllers
{

    public class HolidayApiController : Controller
    {

        IGestionHoliday ms = null;
        public HolidayApiController()
        {

            ms = new GestionHoliday();

        }



     

        [WebMethod]
        [HttpPost]
        public ActionResult CreateMandat(Holiday mandat)
        {
            Holiday m = new Holiday
            {
                HolidayId= mandat.HolidayId , 
                Description = mandat.Description,
                end_Date = mandat.end_Date,
                stard_Date = mandat.stard_Date
               };

            ms.createHoliday(m);
            ms.Commit();

            return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);

        }

    }
}