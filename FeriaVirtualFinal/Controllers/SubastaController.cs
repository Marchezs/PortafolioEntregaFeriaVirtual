using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;

namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class SubastaController : Controller
    {
        // GET: Subasta
        public ActionResult Index()
        {
            ViewBag.subastas = new Subasta().ReadSubastaAll();
            return View();
        }

        public ActionResult View1()
        {
            ViewBag.subastas = new Subasta().ReadSubastaAll();
            return View();
        }

        // GET: Subasta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subasta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subasta/Create
        [HttpPost]
        public ActionResult Create(Subasta subasta)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(subasta);
                }
                subasta.SaveSubasta();

                TempData["mensaje"] = "guardado correctamente";

                return RedirectToAction("Index");
            }
            catch
            {
                return View(subasta);
            }
        }

        // GET: Subasta/Edit/5
        public ActionResult Edit(int id)
        {
            Subasta s = new Subasta().BuscarSubasta(id);

            if (s == null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.subastas = new Subasta().ReadSubastaAll();
            return View(s);
        }

        // POST: Subasta/Edit/5
        [HttpPost]
        public ActionResult Edit(Subasta subasta)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(subasta);
                }
                subasta.SaveSubasta();
                // TODO: Add update logic here

                subasta.UpdateSubasta();
                TempData["mensaje"] = "Pedido con exito";
                return RedirectToAction("View1");
            }
            catch
            {
                return View(subasta);
            }
        }

        // GET: Subasta/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Subasta().BuscarSubasta(id) == null)
            {
                TempData["Mensaje"] = "No existe el producto";
            }


            if (new Subasta().DeleteSubasta(id))
            {
                TempData["mensaje"] = "Eliminado correctamente";
                return RedirectToAction("Index");
            }

            TempData["mensaje"] = "No se ha podido eliminar ";
            return RedirectToAction("Index");
        }

        // POST: Subasta/Delete/5
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
        
        public ActionResult Pedir(Subasta subasta,Transportista transportista)
        {
           if(subasta.SubPesoMax  == transportista.TransMax && subasta.SubPesoMin == transportista.TransMin)
            {
                TempData["mensaje"] = "Pedido correctamente";
                return View("Index");
            }

            TempData["mensaje"] = "No cumple con los requesitos de peso";
            return View("Index");
        }
    }
}
