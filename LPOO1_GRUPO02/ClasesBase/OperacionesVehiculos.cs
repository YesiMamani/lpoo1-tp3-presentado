using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class OperacionesVehiculos
    {
        public static DataTable TraerVehiculosCombo()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT VEH_Matricula," +
                "VEH_Matricula+' - '+VEH_Marca+' - '+VEH_Linea+' - '+VEH_Color AS VEH_Info,CAST(VEH_Precio AS VARCHAR) AS VEH_Precio FROM Vehiculo";
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

        public static DataTable TraerVehiculosMarcaOrden(string opcion)

        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TraerVehiculosPorMarcaOrden";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@MarcaLinea", opcion);
            //CREACION DE LA TABLA
            DataTable dt = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLA
            da.Fill(dt);

            //DEVOLVER LA TABLA
            return dt;
        }

        public static void AgregarVehiculo(Vehiculo oVehiculo)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AgregarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Matricula", oVehiculo.Veh_matricula);
            cmd.Parameters.AddWithValue("@Marca", oVehiculo.Veh_marca);
            cmd.Parameters.AddWithValue("@Linea", oVehiculo.Veh_linea);
            cmd.Parameters.AddWithValue("@Modelo", oVehiculo.Veh_modelo);
            cmd.Parameters.AddWithValue("@Color", oVehiculo.Veh_color);
            cmd.Parameters.AddWithValue("@Puertas", oVehiculo.Veh_puertas);
            cmd.Parameters.AddWithValue("@GPS", oVehiculo.Veh_gps);
            cmd.Parameters.AddWithValue("@TipoVehiculo", oVehiculo.Veh_tipoVehiculo);
            cmd.Parameters.AddWithValue("@ClaseVehiculo", oVehiculo.Veh_claseVehiculo);
            cmd.Parameters.AddWithValue("@Precio", oVehiculo.Veh_precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarVehiculo(string matricula)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EliminarVehiculoPorMatricula";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Matricula",matricula);
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarVehiculo(Vehiculo oVehiculo)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ModificarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Matricula", oVehiculo.Veh_matricula);
            cmd.Parameters.AddWithValue("@Marca", oVehiculo.Veh_marca);
            cmd.Parameters.AddWithValue("@Linea", oVehiculo.Veh_linea);
            cmd.Parameters.AddWithValue("@Modelo", oVehiculo.Veh_modelo);
            cmd.Parameters.AddWithValue("@Color", oVehiculo.Veh_color);
            cmd.Parameters.AddWithValue("@Puertas", oVehiculo.Veh_puertas);
            cmd.Parameters.AddWithValue("@GPS", oVehiculo.Veh_gps);
            cmd.Parameters.AddWithValue("@TipoVehiculo", oVehiculo.Veh_tipoVehiculo);
            cmd.Parameters.AddWithValue("@ClaseVehiculo", oVehiculo.Veh_claseVehiculo);
            cmd.Parameters.AddWithValue("@Precio", oVehiculo.Veh_precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable TraerMarcas()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT DISTINCT VEH_Marca AS Marca FROM Vehiculo";  // distinct: solo trae las marcas distintas
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
    }
}
