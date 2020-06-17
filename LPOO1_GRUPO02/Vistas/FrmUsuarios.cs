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
    public partial class FrmUsuarios : Form
    {
        int idUsuarioExistente = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            cbxRol.DataSource = OperacionesUsuarios.TraerRoles();
            cbxRol.DisplayMember = "ROL_Descripcion";
            cbxRol.ValueMember = "ROL_Codigo";

            dgvUsuarios.DataSource = OperacionesUsuarios.TraerUsuarios();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = OperacionesUsuarios.TraerUsuarios(txtFiltrar.Text);
        }

        private void dgvUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                //Para que al seleccionar cada fila, se cargue automaticamente en el formulario
                lblAgregar.Text = "Se encuentra seleccionado el Usuario ID: "+dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                lblAgregar.Visible = true;
                txtID.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtContrasenia.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtApellidoNombre.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                cbxRol.SelectedValue = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnAddUser.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtUsuario.Text != "" && txtContrasenia.Text != "" && txtApellidoNombre.Text != "" && cbxRol.Text != "")
            {
                if (idUsuarioExistente == 0)
                {
                    Usuario oUsuario = new Usuario();

                    //CAPTURO LOS DATOS DEL FORMULARIO
                    oUsuario.Usu_id = int.Parse(txtID.Text);
                    oUsuario.Usu_nombreUsuario = txtUsuario.Text;
                    oUsuario.Usu_contraseña = txtContrasenia.Text;
                    oUsuario.Usu_apellidoNombre = txtApellidoNombre.Text;
                    oUsuario.Rol_codigo = (string)cbxRol.SelectedValue;

                    OperacionesUsuarios.ModificarUsuario(oUsuario);

                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ingresado se encuentra en uso en el UserID: " + idUsuarioExistente.ToString() + "\n\nPor favor ingrese otro diferente.");
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos");
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var respuesta = MessageBox.Show("¿Desea ELIMINAR el usuario seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta.ToString() == "Yes")
                {
                    int id = int.Parse(txtID.Text);
                    OperacionesUsuarios.EliminarUsuario(id);
                    CargarGrilla();

                }
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Habilito el boton Agregar
            btnAgregar.Enabled = true;
            lblAgregar.Text = "Ingrese los datos del nuevo usuario:";
            lblAgregar.Visible = true;
            //Limpio los controles
            txtID.Clear();
            txtUsuario.Clear();
            txtContrasenia.Clear();
            txtApellidoNombre.Clear();
            cbxRol.SelectedValue = -1;
            //Deshabilito los botones eliminar y modificar
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            //Deshabilito el boton AddUser
            btnAddUser.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContrasenia.Text != "" && txtApellidoNombre.Text != "" && cbxRol.Text != "")
            {
                if (idUsuarioExistente==0)
                {
                    Usuario oUsuario = new Usuario();
                    //CAPTURO LOS DATOS DEL FORMULARIO
                    oUsuario.Usu_nombreUsuario = txtUsuario.Text;
                    oUsuario.Usu_contraseña = txtContrasenia.Text;
                    oUsuario.Usu_apellidoNombre = txtApellidoNombre.Text;
                    oUsuario.Rol_codigo = (string)cbxRol.SelectedValue;

                    OperacionesUsuarios.AgregarUsuario(oUsuario);
                    lblAgregar.Visible = false;

                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ingresado se encuentra en uso en el UserID: " + idUsuarioExistente.ToString() + "\n\nPor favor ingrese otro diferente.");
                    txtUsuario.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos");
            } 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            idUsuarioExistente = OperacionesUsuarios.TraerIdUsuarioSegunNombreUsuario(txtUsuario.Text);
            if (idUsuarioExistente!=0)
            {
                MessageBox.Show("El nombre de usuario ingresado se encuentra en uso en el UserID: "+idUsuarioExistente.ToString()+"\n\nPor favor ingrese otro diferente.");
            }
        }
    }
}
