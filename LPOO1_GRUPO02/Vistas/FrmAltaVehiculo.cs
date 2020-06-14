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
    public partial class FrmAltaVehiculo : Form
    {
        public FrmAltaVehiculo()
        {
            InitializeComponent();
        }

        private void btnAceptarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text !="" && txtMarca.Text != "" && txtLinea.Text != "" && txtModelo.Text != "" && txtColor.Text != "" && txtPuertas.Text != "" && cbxTipoVehiculo.Text != "" && cbxClaseVehiculo.Text != "" && txtPrecio.Text != "")
            {
                Vehiculo oVehiculo = new Vehiculo();
                oVehiculo.Veh_matricula = txtMatricula.Text;
                oVehiculo.Veh_marca = txtMarca.Text;
                oVehiculo.Veh_linea = txtLinea.Text;
                oVehiculo.Veh_modelo = int.Parse(txtModelo.Text);
                oVehiculo.Veh_color = txtColor.Text;
                oVehiculo.Veh_puertas = int.Parse(txtPuertas.Text);
                oVehiculo.Veh_gps = chkGps.Checked;
                oVehiculo.Veh_tipoVehiculo = (int)cbxTipoVehiculo.SelectedValue;
                oVehiculo.Veh_claseVehiculo = (int)cbxClaseVehiculo.SelectedValue;
                oVehiculo.Veh_precio = decimal.Parse(txtPrecio.Text);

                OperacionesVehiculos.AgregarVehiculo(oVehiculo);
                
                var respuesta = MessageBox.Show("Vehiculo agregado exitosamente!\n"
                 + "\n¿Desea agregar otro Vehiculo? "               
                 , "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                txtMatricula.Clear();
                txtMarca.Clear();
                txtLinea.Clear();
                txtModelo.Clear();
                txtColor.Clear();
                txtPuertas.Clear();
                chkGps.Checked=false;
                cbxClaseVehiculo.Text="";
                cbxTipoVehiculo.Text="";
                txtPrecio.Clear();
        }
        private void btnCancelarVehiculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)//cree un evento en propiedades del campo, doble clic keypress 
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) //para q valide y aparezca el cartelito
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPuertas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmAltaVehiculo_Load(object sender, EventArgs e)
        {
            cbxClaseVehiculo.DataSource = OperacionesVehiculos.TraerClasesVehiculo();
            cbxClaseVehiculo.DisplayMember = "DESCRIPCION CLASE DE VEHICULO";
            cbxClaseVehiculo.ValueMember = "Id";

            cbxTipoVehiculo.DataSource = OperacionesVehiculos.TraerTiposVehiculo();
            cbxTipoVehiculo.DisplayMember = "DESCRIPCION DE TIPO DE VEHICULO";
            cbxTipoVehiculo.ValueMember = "Id";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
