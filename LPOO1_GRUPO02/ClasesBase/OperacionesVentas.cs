﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class OperacionesVentas
    {
        public static DataTable TraerVentas()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM VistaVentas";
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

        public static void AgregarVenta(Venta oVenta)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - INSERT
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta (CLI_DNI, VEH_Matricula, USU_ID, VTA_Fecha, FP_ID, VTA_PrecioFinal, VTA_Estado)" +
                                " VALUES " +
                                "(@dni, @matricula, @id, @fecha, @formapago, @preciofinal, @estado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@dni", oVenta.Clie_dni);
            cmd.Parameters.AddWithValue("@matricula", oVenta.Veh_matricula);
            cmd.Parameters.AddWithValue("@id", oVenta.Usu_id);
            cmd.Parameters.AddWithValue("@fecha", oVenta.Vta_fecha);
            cmd.Parameters.AddWithValue("@formapago", oVenta.Vta_formaPago);
            cmd.Parameters.AddWithValue("@preciofinal", oVenta.Vta_precioFinal);
            cmd.Parameters.AddWithValue("@estado", oVenta.Vta_estado);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable TraerVentasPorCliente(string cliDni, out InfoVenta infoVenta)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA Ventas por CLIENTE
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM VistaVentas WHERE [DNI CLIENTE] = @clidni";   //filtro la vista por dni cliente
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@clidni", cliDni);     //cofiguramos el parametro q enviamos

            //CONFIGURACION DE LA CONSULTA Ventas por CLIENTE - Anuladas
            SqlCommand cmdA = new SqlCommand();
            cmdA.CommandText = "SELECT * FROM VistaVentas WHERE [DNI CLIENTE] = @clidni AND ESTADO='ANULADA'";   
            cmdA.CommandType = CommandType.Text;
            cmdA.Connection = cnn;
            //CONFIG PARAMETROS
            cmdA.Parameters.AddWithValue("@clidni", cliDni);     

            //CONFIGURACION DE LA CONSULTA Ventas por cliente - Importe Total de Ventas Activas
            SqlCommand cmdIT = new SqlCommand();
            cmdIT.CommandText = "SELECT ISNULL(SUM(PRECIO),0) AS 'ImporteTotal' FROM VistaVentas WHERE [DNI CLIENTE] = @clidni AND ESTADO='ACTIVA'";
            cmdIT.CommandType = CommandType.Text;
            cmdIT.Connection = cnn;
            //CONFIG PARAMETROS
            cmdIT.Parameters.AddWithValue("@clidni", cliDni);     

            //CREACION DE LA TABLA
            DataTable dtVentas = new DataTable();
            DataTable dtAnuladas = new DataTable();
            DataTable dtImporteTotal = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter daAnuladas = new SqlDataAdapter(cmdA);
            SqlDataAdapter daImporteTotal = new SqlDataAdapter(cmdIT);

            //LLENAR LA TABLAS
            da.Fill(dtVentas);
            daAnuladas.Fill(dtAnuladas);
            daImporteTotal.Fill(dtImporteTotal);
            //ASIGNO VARIABLES
            infoVenta = new InfoVenta();
            infoVenta.CantidadVentas = dtVentas.Rows.Count;
            infoVenta.CantidadVentasAnuladas = dtAnuladas.Rows.Count;
            infoVenta.ImporteTotalVentas = dtImporteTotal.Rows.Count > 0 ? int.Parse(dtImporteTotal.Rows[0][0].ToString()) : 0;

            //DEVOLVER LA TABLA
            return dtVentas;
        }

        public static DataTable TraerVentasPorMarca(string marca)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM VistaVentas WHERE MARCA = @marca" +" SELECT * FROM VistaVentas";     //filtramos por marca
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@marca", marca);

            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);

            //DEVOLVER LA TABLA
            return dt;
        }

        public static DataTable TraerVentasPorFecha(DateTime inicio, DateTime fin)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM VistaVentas WHERE [FECHA DE VENTA] between @inicio AND @fin";     //between: filtrar entre la fecha inicio y fecha fin
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@inicio", inicio);
            cmd.Parameters.AddWithValue("@fin", fin);

            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);
            //DEVOLVER LA TABLA
            return dt;
        }

        public static DataTable TraerFormasPago()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT FP_ID AS Id, FP_Descripcion AS Descripcion  FROM FormaPago";
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

        public static void AgregarFormaPago(string descripcion)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - INSERT
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO FormaPago (FP_Descripcion)" +
                                " VALUES (@descripcion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@descripcion", descripcion);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarFormaPago(string id)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM FormaPago " +
                                "WHERE FP_ID =@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@id", id);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarFormaPago(string id, string descripcion)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - UPDATE
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE FormaPago " +
                                "set FP_Descripcion=@descripcion " +
                                "WHERE FP_ID=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void AnularVenta(int idVenta)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Venta " +
                                "set VTA_Estado='ANULADA' " +
                                "WHERE VTA_ID=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@id", idVenta);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
