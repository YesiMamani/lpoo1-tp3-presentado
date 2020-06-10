﻿using System;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var respuesta = MessageBox.Show("¿Desea eliminar el usuario selecionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            Usuario oUsuario = new Usuario();
            //CAPTURO LOS DATOS DEL FORMULARIO
            oUsuario.Usu_nombreUsuario = txtUsuario.Text;
            oUsuario.Usu_contraseña = txtContrasenia.Text;
            oUsuario.Usu_apellidoNombre = txtApellidoNombre.Text;
            oUsuario.Rol_codigo = (string)cbxRol.SelectedValue;

            var respuesta = MessageBox.Show("¿Desea guardar los datos ingresados?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")

            OperacionesUsuarios.AgregarUsuario(oUsuario);

            CargarGrilla();
        }
    }
}
