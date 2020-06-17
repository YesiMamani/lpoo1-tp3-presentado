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
            string matricula = "";
            switch (cbxVer.SelectedIndex)
            {
                case 0://Clases Vehiculo
                    //Valida si está en uso
                    matricula = OperacionesVehiculos.TraerMatriculaSegunParametro(txtId.Text, "CLASE");
                    if (matricula == "")
                    {
                        var respuesta = MessageBox.Show("¿Desea eliminar la Clase de Vehiculo seleccionada?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta.ToString() == "Yes")
                        {
                            OperacionesVehiculos.EliminarClaseVehiculo(txtId.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La Clase de Vehiculo seleccionada NO se puede eliminar!\n" +
                            "\nSe encuentra en uso en el Vehiculo con Matricula: " + matricula
                            , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                       
                    break;
                case 1://Tipos Vehiculo
                    //Valida si está en uso
                    matricula = OperacionesVehiculos.TraerMatriculaSegunParametro(txtId.Text, "TIPO");
                    if (matricula == "")
                    {
                        var respuesta = MessageBox.Show("¿Desea eliminar Tipo de Vehiculo seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta.ToString() == "Yes")
                        {
                            OperacionesVehiculos.EliminarTipoVehiculo(txtId.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Tipo de Vehiculo seleccionado NO se puede eliminar!\n" +
                            "\nSe encuentra en uso en el Vehiculo con Matricula: " + matricula
                            , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                       
                    break;
                case 2://Formas Pago
                    //Valida si está en uso
                    int nroVenta = OperacionesVentas.TraerNROVentaSegunParametro(txtId.Text, "FORMAPAGO");
                    if (nroVenta == 0)
                    {
                        var respuesta = MessageBox.Show("¿Desea eliminar la Forma de Pago seleccionada?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta.ToString() == "Yes")
                        {                            
                            OperacionesVentas.EliminarFormaPago(txtId.Text);
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("La Forma de Pago seleccionada NO se puede eliminar!\n" +
                            "\nSe encuentra en uso en la Venta NRO: " + nroVenta
                            , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                    
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
                    dgvGestion.AutoResizeColumns();
                    break;
                case 1://Tipos Vehiculo
                    dgvGestion.DataSource = OperacionesVehiculos.TraerTiposVehiculo();
                    dgvGestion.AutoResizeColumns();
                    break;
                case 2://Formas Pago
                    dgvGestion.DataSource = OperacionesVentas.TraerFormasPago();
                    dgvGestion.AutoResizeColumns();
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

        private void cbxVer_SelectedIndexChanged(object sender, EventArgs e)  //carga la grila segun la opcion
        {
            CargarGrillaSegunOpcion(cbxVer.SelectedIndex);
        }

        private void dgvGestion_CurrentCellChanged(object sender, EventArgs e)   //carga descripcion segun fila seleccionada
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
