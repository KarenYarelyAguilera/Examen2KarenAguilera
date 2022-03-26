using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedidos
    {
        public int IdPedido { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }

        public Pedidos()
        {
        }
  

        public Pedidos(int idPedido, string nombreCliente,  DateTime fecha, decimal subTotal, decimal iSV, decimal total)
        {
            IdPedido = IdPedido;
            NombreCliente = nombreCliente ;
            Fecha = fecha;
            SubTotal = subTotal;
            ISV = iSV;
            Total = total;
        }
    }
}

