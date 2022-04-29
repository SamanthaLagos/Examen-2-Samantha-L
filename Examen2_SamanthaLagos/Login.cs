using ClasesUsuario.Acceso;
using ClasesUsuario.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_SamanthaLagos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn__Aceptar_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(Txt_usuario.Text, Txt_contraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario ó contraseña incorrectos");

            }
            else
            {
                MessageBox.Show("Usuario Correcto");
            }

            Frm_Menu frm_Menu = new Frm_Menu();
            frm_Menu.Show();
            this.Hide();
        
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
