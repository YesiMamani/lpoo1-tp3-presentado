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
    public partial class FrmListadoVehiculos : Form
    {
        public FrmListadoVehiculos()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarListado_Click(object sender, EventArgs e)
        {
            string opcion = "M";
            if (rdbLinea.Checked)
            {
                opcion = "L";
            }
            dgvVehiculos.DataSource = OperacionesVehiculos.TraerVehiculosMarcaOrden(opcion);
        }

        private void FrmListadoVehiculos_Load(object sender, EventArgs e)
        {
            dgvVehiculos.DataSource = OperacionesVehiculos.TraerVehiculosMarcaOrden("M");
        }
    }
}
