using System;
using Servicios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios
{
    public class ServiciosProducto
    {
        public static List<Producto> ListaProductos = new List<Producto>();
        public static List<TipoProducto> ListaTiposProductos = new List<TipoProducto>(){
            new TipoProducto { tipo= "Libreria", IdTipo = 1},
            new TipoProducto { tipo = "Hogar", IdTipo = 2},
            new TipoProducto { tipo = "Tecnologia", IdTipo = 3}
        };
       
        public static bool CrearProducto(Producto producto)
        {
              if (ValidarSiExisteId(producto.id) == false)
            {
                ListaProductos.Add(producto);
                return true;
            }

            return false;
        }

 
    public static List<TipoProducto> ObtenerTiposDeProductos()
    {
           // ServiciosProducto.AsignarTiposDeProductos();
            return ListaTiposProductos;
    }

    public static bool ValidarSiExisteId(int id)
    {
            if (ListaProductos.Count>0)
            {
                // si existe un producto en la lista con el id elegido
                if (ListaProductos.Exists(o => o.id.Equals(id)))
                {
                    return true;
                }
            }
        return false;
        }

    public static Producto ObtenerProductoPorId(int id)
    {
        return ListaProductos.Find(o => o.id.Equals(id));
    }

    public static List<Producto> ObtenerProductos()
    {
        return ListaProductos;
    }

    public static void Modificar(Producto p)
    {
        Producto productoActual = ObtenerProductoPorId(p.id);
        productoActual.nombre = p.nombre;
        productoActual.cantidad = p.cantidad;
        productoActual.precio = p.precio;
        productoActual.fechaAlta = p.fechaAlta;
        productoActual.IdTipo= p.IdTipo;
    }

    public static void Eliminar(int id)
    {
        ListaProductos.RemoveAll(o => o.id.Equals(id));
    }
}
}
