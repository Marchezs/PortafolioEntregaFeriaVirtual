using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;

namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            ViewBag.productos = new Producto().ReadProductoAll();
            

            return View();
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(producto);
                }
                producto.SaveProducto();
                
                TempData["mensaje"] = "guardado correctamente";
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View(producto);
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            Producto p = new Producto().BuscarProducto(id);

            if(p == null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.productos = new Producto().ReadProductoAll();
            return View(p);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(producto);
                }
                producto.UpdateProducto();
                TempData["mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(producto);
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Producto().BuscarProducto(id) == null)
            {
                TempData["Mensaje"] = "No existe el producto";
            }


            if (new Producto().DeleteProducto(id))
            {
                TempData["mensaje"] = "Eliminado correctamente";
                return RedirectToAction("Index");
            }

            TempData["mensaje"] = "No se ha podido eliminar ";
            return RedirectToAction("Index");
        }

        // POST: Producto/Delete/5
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
