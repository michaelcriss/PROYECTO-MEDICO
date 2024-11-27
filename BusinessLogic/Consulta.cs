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
    public class Consulta
    {
        public int Id { get; set; }
        public int? IDMedico { get; set; }
        public string? Lunes{ get; set; }
        public string? Martes{ get; set; }
        public string? Miercoles { get; set; }
        public string? Jueves { get; set; }
        public string? Viernes{ get; set; }
        public string? Sabado { get; set; }
        public string? Domingo { get; set; }
        public DataTable ListarMedico()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarMedico";
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
                sql = " Insert into HORARIOS (IDMEDICO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO) Values (@IDMEDICO, @LUNES, @MARTES, @MIERCOLES, @JUEVES, @VIERNES, @SABADO, @DOMINGO) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDMEDICO", IDMedico);
                cmd.Parameters.AddWithValue("@LUNES", Lunes);
                cmd.Parameters.AddWithValue("@MARTES", Martes);
                cmd.Parameters.AddWithValue("@MIERCOLES", Miercoles);
                cmd.Parameters.AddWithValue("@JUEVES", Jueves);
                cmd.Parameters.AddWithValue("@VIERNES", Viernes);
                cmd.Parameters.AddWithValue("@SABADO", Sabado);
                cmd.Parameters.AddWithValue("@DOMINGO", Domingo);

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
                sql = " Select IDHORARIO, IDMEDICO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO from HORARIOS ";
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
                sql = " Select IDHORARIO, IDMEDICO, LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO from HORARIOS Where IDHORARIO=@IDHORARIO";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDHORARIO", Id);
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
                sql = " Update HORARIOS set IDMEDICO=IDMEDICO, LUNES=@LUNES, MARTES=@MARES, MIERCOLES=@MIERCOLES, JUEVES=@JUEVES, VIERNES=@VIERNES, SABADO=@SABADO, DOMINGO=@DOMINGO Where IDHORARIO=@IDHORARIO";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDMEDICO", IDMedico);
                cmd.Parameters.AddWithValue("@LUNES", Lunes);
                cmd.Parameters.AddWithValue("@MARTES", Martes);
                cmd.Parameters.AddWithValue("@MIERCOLES", Miercoles);
                cmd.Parameters.AddWithValue("@JUEVES", Jueves);
                cmd.Parameters.AddWithValue("@VIERNES", Viernes);
                cmd.Parameters.AddWithValue("@SABADO", Sabado);
                cmd.Parameters.AddWithValue("@DOMINGO", Domingo);

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
                sql = " Delete from HORARIOS Where IDHORARIO=@IDHORARIO ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDHORARIO", Id);
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
