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
                "VEH_Matricula+' - '+VEH_Marca+' - '+VEH_Linea+' - '+VEH_Color AS VEH_Info,CAST(VEH_Precio AS VARCHAR) AS VEH_Precio FROM Vehiculo "+
                "WHERE VEH_Matricula NOT IN (SELECT VEH_Matricula FROM Venta WHERE VTA_Estado='ACTIVA')";//Solo muestra vehiculos que no esten vendidos (Si la venta se anula, se libera el vehiculo)
                //matricula de combo no este en (lista d matriculas de vehiculos vendidos)
            
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

        public static DataTable TraerClasesVehiculo()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CV_ID AS ID, CV_Descripcion AS 'DESCRIPCION CLASE DE VEHICULO'  FROM ClaseVehiculo";
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

        public static DataTable TraerTiposVehiculo()
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT TV_ID AS ID, TV_Descripcion AS 'DESCRIPCION DE TIPO DE VEHICULO'  FROM TipoVehiculo";
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

        public static void AgregarClaseVehiculo(string descripcion)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - INSERT
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO ClaseVehiculo (CV_Descripcion)" +
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

        public static void AgregarTipoVehiculo(string descripcion)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - INSERT
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO TipoVehiculo (TV_Descripcion)" +
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

        public static void EliminarClaseVehiculo(string id)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM ClaseVehiculo " +
                                "WHERE CV_ID =@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@id", id);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarTipoVehiculo(string id)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM TipoVehiculo " +
                                "WHERE TV_ID =@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@id", id);

            //ABRIMOS LA CONEXION EJECUTAMOS LA QUERY Y CERRAMOS LA CONEXION
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarClaseVehiculo(string id, string descripcion)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - UPDATE
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE ClaseVehiculo " +
                                "set CV_Descripcion=@descripcion " +
                                "WHERE CV_ID=@id";
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

        public static void ModificarTipoVehiculo(string id, string descripcion)
        {
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA - UPDATE
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE TipoVehiculo " +
                                "set TV_Descripcion=@descripcion " +
                                "WHERE TV_ID=@id";
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

        public static string TraerMatriculaSegunParametro(string parametro, string campoDondeBuscar)
        {
            string matricula = "";
            string campoDB = "";
            switch (campoDondeBuscar)
            {
                case "CLASE":
                    campoDB = "CV_ID";
                    break;
                case "TIPO":
                    campoDB = "TV_ID";
                    break;
                case "MATRICULA":
                    campoDB = "VEH_Matricula";
                    break; 
            }
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA MAtricula segun campoDB
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select VEH_Matricula as Matricula FROM Vehiculo WHERE " + campoDB + " = @parametro";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@parametro", parametro);     //configuramos el parametro q enviamos

            //CREACION DE LA TABLA
            DataTable dtVehiculos = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLAS
            da.Fill(dtVehiculos);

            matricula = dtVehiculos.Rows.Count > 0 ? dtVehiculos.Rows[0][0].ToString() : "";

            //DEVUELVO matricula
            return matricula;
        }

        public static int TraerIDsegunParametro(string parametro, string opcion)
        {
            int idExistente = 0;
            string query = "";
            switch (opcion)
            {
                case "CLASE":
                    query = "SELECT CV_ID AS ID FROM ClaseVehiculo WHERE CV_Descripcion=@parametro";
                    break;
                case "TIPO":
                    query = "SELECT TV_ID AS ID FROM TipoVehiculo WHERE TV_Descripcion=@parametro";
                    break;                 
            }
            //CONEXION
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.Cadena);

            //CONFIGURACION DE LA CONSULTA MAtricula segun campoDB
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            //CONFIG PARAMETROS
            cmd.Parameters.AddWithValue("@parametro", parametro);     //configuramos el parametro q enviamos

            //CREACION DE LA TABLA
            DataTable dtVehiculos = new DataTable();

            //CREACION DEL ADAPTADOR
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //LLENAR LA TABLAS
            da.Fill(dtVehiculos);

            idExistente = dtVehiculos.Rows.Count > 0 ? int.Parse(dtVehiculos.Rows[0][0].ToString()) : 0;

            //DEVUELVO matricula
            return idExistente;
        }
    }
}
