using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? HorasVuelo {  get; set; } 

        public bool Add()
        {
            try
            {
                string sql;
                sql = " Insert into piloto (CODIGO,NOMBRE,HORASVUELO) Values(@CODIGO,@NOMBRE,@HORASVUELO) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@CODIGO", Codigo);
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@HORASVUELO", HorasVuelo);
                dbAcess.Ejecutar(cmd);

                return true;    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Get()
        {
            try
            {
                string sql;
                sql = " Select IDPILOTO,CODIGO,NOMBRE,HORASVUELO from piloto ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                dt =dbAcess.Consultar(cmd);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetById()
        {
            try
            {
                string sql;
                sql = " Select IDPILOTO,CODIGO,NOMBRE,HORASVUELO from piloto Where IDPILOTO=@IDPILOTO";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDPILOTO",Id);
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Edit()
        {
            try
            {
                string sql;
                sql = " Update piloto set CODIGO=@CODIGO,NOMBRE=@NOMBRE,HORASVUELO=@HORASVUELO Where IDPILOTO=@IDPILOTO";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDPILOTO", Id);
                cmd.Parameters.AddWithValue("@CODIGO", Codigo);
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@HORASVUELO", HorasVuelo); 

                dbAcess.Ejecutar(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete()
        {
            try
            {
                string sql;
                sql = " Delete from piloto Where IDPILOTO=@IDPILOTO ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDPILOTO", Id);
                dbAcess.Ejecutar(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
