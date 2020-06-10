using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasenia.Text;

            oUsuario = OperacionesUsuarios.TraerUsuario(usuario, contraseña);

            if (oUsuario != null)
            {
                MessageBox.Show("Bienvenido al Sistema: " + oUsuario.Usu_apellidoNombre, "Bienvenida");
                FrmPrincipal oFrmPrincipal = new FrmPrincipal(oUsuario);
                oFrmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O CONTRASEÑA ES INCORRECTO!");//muestra un mnj
            }

                       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//para q cierre la ventana del login. this hace referencia asi mismo
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.Height = 52;//cambiando el tamaño al boton
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.Height = 40;//vuelve al tamaño original
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Red; //cambiando el color de fondo a rojo al boton
           
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Gray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
