using GPRS_CLOUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GPRS_CLOUD.Controllers
{
    [Authorize]
    public class HistoricalDataController : Controller
    {
        // GET: HistoricalData
        public ActionResult Index()
        {

            var model = new HistoricalDataM();

            return View(model);


        }

        public ActionResult check()
        {

            // var model = new HistoricalDataM();

            // return View(model);

            //            return View();
            return Content("Success !!");

        }




        [HttpPost]
        public ActionResult Index(HistoricalDataM m )
        {

            var model = new HistoricalDataM();

            return View(model);
        }


        // GET: HistoricalData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HistoricalData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoricalData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HistoricalData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoricalData/Edit/5
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

        // GET: HistoricalData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoricalData/Delete/5
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
