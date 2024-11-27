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
    public class VacAdministracionCL
    {
        public int Id { get; set; }
        public int? IDAdmin { get; set; }
        public string? Inicio { get; set; }
        public string? Final { get; set; }
        public int? IDOpcionesVac { get; set; }

        public DataTable ListarAdministracion()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarAdministracion";
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
                sql = " Insert into VACADMIN (IDADMIN, INICIO, FINAL, IDOPCIONESVAC) Values(@IDADMIN, @INICIO, @FINAL, @IDOPCIONESVAC) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDADMIN", IDAdmin);
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

                sql = " Select IDVACADMIN, NOMBRE , INICIO, FINAL, OPCIONES from VACADMIN " +
                    "inner join VACOPCIONES ON VACADMIN.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                    "inner join ADMINISTRADORES ON VACADMIN.IDADMIN = ADMINISTRADORES.IDADMIN";
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
                sql = " Select IDVACADMIN, NOMBRE , INICIO, FINAL, OPCIONES from VACADMIN " +
                    "inner join VACOPCIONES ON VACADMIN.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                    "inner join ADMINISTRADORES ON VACADMIN.IDADMIN = ADMINISTRADORES.IDADMIN " +
                    "where IDVACADMIN=@IDVACADMIN"
                ;
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("IDVACADMIN", Id);
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
                sql = " Update VACADMIN set IDADMIN=@IDADMIN, INICIO=@INICIO, FINAL=@FINAL, IDOPCIONESVAC=@IDOPCIONESVAC Where IDVACADMIN=@IDVACADMIN";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACADMIN", Id);
                cmd.Parameters.AddWithValue("@IDADMIN", IDAdmin);
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
                sql = " Delete from VACADMIN Where IDVACADMIN=@IDVACADMIN ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACADMIN", Id);
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
                sql = " Select IDVACADMIN, NOMBRE , INICIO, FINAL from VACADMIN " +
                    "inner join ADMINISTRADORES ON VACADMIN.IDADMIN = ADMINISTRADORES.IDADMIN " +
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
                sql = " Select IDVACADMIN, NOMBRE , INICIO, FINAL from VACADMIN " +
                    "inner join ADMINISTRADORES ON VACADMIN.IDADMIN = ADMINISTRADORES.IDADMIN " +
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
