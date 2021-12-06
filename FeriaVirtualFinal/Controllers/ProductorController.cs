using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;

namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class ProductorController : Controller
    {
        // GET: Productor
        public ActionResult Index()

        {
            ViewBag.productores = new Productor().ReadProductorAll();
            return View();
        }

        // GET: Productor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Productor/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Productor/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ProductorNom,ProductorRut,ProductorDirec,ProductorTelef,ProductorMail")]Productor productor)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(productor);
                }
                productor.SaveProductor();
                TempData["mensaje"] = "guardado correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(productor);
            }
        }

        // GET: Productor/Edit/5
        public ActionResult Edit(int id)
        {
            Productor l = new Productor().BuscarProductor(id);

            if(l == null)
            {
                TempData["Mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.productores = new Productor().ReadProductorAll();
            return View(l);
        }

        // POST: Productor/Edit/5
        [HttpPost]
        public ActionResult Edit(Productor productor)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(productor);
                }
                productor.UpdateProductor();
                TempData["Mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(productor);
            }
        }

        // GET: Productor/Delete/5
        public ActionResult Delete(int id)

        {
            if(new Productor().BuscarProductor(id) == null)
            {
                TempData["Mensaje"] = "No existe el producto";
            }


            if(new Productor().DeleteProductor(id))
            {
                TempData["mensaje"] = "Eliminado correctamente";
                return RedirectToAction("Index");
            }

            TempData["mensaje"] = "No se ha podido eliminar ";
            return RedirectToAction("Index");
        }

        // POST: Productor/Delete/5
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
