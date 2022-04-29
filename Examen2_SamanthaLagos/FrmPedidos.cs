using ClasesUsuario.Acceso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesUsuario.Entidades;

namespace Examen2_SamanthaLagos
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        ProductoDA productoDA = new ProductoDA();
        PedidosDA pedidoDA = new PedidosDA();
        Producto producto;
        Pedidos pedidos;
        List<Detalle_Pedidos> detalle_Ped_List = new List<Detalle_Pedidos>();

        decimal Sub_Tota = decimal.Zero;
        decimal isv = decimal.Zero;
        decimal Tot = decimal.Zero;

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            dtp_Pedido.DataSource = detalle_Ped_List;
        }

        private void Txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoDA.GetProductoporCoodigo(Txt_Codigo.Text);
                Txt_Descr.Text = producto.Descripcion;
                Txt_Cantidad.Focus();
            }
            else
            {
                producto = null;
                Txt_Descr.Clear();
                Txt_Cantidad.Clear();
            }
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(Txt_Cantidad.Text))
            {
                Detalle_Pedidos detallePed = new Detalle_Pedidos();
                detallePed.CodigoProducto = producto.Codigo;
                detallePed.Descripcion = producto.Descripcion;
                detallePed.Cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                detallePed.Precio = producto.Precio;
                detallePed.Total = producto.Precio * Convert.ToInt32(Txt_Cantidad.Text);

                Sub_Tota += detallePed.Total;
                isv = Sub_Tota * 0.15M;
                Tot = Sub_Tota + isv;

                Txt_Sub_Tot.Text = Sub_Tota.ToString();
                Txt_Isv.Text = isv.ToString();
                Txt_TotalP.Text = Tot.ToString();


                detalle_Ped_List.Add(detallePed);
                dtp_Pedido.DataSource = null;
                dtp_Pedido.DataSource = detalle_Ped_List;

            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            pedidos.IdentidadClient = Convert.ToString(TxtM_Identidad.Text);
            pedidos.Cliente = Txt_Nombre.Text;
            pedidos.Fecha = dateTp_Fecha.Value;
            pedidos.Sub_Tot = Convert.ToDecimal(Txt_Sub_Tot.Text);
            pedidos.Isv = Convert.ToDecimal(Txt_Isv.Text);
            pedidos.Total = Convert.ToDecimal(Txt_TotalP.Text);

            int idPedidos = 0;

            idPedidos = pedidoDA.InsertPedido(pedidos);

            if (idPedidos != 0)
            {
                foreach (var item in detalle_Ped_List)
                {
                    item.IdPedidos = idPedidos;
                    pedidoDA.InsertDetalle_P(item);

                }
            }
        }
    }


}
