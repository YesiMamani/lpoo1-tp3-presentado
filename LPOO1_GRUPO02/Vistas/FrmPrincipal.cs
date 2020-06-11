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
    public partial class FrmPrincipal : Form
    {
        Usuario myUser = new Usuario();
        public FrmPrincipal(Usuario myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
            RestringirAccesoSegunRol(myUser.Rol_codigo);
       
        }

        private void RestringirAccesoSegunRol(string codRol)
        {
            if (codRol == "ADM")
            {
                clientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem.Enabled = false;
            }
            else if (codRol == "VND")
            {
                usuarioToolStripMenuItem.Enabled = false;
                vehiculosToolStripMenuItem.Enabled = false;
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes oFrmClientes = new FrmClientes();
            oFrmClientes.Show();
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea salir del sistema?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                Application.Exit(); //sale del sist     
            }
            
            
           
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmAltaVehiculo oFrmAltaVehiculi = new FrmAltaVehiculo();
            //oFrmAltaVehiculi.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios oFrmUsuarios = new FrmUsuarios();
            oFrmUsuarios.Show();
        }

        private void registroVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas oFrmVentas = new FrmVentas(myUser);
            oFrmVentas.Show();
        }

        private void listadoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoVentas oListadoVentas = new FrmListadoVentas();
            oListadoVentas.Show();
        }

        private void listadoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoVehiculos oFrmListadoVehiculos = new FrmListadoVehiculos();
            oFrmListadoVehiculos.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Vistas.Properties.Resources.virtus_web;
        }

        private void clientesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Vistas.Properties.Resources.vento;
        }

        private void vehiculosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Vistas.Properties.Resources.passat;
        }

        private void ventasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Vistas.Properties.Resources.poloweb;
        }

        private void usuarioToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.BackgroundImage = Vistas.Properties.Resources.prueba;
        }

        private void gestionDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculos oFrmVehiculos = new FrmVehiculos();
            oFrmVehiculos.ShowDialog();
        }

        private void gestionClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestion oFrmGestion = new FrmGestion();
            oFrmGestion.ShowDialog();
        }

       
       
    }
}
