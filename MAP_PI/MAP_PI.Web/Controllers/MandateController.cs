using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MAP_PI.Web.Controllers
{
  
    public class MandateController : Controller
    {
        IGestionMandats gm;
        IProjService ps;
        IRessService rs;
        public MandateController()
        {
            gm = new GestionMandats();
            ps = new ProjService();
            rs = new RessService();
        }

        // GET: Mandate
        public ActionResult Index()
        {
            var r = gm.GetAllMandats();
            return View(r);
        }

        // GET: Mandate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mandate/Create
        public ActionResult Create()
        {
            ViewBag.proj = new SelectList(ps.GetAllProj(), "ProjectId", "project_name");
            ViewBag.ress = new SelectList(rs.GetResByEtat(), "Id", "Email");

            return View();
        }

        // POST: Mandate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mandate pc , String maile)
        {
           
            Mandate p = new Mandate();
            float diffdays = (float)((pc.end_Date.Date - pc.start_Date.Date).Days);
            float costfloat = 1F;
            if (diffdays < 60F)
            {
                costfloat = diffdays * 5F;
            }
            else if (diffdays > 60F)
            {
                costfloat = diffdays * 7.5F;
            }

            p.start_Date = pc.start_Date;
            p.end_Date = pc.end_Date;
            p.Fees = costfloat;
            p.ProjectId = pc.ProjectId;
            p.Id = pc.Id;
          
           
            try
            {
                MailMessage message = new MailMessage("amine.benkhelifa@esprit.tn","amine.benkhelifa@esprit.tn", "You Are Assigned To an other mandate", "Hello Mr Ressource you are assigned to work for an other Project . Greeting LeviO ");
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("amine.benkhelifa@esprit.tn", "18071964dad");
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


            gm.createMandat(p);
            gm.Commit();
            
            return RedirectToAction("Index", "Mandate");



            
        }

        // GET: Mandate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mandate/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int idp, string idr)
        {
            gm.deleteMandate(idp, idr);
            return RedirectToAction("Index", "Mandate");
        }

        
        public ActionResult MandateInfo(int id)
        {

            
            var RessourceInfo = gm.GetById((long)id); 
            return View(RessourceInfo); 


        }





        //[HttpPost]
        //public ActionResult StartWork(String id, int idp, String maile, Mandate cm)
        //{


        //    Mandate c = new Mandate();
        //    // c = ms.Get(t => t.CIN == id);
        //    // c = ms.Get(t => t.projectId == idp);
        //    c.ResFk.Email = id;
        //    c.ProjectId = idp;

        //    c.end_Date = cm.end_Date;
        //    c.start_Date = cm.start_Date; 
        //    c.Fees = 1F;
        //    // c.Cost= (((c.MandateStartDate.Year - c.MandateEndDate.Year) * 12) + c.MandateStartDate.Month - c.MandateEndDate.Month) * 25F;


        //    try
        //    {
        //        MailMessage message = new MailMessage("amine.benkhelifa@esprit.tn", "ressource", "aandek mandat jdid", "haya bara ekhdem");
        //        message.IsBodyHtml = true;
        //        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        //        client.EnableSsl = true;
        //        client.Credentials = new System.Net.NetworkCredential("amine.benkhelifa@esprit.tn", "18071964dad");
        //        client.Send(message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //    }

        //    gm.Add(c);
        //    gm.Commit();

        //    Mandate f = new Mandate();
        //    f = gm.Get(t => t.ResFk.Email == id);


        //    float diffdays = (float)((f.end_Date.Date - f.start_Date.Date).Days);
        //    float costfloat = 1F;
        //    if (diffdays < 60F)
        //    {
        //        costfloat = diffdays * 5F;
        //    }
        //    else if (diffdays > 60F)
        //    {
        //        costfloat = diffdays * 7.5F;
        //    }
        //    f.Fees = costfloat;
        //    gm.Update(f);
        //    gm.Commit();


        //    /*Ressource r = new Ressource();
        //    r = rs.Get(t => t.CIN == id);
        //    r.etat = "InMandate";
        //    rs.Update(r);
        //    rs.Commit();*/



        //    return RedirectToAction("Index");


        //}




    }
}
