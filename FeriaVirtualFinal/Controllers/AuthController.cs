using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FeriaVirtualFinal.Negocio;
using System.Web.Security;

namespace FeriaVirtualFinal.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario,string ReturnUrl)
        {

            if (IsValid(usuario))
            {
                FormsAuthentication.SetAuthCookie(usuario.Email,false);
                if(ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else if (usuario.Rol == "administrador")
                {
                    return RedirectToAction("MenuAdministrador", "Home");
                }
                else if (usuario.Rol == "productor")
                {
                    return RedirectToAction("VistaProductor", "Home");

                }

                else if (usuario.Rol == "transportista")
                {
                    return RedirectToAction("VistaTransportista", "Home");

                }
                else if (usuario.Rol == "cliente")
                {
                    return RedirectToAction("VistaTotalClientes", "Home");

                }

                return RedirectToAction("Index", "Home");



            }


            TempData["mensaje"] = "credenciales incorrectos";
            return View(usuario);



        }
       

        private bool IsValid(Usuario usuario)
        {

            return usuario.Autenticar();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


    }
}