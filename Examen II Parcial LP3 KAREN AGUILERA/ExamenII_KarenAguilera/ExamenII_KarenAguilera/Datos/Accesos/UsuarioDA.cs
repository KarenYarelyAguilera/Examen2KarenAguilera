using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos.Entidades;

namespace Datos.Accesos
{
    public class UsuarioDA
    {
        readonly string cadena = "Server= localhost; Port=3306; Database= Examen2BD; Uid=root; Pwd=12345678";
        MySqlConnection conn;
        MySqlCommand cmd;


        public Usuario Login(string NombreUsuario, string Contraseña)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE NombreUsuario= @NombreUsuario AND Contraseña = @Contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.NombreUsuario = reader[0].ToString();
                    user.Contraseña = reader[1].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {


            }
            return user;
        }


    }
}

