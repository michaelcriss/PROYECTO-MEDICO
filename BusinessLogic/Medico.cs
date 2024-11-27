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
    public class Medico
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }

        public string? Poblacion { get; set; }

        public string? Provincia { get; set; }

        public string? CodigoPostal { get; set; }

        public string? NIF { get; set; }

        public string? NUMSS { get; set; }

        public string? NOCOLEGIADO { get; set; }

        public string? TIPO { get; set; }

        public DataTable ListarEstado()
        {
            try
            {
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "ListarEstadoss";
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
                sql = " Insert into Medicos (NOMBRE, DIRECCION, TELEFONO, POBLACION, PROVINCIA, CODIGOPOSTAL, NIF, NOSS,NOCOLEGIADO, TIPO) Values(@NOMBRE, @DIRECCION, @TELEFONO, @POBLACION, @PROVINCIA, @CODIGOPOSTAL, @NIF, @NOSS,@NOCOLEGIADO, @TIPO) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
                cmd.Parameters.AddWithValue("@TELEFONO", Telefono);
                cmd.Parameters.AddWithValue("@POBLACION", Poblacion);
                cmd.Parameters.AddWithValue("@PROVINCIA", Provincia);
                cmd.Parameters.AddWithValue("@CODIGOPOSTAL", CodigoPostal);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@NOSS", NUMSS);
                cmd.Parameters.AddWithValue("@NOCOLEGIADO", NOCOLEGIADO);
                cmd.Parameters.AddWithValue("@TIPO", TIPO);
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
                sql = " Select IDMEDICO, NOMBRE, DIRECCION, TELEFONO, POBLACION, PROVINCIA, CODIGOPOSTAL, NIF, NOSS,NOCOLEGIADO, TIPO from Medicos ";
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
                sql = "  Select IDMEDICO, NOMBRE, DIRECCION, TELEFONO, POBLACION, PROVINCIA, CODIGOPOSTAL, NIF, NOSS,NOCOLEGIADO, TIPO from Medicos  Where IDMEDICO=@IDMEDICO";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDMEDICO", Id);
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
                sql = " Update Medicos set Select IDMEDICO=@IDMEDICO, NOMBRE=@NOMBRE, DIRECCION=@DIRECCION, TELEFONO=@DIRECCION, POBLACION=@POBLACION, PROVINCIA=@PROVINCIA, CODIGOPOSTAL=@CODIGOPOSTAL, NIF=@NIF, NOSS=@NOSS,NOCOLEGIADO=@NOCOLEGIADO, TIPO=@TIPO Where IDMEDICO=@IDMEDICO";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDMEDICO", Id);
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
                cmd.Parameters.AddWithValue("@TELEFONO", Telefono);
                cmd.Parameters.AddWithValue("@POBLACION", Poblacion);
                cmd.Parameters.AddWithValue("@PROVINCIA", Provincia);
                cmd.Parameters.AddWithValue("@CODIGOPOSTAL", CodigoPostal);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@NOSS", NUMSS);
                cmd.Parameters.AddWithValue("@NOCOLEGIADO", NOCOLEGIADO);
                cmd.Parameters.AddWithValue("@TIPO", TIPO);

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
                sql = " Delete from Medicos Where IDMEDICO=@IDMEDICO ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDMEDICO", Id);
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


