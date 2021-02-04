using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaCaso2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(string User, string Pass)
        {
            try
            {
                
                if(User == "wacalderon4" && Pass=="BpX8vLHk")
                {
                    return RedirectToAction("Principal", "Home");
                }
                else
                {
                    if (User == null && Pass == null)
                    {
                        ViewBag.Error = "Ingrese su usuario y contraseña";
                        return View();
                    }
                    else
                    {
                        ViewBag.Error = "Usuario y/o contraseña incorrectos";
                        return View();
                    }
                }
            }catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        [HttpPost]

        public ActionResult CerrarSesion()
        {
            return View();
        }
    }
}