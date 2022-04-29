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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        string opera = string.Empty;

        ProductoDA productoDA = new ProductoDA();

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            opera = "Nuevo";
            HabilitarControles();
        }
        private void HabilitarControles()
        {
            Txt_Codigo.Enabled = true;
            Txt_Descr.Enabled = true;
            Txt_Precio.Enabled = true;
            Txt_Existencia.Enabled = true;
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_Nuevo.Enabled = false;
            Btn_Modificar.Enabled = false;

        }
        private void DesabilitarControles()
        {
            Txt_Codigo.Enabled = false;
            Txt_Descr.Enabled = false;
            Txt_Existencia.Enabled = false;
            Txt_Precio.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Nuevo.Enabled = true;
            Btn_Modificar.Enabled = true;

        }
        private void LimpiarControles()
        {
            Txt_Codigo.Clear();
            Txt_Descr.Clear();
            Txt_Precio.Clear();
            Txt_Existencia.Clear();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Codigo.Text))
                {
                    errorProvider1.SetError(Txt_Codigo, "Ingrese el código");
                    Txt_Codigo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Txt_Descr.Text))
                {
                    errorProvider1.SetError(Txt_Descr, "Ingrese una descripción");
                    Txt_Descr.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Txt_Precio.Text))
                {
                    errorProvider1.SetError(Txt_Precio, "Ingrese un precio");
                    Txt_Precio.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Txt_Existencia.Text))
                {
                    errorProvider1.SetError(Txt_Existencia, "Ingrese una existencia");
                    Txt_Existencia.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.Codigo = Txt_Codigo.Text;
                producto.Descripcion = Txt_Descr.Text;
                producto.Precio = Convert.ToDecimal(Txt_Precio.Text);
                producto.Existencia = Convert.ToInt32(Txt_Existencia.Text);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();


                if (opera == "Nuevo")
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
                else if (opera == "Modificar")
                {
                    bool modifico = productoDA.ModificarProducto(producto);
                    if (modifico)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Modificado");
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            Dtp_Productos.DataSource = productoDA.ListarProductos();
        }

        private void Txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(Txt_Precio, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Txt_Existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            opera = "Modificar";

            if (Dtp_Productos.SelectedRows.Count > 0)
            {
                Txt_Codigo.Text = Dtp_Productos.CurrentRow.Cells["Codigo"].Value.ToString();
                Txt_Descr.Text = Dtp_Productos.CurrentRow.Cells["Descripcion"].Value.ToString();
                Txt_Precio.Text = Dtp_Productos.CurrentRow.Cells["Precio"].Value.ToString();
                Txt_Existencia.Text = Dtp_Productos.CurrentRow.Cells["Existencia"].Value.ToString();


                HabilitarControles();
                Txt_Codigo.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }
    }
}
