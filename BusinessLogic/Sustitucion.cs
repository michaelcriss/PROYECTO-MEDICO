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
    public class Sustitucion

    {
        public int Id { get; set; }
        public int? IDMEDICO { get; set; }
        public string? FECHAALTA { get; set; }
        public string? FECHABAJA { get; set; }

        public int? IDSUSTITUIDO { get; set; }

        public bool Add()
        {
            try
            {
                string sql;
                sql = " Insert into SUSTITUCION (IDMEDICO, FECHAALTA, FECHABAJA) Values(@IDMEDICO, @FECHAALTA, @FECHABAJA) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDMEDICO", IDMEDICO);
                cmd.Parameters.AddWithValue("@FECHAALTA", FECHAALTA);
                cmd.Parameters.AddWithValue("@FECHABAJA", FECHABAJA);
                cmd.Parameters.AddWithValue("@IDSUSTITUIDO", IDSUSTITUIDO);

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

                sql = " Select IDSUSTITUCION,NOMBRE, FECHAALTA, FECHABAJA from SUSTITUCION " +
                    "inner join Medicos on SUSTITUCION.IDMEDICO = Medicos.IDMEDICO" ;
               
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
                sql = " Select IDSUSTITUCION,NOMBRE, FECHAALTA, FECHABAJA from SUSTITUCION " +
                    "inner join Medicos on SUSTITUCION.IDMEDICO = Medicos.IDMEDICO" +
                "where IDSUSTITUCION=@IDSUSTITUCION";
                ;
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("IDSUSTITUCION", Id);
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
