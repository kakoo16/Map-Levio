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
        public ActionResult Create(Mandate pc)
        {
         
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
            pc.Fees = costfloat;

            Person p1 = new Person();
            IEnumerable<Person> list = rs.GetAll();
            foreach (Person p in list)
            {
                if (p.Id.Equals(pc.Id))
                    p1 = p;
            }

            try
            {
                MailMessage message = new MailMessage("amine.benkhelifa@esprit.tn", p1.Email, "You Are Assigned To an other mandate", "Hello Mr Ressource you are assigned to work for an other Project . Greeting LeviO ");
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


            gm.createMandat(pc);
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

        
        public Person MandateInfo(string id)
        {
            IEnumerable<Person> list = rs.GetAll();
            foreach(Person p in list)
            {
                if (p.Id.Equals(id))
                    return p;
            }
            return null;
        }





      



    }
}
