using MAP_PI.Domain.Entities;
using MAP_PI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAP_PI.Web.Controllers
{
    public class HolidayController : Controller
    {
        IGestionHoliday gm;


        public HolidayController()
        {
            gm = new GestionHoliday();
        }

        // GET: Holiday
        public ActionResult Index()
        {
            var r = gm.GetAllHoliday();
            return View(r);
        }

        // GET: Holiday/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Holiday/Create
        public ActionResult CreateHoliday()
        {
            return View();
        }

        // POST: Holiday/Create
        [HttpPost]
        public ActionResult CreateHoliday(Holiday re)
        {
            Holiday p = new Holiday
            {
              HolidayId = re.HolidayId ,             
              Description = re.Description,
              end_Date = re.end_Date , 
              stard_Date = re.stard_Date

            };

            gm.createHoliday(p);
            gm.Commit();

            return RedirectToAction("Index", "Holiday");


        }

        // GET: Holiday/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Holiday/Edit/5
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

        // GET: Holiday/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Holiday/Delete/5
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
