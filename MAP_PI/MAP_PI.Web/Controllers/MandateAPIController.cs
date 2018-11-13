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
    public class MandateAPIController : ApiController
    {
        IGestionMandats gm;
        public MandateAPIController()
        {
            gm = new GestionMandats();
        }

        // GET: api/ClaimAPI
        public IEnumerable<Mandate> Get()
        {
            return gm.GetAllMandats(); ;
        }

        // GET: api/ClaimAPI/5
        public string Get(int id)
        {
            return "value";
        }

        public void Post([FromBody]Mandate m)
        {
            gm.createMandat(m);
        }


        // PUT: api/ClaimAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ClaimAPI/5
        public void Delete(int id)
        {
        }
    }
}
