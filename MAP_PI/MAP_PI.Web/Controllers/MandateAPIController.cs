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
    [RoutePrefix("api/Mandat")]
    public class MandateAPIController : ApiController
    {
        IGestionMandats gm;
        public MandateAPIController()
        {
            gm = new GestionMandats();
        }

        // GET: api/MandateAPI
        /*  public IEnumerable<Mandate> GetMyMandate()
          {
              return gm.GetAllMandats();
          }

          // GET: api/MandateAPI/5
          public string Get(int id)
          {
              return "value";
          }
          */


        [HttpGet]
        [Route("GetMandats")]
        public List<Mandate> GetMandats()
        {
            var mandat = gm.GetAllMandats();

            List<Mandate> f = new List<Mandate>();
            foreach (var item in mandat)
            {

                f.Add(new Mandate
                {
                    Id = item.Id,
                    start_Date = item.start_Date,
                    ProjectId = item.ProjectId,
                    end_Date = item.end_Date,
                    Fees = item.Fees,
                  
                });
            }

            return f;
        }



    }
}
