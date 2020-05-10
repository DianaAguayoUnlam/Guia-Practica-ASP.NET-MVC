using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GuiaPracticaASPNET_MVC.Controllers
{
    public class HomeController : Controller
    {
        /* 1.	Crear un proyecto de tipo Aplicación ASP.NET  MVC y crear un formulario Web.
             * En este formulario agregar una html input y un botón de type=submit.
             * En el action retornar un mensaje de éxito que debe ser mostrado en un control HTML p
             * dentro de la misma vista.
             */
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Mensaje()
        {
            ViewBag.mensaje = Request["mensaje"];
            return View();
        }

        [HttpPost]
        public ActionResult MostrarMensaje()
        {
             ViewBag.mensaje = Request["mensaje"];
            return View("Mensaje");
        }
    }
}