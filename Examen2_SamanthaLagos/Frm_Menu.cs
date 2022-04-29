using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2_SamanthaLagos
{
    public partial class Frm_Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }


        FrmProducto frmProducto = null;
        FrmPedidos frmPedidos = null;
       

        private void FrmPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPedidos = null;

        }

        private void Producto_toolStripButton_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
            {
                frmProducto.Activate();
            }
        }

        private void PedidotoolStripButton_Click(object sender, EventArgs e)
        {
            if (frmPedidos == null)
            {
                frmPedidos = new FrmPedidos();
                frmPedidos.MdiParent = this;
                frmPedidos.FormClosed += FrmPedidos_FormClosed;
                frmPedidos.Show();
            }
            else
            {
                frmPedidos.Activate();
            }
        }
    }
}
