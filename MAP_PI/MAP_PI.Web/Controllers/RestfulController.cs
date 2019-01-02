using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace MAP_PI.Web.Controllers
{
    public class RestfulController : Controller
    {
        // GET: Restful

        GestionMandats ms = null;
        IRessService rs;
        public RestfulController()
        {

            ms = new GestionMandats();
            rs = new RessService();
        }

        
        [WebMethod]
        [HttpPost]
        public ActionResult CreateMandat(Mandate mandat)
        {
              Mandate m = new Mandate
               {
                   end_Date = mandat.end_Date ,
                   start_Date = mandat.start_Date , 
                   ProjectId=mandat.ProjectId , 
                   Fees=mandat.Fees , 
                   Id=mandat.Id 
               };

               ms.createMandat(m);
               ms.Commit();
     
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK); 
 
        }


        [WebMethod]
        [HttpDelete]
        public ActionResult Delete(int idp, string idr)
        {
            ms.deleteMandate(idp, idr);
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
        }








    }
}