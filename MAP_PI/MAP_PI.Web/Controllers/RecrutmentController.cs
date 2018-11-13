using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAP_PI.Web.Controllers
{
    [Authorize(Roles = "condidat")]
    public class RecrutmentController : Controller
    {

        IGestionRecrutment gm;

        public RecrutmentController()
        {
            gm = new GestionRecrutment();
        }



        // GET: Recrutment
        public ActionResult Index()
        {
            var r = gm.GetAllRequest();
            return View(r);
        }

        // GET: Recrutment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recrutment/Create
        public ActionResult Create()
        {

            return View();

        }

        // POST: Recrutment/Create
        [HttpPost]
        public ActionResult Create(Request re)
        {
            Request p = new Request
            {
               deposit_Date= re.deposit_Date , 
               experience_year= re.experience_year , 
               education_scolarity= re.education_scolarity , 
               requested_profil = re.requested_profil ,  
               deposit_hour = re.deposit_hour , 
               end_date_mandate= re.end_date_mandate , 
               start_date_mandate = re.start_date_mandate 
               
            };

            gm.createRequest(p);
            gm.Commit();
            return RedirectToAction("Index", "Recrutment");
        }

        // GET: Recrutment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recrutment/Edit/5
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

        // GET: Recrutment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recrutment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
