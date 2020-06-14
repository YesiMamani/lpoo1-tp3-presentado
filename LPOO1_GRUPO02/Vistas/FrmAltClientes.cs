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
    public partial class FrmAltClientes : Form
    {
        public FrmAltClientes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

          if(txtNombre.Text != "" && txtApellido.Text != "" && txtDni.Text !="" && txtDireccion.Text !="" && txtTelefono.Text !="")
            {

                Cliente oCliente = new Cliente();
                oCliente.Cli_nombre = txtNombre.Text;
                oCliente.Cli_apellido = txtApellido.Text;
                oCliente.Cli_dni = txtDni.Text;
                oCliente.Cli_direccion = txtDireccion.Text;
                oCliente.Cli_telefono = txtTelefono.Text;

                OperacionesClientes.AgregarCliente(oCliente);
                
              var respuesta=MessageBox.Show("Cliente agregado exitosamente!\n"
             +"\n¿Desea agregar otro Cliente?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              if (respuesta.ToString() == "Yes")
              {
                  limpiarCampos();
              }
              else
              {
                  this.Close();
              }
          }
          else
          {
              MessageBox.Show("Debe completar todos los datos");
          } 
        }

        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


    }
}
