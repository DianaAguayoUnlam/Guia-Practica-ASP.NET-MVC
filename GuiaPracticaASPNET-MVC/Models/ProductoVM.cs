using Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace GuiaPracticaASPNET_MVC.Models
{
    public class ProductoVM
    {
        public Producto Producto { get; set; }
        public List<TipoProducto> Tipos { get; set; }
       

    }
}