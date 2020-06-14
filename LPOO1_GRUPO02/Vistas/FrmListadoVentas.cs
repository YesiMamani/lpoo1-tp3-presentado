using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Globalization;

namespace Vistas
{
    public partial class FrmListadoVentas : Form
    {
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            CargarGrillaVentas();
        }

        private void CargarGrillaVentas()
        {   //carco combo cliente
            cbxListadoCliente.DataSource = OperacionesClientes.TraerClientes();
            cbxListadoCliente.DisplayMember = "ApeyNom";
            cbxListadoCliente.ValueMember = "DNI";
            cbxListadoCliente.Text = "Seleccione...";

            //cargo combo marcas
            cbxListadoMarca.DataSource = OperacionesVehiculos.TraerMarcas();
            cbxListadoMarca.DisplayMember = "Marca";
            cbxListadoMarca.ValueMember = "Marca";
            cbxListadoMarca.Text = "Seleccione...";

          
            dgvVentasRealizadas.DataSource = OperacionesVentas.TraerVentas();
            dgvVentasRealizadas.Columns["FECHA DE VENTA"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cantVentas.Text = "-";
            cantVentasAnuladas.Text = "-";
            importeTotal.Text = "-";
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            CargarGrillaVentas();
        }

        private void cbxListadoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoVenta infoVenta=new InfoVenta();  //pto 6
            dgvVentasRealizadas.DataSource = OperacionesVentas.TraerVentasPorCliente(cbxListadoCliente.SelectedValue.ToString(),out infoVenta); //
            cantVentas.Text = infoVenta.CantidadVentas.ToString();  //asigno valores
            cantVentasAnuladas.Text = infoVenta.CantidadVentasAnuladas.ToString();
            importeTotal.Text = infoVenta.ImporteTotalVentas.ToString();
            dgvVentasRealizadas.Columns["FECHA DE VENTA"].DefaultCellStyle.Format = "dd/MM/yyyy";        //formateando fecha
            cbxListadoMarca.Text = "Seleccione...";   //volvemos al estado inicial de marcas
            
        }

        private void cbxListadoMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvVentasRealizadas.DataSource = OperacionesVentas.TraerVentasPorMarca(cbxListadoMarca.SelectedValue.ToString());
            dgvVentasRealizadas.Columns["FECHA DE VENTA"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cbxListadoCliente.Text = "Seleccione...";
           
        }

        private void btnListarFecha_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpFechaInicio.Value.Date;
            DateTime fin = dtpFechaFin.Value.Date;
            dgvVentasRealizadas.DataSource = OperacionesVentas.TraerVentasPorFecha(inicio, fin);
            
            dgvVentasRealizadas.Columns["FECHA DE VENTA"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cbxListadoCliente.Text = "Seleccione...";
            cbxListadoMarca.Text = "Seleccione...";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnularVentaSeleccionada_Click(object sender, EventArgs e)
        {
            if (dgvVentasRealizadas.CurrentRow != null)
            {
                var respuesta = MessageBox.Show("¿Desea ANULAR la venta selecionada?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta.ToString() == "Yes")
                {
                    int idVenta=(int)dgvVentasRealizadas.CurrentRow.Cells[0].Value;//VTA_ID
                    OperacionesVentas.AnularVenta(idVenta);
                    CargarGrillaVentas();
                }
            }
        }
    }
}