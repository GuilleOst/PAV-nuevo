using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using TPG6.Entidades;

namespace TPG6.AccesoADatos
{
    public class AD_Rol
    {
        public static DataTable ObtenerTablaRol()
        {
            string cadenaConexion = ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetNombreRoles";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
