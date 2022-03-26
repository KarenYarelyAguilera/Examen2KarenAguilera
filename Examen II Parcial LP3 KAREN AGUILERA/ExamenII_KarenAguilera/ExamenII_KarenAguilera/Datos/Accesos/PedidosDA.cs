using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Accesos;
using Datos.Entidades;
using MySql.Data.MySqlClient;


namespace Datos.Accesos
{
    public class PedidosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=Examen2BD; Uid=root; Pwd=12345678;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int AgregarPedido(Pedidos pedidos)
        {
            int IdPedido = 0;
            try
            {
                string sql = "INSERT INTO Pedidos (NombreCliente,Fecha, SubTotal, ISV, Total) VALUES (@IdPedido, @NombreCliente, @Fecha, @SubTotal,@ISV, @Total)select last_insert_id();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@NombreCliente", pedidos.NombreCliente);
                cmd.Parameters.AddWithValue("@Fecha", pedidos.Fecha);
                cmd.Parameters.AddWithValue("@SubTotal", pedidos.SubTotal);
                cmd.Parameters.AddWithValue("@Impuesto", pedidos.ISV);
                cmd.Parameters.AddWithValue("@Total", pedidos.Total);
                IdPedido= Convert.ToInt32(cmd.ExecuteScalar());


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return IdPedido;
        }

        public bool InsertarDetalle(DetallePedidos detallePedido)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO DetallePedidos (IdDetallePedidos, CodigoProducto, DescripcionProducto, Cantidad, PrecioProducto, Total) VALUES (@IdDetallesPedido, @CodigoProducto, @DescripcionProducto, @Cantidad, @PrecioProducto, @Total);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdDetallePedidos", detallePedido.IdDetallePedidos);
                cmd.Parameters.AddWithValue("@IdProducto", detallePedido.IdProducto);
                cmd.Parameters.AddWithValue("@DescripcionProducto", detallePedido.DescripcionProducto);
                cmd.Parameters.AddWithValue("@Cantidad", detallePedido.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioProducto", detallePedido.PrecioProducto);
                cmd.Parameters.AddWithValue("@Total", detallePedido.Total);
                cmd.ExecuteNonQuery();

                inserto = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }

    }

}

