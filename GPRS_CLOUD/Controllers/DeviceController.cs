using GPRS_CLOUD.Models;
using GPRS_CLOUD.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GPRS_CLOUD.Controllers
{
    public class DeviceController : Controller
    {
        // GET: Device
        public ActionResult Index()
        {
            return Content("successfuly added");
        }

        [HttpPost]
        public ActionResult Index(string Id, string Key, string value)
        {

            //string  a=  DeviceId;
            //string b = Key;
            //string c = value;

            DeviceLog x = new DeviceLog();
            x.DeviceId = Id;
            x.Key = Key;
            x.value = value;

            var Insert = LiveMonitoringRepo.Insert( x);


            return Content("successfuly added");

        }
      
      






        // GET: Device/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Device/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Device/Create
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

        // GET: Device/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Device/Edit/5
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

        // GET: Device/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Device/Delete/5
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
