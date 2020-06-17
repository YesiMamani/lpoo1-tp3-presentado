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
            cbxClaseVehiculo.DataSource = OperacionesVehiculos.TraerClasesVehiculo();
            cbxClaseVehiculo.DisplayMember = "DESCRIPCION CLASE DE VEHICULO";   //muestre la descripcion
            cbxClaseVehiculo.ValueMember = "Id";

            cbxTipoVehiculo.DataSource = OperacionesVehiculos.TraerTiposVehiculo();
            cbxTipoVehiculo.DisplayMember = "DESCRIPCION DE TIPO DE VEHICULO";
            cbxTipoVehiculo.ValueMember = "Id";

            CargarGrillaVehiculos();
        }

        private void CargarGrillaVehiculos()
        {
            dgvVehiculos.DataSource = OperacionesVehiculos.TraerVehiculosMarcaOrden("M");
            dgvVehiculos.Columns["TV_ID"].Visible = false;
            dgvVehiculos.Columns["CV_ID"].Visible = false;            
            dgvVehiculos.AutoResizeColumns();
                        
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            FrmAltaVehiculo oFrmAltaVehiculo = new FrmAltaVehiculo();
            oFrmAltaVehiculo.ShowDialog();
            CargarGrillaVehiculos();
        }

        private void dgvVehiculos_CurrentCellChanged(object sender, EventArgs e)
        {
             if (dgvVehiculos.CurrentRow != null)
            {
                txtMAtricula.Text = dgvVehiculos.CurrentRow.Cells[0].Value.ToString();
                cbxMarca.Text = dgvVehiculos.CurrentRow.Cells[1].Value.ToString();
                txtLinea.Text = dgvVehiculos.CurrentRow.Cells[2].Value.ToString();
                cbxModelo.Text = dgvVehiculos.CurrentRow.Cells[3].Value.ToString();
                cbxColor.Text = dgvVehiculos.CurrentRow.Cells[4].Value.ToString();
                cbxPuertas.Text = dgvVehiculos.CurrentRow.Cells[5].Value.ToString();
                chkGPS.Checked = (bool)dgvVehiculos.CurrentRow.Cells[6].Value;
                cbxTipoVehiculo.SelectedValue = (int)dgvVehiculos.CurrentRow.Cells[7].Value;
                cbxClaseVehiculo.SelectedValue = (int)dgvVehiculos.CurrentRow.Cells[8].Value;
                txtPrecio.Text = dgvVehiculos.CurrentRow.Cells[11].Value.ToString();
            }
             
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow != null)
            {
                //Valida si está en uso
                int nroVenta = OperacionesVentas.TraerNROVentaSegunParametro(txtMAtricula.Text, "MATRICULA");
                if (nroVenta == 0)
                {
                    var respuesta = MessageBox.Show("¿Desea eliminar el Vehiculo seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta.ToString() == "Yes")
                    {
                        string matricula = txtMAtricula.Text;
                        OperacionesVehiculos.EliminarVehiculo(matricula);
                    }

                    CargarGrillaVehiculos();
                }
                else
                {
                    MessageBox.Show("El Vehiculo seleccionado NO se puede eliminar!\n" +
                        "\nSe encuentra en uso en la Venta NRO: " + nroVenta
                        , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtMAtricula.Text != "" && cbxMarca.Text != "" && txtLinea.Text != "" && cbxModelo.Text != "" && cbxColor.Text != "" && cbxPuertas.Text != "" && cbxTipoVehiculo.Text != "" && cbxClaseVehiculo.Text != "" && txtPrecio.Text != "")
            {
                Vehiculo oVehiculo = new Vehiculo();
                oVehiculo.Veh_matricula = txtMAtricula.Text;
                oVehiculo.Veh_marca = cbxMarca.Text;
                oVehiculo.Veh_linea = txtLinea.Text;
                oVehiculo.Veh_modelo = int.Parse(cbxModelo.Text);
                oVehiculo.Veh_color = cbxColor.Text;
                oVehiculo.Veh_puertas = int.Parse(cbxPuertas.Text);
                oVehiculo.Veh_gps = chkGPS.Checked;
                oVehiculo.Veh_tipoVehiculo = (int)cbxTipoVehiculo.SelectedValue;
                oVehiculo.Veh_claseVehiculo = (int)cbxClaseVehiculo.SelectedValue;
                oVehiculo.Veh_precio = decimal.Parse(txtPrecio.Text);

                OperacionesVehiculos.ModificarVehiculo(oVehiculo);

                CargarGrillaVehiculos();
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxColor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbxModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbxPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
