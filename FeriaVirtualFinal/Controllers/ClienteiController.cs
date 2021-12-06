using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;


namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class ClienteiController : Controller
    {
        // GET: Clientei
        public ActionResult Index()
        {

            ViewBag.clienteis = new Clientei().ReadClienteiAll();
            return View();
        }

        // GET: Clientei/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientei/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientei/Create
        [HttpPost]
        public ActionResult Create(Clientei clientei)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(clientei);
                }
                clientei.SaveClientei();

                TempData["mensaje"] = "guardado correctamente";

                return RedirectToAction("Index");

            }
            catch
            {
                return View(clientei);
            }
        }

        // GET: Clientei/Edit/5
        public ActionResult Edit(int id)
        {
            Clientei i = new Clientei().BuscarClientei(id);

            if (i == null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.clienteis = new Clientei().ReadClienteiAll();
            return View(i);
        }

        // POST: Clientei/Edit/5
        [HttpPost]
        public ActionResult Edit(Clientei clientei)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(clientei);
                }

                clientei.UpdateClientei();
                TempData["mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(clientei);
            }
        }

        // GET: Clientei/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Clientei().BuscarClientei(id) == null)
            {
                TempData["Mensaje"] = "No existe el producto";
            }


            if (new Clientei().DeleteClientei(id))
            {
                TempData["mensaje"] = "Eliminado correctamente";
                return RedirectToAction("Index");
            }

            TempData["mensaje"] = "No se ha podido eliminar ";
            return RedirectToAction("Index");
        }

        // POST: Clientei/Delete/5
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

        public ActionResult Vista1()
        {

            ViewBag.clienteis = new Clientei().ReadClienteiAll();
            return View();
        }
    }
}
