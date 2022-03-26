using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Productosentidad
    {
        public string IdProductos { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
      

        public Productosentidad()
        {

        }

        public Productosentidad(string idProductos, string nombreProducto, string descripcion, decimal precio, int existencia)
        {
            IdProductos = idProductos;
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
          
        }
    }

}
