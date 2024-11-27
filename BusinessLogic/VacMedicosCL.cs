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
    public class VacMedicosCL
    {
        public int Id { get; set; }
        public int? IDMedico{ get; set; }
        public string? Inicio { get; set; }
        public string? Final { get; set; }
        public int? IDOpcionesVac { get; set; }

        public DataTable ListarEstado()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarMedicos";
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
                sql = " Insert into VACMEDICOS (IDMEDICO, INICIO, FINAL, IDOPCIONESVAC) Values(@IDMEDICO, @INICIO, @FINAL, @IDOPCIONESVAC) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDMEDICO", IDMedico);
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

                sql = " Select IDVACMEDICOS, NOMBRE , INICIO, FINAL, OPCIONES from VACMEDICOS " +
                    "inner join VACOPCIONES ON VACMEDICOS.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                    "inner join Medicos ON VACMEDICOS.IDMEDICO = Medicos.IDMEDICO";
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
                sql = " Select IDVACMEDICOS, NOMBRE , INICIO, FINAL, OPCIONES from VACMEDICOS " +
                "inner join VACOPCIONES ON VACMEDICOS.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                "inner join Medicos ON VACMEDICOS.IDMEDICO = Medicos.IDMEDICO " +
                "where IDVACMEDICOS=@IDVACMEDICOS"
                ;
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("IDVACMEDICOS", Id);
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
                sql = " Update VACMEDICOS set IDMEDICO=@IDMEDICO, INICIO=@INICIO, FINAL=@FINAL, IDOPCIONESVAC=@IDOPCIONESVAC Where IDMEDICO=@IDMEDICO";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACMEDICOS", Id);
                cmd.Parameters.AddWithValue("@IDMedico", IDMedico);
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
                sql = " Delete from VACMEDICOS Where IDVACMEDICOS=@IDVACMEDICOS ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACMEDICOS", Id);
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
                sql = " Select IDVACMEDICOS, NOMBRE , INICIO, FINAL from VACMEDICOS " +
                "inner join Medicos ON VACMEDICOS.IDMEDICO= Medicos.IDMEDICO " +
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
                sql = " Select IDVACMEDICOS, NOMBRE , INICIO, FINAL from VACMEDICOS " +
                "inner join Medicos ON VACMEDICOS.IDMEDICO= Medicos.IDMEDICO " +
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
