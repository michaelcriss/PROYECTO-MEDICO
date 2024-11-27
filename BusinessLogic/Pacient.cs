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
    public class Pacient
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? CodigoPostal { get; set; }

        public string? NIF { get; set; }
        public string? NOSS { get; set; }
        public int? IDMedico { get; set; }


        public DataTable ListarMed()
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

        public bool Add()
        {
            try
            {
                string sql;
                sql = " Insert into PACIENTES (NOMBRE, DIRECCION, TELEFONO, CODIGOPOSTAL, NIF, NUMSS, IDMEDICO) Values(@NOMBRE, @DIRECCION, @TELEFONO, @CODIGOPOSTAL, @NIF, @NUMSS, @IDMEDICO) ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
                cmd.Parameters.AddWithValue("@TELEFONO", Telefono);
                cmd.Parameters.AddWithValue("@CODIGOPOSTAL", CodigoPostal);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@NUMSS", NOSS);
                cmd.Parameters.AddWithValue("@IDMEDICO", IDMedico);
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
                sql = " Select PACIENTES.IDPACIENTE, PACIENTES.NOMBRE, PACIENTES.DIRECCION, PACIENTES.TELEFONO, PACIENTES.CODIGOPOSTAL, PACIENTES.NIF, PACIENTES.NUMSS, Medicos.NOMBRE as MEDICOS from  PACIENTES " +
                    "inner join Medicos ON PACIENTES.IDMEDICO = Medicos.IDMEDICO ";
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

                sql = " Select IDPACIENTE, PACIENTES.NOMBRE, PACIENTES.DIRECCION, PACIENTES.TELEFONO, PACIENTES.CODIGOPOSTAL, PACIENTES.NIF, PACIENTES.NUMSS, Medicos.NOMBRE as MEDICOS from  PACIENTES " +
                    "inner join Medicos ON PACIENTES.IDMEDICO = Medicos.IDMEDICO" +
                    " Where IDPACIENTE=@IDPACIENTE ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDPACIENTE", Id);
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
                sql = " Update PACIENTES set NOMBRE=@NOMBRE, DIRECCION=@DIRECCION, TELEFONO=@TELEFONO, CODIGOPOSTAL=@CODIGOPOSTAL, NIF=@NIF, NUMSS=@NUMSS, IDMEDICO=@IDMEDICO where IDPACIENTE=@IDPACIENTE";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDPACIENTE", Id);
                cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                cmd.Parameters.AddWithValue("@DIRECCION", Direccion);
                cmd.Parameters.AddWithValue("@TELEFONO", Telefono);
                cmd.Parameters.AddWithValue("@CODIGOPOSTAL", CodigoPostal);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@NUMSS", NOSS);
                cmd.Parameters.AddWithValue("@IDMEDICO", IDMedico);

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
                sql = " Delete from PACIENTES Where IDPACIENTE=@IDPACIENTE ";
                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@IDPACIENTE", Id);
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
