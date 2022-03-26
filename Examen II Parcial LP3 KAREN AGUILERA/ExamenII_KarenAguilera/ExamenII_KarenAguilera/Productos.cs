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
using Datos.Accesos;
using Datos.Entidades;


namespace ExamenII_KarenAguilera
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;

        ProductosDA productoDA = new ProductosDA();

        public string IdProductos { get; internal set; }
        public string Descripcion { get; internal set; }
        public decimal Precio { get; internal set; }

        private void Nuevo_btn_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
 
        }
        private void HabilitarControles()
        {
            IdProducto_txt.Enabled = true;
            DescripcionProducto_txt.Enabled = true;
            NombreProducto_txt.Enabled = true;
            PrecioProducto_txt.Enabled = true;
            ExistenciaProducto_txt.Enabled = true;
            Guardar_btn.Enabled = true;
            Cancelar_btn.Enabled = true;
            Nuevo_btn.Enabled = false;
          

        }
        private void DesabilitarControles()
        {
            IdProducto_txt.Enabled = false;
            DescripcionProducto_txt.Enabled = false;
            NombreProducto_txt.Enabled = false;
            PrecioProducto_txt.Enabled = false;
            ExistenciaProducto_txt.Enabled = false;
            Guardar_btn.Enabled = false;
            Cancelar_btn.Enabled = false;
            Nuevo_btn.Enabled = true;
          

        }
        private void LimpiarControles()
        {
            IdProducto_txt.Clear();
            NombreProducto_txt.Clear();
            DescripcionProducto_txt.Clear();
            PrecioProducto_txt.Clear();
            ExistenciaProducto_txt.Clear();
        }

        private void Guardar_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(IdProducto_txt.Text))
                {
                    errorProvider1.SetError(IdProducto_txt, "Ingrese el código");
                    IdProducto_txt.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombreProducto_txt.Text))
                {
                    errorProvider1.SetError(NombreProducto_txt, "Ingrese el Nombre del producto");
                    NombreProducto_txt.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionProducto_txt.Text))
                {
                    errorProvider1.SetError(DescripcionProducto_txt, "Ingrese una descripción");
                    DescripcionProducto_txt.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioProducto_txt.Text))
                {
                    errorProvider1.SetError(PrecioProducto_txt, "Ingrese un precio");
                    PrecioProducto_txt.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciaProducto_txt.Text))
                {
                    errorProvider1.SetError(ExistenciaProducto_txt, "Ingrese una existencia");
                    ExistenciaProducto_txt.Focus();
                    return;
                }

                Productosentidad producto = new Productosentidad();
                producto.IdProductos = IdProducto_txt.Text;
                producto.NombreProducto = NombreProducto_txt.Text;
                producto.Descripcion = DescripcionProducto_txt.Text;
                producto.Precio = Convert.ToDecimal(PrecioProducto_txt.Text);
                producto.Existencia = Convert.ToInt32(ExistenciaProducto_txt.Text);

              
                if (operacion == "Nuevo")
                {
                    bool inserto = productoDA.InsertarProducto(producto);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto insertado");
                    }
                }
                else if (operacion == "Nuevo")
                {
                    bool inserto = productoDA.InsertarProducto(producto);
                    if (inserto)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        ListarProductos();

                        MessageBox.Show("Producto Insertado");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            ListaProductos_Dgv.DataSource = productoDA.ListarProductos();

        }

        private void PrecioProducto_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(PrecioProducto_txt, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void ExistenciaProducto_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            if (ListaProductos_Dgv.SelectedRows.Count > 0)
            {
                bool elimino = productoDA.EliminarProducto(ListaProductos_Dgv.CurrentRow.Cells["Codigo"].Value.ToString());

                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("Producto Eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

}
