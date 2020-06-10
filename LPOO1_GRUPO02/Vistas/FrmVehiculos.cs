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
    public partial class FrmVehiculos : Form
    {
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource = OperacionesVehiculos.TraerVehiculosMarcaOrden("M");
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            FrmAltaVehiculo oFrmAltaVehiculo = new FrmAltaVehiculo();
            oFrmAltaVehiculo.ShowDialog();
            dgvVehiculos.DataSource = OperacionesVehiculos.TraerVehiculosMarcaOrden("M");
        }

        private void dgvVehiculos_CurrentCellChanged(object sender, EventArgs e)
        {
             if (dgvVehiculos.CurrentRow != null)
            {
                txtMAtricula.Text = dgvVehiculos.CurrentRow.Cells[0].Value.ToString();
                txtMArca.Text = dgvVehiculos.CurrentRow.Cells[1].Value.ToString();
                txtLinea.Text = dgvVehiculos.CurrentRow.Cells[2].Value.ToString();
                txtModelo.Text = dgvVehiculos.CurrentRow.Cells[3].Value.ToString();
                txtColor.Text = dgvVehiculos.CurrentRow.Cells[4].Value.ToString();
                txtPuertas.Text = dgvVehiculos.CurrentRow.Cells[5].Value.ToString();
                chkGPS.Checked = (bool)dgvVehiculos.CurrentRow.Cells[6].Value;
                txtTipoVehiculo.Text = dgvVehiculos.CurrentRow.Cells[7].Value.ToString();
                txtClaseVehiculo.Text = dgvVehiculos.CurrentRow.Cells[8].Value.ToString();
                txtPrecio.Text = dgvVehiculos.CurrentRow.Cells[9].Value.ToString();
            }
             
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow != null)
            {
                string matricula = txtMAtricula.Text;
                OperacionesVehiculos.EliminarVehiculo(matricula);
                dgvVehiculos.DataSource = OperacionesVehiculos.TraerVehiculosMarcaOrden("M");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Vehiculo oVehiculo = new Vehiculo();
            oVehiculo.Veh_matricula = txtMAtricula.Text;
            oVehiculo.Veh_marca = txtMArca.Text;
            oVehiculo.Veh_linea = txtLinea.Text;
            oVehiculo.Veh_modelo = int.Parse(txtModelo.Text);
            oVehiculo.Veh_color = txtColor.Text;
            oVehiculo.Veh_puertas = int.Parse(txtPuertas.Text);
            oVehiculo.Veh_gps = chkGPS.Checked;
            oVehiculo.Veh_tipoVehiculo = txtTipoVehiculo.Text;
            oVehiculo.Veh_claseVehiculo = txtClaseVehiculo.Text;
            oVehiculo.Veh_precio = decimal.Parse(txtPrecio.Text);

            OperacionesVehiculos.ModificarVehiculo(oVehiculo);

            dgvVehiculos.DataSource = OperacionesVehiculos.TraerVehiculosMarcaOrden("M"); //actualiza la grilla
        }
    }
}
