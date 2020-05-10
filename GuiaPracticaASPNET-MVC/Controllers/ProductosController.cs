using Entidades;
using GuiaPracticaASPNET_MVC.Models;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuiaPracticaASPNET_MVC.Controllers
{
    public class ProductosController : Controller
    {
   // GET: Productos
        private ProductoVM ObtenerProductoVM()
        {
            List<TipoProducto> Tipos = ServiciosProducto.ObtenerTiposDeProductos();
            ProductoVM productoVM = new ProductoVM();
            productoVM.Tipos = Tipos;
            return productoVM;
        }

        [HttpGet]
        public ActionResult Crear()
        {

           var model = ObtenerProductoVM();
           return View(model);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
          if (!ServiciosProducto.CrearProducto(producto))
            {
                ViewBag.error = $"Error. El id {producto.id} ya existe";
                return RedirectToAction("Crear");
            } 
            return RedirectToAction("Crear");
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            ProductoVM model = ObtenerProductoVM();
            model.Producto = ServiciosProducto.ObtenerProductoPorId(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Modificar(Producto p)
        {
            ServiciosProducto.Modificar(p);
            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
            List<Producto> lista = ServiciosProducto.ObtenerProductos();
            return View(lista);
        }

        public ActionResult Eliminar(int id)
        {
            ServiciosProducto.Eliminar(id);
            return RedirectToAction("Listar");
        }


    }
}