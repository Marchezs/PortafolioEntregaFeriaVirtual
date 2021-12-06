using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;

namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class TransportistaController : Controller
    {
        // GET: Transportista
        public ActionResult Index()
        {
            ViewBag.transportistas = new Transportista().ReadTransportistaAll();
            return View();
        }

        // GET: Transportista/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transportista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transportista/Create
        [HttpPost]
        public ActionResult Create(Transportista transportista)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(transportista);
                }

                transportista.SaveTransportista();

                TempData["mensaje"] = "guardado correctamente";

                return RedirectToAction("Index");
            }
            catch
            {
                return View(transportista);
            }
        }

        // GET: Transportista/Edit/5
        public ActionResult Edit(int id)
        {
            Transportista t = new Transportista().BuscarTrasportista(id);

            if (t == null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.transportistas = new Transportista().ReadTransportistaAll();
            return View(t);
        }

        // POST: Transportista/Edit/5
        [HttpPost]
        public ActionResult Edit(Transportista transportista)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(transportista);
                }

                transportista.UpdateTransportista();
                TempData["mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(transportista);
            }
        }

        // GET: Transportista/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Transportista().BuscarTrasportista(id) == null)
            {
                TempData["Mensaje"] = "No existe el producto";
            }


            if (new Transportista().DeleteTransportista(id))
            {
                TempData["mensaje"] = "Eliminado correctamente";
                return RedirectToAction("Index");
            }

            TempData["mensaje"] = "No se ha podido eliminar ";
            return RedirectToAction("Index");
        }

        // POST: Transportista/Delete/5
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
