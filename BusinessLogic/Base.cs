

using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class Base
    {

        public int Id { get; set; }
        public string? BaseMantenimiento { get; set; }
        public string? Ubicacion { get; set; }


        public bool Add()
        {
            try
            {
                string sql;
                sql = " Insert into BaseMantenimiento (BASE,UBICACION) Values(@BASE,@UBICACION) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@BASE", BaseMantenimiento);
                cmd.Parameters.AddWithValue("@UBICACION", Ubicacion);

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
                sql = " Select IDBASE,BASE,UBICACION from BaseMantenimiento ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);

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
                sql = " Select IDBASE,BASE,UBICACION from BaseMantenimiento Where IDBASE=@IDBASE";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDBASE", Id);
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
                sql = " Update BaseMantenimiento set BASE=@BASE,UBICACION=@UBICACION Where IDBASE=@IDBASE";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@BASE", BaseMantenimiento);
                cmd.Parameters.AddWithValue("@UBICACION", Ubicacion);


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
                sql = " Delete from BaseMantenimiento Where IDBASE=@IDBASE ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDBASE", Id);
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
