using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class DetallePedidos
    {
   
        public int IdDetallePedidos { get; set; }
        public int IdProducto {get; set; }
        public int IdPedido {get; set; }    
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioProducto { get; set; }
        public decimal Total { get; set; }

        public DetallePedidos()
        {
        }

        public DetallePedidos( int idDetallesPedido, int idProducto, int idPedido, string descripcionProducto, int cantidad, decimal precioProducto, decimal total)
        {
            
            IdDetallePedidos = idDetallesPedido;
            IdProducto = idProducto;
            IdPedido = idPedido;
            DescripcionProducto = descripcionProducto;
            Cantidad = cantidad;
            PrecioProducto = precioProducto;
            Total = total;
        }
    }
}
