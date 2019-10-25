using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Alumnos.Controllers
{
    public class HomeController : Controller
    {

        private Alumno alumno = new Alumno();
        public ActionResult Index()
        {
         

            return View(alumno.Listar());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}