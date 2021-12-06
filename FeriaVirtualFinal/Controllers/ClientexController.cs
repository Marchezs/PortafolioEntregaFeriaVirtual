using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;

namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class ClientexController : Controller
    {
      
        // GET: Clientex
        public ActionResult Index()
        {
            ViewBag.clientexs = new Clientex().ReadClientexAll();
            return View();
        }

        // GET: Clientex/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientex/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientex/Create
        [HttpPost]
        public ActionResult Create(Clientex clientex)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(clientex);
                }

                clientex.SaveClientex();

                TempData["mensaje"] = "guardado correctamente";

                return RedirectToAction("Index");
            }
            catch
            {
                return View(clientex);
            }
        }

        // GET: Clientex/Edit/5
        public ActionResult Edit(int id)
        {
            Clientex x = new Clientex().BuscarClientex(id);

            if (x == null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.clientexs = new Clientex().ReadClientexAll();
            return View(x);
        }

        // POST: Clientex/Edit/5
        [HttpPost]
        public ActionResult Edit(Clientex clientex)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(clientex);
                }

                clientex.UpdateClientex();
                TempData["mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(clientex);
            }
        }

        // GET: Clientex/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Clientex().BuscarClientex(id) == null)
            {
                TempData["Mensaje"] = "No existe el producto";
            }


            if (new Clientex().DeleteClientex(id))
            {
                TempData["mensaje"] = "Eliminado correctamente";
                return RedirectToAction("Index");
            }

            TempData["mensaje"] = "No se ha podido eliminar ";
            return RedirectToAction("Index");
        }

        // POST: Clientex/Delete/5
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
