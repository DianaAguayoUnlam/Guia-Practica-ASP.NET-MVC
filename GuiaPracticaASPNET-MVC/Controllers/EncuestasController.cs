using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuiaPracticaASPNET_MVC.Controllers
{
    public class EncuestasController : Controller
    {
        /********************* punto 3: Encuesta con FormCollection *************************************/
        // GET: Encuestas
        [HttpGet]
        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(FormCollection form)
        {
            string nombre = form["Nombre"];
            string descripcion = form["Descripcion"];
            string check = form["check"];
            //Paso los datos por querystring
            return RedirectToAction("MostrarEncuesta", new { nombre, descripcion, check });
        }

        public ActionResult MostrarEncuesta(string Nombre, string Descripcion ,string check)
        {
            ViewBag.nombre = Nombre;
            ViewBag.descripcion = Descripcion;
            ViewBag.check = check;
            return View();
        }


        /********************* punto 4: Encuesta con clase Encuesta *************************************/

        public ActionResult AltaConClaseEncuesta(Encuesta encuesta)
        {
            //Paso los datos por querystring
            return RedirectToAction("MostrarEncuesta", new { encuesta.Nombre, encuesta.Descripcion, encuesta.check });
        }
    }
}