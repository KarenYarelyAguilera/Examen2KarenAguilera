using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Accesos;
using Datos.Entidades;
using MySql.Data.MySqlClient;
using System.Data;


namespace Datos.Accesos
{
    public class ProductosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=Examen2BD; Uid=root; Pwd=12345678;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();

            try
            {
                string sql = "SELECT * FROM Productos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return lista;
        }

        public bool InsertarProducto(Productosentidad producto)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO Productos VALUES (@IdProductos, @NombreProducto, @Descripcion, @Precio, @Existencia);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdProductos", producto.IdProductos);
                cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }

        public bool ModificarProducto(Productosentidad producto)
        {
            bool modifico = false;
            try
            {
                string sql = "UPDATE Productos SET IdProductos = @IdProductos, NombreProducto = @NombreProducto, " +
                             "Descripcion = @Descripcion, Precio = @Precio, Existencia = @Existencia WHERE IdProductos = @IdProductos;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdProductos", producto.IdProductos);
                cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                cmd.Parameters.AddWithValue("@Descripcion",producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception)
            {
            }
            return modifico;
        }

        public bool EliminarProducto(string IdProductos)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM Productos WHERE IdProductos = @IdProductos;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdProductos", IdProductos);

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }

        

        public Productosentidad GetProductoPorCodigo(string IdProductos)
        {
            Productosentidad producto = new Productosentidad();
            try
            {
                string sql = "Select * from Productos WHERE IdProductos = @IdProductos;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdProductos", IdProductos);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto.IdProductos = reader["IdProductos"].ToString();
                    producto.NombreProducto= reader["NombreProducto"].ToString() ;
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Precio = Convert.ToDecimal(reader["Precio"]);
                    producto.Existencia = Convert.ToInt32(reader["Existencia"].ToString());
       
                }

                conn.Close();
            }
            catch (Exception)
            {
            }
            return producto;
        }

    }
}

