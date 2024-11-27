using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class VacATSZonaCL
    {
        public int Id { get; set; }
        public int? IDATSZona { get; set; }
        public string? Inicio { get; set; }
        public string? Final { get; set; }
        public int? IDOpcionesVac { get; set; }

        public DataTable ListarAtsZona()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarAtsZona";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListarOpciones()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarOpcionesVac";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Add()
        {
            try
            {
                string sql;
                sql = " Insert into VACATSZONA (IDATSZONA, INICIO, FINAL, IDOPCIONESVAC) Values(@IDATSZONA, @INICIO, @FINAL, @IDOPCIONESVAC) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDATSZONA", IDATSZona);
                cmd.Parameters.AddWithValue("@INICIO", Inicio);
                cmd.Parameters.AddWithValue("@FINAL", Final);
                cmd.Parameters.AddWithValue("@IDOPCIONESVAC", IDOpcionesVac);

                ;
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

                sql = " Select IDVACATSZONA, NOMBRE , INICIO, FINAL, OPCIONES from VACATSZONA " +
                    "inner join VACOPCIONES ON VACATSZONA.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                    "inner join ATSZONA ON VACATSZONA.IDATSZONA = ATSZONA.IDATSZONA";
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
                sql = " Select IDVACATSZONA, NOMBRE , INICIO, FINAL, OPCIONES from VACATSZONA " +
                    "inner join VACOPCIONES ON VACATSZONA.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                    "inner join ATSZONA ON VACATSZONA.IDATSZONA = ATSZONA.IDATSZONA" +
                    "where IDVACATSZONA=@IDVACATSZONA";
                ;
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("IDVACATSZONA", Id);
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
                sql = " Update VACATSZONA set IDATSZONA=@IDATSZONA, INICIO=@INICIO, FINAL=@FINAL, IDOPCIONESVAC=@IDOPCIONESVAC Where IDVACATSZONA=@IDVACATSZONA";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACATSZONA", Id);
                cmd.Parameters.AddWithValue("@IDATSZONA", IDATSZona);
                cmd.Parameters.AddWithValue("@INICIO", Inicio);
                cmd.Parameters.AddWithValue("@FINAL", Final);
                cmd.Parameters.AddWithValue("@IDOPCIONESVAC", IDOpcionesVac);

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
                sql = " Delete from VACATSZONA Where IDVACATSZONA=@IDVACATSZONA ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACATSZONA", Id);
                dbAcess.Ejecutar(cmd);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetByDisfrutar()
        {
            try
            {
                string sql;
                sql = " Select IDVACATSZONA, NOMBRE , INICIO, FINAL from VACATSZONA " +
                "inner join ATSZONA ON VACATSZONA.IDATSZONA = ATSZONA.IDATSZONA " +
                "where IDOPCIONESVAC=@IDOPCIONESVAC";

                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDOPCIONESVAC", IDOpcionesVac);
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);


                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetByPlanificadas()
        {
            try
            {
                string sql;
                sql = " Select IDVACATSZONA, NOMBRE , INICIO, FINAL from VACATSZONA " +
                "inner join ATSZONA ON VACATSZONA.IDATSZONA = ATSZONA.IDATSZONA " +
                "where IDOPCIONESVAC=@IDOPCIONESVAC";

                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDOPCIONESVAC", IDOpcionesVac);
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);


                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
