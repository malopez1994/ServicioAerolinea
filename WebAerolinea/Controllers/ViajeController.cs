﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAerolinea.Controllers
{
    public class ViajeController : Controller
    {
        // GET: Viaje
        public ActionResult Index()
        {
            return View();
        }

        // GET: Viaje/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Viaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Viaje/Create
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

        // GET: Viaje/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Viaje/Edit/5
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

        // GET: Viaje/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Viaje/Delete/5
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
