using BusinessLogic;
using DataAccess;
using Presentation.Pacientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Paciente : Form
    {

        public Paciente()
        {
            InitializeComponent();

        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Agregar ver = new Agregar();
            ver.Show();

        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = " Select PACIENTES.IDPACIENTE as CODIGO, PACIENTES.NOMBRE as PACIENTE, PACIENTES.DIRECCION, PACIENTES.TELEFONO, PACIENTES.CODIGOPOSTAL as CODIGO_POSTAL, PACIENTES.NIF, PACIENTES.NUMSS as NSS, Medicos.NOMBRE as MEDICO from  PACIENTES" +
                    " inner join Medicos ON PACIENTES.IDMEDICO = Medicos.IDMEDICO " +
                    " where PACIENTES.Nombre like ('" + txtBuscar.Text + "%') or PACIENTES.TELEFONO like ('" + txtBuscar.Text + "%') " +
                    "or PACIENTES.DIRECCION like ('" + txtBuscar.Text + "%') or PACIENTES.CODIGOPOSTAL like ('" + txtBuscar.Text + "%') or PACIENTES. NIF like ('" + txtBuscar.Text + "%') " +
                    "or PACIENTES.NUMSS like ('" + txtBuscar.Text + "%') or PACIENTES.IDMEDICO like ('" + txtBuscar.Text + "%') ";


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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar ver = new Editar();
            ver.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Pacient pacientes = new Pacient();

                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    if (id > 0)
                    {
                        pacientes.Id = id;
                        if (pacientes.Delete())
                        {
                            dataGridView1.DataSource = pacientes.Get();
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

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedCells[0].Value.ToString();

            
        }
    }

}
