using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;

namespace FeriaVirtualFinal.Controllers
{
    [Authorize]
    public class PedidoController : Controller
    {

        // GET: Pedido
        public ActionResult Index()
        {

            ViewBag.pedidos = new Pedido().ReadPedidoAll();
            return View();
        }

        // GET: Pedido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pedido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedido/Create
        [HttpPost]
        public ActionResult Create(Pedido pedido)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(pedido);
                }

                pedido.SavePedido();
                TempData["mensaje"] = "guardado correctamente";

                return RedirectToAction("Index");
            }
            catch
            {
                return View(pedido);
            }
        }

        // GET: Pedido/Edit/5
        public ActionResult Edit(int id)
        {

            Pedido o = new Pedido().BuscarPedido(id);

            if (o == null)
            {
                TempData["mensaje"] = "El producto no existe";
                return RedirectToAction("Index");
            }

            ViewBag.pedidos = new Pedido().ReadPedidoAll();
            return View(o);
            
        }

        // POST: Pedido/Edit/5
        [HttpPost]
        public ActionResult Edit(Pedido pedido)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View(pedido);
                }

                pedido.UpdatePedido();
                TempData["mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index");

                
            }
            catch
            {
                return View(pedido);
            }
        }

        // GET: Pedido/Delete/5
        public ActionResult Delete(int id)
        {
            if (new Pedido().BuscarPedido(id) == null)
            {
                TempData["Mensaje"] = "No existe el producto";
            }


            if (new Pedido().DeletePedido(id))
            {
                TempData["mensaje"] = "Eliminado correctamente";
                return RedirectToAction("Index");
            }

            TempData["mensaje"] = "No se ha podido eliminar ";
            return RedirectToAction("Index");
        }

        // POST: Pedido/Delete/5
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
