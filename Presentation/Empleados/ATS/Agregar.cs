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

namespace Presentation.Empleados.ATS
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var empleados = new ATScl();
                empleados.Nombre = txtNombre.Text;
                empleados.Direccion = txtDireccion.Text;
                empleados.Telefono = txtTelefono.Text;
                empleados.CodigoPostal = txtCodigoPostal.Text;
                empleados.NIF = txtNIF.Text;
                empleados.NOSS = txtSeguridadSocial.Text;
                empleados.Provincia = textBox1.Text;
                empleados.Poblacion = "Hola";
                if (empleados.Add())
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
        public void Vaciar()
        {
            textBox1.Clear();
            txtCodigoPostal.Clear();
            txtNIF.Clear();
            txtSeguridadSocial.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCodigoPostal.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Vaciar();

        }
    }
}
