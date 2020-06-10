﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class OperacionesUsuarios
    {
        /// <summary>
        /// este metodo me trae todos usuarios
        /// </summary>
        /// <returns></returns>
        public static DataTable TraerUsuarios() //static para q podamos usar el metodo TraerUsuario sin necesidad de instanciar la clase OeracionesUsuarios
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);

            //DEVOLVER LA TABLA
            return dt;
        }



        public static DataTable TraerUsuarios(string traer)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE USU_NombreUsuario LIKE @textoFiltro";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@textoFiltro", "%" + traer + "%");
            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);

            //DEVOLVER LA TABLA
            return dt;
        }

        public static void ModificarUsuario(Usuario oUsuario)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - UPDATE
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario " +
                                "set " +
                                "usu_nombreusuario=@usuario, usu_contraseña=@contra, usu_apellidonombre=@apeynom, rol_codigo=@rolcod " +
                                "WHERE usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@id", oUsuario.Usu_id);
            cmd.Parameters.AddWithValue("@usuario", oUsuario.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@contra", oUsuario.Usu_contraseña);
            cmd.Parameters.AddWithValue("@apeynom", oUsuario.Usu_apellidoNombre);
            cmd.Parameters.AddWithValue("@rolcod", oUsuario.Rol_codigo);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable TraerRoles()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);

            //DEVOLVER LA TABLA
            return dt;
        }

        public static void EliminarUsuario(int id)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario " +
                                "WHERE USU_id =@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@id", id);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void AgregarUsuario(Usuario oUsuario)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - INSERT
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario (usu_nombreusuario, usu_contraseña, usu_apellidonombre, rol_codigo)" +
                                " VALUES " +
                                "(@usuario, @contra, @apeynom, @codrol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@usuario", oUsuario.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@contra", oUsuario.Usu_contraseña);
            cmd.Parameters.AddWithValue("@apeynom", oUsuario.Usu_apellidoNombre);
            cmd.Parameters.AddWithValue("@codrol", oUsuario.Rol_codigo);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Usuario TraerUsuario(string usuario, string contraseña)
        {

            Usuario oUser = new Usuario();
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario " +
                                "WHERE USU_nombreusuario = @usuario AND USU_contraseña=@contraseña";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                oUser.Usu_id = dr.GetInt32(0);
                oUser.Usu_apellidoNombre = dr.GetString(3);
                oUser.Rol_codigo = dr.GetString(4);
            }
            else
            {
                oUser = null;
            }

            dr.Close();
            cnn.Close();

            return oUser;
        }
    }
}
    