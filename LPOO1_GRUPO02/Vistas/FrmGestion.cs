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
    public partial class FrmGestion : Form
    {
        public FrmGestion()
        {
            InitializeComponent();
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            CargarGrillaSegunOpcion(0);
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            switch (cbxVer.SelectedIndex)
            {
                case 0://Clases Vehiculo
                    OperacionesVehiculos.EliminarClaseVehiculo(txtId.Text);
                    break;
                case 1://Tipos Vehiculo
                    OperacionesVehiculos.EliminarTipoVehiculo(txtId.Text);
                    break;
                case 2://Formas Pago
                    OperacionesVentas.EliminarFormaPago(txtId.Text);
                    break;
            }
            CargarGrillaSegunOpcion(cbxVer.SelectedIndex);
        }

        private void CargarGrillaSegunOpcion(int opcion)
        {
            switch (opcion)
            {
                case 0://Clases Vehiculo
                    dgvGestion.DataSource = OperacionesVehiculos.TraerClasesVehiculo();
                    break;
                case 1://Tipos Vehiculo
                    dgvGestion.DataSource = OperacionesVehiculos.TraerTiposVehiculo();
                    break;
                case 2://Formas Pago
                    dgvGestion.DataSource = OperacionesVentas.TraerFormasPago();
                    break;
                default:
                    dgvGestion.DataSource = OperacionesVehiculos.TraerClasesVehiculo();
                    break;
            }
            cbxVer.SelectedIndex = opcion;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (cbxVer.SelectedIndex)
            {
                case 0://Clases Vehiculo
                    OperacionesVehiculos.ModificarClaseVehiculo(txtId.Text, txtDescripcion.Text);
                    break;
                case 1://Tipos Vehiculo
                    OperacionesVehiculos.ModificarTipoVehiculo(txtId.Text, txtDescripcion.Text);
                    break;
                case 2://Formas Pago
                    OperacionesVentas.ModificarFormaPago(txtId.Text, txtDescripcion.Text);
                    break;
            }
            CargarGrillaSegunOpcion(cbxVer.SelectedIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            btnAgregar.Enabled = true;
            btnEliminarSeleccionado.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (cbxVer.SelectedIndex)
            {
                case 0://Clases Vehiculo
                    OperacionesVehiculos.AgregarClaseVehiculo(txtDescripcion.Text);
                    break;
                case 1://Tipos Vehiculo
                    OperacionesVehiculos.AgregarTipoVehiculo(txtDescripcion.Text);
                    break;
                case 2://Formas Pago
                    OperacionesVentas.AgregarFormaPago(txtDescripcion.Text);
                    break;
            }
            CargarGrillaSegunOpcion(cbxVer.SelectedIndex);
        }

        private void cbxVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrillaSegunOpcion(cbxVer.SelectedIndex);
        }

        private void dgvGestion_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvGestion.CurrentRow != null)
            {
                txtId.Text = dgvGestion.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvGestion.CurrentRow.Cells[1].Value.ToString();
                btnAgregar.Enabled = false;
                btnEliminarSeleccionado.Enabled = true;
                btnModificar.Enabled = true;
                btnNuevo.Enabled = true;
            }
        }
    }
}
