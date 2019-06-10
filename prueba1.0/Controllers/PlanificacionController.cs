using prueba1._0.Models;
using prueba1._0.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prueba1._0.Controllers
{
    public class PlanificacionController : Controller
    {
        private PlanificaionRepositorio _repo;
        public PlanificacionController()
        {
            _repo = new PlanificaionRepositorio();
        }

        // GET: Planificacion
        public ActionResult Index()
        {
            var model = _repo.ObtenerDatos();
            return View(model);
        }

        // GET: Planificacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Planificacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Planificacion/Create
        [HttpPost]
        public ActionResult Create(Planificacion model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Crear(model);
                    return RedirectToAction("Index");
                }
                // TODO: Add insert logic here

                
            }
            catch(Exception ex)
            {
                 
            }
            return View(model);
        }

        // GET: Planificacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Planificacion/Edit/5
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

        // GET: Planificacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Planificacion/Delete/5
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
