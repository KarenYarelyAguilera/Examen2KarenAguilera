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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            Detalles_dataGridView.DataSource = detallePedidosLista;
        }

        ProductosDA productoDA = new ProductosDA();
        Pedidos pedidos = new Pedidos();
        Productos producto;
        PedidosDA pedidosDA = new PedidosDA();

        List<DetallePedidos> detallePedidosLista = new List<DetallePedidos>();

        decimal SubTotal = decimal.Zero;
        decimal ISV = decimal.Zero;
        decimal Total = decimal.Zero;

        private void CodigoProducto_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Productosentidad producto = new Productosentidad();
                producto = productoDA.GetProductoPorCodigo(Cantidad_txt.Text);
                Descripcion_txt.Text = producto.Descripcion;
                Cantidad_txt.Focus();
            }
            else
            {
                producto = null;
                Descripcion_txt.Clear();
                Cantidad_txt.Clear();

            }

        }

        private void Cantidad_txt_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(Cantidad_txt.Text))
            {
                DetallePedidos detallePedido = new DetallePedidos();
                
                detallePedido.DescripcionProducto = producto.Descripcion;
                detallePedido.Cantidad = Convert.ToInt32(Cantidad_txt.Text);
                detallePedido.PrecioProducto = producto.Precio;
                detallePedido.Total = producto.Precio * Convert.ToInt32(Cantidad_txt.Text);

                SubTotal += detallePedido.Total;
                ISV = SubTotal * 0.15M;
                Total = SubTotal + ISV;

                SubTotal_txt.Text = SubTotal.ToString();
                isv_txt.Text = ISV.ToString();
                Total_txt.Text = Total.ToString();

                detallePedidosLista.Add(detallePedido);
                Detalles_dataGridView.DataSource = null;
            }
        }

        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            pedidos.NombreCliente = NombreCliente_txt.Text;
            pedidos.Fecha = Fecha_dateTimePicker.Value;
            pedidos.SubTotal = Convert.ToDecimal(SubTotal_txt.Text);
            pedidos.ISV = Convert.ToDecimal(isv_txt.Text);
            pedidos.Total = Convert.ToDecimal(Total_txt.Text);

            int IdPedidos = 0;

            IdPedidos = pedidosDA.AgregarPedido(pedidos);

            if (IdPedidos != 0)
            {
                foreach (var item in detallePedidosLista)
                {
                    item.IdPedido= IdPedidos;
                    pedidosDA.InsertarDetalle(item);
                }
            }

        }
    }
}


 
