using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Pacientes
{
    public partial class Agregar : Form
    {
        public Agregar()
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


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Pacient pacientes = new Pacient();
                pacientes.Nombre = txtNombre.Text;
                pacientes.Direccion = txtDireccion.Text;
                pacientes.Telefono = txtTelefono.Text;
                pacientes.CodigoPostal = txtCodigoPostal.Text;
                pacientes.NIF = txtNIF.Text;
                pacientes.NOSS = txtSeguridadSocial.Text;
                pacientes.IDMedico = Convert.ToInt32(cmbMedico.SelectedValue);

                if (pacientes.Add())
                {

                    MessageBox.Show("Los datos fueron registrado correctamente");
                    Vaciar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vaciar();

        }

        public void Vaciar()
        {
            Pacient pacientes = new Pacient();
            txtCodigoPostal.Clear();
            txtNIF.Clear();
            txtSeguridadSocial.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCodigoPostal.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
