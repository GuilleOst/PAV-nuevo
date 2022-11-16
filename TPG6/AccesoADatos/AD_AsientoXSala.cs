using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TPG6.Entidades;

namespace TPG6.AccesoADatos
{
    public class AD_AsientoXSala
    {
        public static List<string> GetAsientos(System.DateTime fechaHora, int sala) 
        {
            List <string> listaAsientos = new List<string> ();
            string cadenaConexion = ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "GetAsientosOcupadosFuncion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaHora", fechaHora);
                cmd.Parameters.AddWithValue("@sala", sala);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                string fila;
                string letra;
                string ocupado;
                while (dr.Read())
                {
                    fila = dr["numeroFila"].ToString();
                    letra = dr["letraColumna"].ToString();
                    ocupado = letra + fila;
                    listaAsientos.Add(ocupado);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        return listaAsientos;
        }
    }
}
