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
    public class VacAuxiliarCL
    {
        public int Id { get; set; }
        public int? IDAuxiliar { get; set; }
        public string? Inicio { get; set; }
        public string? Final { get; set; }
        public int? IDOpcionesVac { get; set; }

        public DataTable ListarAuxiliares()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarAuxiliar";
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
                sql = " Insert into VACAUXILIAR (IDAUXILIAR, INICIO, FINAL, IDOPCIONESVAC) Values(@IDAUXILIAR, @INICIO, @FINAL, @IDOPCIONESVAC) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDAUXILIAR", IDAuxiliar);
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

                sql = " Select IDVACAUXILIAR, NOMBRE , INICIO, FINAL, OPCIONES from VACAUXILIAR " +
                    "inner join VACOPCIONES ON VACAUXILIAR.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                    "inner join AUXILIAR ON VACAUXILIAR.IDAUXILIAR = AUXILIAR.IDAUXILIAR";
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
                sql = " Select IDVACAUXILIAR, NOMBRE , INICIO, FINAL, OPCIONES from VACAUXILIAR " +
                "inner join VACOPCIONES ON VACAUXILIAR.IDOPCIONESVAC = VACOPCIONES.IDOPCIONESVAC " +
                "inner join AUXILIAR ON VACAUXILIAR.IDAUXILIAR = AUXILIAR.IDAUXILIAR " +
                "where IDVACAUXILIAR=@IDVACAUXILIAR"
                ;
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("IDVACAUXILIAR", Id);
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
                sql = " Update VACAUXILIAR set IDAUXILIAR=@IDAUXILIAR, INICIO=@INICIO, FINAL=@FINAL, IDOPCIONESVAC=@IDOPCIONESVAC Where IDAUXILIAR=@IDAUXILIAR";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACAUXILIAR", Id);
                cmd.Parameters.AddWithValue("@IDAUXILIAR", IDAuxiliar);
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
                sql = " Delete from VACAUXILIAR Where IDVACAUXILIAR=@IDVACAUXILIAR ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDVACAUXILIAR", Id);
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
                sql = " Select IDVACAUXILIAR, NOMBRE , INICIO, FINAL from VACAUXILIAR " +
                "inner join AUXILIAR ON VACAUXILIAR.IDAUXILIAR = AUXILIAR.IDAUXILIAR " +
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
                sql = " Select IDVACAUXILIAR, NOMBRE , INICIO, FINAL from VACAUXILIAR " +
                "inner join AUXILIAR ON VACAUXILIAR.IDAUXILIAR = AUXILIAR.IDAUXILIAR " +
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
