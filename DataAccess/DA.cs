using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DA
    {
        string cadena =string.Empty;
        private SqlConnection conn;

        public DA()
        {
            cadena = ConfigurationManager.ConnectionStrings["CadenaDB"].ConnectionString;
            conn = new SqlConnection(cadena);
        }

        public DataTable Consultar(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void Ejecutar(SqlCommand cmd)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public string Probar()
        //{
        //    return cadena;
        //}

    }
}
