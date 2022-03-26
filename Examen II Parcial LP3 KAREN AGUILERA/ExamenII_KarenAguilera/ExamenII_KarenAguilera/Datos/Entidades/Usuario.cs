using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombreUsuario, string contraseña)
        {
            NombreUsuario = NombreUsuario;
            this.Contraseña = contraseña;
        }
    }
}

