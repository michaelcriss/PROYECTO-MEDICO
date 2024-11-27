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

namespace Presentation.Pacientes
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
            ListarMedico();

        }

        private void ListarMedico()
        {
            Pacient pacientes = new Pacient();
            cmbMedico.DataSource = pacientes.ListarMed();
            cmbMedico.DisplayMember = "NOMBRE";
            cmbMedico.ValueMember = "IDMEDICO";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Pacient pacientes = new Pacient();
                pacientes.Nombre = txtNom.Text;
                pacientes.Direccion = txtDir.Text;
                pacientes.Telefono = txtTelefono.Text;
                pacientes.CodigoPostal = txtCodigoPostal.Text;
                pacientes.NIF = txtNIF.Text;
                pacientes.NOSS = txtSeguridadSocial.Text;
                pacientes.IDMedico = Convert.ToInt32(cmbMedico.SelectedValue);


                if (pacientes.Add())
                {
                    dataGridView1.DataSource = pacientes.Get();
                    MessageBox.Show("Los datos fueron registrado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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
                        pacientes.Nombre = txtNom.Text;
                        pacientes.Direccion = txtDir.Text;
                        pacientes.Telefono = txtTelefono.Text;
                        pacientes.CodigoPostal = txtCodigoPostal.Text;
                        pacientes.NIF = txtNIF.Text;
                        pacientes.NOSS = txtSeguridadSocial.Text;
                        pacientes.IDMedico = Convert.ToInt32(cmbMedico.SelectedValue);


                        if (pacientes.Edit())
                        {
                            dataGridView1.DataSource = pacientes.Get();
                            MessageBox.Show("Los datos fueron actualizados correctamente");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNom.Clear();
            txtDir.Clear();
            txtTelefono.Clear();
            txtCodigoPostal.Clear();
            txtNIF.Clear();
            txtSeguridadSocial.Clear();
            txtBuscar.Clear();
            button1_Click(sender, e);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtNom.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtDir.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtTelefono.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtCodigoPostal.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtNIF.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtSeguridadSocial.Text = dataGridView1.SelectedCells[6].Value.ToString();


        }
    }
}
