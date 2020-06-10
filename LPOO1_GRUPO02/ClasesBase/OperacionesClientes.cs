using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class OperacionesClientes
    {

        public static DataTable TraerClientes()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,CLI_Apellido +', '+ CLI_nombre AS 'ApeyNom' FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);

            return dt;
        }

        public static DataTable TraerClientes(string txtFiltro)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente " +
                                "WHERE CLI_Nombre LIKE @Filtro OR CLI_Apellido LIKE @Filtro";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Filtro", "%" + txtFiltro + "%");
            // cmd.Parameters.AddWithValue("@FiltroApellido", "%" + txtFiltroApellido + "%");

            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);

            //DEVOLVER LA TABLA
            return dt;
        }

        public static void EliminarCliente(string dni)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente " +
                                "WHERE CLI_DNI =@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@dni", dni);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarCliente(Cliente oCliente)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - UPDATE
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente " +
                                "set " +
                                "CLI_Nombre=@nombre, CLI_Apellido=@apellido, CLI_Direccion=@direccion, CLI_Telefono=@telefono " +
                                "WHERE CLI_DNI=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_dni);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_apellido);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_direccion);
            cmd.Parameters.AddWithValue("@telefono", oCliente.Cli_telefono);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void AgregarCliente(Cliente oCliente)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - INSERT
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente (CLI_DNI, CLI_Nombre, CLI_Apellido, CLI_Direccion, CLI_Telefono)" +
                                " VALUES " +
                                "(@dni, @nombre, @apellido, @direccion,@telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_dni);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_apellido);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_direccion);
            cmd.Parameters.AddWithValue("@telefono", oCliente.Cli_telefono);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable TraerClientesCombo()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CLI_DNI,CLI_DNI+' - '+CLI_Apellido+', '+CLI_Nombre As CLI_ayn FROM Cliente";
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

        public static DataTable TraerClientesOrdenadosPorApellidos()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerClientesOrdenadosPorApellido";
            cmd.CommandType = CommandType.StoredProcedure;
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
    }
}
