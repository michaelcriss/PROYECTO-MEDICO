using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Empleados.Administracion
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = "SELECT ATS.IDATS as CODIGO, ATS.NOMBRE as PACIENTE, ATS.DIRECCION, ATS.TELEFONO, " +
                      "ATS.PROVINCIA, ATS.CODIGOPOSTAL as CODIGO_POSTAL, ATS.NIF, ATS.NUMSS as NSS " +
                      "FROM ATS " +
                      "WHERE ATS.NOMBRE LIKE ('" + txtBuscar.Text + "%') " +
                      "OR ATS.TELEFONO LIKE ('" + txtBuscar.Text + "%') " +
                      "OR ATS.DIRECCION LIKE ('" + txtBuscar.Text + "%') " +
                      "OR ATS.PROVINCIA LIKE ('" + txtBuscar.Text + "%') " +
                      "OR ATS.CODIGOPOSTAL LIKE ('" + txtBuscar.Text + "%') " +
                      "OR ATS.NIF LIKE ('" + txtBuscar.Text + "%') " +
                      "OR ATS.NUMSS LIKE ('" + txtBuscar.Text + "%')";




                DA dbAcess = new DA();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                dt = dbAcess.Consultar(cmd);

                dataGridView1.DataSource = dt;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
