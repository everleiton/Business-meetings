using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebIIProyectoIEverLeiton.Models;

namespace WebIIProyectoIEverLeiton.Controllers
{
    public class ReunionController : Controller
    {
        private DBContext db = new DBContext();
        // GET: Reunion
        public ActionResult Index()
        {
            return View(db.Reunion.ToList());
        }

        // GET: Reunion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reunion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reunion/Create
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

        // GET: Reunion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reunion/Edit/5
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

        // GET: Reunion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reunion/Delete/5
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