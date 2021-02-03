using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaCaso2.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Principal()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        public ActionResult DMedico()
        {
            return View();
        }

        public ActionResult Citas()
        {
            ViewBag.Message = "Puede sacar citas médicas en el hospital UTPL en las siguientes especialidades";

            return View();
        }

        public ActionResult Especialidades()
        {
            ViewBag.Message = "El hospital UTPL tiene a su disposición atención médica en las siguientes especialidades";

            return View();
        }
    }
}