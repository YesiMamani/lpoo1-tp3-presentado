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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrillaClientes();
        }

        private void CargarGrillaClientes()
        {
            dgvClientes.DataSource = OperacionesClientes.TraerClientes();
            dgvClientes.Columns["ApeyNom"].Visible = false;
        }

       

        private void dgvClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                txtDNI.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                //Valida si está en uso
                int nroVenta = OperacionesVentas.TraerNROVentaSegunParametro(txtDNI.Text,"DNI");
                if (nroVenta == 0)
                {
                    var respuesta = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta.ToString() == "Yes")
                    {
                        string dni = txtDNI.Text;
                        OperacionesClientes.EliminarCliente(dni);
                    }

                    CargarGrillaClientes();
                }
                else
                {
                    MessageBox.Show("El cliente seleccionado NO se puede eliminar!\n"+
                        "\nSe encuentra en uso en la Venta NRO: "+nroVenta
                        ,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();
            //CAPTURO LOS DATOS DEL FORMULARIO
            oCliente.Cli_dni = txtDNI.Text;
            oCliente.Cli_nombre = txtNombre.Text;
            oCliente.Cli_apellido = txtApellido.Text;
            oCliente.Cli_direccion = txtDireccion.Text;
            oCliente.Cli_telefono = txtTelefono.Text;

            OperacionesClientes.ModificarCliente(oCliente);

            CargarGrillaClientes();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FrmAltClientes oFrmAltClientes = new FrmAltClientes();
            oFrmAltClientes.ShowDialog();
            CargarGrillaClientes();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
              
            dgvClientes.DataSource = OperacionesClientes.TraerClientes(txtFiltro.Text);

        }

        private void btnOrdenarApellido_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = OperacionesClientes.TraerClientesOrdenadosPorApellidos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
