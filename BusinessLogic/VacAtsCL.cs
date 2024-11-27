using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLogic
{
    public class VacAtsCL
    {

        public int Id { get; set; }
        public int? IDATS {get; set; }
        public string? Inicio { get; set; }
        public string? Final{ get; set; }
        public int? IDOpcionesVac { get; set; }

        public DataTable ListarEstado()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarAts";
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
                sql = " Insert into VACATS (IDATS, INICIO, FINAL, IDOPCIONESVAC) Values(@IDATS, @INICIO, @FINAL, @IDOPCIONESVAC) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDATS", IDATS);
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

                sql = " Select IDVACATS, NOMBRE , INICIO, FINAL, OPCIONES from VACATS " +
                    "inner join VACOPCIONES ON VACATS.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                    "inner join ATS ON VACATS.IDATS = ATS.IDATS";
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
                sql = " Select IDVACATS, NOMBRE , INICIO, FINAL, OPCIONES from VACATS " +
                "inner join VACOPCIONES ON VACATS.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                "inner join ATS ON VACATS.IDATS = ATS.IDATS " +
                "where IDVACATS=@IDVACATS"
                ;
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("IDVACATS", Id);
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
                 sql = " Update VACATS set IDATS=@IDATS, INICIO=@INICIO, FINAL=@FINAL, IDOPCIONESVAC=@IDOPCIONESVAC Where IDVACATS=@IDVACATS";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACATS", Id);
                cmd.Parameters.AddWithValue("@IDATS", IDATS);
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
                sql = " Delete from VACATS Where IDVACATS=@IDVACATS ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACATS", Id);
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
                sql = " Select IDVACATS, NOMBRE , INICIO, FINAL from VACATS " +
                "inner join ATS ON VACATS.IDATS = ATS.IDATS " +
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
                sql = " Select IDVACATS, NOMBRE , INICIO, FINAL from VACATS " +
                "inner join ATS ON VACATS.IDATS = ATS.IDATS " +
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
