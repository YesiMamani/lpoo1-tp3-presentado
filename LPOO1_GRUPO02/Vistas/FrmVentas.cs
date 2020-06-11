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
    public partial class FrmVentas : Form
    {
        Usuario myUser = new Usuario();
        public FrmVentas(Usuario myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
            txtVendedor.Text = myUser.Usu_apellidoNombre;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = OperacionesClientes.TraerClientesCombo();
            cmbCliente.DisplayMember = "CLI_ayn";
            cmbCliente.ValueMember = "CLI_DNI";

            cmbVehiculo.DataSource = OperacionesVehiculos.TraerVehiculosCombo();
            cmbVehiculo.DisplayMember = "VEH_Info";
            cmbVehiculo.ValueMember = "VEH_Matricula";

            cmbPrecioFinal.DataSource = OperacionesVehiculos.TraerVehiculosCombo();
            cmbPrecioFinal.DisplayMember = "VEH_Precio";
            cmbPrecioFinal.ValueMember = "VEH_Matricula";

            cmbFormaDePago.DataSource = OperacionesVentas.TraerFormasPago();
            cmbFormaDePago.DisplayMember = "Descripcion";
            cmbFormaDePago.ValueMember = "Id";

            dtpFechaDeCompra.Value = DateTime.Today;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehiculo.SelectedValue != null)
            {
                cmbPrecioFinal.SelectedValue = cmbVehiculo.SelectedValue;
            }

        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            Venta oVenta = new Venta();

            oVenta.Clie_dni = (string)cmbCliente.SelectedValue;
            oVenta.Veh_matricula = (string)cmbVehiculo.SelectedValue;
            oVenta.Usu_id = myUser.Usu_id;
            oVenta.Vta_fecha = dtpFechaDeCompra.Value;
            oVenta.Vta_formaPago = cmbFormaDePago.SelectedIndex;
            oVenta.Vta_precioFinal = int.Parse(cmbPrecioFinal.Text);
            oVenta.Vta_estado = "ACTIVA";

            OperacionesVentas.AgregarVenta(oVenta);
            MessageBox.Show("Venta Registrada");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbVehiculo.SelectedIndex = -1;
            cmbFormaDePago.SelectedIndex = -1;
            cmbPrecioFinal.SelectedIndex = -1;
            dtpFechaDeCompra.Value = DateTime.Today;
        }
    
    }

}
