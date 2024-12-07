using BusinessLogic;
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

namespace Presentation.Empleados.ATS
{
    public partial class ATS : Form
    {
        public ATS()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar ver = new Editar();
            ver.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = new ATScl();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        empleado.Id = id;
                        if (empleado.Delete())
                        {
                            dataGridView1.DataSource = empleado.Get();
                            MessageBox.Show("Los datos fueron eliminados correctamente");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var empleado = new ATScl();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        empleado.Id = id;
                        if (empleado.Delete())
                        {
                            dataGridView1.DataSource = empleado.Get();
                            MessageBox.Show("Los datos fueron eliminados correctamente");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedCells[0].Value.ToString();

        }
    }
}
