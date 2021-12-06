using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;

namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class ContratoController : Controller
    {
        // GET: Contrato
        public ActionResult Index()
        {
            ViewBag.contratos = new Contrato().ReadContrato();
            ViewBag.productores = new Productor().ReadProductorAll();

            return View();
        }

        // GET: Contrato/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contrato/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contrato/Create
        [HttpPost]
        public ActionResult Create(Contrato contrato)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(contrato);
                }

                contrato.SaveContrato();

                TempData["mensaje"] = "guardado correctamente";

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contrato/Edit/5
        public ActionResult Edit(int id)
        {
            Contrato u = new Contrato().BuscarContrato(id);

            if (u == null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.contratos = new Contrato().ReadContrato();
            return View(u);
        }

        // POST: Contrato/Edit/5
        [HttpPost]
        public ActionResult Edit(Contrato contrato)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(contrato);
                }

                contrato.UpdateContrato();
                TempData["mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(contrato);
            }
        }

        // GET: Contrato/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contrato/Delete/5
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
