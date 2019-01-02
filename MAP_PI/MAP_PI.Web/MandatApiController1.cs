using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MAP_PI.Web
{
    public class MandatApiController1 : ApiController
    {
        IGestionMandats gm;
        public MandatApiController1()
        {
            gm = new GestionMandats();
        }
        // GET api/<controller>
        public IEnumerable<Mandate> Get()
        {
          //  IEnumerable<Mandate> 
              var   a = gm.GetMany(); 
            return a; 
        }
   /*     [Route("api/Mandatelist")]
        [HttpGet]
        public IHttpActionResult getMandate()
        {

            return Ok(gm.GetAllMandats());
        }
        */
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}