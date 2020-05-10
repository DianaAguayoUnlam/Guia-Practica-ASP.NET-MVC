using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntidadesCalculadora;
using Servicios;

namespace EjercicioCalculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        /*2.	Crear un proyecto de tipo Aplicación ASP.NET MVC.
            a.	Crear un controller llamado calculadora (recordar la convención de MVC).
            b.	Agregar una vista con un form con los siguientes campos:
            i.	Input con id “Operador1”
            ii.	Input con id “Operador2”
            iii.	Input type=submit
            iv.	Control HTML p con id “Resultado”
            v.	Agregar un action a donde será recepcionado el submit del formulario para mostrar el mensaje en el control HTML p con id “Resultado”.
           */
        // GET: Calculadora
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Operar(ClaseCalculadora c) 
        {
            double resultado = ServiciosCalculadora.Resolver(c.operando1, c.operando2, c.operador);
            ViewBag.resultado = resultado;
            return View("Index");

        }
    }
}