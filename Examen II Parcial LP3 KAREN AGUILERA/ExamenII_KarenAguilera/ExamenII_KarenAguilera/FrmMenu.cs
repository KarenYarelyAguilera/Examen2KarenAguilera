using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamenII_KarenAguilera
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        Productos productos = null;
        FrmPedidos frmPedidos = null;

        private void Productos_toolStripButton1_Click(object sender, EventArgs e)
        {
            if (productos == null)
            {
                productos = new Productos();
                productos.MdiParent = this;
                productos.FormClosed += Productos_FormClosed;
                productos.Show();
            }
            else
            {
                productos.Activate();
            }
        }

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            productos = null;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmPedidos == null)
            {
                frmPedidos = new FrmPedidos();
                frmPedidos.MdiParent = this;
                frmPedidos.FormClosed += toolStripButton1_FormClosed;
                frmPedidos.Show();
            }
            else
            {
                frmPedidos.Activate();
            }
        }

        private void toolStripButton1_FormClosed(object sender, EventArgs e)
        {
            frmPedidos = null;
        }
    }
}
  
