using GPRS_CLOUD.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GPRS_CLOUD.Controllers
{
    [Authorize]
    public class LiveController : Controller
    {
        // GET: Live
        public ActionResult Index()


        {

            var WeatherModel = LiveMonitoringRepo.GetWeatherdata();

            return View(WeatherModel);
        }

        //public FileContentResult DownloadCSV()
        //{
        //    string csv = "Charlie, Chaplin, Chuckles";
        //    return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", "Report123.csv");
        //}

        //public ActionResult ExportData()
        //{
        //    System.IO.FileInfo exportFile = from r in LiveMonitoringRepo.GetWeatherdata()
        //                                    select r;
        //     //create your ExportFile
        //    return File(exportFile.FullName, "text/csv", string.Format("Export-{0}.csv", DateTime.Now.ToString("yyyyMMdd-HHmmss")));
        //}
        



        // GET: Live/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Live/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Live/Create
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

        // GET: Live/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Live/Edit/5
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

        // GET: Live/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Live/Delete/5
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
