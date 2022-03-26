using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Entidades;
using Datos.Accesos;

namespace ExamenII_KarenAguilera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            UsuarioDA UsuarioDA = new UsuarioDA();
            Usuario Usuario = new Usuario();
            Usuario = UsuarioDA.Login(NombreUsuario_Txt.Text, Contraseña_txt.Text);

            if (Usuario == null)
            {
                MessageBox.Show("Datos invalidos");

            }

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();


        }
    }
}
